using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon_api_model
{
   public class Setup_model
    {
       public int category_id{ get; set; }
       public string Category_name { get; set; }    
        public string Status { get; set; }
        public string dbsource { get; set; }
        public int result { get; set; }
        public string msg { get; set; }
        public int Respon_id { get; set; }
        public string Respon_name { get; set; }
        public int tranbrkptype_gid { get; set; }
        public string tranbrkptype_name { get; set; }
        public string user_code { get; set; }
        public int remark_gid { get; set; }
        public string remark_desc { get; set; }
        public int tran_gid { get; set; }
        public int tranrecon_gid { get; set; }
        public string remark1 { get; set; }
        public string ip_address { get; set; }
        public string remark2 { get; set; }
        
    }
}
