﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon_api_model
{
   public class Systemmatchoff_model
    {
        public int WSlNo { get; set; }
        public int BSlNo { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public string Select { get; set; }
        public string status { get; set; }
        public string Recontype { get; set; }        
        public string AccountNo1 { get; set; }
        public string ReconName { get; set; }
        public string AccountNo2 { get; set; }
        public string period_from { get; set; }
        public string period_to { get; set; }
        public string dbsource { get; set; }
        public string createdby { get; set; }
        public int result { get; set; }
        public string msg { get; set; }
        public string ip_address { get; set; }
        public string user_code { get; set; } 
   }

}
