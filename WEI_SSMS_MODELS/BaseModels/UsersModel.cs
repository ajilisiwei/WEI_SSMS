using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEI_SSMS_MODELS
{
    public class UsersModel 
    {
        #region 实体属性
        public System.Guid UserID { get; set; }
        public string UserName { get; set; }
        public string IDCardNo { get; set; }
        public string PhoneNo { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public Nullable<byte> Gender { get; set; }
        public Nullable<byte> Type { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.Guid> JobID { get; set; }
        public string Remark { get; set; } 
        #endregion

    }
}
