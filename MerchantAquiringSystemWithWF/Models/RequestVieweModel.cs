using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MerchantAquiringSystemWithWF.Models
{
    public class RequestViewModel
    {
        public Int32 Id { get; set; }
        public string RequestType { get; set; }
        public string RequestDescription { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string View { get; set; }
    }
}