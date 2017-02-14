using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS.Dashboard.Model
{
  
   public class Department
    {
        private int DepartmentID;

        private string DepartmentName;

        private string ParentID;

        private string DepartmentAddr;

        private string DepartmentContact;

        private string DepartmentPostCode;

        private string DepartmentDesc;

        private string Administor;

        public Department()
        {

        }

        public Department(int id)
        {
            this.DepartmentID = id;
        }

        public int getDepartmentID
        {
            get { return DepartmentID; }
            set { DepartmentID = value; }
        }
      

        public string getDepartmentName
        {
            get { return DepartmentName; }
            set { DepartmentName = value; }
        }
     

        public string getParentID
        {
            get { return ParentID; }
            set { ParentID = value; }
        }
     

        public string getDepartmentAddr
        {
            get { return DepartmentAddr; }
            set { DepartmentAddr = value; }
        }
      

        public string getDepartmentContact
        {
            get { return DepartmentContact; }
            set { DepartmentContact = value; }
        }
     

        public string getDepartmentPostCode
        {
            get { return DepartmentPostCode; }
            set { DepartmentPostCode = value; }
        }
      

        public string getDepartmentDesc
        {
            get { return DepartmentDesc; }
            set { DepartmentDesc = value; }
        }
        
        public string getAdministor
        {
            get { return Administor; }
            set { Administor = value; }
        }

      

    }

   
}
