using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEI_SSMS_MODELS
{
    public class GoodsModel
    {
        public System.Guid GoodsID { get; set; }
        public string GoodsName { get; set; }
        public string Number { get; set; }
        public Nullable<System.Guid> TypeID { get; set; }
        public Nullable<System.Guid> SpecificationID { get; set; }
        public Nullable<decimal> RentPrice { get; set; }
        public Nullable<decimal> TransportPrice { get; set; }
        public string GoodsNo { get; set; }
        public string PhotoNo { get; set; }
        public Nullable<decimal> SellingPrice { get; set; }
        public string Remark { get; set; }
    }
}
