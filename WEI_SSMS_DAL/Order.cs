//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEI_SSMS_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Order()
        {
            this.OrderDetail = new HashSet<OrderDetail>();
        }
    
        public System.Guid OrderID { get; set; }
        public Nullable<System.Guid> ContractID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> Number { get; set; }
        public Nullable<System.Guid> GoodsID { get; set; }
        public Nullable<System.Guid> SellerID { get; set; }
        public Nullable<byte> OrderType { get; set; }
        public Nullable<byte> OrderStatus { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModiedOn { get; set; }
        public string ModiedBy { get; set; }
        public Nullable<byte> IsDel { get; set; }
        public string Remark { get; set; }
    
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}