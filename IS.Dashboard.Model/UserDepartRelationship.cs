using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS.Dashboard.Common.Entity
{
    [ActiveRecord("UserDepartRelationship")]
    public class UserDepartRelationship : ActiveRecordBase
    {
        #region
        private int _ID;

        private int _DepartmentID;

        private int _UserID;

        private string _StartDate;

        private string _EndDate;

        [PrimaryKey(PrimaryKeyType.Identity, "ID")]
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        [Property("DepartmentID")]
        public int DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }

        [Property("UserID")]
        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }

        [Property("StartDate")]
        public string StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        [Property("EndDate")]
        public string EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        #endregion
    }
}
