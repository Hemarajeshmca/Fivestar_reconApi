using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon_api_model
{
   public class ManualMatchOff_model
    {

        public int SlNo { get; set; }
        public int recongid { get; set; }
        public int tran_gid { get; set; }
        public int tranrecon_gid { get; set; }
        public int recon_gid { get; set; }
        public int tranbrkp_gid { get; set; }
        public int group_sno { get; set; }
        public int applyrule_gid { get; set; }
        public int applyruledtl_gid { get; set; }
        public int rule_gid { get; set; }

        public int report_gid { get; set; }
        public bool in_outfile_flag { get; set; }
        public string table_name { get; set; }
        public string Report_condition { get; set; }
        public int valuedrop { get; set; }

        public int count { get; set; }
        public int outresult { get; set; }
        public int sessiongid { get; set; }
        public int TranId { get; set; }

        public double debitscore { get; set; }
        public string tranid_frame { get; set; }
        public string knockoffreason { get; set; }
        public int pageno { get; set; }
        public int pagesize { get; set; }

        public string attributvalue { get; set; }
        public string Rule { get; set; }
        public string AccountNo { get; set; }
        public string TranDate { get; set; }
        public string ValueDate { get; set; }
        public string Description { get; set; }
        public string Accountmode { get; set; }
        public string Accountmode_desc { get; set; }
        public string Source { get; set; }
        public string Comparition { get; set; }
        public string Select { get; set; }
        public string Exceptionamount { get; set; }
        public string amount { get; set; }
        public string chequeno { get; set; }
        public string Chequedate { get; set; }
        public string Refno { get; set; }
        public string tranRefno { get; set; }
       // public string TranId { get; set; }
        public string periodfrom { get; set; }
        public string periodto { get; set; }
        public string filetype { get; set; }
        public string user_code { get; set; }
        public string ko_amount { get; set; }
        public double ko_amountcon { get; set; }
        public double amountcon { get; set; }
        public double Exceptionamountcon { get; set; }
        public string dbsource { get; set; }
        public string reversal_flag { get; set; }
        public string koreason { get; set; }

        public int sno { get; set; }
        public string rule_name { get; set; }
        public string status { get; set; }
        public string recontype { get; set; }
        public string automatchoff { get; set; }
        public string grp_field { get; set; }

        public int file_gid { get; set; }
        public string file_name { get; set; }
        public string acc_no { get; set; }
        public string tranbrkptype_name { get; set; }
        public string excp_amount { get; set; }
        public string cnt { get; set; }        

        public int result { get; set; }
        public string ip_address { get; set; }
        public string msg { get; set; }

        public int jobgid { get; set; }
       // public string knockoffreason { get; set; }
    }
}
