using System;
using Castle.ActiveRecord;

namespace IS.Dashboard.Model
{
    [ActiveRecord("UserInfo")]
    public class User : BaseModel
    {
        #region

        [PrimaryKey(PrimaryKeyType.Identity, "UserID")]
        public int UserId { get; set; }

        [Property("LastName")]
        public string LastName { get; set; }

        [Property("FirstName")]
        public string FirstName { get; set; }

        [Property("EmailAddress")]
        public string EmailAddress { get; set; }

        [Property("Gender")]
        public char Gender { get; set; }

        [Property("BOD")]
        public DateTime BOD { get; set; }

        [Property("PicURL")]
        public string PicUrl { get; set; }

        [Property("LogOnName")]
        public string LogOnName { get; set; }

        [Property("Password")]
        public string Password { get; set; }

        [Property("Title")]
        public string Title { get; set; }

        #endregion
    }
}


