
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dashboard.Models
{
    public class User 
    {

        private int _UserId;

        private string _LastName;

        private string _FirstName;

        private string _EmailAddress;

        private DateTime _BOD;

        private string _PicURL;

        private char _Gender;

        private string _LogOnName;

        private string _Password;

        private string _Title;

        public User()
        {

        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        
     
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
       

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
      

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        

        public string EmailAddress
        {
            get { return _EmailAddress; }
            set { _EmailAddress = value; }
        }
      

        public char Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }
      

        public DateTime BOD
        {
            get { return _BOD; }
            set { _BOD = value; }
        }
       

        public string PicURL
        {
            get { return _PicURL; }
            set { _PicURL = value; }
        }
     
      
        public string LogOnName
        {
            get { return _LogOnName; }
            set { _LogOnName = value; }
        }
        

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        } 
        
       
    }
}
       
    