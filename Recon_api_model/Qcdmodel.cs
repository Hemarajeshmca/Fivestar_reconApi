using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon_api_model
{
    public  class Qcdmodel
    {
        public int result { get; set; }
        public string msg { get; set; }
        public string user_code { get; set; }
        public string action { get; set; }
        public string ip_address { get; set; }

        public int masterGid { get; set; }
        public string master_Gid { get; set; }
        public string ParentMasterSyscode { get; set; }
        public string masterSyscode { get; set; }
        public string masterCode { get; set; }
        public string masterShortCode { get; set; }
        public string masterName { get; set; }
        public string mastermutiplename { get; set; }
        public string active_status { get; set; }
        public string Status { get; set; }
    }
}
