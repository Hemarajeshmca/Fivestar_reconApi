using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon_api_model
{
    public class Dashboard_model
    {
        public string periodfrom { get; set; }
        public string periodto { get; set; }
        public string recon_gid { get; set; }
        public string ip_address { get; set; }
        public string user_code { get; set; }
    }
}
