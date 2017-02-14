using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data;
using NPOI.HSSF.UserModel;
using System.Reflection;
using NPOI.HSSF.Record.Formula.Functions;


namespace WebExportExcelByNOPI.Service
{
    public class NPOIHelper
    {
        public static Stream RenderDataTableToExcel(DataTable SourceTable)
        {
            HSSFWorkbook workbook = new HSSFWorkbook();
            MemoryStream ms = new MemoryStream();
            HSSFSheet sheet = workbook.CreateSheet();
            HSSFRow headerRow = sheet.CreateRow(0);

            // handling header. 
            foreach (DataColumn column in SourceTable.Columns)
                headerRow.CreateCell(column.Ordinal).SetCellValue(column.ColumnName);

            // handling value. 
            int rowIndex = 1;

            foreach (DataRow row in SourceTable.Rows)
            {
                HSSFRow dataRow = sheet.CreateRow(rowIndex);

                foreach (DataColumn column in SourceTable.Columns)
                {
                    dataRow.CreateCell(column.Ordinal).SetCellValue(row[column].ToString());
                }

                rowIndex++;
            }

            workbook.Write(ms);
            ms.Flush();
            ms.Position = 0;

            sheet = null;
            headerRow = null;
            workbook = null;

            return ms;
        }
        public static DataTable DoReadExcelDataTable(string filePath, int startRow)
        {
            DataTable dt = new DataTable();


            if (!File.Exists(filePath))
            {
                return dt;
            }


            HSSFWorkbook workbook = null;


            HSSFSheet sheet = null;


            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);


            workbook = new HSSFWorkbook(fs);


            sheet = workbook.GetSheetAt(0);


            HSSFRow row1 = sheet.GetRow(startRow);


            int cellCount = row1.LastCellNum;


            //此处是读取列名的，如果不需要列名则注释此代码  
            for (int i = row1.FirstCellNum; i < row1.LastCellNum; i++)
            {
                DataColumn columItem = new DataColumn(row1.GetCell(i).StringCellValue);
                dt.Columns.Add(columItem);
            }


            int rowCount = sheet.LastRowNum;


            for (int i = (sheet.FirstRowNum + 1); i <= sheet.LastRowNum; i++)
            {
                HSSFRow row = sheet.GetRow(i);


                DataRow dtrow = dt.NewRow();


                for (int j = row.FirstCellNum; j < cellCount; j++)
                {
                    if (row.GetCell(j) != null)
                    {
                        dtrow[j] = row.GetCell(j).ToString();
                    }
                }


                dt.Rows.Add(dtrow);
            }
            sheet = null;


            workbook = null;


            return dt;
        }  
        public static void RenderDataTableToExcel(DataTable SourceTable, string FileName)
        {
            MemoryStream ms = RenderDataTableToExcel(SourceTable) as MemoryStream;
            FileStream fs = new FileStream(FileName, FileMode.Create, FileAccess.Write);
            byte[] data = ms.ToArray();

            fs.Write(data, 0, data.Length);
            fs.Flush();
            fs.Close();

            data = null;
            ms = null;
            fs = null;
        }

        public static DataTable RenderDataTableFromExcel(Stream ExcelFileStream, string SheetName, int HeaderRowIndex)
        {
            HSSFWorkbook workbook = new HSSFWorkbook(ExcelFileStream);
            HSSFSheet sheet = workbook.GetSheet(SheetName);

            DataTable table = new DataTable();

            HSSFRow headerRow = sheet.GetRow(HeaderRowIndex);
            int cellCount = headerRow.LastCellNum;

            for (int i = headerRow.FirstCellNum; i < cellCount; i++)
            {
                DataColumn column = new DataColumn(headerRow.GetCell(i).StringCellValue);
                table.Columns.Add(column);
            }

            int rowCount = sheet.LastRowNum;

            for (int i = (sheet.FirstRowNum + 1); i < sheet.LastRowNum; i++)
            {
                HSSFRow row = sheet.GetRow(i);
                DataRow dataRow = table.NewRow();

                for (int j = row.FirstCellNum; j < cellCount; j++)
                    dataRow[j] = row.GetCell(j).ToString();
            }

            ExcelFileStream.Close();
            workbook = null;
            sheet = null;
            return table;
        }

        public static DataTable RenderDataTableFromExcel(Stream ExcelFileStream, int SheetIndex, int HeaderRowIndex)
        {

            HSSFWorkbook workbook = new HSSFWorkbook(ExcelFileStream);
            HSSFSheet sheet = workbook.GetSheetAt(SheetIndex);

            DataTable table = new DataTable();

            HSSFRow headerRow = sheet.GetRow(HeaderRowIndex);
            int cellCount = headerRow.LastCellNum;

            for (int i = headerRow.FirstCellNum; i < cellCount; i++)
            {
                DataColumn column = new DataColumn(headerRow.GetCell(i).StringCellValue);
                table.Columns.Add(column);
            }

            int rowCount = sheet.LastRowNum;

            for (int i = (HeaderRowIndex + 1); i < sheet.LastRowNum; i++)
            {
                HSSFRow row = sheet.GetRow(i);
                DataRow dataRow = table.NewRow();

                for (int j = row.FirstCellNum; j < cellCount; j++)
                {
                    if (row.GetCell(j) != null)
                        dataRow[j] = row.GetCell(j).ToString();
                }

                table.Rows.Add(dataRow);
            }

            ExcelFileStream.Close();
            workbook = null;
            sheet = null;
            return table;
        }



        #region  

        public static void ListToExcel(IList<T> list, string fileName, params string[] propertyName)
        {
            HttpContext.Current.Response.ContentType = "application/vnd.ms-excel;charset=UTF-8";
            HttpContext.Current.Response.AddHeader("Content-Disposition", string.Format("attachment;filename={0}", fileName));
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.BinaryWrite(ListToExcel<T>(list, propertyName).GetBuffer());
            HttpContext.Current.Response.End();
        }

        public static MemoryStream ListToExcel<T>(IList<T> list, params  string[] propertyName)
        {
            //创建流对象
            using (MemoryStream ms = new MemoryStream())
            {
                //将参数写入到一个临时集合中
                List<string> propertyNameList = new List<string>();
                if (propertyName != null)
                    propertyNameList.AddRange(propertyName);
                //床NOPI的相关对象
                HSSFWorkbook workbook = new HSSFWorkbook();
                HSSFSheet sheet = workbook.CreateSheet();
                HSSFRow headerRow = sheet.CreateRow(0);

                if (list.Count > 0)
                {
                    //通过反射得到对象的属性集合
                    PropertyInfo[] propertys = list[0].GetType().GetProperties();
                    //遍历属性集合生成excel的表头标题
                    for (int i = 0; i < propertys.Count(); i++)
                    {
                        //判断此属性是否是用户定义属性
                        if (propertyNameList.Count == 0)
                        {
                            headerRow.CreateCell(i).SetCellValue(propertys[i].Name);
                        }
                        else
                        {
                            //if (propertyNameList.Contains(propertys[i].Name))
                                //headerRow.CreateCell(i).SetCellValue(propertys[i].Name);
                            headerRow.CreateCell(i).SetCellValue(propertyName[i]);
                        }
                    }


                    int rowIndex = 1;
                    //遍历集合生成excel的行集数据
                    for (int i = 0; i < list.Count; i++)
                    {
                        HSSFRow dataRow = sheet.CreateRow(rowIndex);
                        for (int j = 0; j < propertys.Count(); j++)
                        {
                            if (propertyNameList.Count == 0)
                            {
                                object obj = propertys[j].GetValue(list[i], null);
                                dataRow.CreateCell(j).SetCellValue(obj.ToString());
                            }
                            else
                            {
                                //if (propertyNameList.Contains(propertys[j].Name))
                                //{
                                    object obj = propertys[j].GetValue(list[i], null);
                                    dataRow.CreateCell(j).SetCellValue(obj.ToString());
                                //}
                            }
                        }
                        rowIndex++;
                    }
                }
                workbook.Write(ms);
                ms.Flush();
                ms.Position = 0;
                return ms;
            }
        }
        #endregion



    }
}