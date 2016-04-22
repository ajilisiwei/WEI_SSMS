using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEI_SSMS_MODELS
{
    public class SpecificationModel
    {
        public System.Guid SpecificationID { get; set; }
        public string SpecificationName { get; set; }
        public Nullable<double> Lenght { get; set; }
        public Nullable<double> Width { get; set; }
        public Nullable<double> Height { get; set; }
        public string Remark { get; set; }
    }
}
