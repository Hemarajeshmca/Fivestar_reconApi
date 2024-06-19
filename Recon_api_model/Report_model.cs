using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon_api_model
{
    public class Report_model
    {
        public int report_gid { get; set; }
        public string report_desc { get; set; }
        public string report_isremoved { get; set; }
        public int reportparam_gid { get; set; }
        public string report_code { get; set; }
        public int Recongid { get; set; }
        public string Recon_gid { get; set; }
        public string Trandate { get; set; }
        public int reportparam_code { get; set; }
        public string reportparam_value { get; set; }
        public int report_giddrop { get; set; }
        public bool in_outfile_flag { get; set; }
        public bool resultset_flag { get; set; }
        public string table_name { get; set; }
        public string Report_condition { get; set; }
        public int valuedrop { get; set; }

        public string account1_desc { get; set; }
        public string tran_date { get; set; }
        public string status_flag { get; set; }

        public int koid { get; set; }
        public string kodate { get; set; }
        public string reconname { get; set; }
        public string rulename { get; set; }
        public string mappingdesctype { get; set; }
        public string matchoff_type { get; set; }
        public string Knockoffby { get; set; }
        public string Knockoffamount { get; set; }
        public string review { get; set; }

        public string period_from { get; set; }
        public string period_to { get; set; }
        public string file_type { get; set; }
        public string filetype_desc { get; set; }
        public string import_date { get; set; }
        public int file_gid { get; set; }
        public string file_name { get; set; }

        public string particular { get; set; }
        public string amount { get; set; }
        public string accmode { get; set; }
        public string bal_amount { get; set; }      
        public int brs_gid { get; set; }
        public int recon_gid { get; set; }
        public string rec_id { get; set; }

        public string user_code { get; set; }
        public int result { get; set; }
        public string msg { get; set; }

        public int process_gid { get; set; }
        public string ProcessName { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string InitiatedBy { get; set; }
        public string process_status { get; set; }
        public string process_status_desc { get; set; }
        public string ip_address { get; set; }

        public int sessiongid { get; set; }
        public int pageno { get; set; }
        public int pagesize { get; set; }
        public int count { get; set; }
        public string update_flag { get; set; }
        public string active_status { get; set; }
        public string recontype { get; set; }

        public string recontallied { get; set; }
        public string recondaily_gid { get; set; }
        public int no_of_recons { get; set; }
        public string fromdate { get; set; }
        public string todate { get; set; }
       
    }
}
