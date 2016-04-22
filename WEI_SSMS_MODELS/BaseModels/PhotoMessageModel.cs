using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEI_SSMS_MODELS
{
    public class PhotoMessageModel
    {
        public System.Guid PhotoID { get; set; }
        public string ContractNo { get; set; }
        public Nullable<byte> PhotoType { get; set; }
        public string PhotoPath { get; set; }
    }
}
