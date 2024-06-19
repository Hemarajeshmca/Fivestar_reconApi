using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon_api_model
{
    public class FileImport_model
    {
        public int Template_id { get; set; }
        public string ExFieldName { get; set; }

        public string TranFldName { get; set; }
        public string msg { get; set; }
        public int result { get; set; }
        public Int64 filetemplate_gid { get; set; }
        public int Csv_Columns { get; set; }

        public string FileName { get; set; }
        public string FileType { get; set; }
        public string Actionby { get; set; }


        public string file_gid { get; set; }
        public string acc_no { get; set; }
        public string tran_date { get; set; }
        public string value_date { get; set; }
        public string tran_desc { get; set; }
        public string amount { get; set; }
        public string mult { get; set; }
        public string active_status { get; set; }
        public string acc_mode { get; set; }
        public string ref_col1 { get; set; }
        public string ref_col2 { get; set; }
        public string ref_col3 { get; set; }
        public string ref_col4 { get; set; }
        public string ref_col5 { get; set; }
        public string ref_col6 { get; set; }
        public string ref_col7 { get; set; }
        public string ref_col8 { get; set; }
        public string ref_col9 { get; set; }
        public string ref_col10 { get; set; }
        public string ref_col11 { get; set; }
        public string ref_col12 { get; set; }
        public string ref_col13 { get; set; }
        public string ref_col14 { get; set; }
        public string ref_col15 { get; set; }
        public string ref_col16 { get; set; }
        public string ref_col17 { get; set; }
        public string ref_col18 { get; set; }
        public string ref_col19 { get; set; }
        public string ref_col20 { get; set; }
        public string ref_col21 { get; set; }
        public string ref_col22 { get; set; }
        public string ref_col23 { get; set; }
        public string ref_col24 { get; set; }
        public string ref_col25 { get; set; }
        public string ref_col26 { get; set; }
        public string ref_col27 { get; set; }
        public string ref_col28 { get; set; }
        public string ref_col29 { get; set; }
        public string ref_col30 { get; set; }
        public string ref_col31 { get; set; }
        public string ref_col32 { get; set; }
        
        public Boolean balance_flag { get; set; }
        public string bal_amount { get; set; }
        public string bal_amount_signed { get; set; }
        public string bal_amount_reverse_signed { get; set; }
        public string bal_amount_acc_mode { get; set; }
        public string debug_flag { get; set; }

        public string amount_signed { get; set; }
        public string amount_debit { get; set; }
        public string amount_reverse_signed { get; set; }
        public string amount_credit { get; set; }

        public int recon_gid { get; set; }

        public int tranbrkptype_gid { get; set; }
        public string ip_address { get; set; }
        public string user_code { get; set; }
        public int LineNo { get; set; }
        public string error_line { get; set; }
    }
}
