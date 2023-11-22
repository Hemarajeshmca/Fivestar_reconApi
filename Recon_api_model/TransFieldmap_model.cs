using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon_api_model
{
    public class TransFieldmap_model
    {
        public int slno { get; set; }
        public string DBfieldName { get; set; }
        public string Alias { get; set; }
        public string Type { get; set; }
        public string Length { get; set; }
        public string Format { get; set; }
        public string Mandatory { get; set; }
        public string code { get; set; }
        public string Name { get; set; }
        public string dbsource { get; set; }
        public int result { get; set; }
        public string msg { get; set; }
        public string ip_address { get; set; }
        public string user_code { get; set; }
        public string temflag { get; set; }
    }
}
