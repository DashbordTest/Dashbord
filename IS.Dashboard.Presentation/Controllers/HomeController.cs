using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;
using WebExportExcelByNOPI.Service;
namespace IS.Dashboard.Presentation.Web.Controllers
{
    public class HomeController : Controller
    {
        public static int IntlsUF = 0;
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult Upfiles()
        {
            //ViewBag.Message = "Your forgetting password page.";

            return View();
        }
        [HttpPost]
        public ActionResult UpSuccess()
        {
            HttpPostedFileBase files = Request.Files[0];
            string name = System.IO.Path.GetFileName(files.FileName);
            string filename = "EmployeeData.xls"; //files.FileName;
            files.SaveAs(Server.MapPath("~/App_Data/" + name));
            FileInfo fi = new FileInfo(filename);
            string FilePath = Server.MapPath("~/App_Data/EmployeeData.xls");
            Stream stream = (Stream)new FileStream(FilePath, FileMode.Open);
            DataTable table = NPOIHelper.RenderDataTableFromExcel(stream, 0, 0);
            DataTable dt1 = NewMethod(table);
            inputdata(dt1);
            return View();
        }
        private void inputdata(DataTable table)
        {
            DateTime beginTime = DateTime.Now;
            Response.Write("开始时间：" + beginTime.ToString("yyyy年MM月dd日：HH:mm:ss:fff"));
            //构造一个Datatable存储将要批量导入的数据        
            string str = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString.ToString();         //声明数据库连接        
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            using (SqlBulkCopy sqlBC = new SqlBulkCopy(conn))  //声明SqlBulkCopy ,using释放非托管资源       
            {
                sqlBC.BatchSize = 1000;    //一次批量的插入的数据量                  
                sqlBC.BulkCopyTimeout = 60;//超时之前操作完成所允许的秒数，如果超时则事务不会提交 ，数据将回滚，所有已复制的行都会从目标表中移除                    
                sqlBC.NotifyAfter = 10000;   //设定 NotifyAfter 属性，以便在每插入10000 条数据时，呼叫相应事件。         
                sqlBC.SqlRowsCopied += new SqlRowsCopiedEventHandler(OnSqlRowsCopied);
                sqlBC.DestinationTableName = "dbo.UserInfo"; //设置要批量写入的表 
                //自定义的datatable和数据库的字段进行对应            
                sqlBC.ColumnMappings.Add("EmployeeID", "EmployeeID");
                sqlBC.ColumnMappings.Add("Name - Last", "LastName");
                sqlBC.ColumnMappings.Add("Name - First", "FirstName");
                sqlBC.ColumnMappings.Add("Email Address", "EmailAddress");
                sqlBC.ColumnMappings.Add("Gender", "Gender");
                sqlBC.ColumnMappings.Add("BOD", "BOD");
                sqlBC.ColumnMappings.Add("PicURL", "PicURL");
                sqlBC.ColumnMappings.Add("Email Address", "LogOnName");
                sqlBC.ColumnMappings.Add("Password", "Password");
                sqlBC.ColumnMappings.Add("Supervisor Name", "Title");
                sqlBC.WriteToServer(table);         //批量写入  
            }
            conn.Dispose();
            Response.Write("<br/>");
            DateTime endTime = DateTime.Now;
            Response.Write("结束时间：" + endTime.ToString("yyyy年MM月dd日：HH:mm:ss:fff"));
            TimeSpan useTime = endTime - beginTime;//使用时间        
            Response.Write("<br/>插入时间：" + useTime.TotalSeconds.ToString() + "秒");
        }

        void OnSqlRowsCopied(object sender, SqlRowsCopiedEventArgs e)
        {
            Response.Write("<br/> OK! ");
        }

        private DataTable NewMethod(DataTable table)
        {
            DataTable dt1 = table.Copy();
            int rownum = dt1.Rows.Count;
            for (int i = dt1.Columns.Count - 1; i >= 0; i--)
            {

                //获取有效列数据
                if (dt1.Columns[i].ColumnName != "Employee ID" && dt1.Columns[i].ColumnName != "Email Address" && dt1.Columns[i].ColumnName != "Name - Last" && dt1.Columns[i].ColumnName != "Name - First" && dt1.Columns[i].ColumnName != "Original Hire Date" && dt1.Columns[i].ColumnName != "Fte" && dt1.Columns[i].ColumnName != "Supervisor Name")
                {
                    dt1.Columns.RemoveAt(i);
                }
                else if (dt1.Columns[i].ColumnName == "Employee ID")
                {
                    DataColumn dc1 = null;
                    dc1 = dt1.Columns.Add("EmployeeID", Type.GetType("System.Int32"));
                    for (int m = dt1.Rows.Count - 1; m >= 0; m--)
                    {
                        dt1.Rows[m]["EmployeeID"] = int.Parse(dt1.Rows[m]["Employee ID"].ToString());
                    }
                    dt1.Columns.RemoveAt(i);
                }
                else if (dt1.Columns[i].ColumnName == "Original Hire Date")
                {
                    DataColumn dc1 = null;
                    dc1 = dt1.Columns.Add("BOD", Type.GetType("System.DateTime"));
                    for (int m = dt1.Rows.Count - 1; m >= 0; m--)
                    {
                        //dt1.Rows[m]["BOD"] = DateTime.Today;//设置默认时间为当前时间
                        //string date = dt1.Rows[m]["Original Hire Date"].ToString();
                        //string datetime = DateTime.Parse(date).ToString("yyyy-MM-dd");//因为无法读取table中的时间数据，所以使用当前上传日期
                        //dt1.Rows[m]["BOD"] = DateTime.Parse(datetime);//问题，第一次可以处理，第二次循环处理就出错
                        double d = double.Parse(dt1.Rows[m]["Original Hire Date"].ToString());
                        DateTime Date = ConvertIntDateTime(d);//采用Unix时间戳处理number格式
                        dt1.Rows[m]["BOD"] = Date;
                    }
                    dt1.Columns.RemoveAt(i);
                }
            }
            DataTable tblDatas = dt1;

            DataColumn dc = null;
            dc = dt1.Columns.Add("Password", Type.GetType("System.String"));
            dc = tblDatas.Columns.Add("Gender", Type.GetType("System.Char"));
            dc = tblDatas.Columns.Add("PicURL", Type.GetType("System.String"));
            for (int j = tblDatas.Rows.Count - 1; j >= 0; j--)
            {

                for (int m = dt1.Rows.Count - 1; m >= 0; m--)
                {
                    dt1.Rows[m]["Gender"] = "M";
                    dt1.Rows[m]["PicURL"] = "PicURL";
                    dt1.Rows[m]["Password"] = "Password";
                }
            }

            return tblDatas;

        }

        public static System.DateTime ConvertIntDateTime(double d)
        {
            System.DateTime time = System.DateTime.MinValue;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1900, 1, 1));
            time = startTime.AddDays(d - 2);
            return time;
        }


        public ActionResult Rspsw()
        {
            ViewBag.Message = "Your resetting new password page.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}