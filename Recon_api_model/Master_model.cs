using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon_api_model
{
   public class Master_model
    {
        public int master_gid { get; set; }
        public string master_syscode { get; set; }
        public string master_code { get; set; }
        public string master_short_code { get; set; }
        public string master_name { get; set; }      
        public string parent_master_syscode { get; set; }
        public string active_status { get; set; }
        public string ip_address { get; set; }
        public string user_code { get; set; }
        public string result_value { get; set; }
        public string msg { get; set; }
        public int result { get; set; }
        public string table_code { get; set; }
        public string lookup_field { get; set; }
        public string return_field { get; set; }
        public string lookup_value { get; set; }
    }
}
