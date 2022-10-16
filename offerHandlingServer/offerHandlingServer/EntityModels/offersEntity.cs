using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace offerHandlingServer.EntityModels
{
    public class getCompanies
    {
        public int companyId { get; set; }
        public string companyName { get; set; }
        public string tagOfIt { get; set; }
        public string appliedDate { get; set; }
        public string responseDate { get; set; }
        public int minPackage { get; set; }
        public int maxPackage { get; set; }
        public string myloaction { get; set; }
        public string response { get; set; }
        public byte? isInerviewScheduled { get; set; }
        public string condition { get; set; }
        public string subLocation { get; set; }
    }
}