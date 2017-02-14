using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS.Dashboard.Common.Entity
{
    [ActiveRecord("Department")]
    public class Department : ActiveRecordBase
    {
        #region
        private string _DepartmentID;

        private string _DepartmentName;

        private string _ParentID;

        private string _DepartmentAddr;

        private string _DepartmentContact;

        private string _DepartmentPostCode;

        private string _DepartmentDesc;

        private string _Administor;

        [PrimaryKey(PrimaryKeyType.Identity, "DepartmentID")]
        public string DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }


        [Property("DepartmentName")]
        public string DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }

        [Property("ParentID")]
        public string ParentID
        {
            get { return _ParentID; }
            set { _ParentID = value; }
        }


        [Property("DepartmentAddr")]
        public string DepartmentAddr
        {
            get { return _DepartmentAddr; }
            set { _DepartmentAddr = value; }
        }


        [Property("DepartmentContact")]
        public string DepartmentContact
        {
            get { return _DepartmentContact; }
            set { _DepartmentContact = value; }
        }


        [Property("DepartmentPostCode")]
        public string DepartmentPostCode
        {
            get { return _DepartmentPostCode; }
            set { _DepartmentPostCode = value; }
        }


        [Property("DepartmentDesc")]
        public string DepartmentDesc
        {
            get { return _DepartmentDesc; }
            set { _DepartmentDesc = value; }
        }


        [Property("Administor")]
        public string Administor
        {
            get { return _Administor; }
            set { _Administor = value; }
        }

        #endregion
    }
}
