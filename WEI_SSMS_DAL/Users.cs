//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEI_SSMS_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
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
    
        public virtual Jobs Jobs { get; set; }
    }
}
