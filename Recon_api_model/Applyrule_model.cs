using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon_api_model
{
    public class Applyrule_model
    {
        public int listslno { get; set; }
        public int slno { get; set; }
        public int slnoadd { get; set; }
        public string ComparisonCriteria { get; set; }
        public int slnorule { get; set; }
        public int slnobaseFilter { get; set; }
        public int slnobase { get; set; }
        public int Rulegid { get; set; }
        public string ReconName { get; set; }
        public int ReconName_id { get; set; }
        public string supporting_file { get; set; }
        public int supporting_file_id { get; set; }
        public string matchoffSys { get; set; }
        public string matchoffMan { get; set; }
        public string RuleName { get; set; }
        public string reversl_flag { get; set; }
        public string group_flag { get; set; }
        public string group_method { get; set; }
        public string group_many { get; set; }
        public string period_from { get; set; }
        public string period_to { get; set; }
        public string untillactive { get; set; }
        public string Additionalcondition { get; set; }
        public string groupcondittion { get; set; }
        public string basecondittion { get; set; }
        public string Ruleorder { get; set; }
        public string Accountmode { get; set; }
        public string account1 { get; set; }
        public string account2 { get; set; }
        public string Accountmode_alias_name { get; set; }
        public string Select { get; set; }
        public string ExtractionCriteria { get; set; }
        public string groupCriteria { get; set; }
         public string comparecrtieria { get; set; }
        public string TargetField { get; set; }
        public string field_name { get; set; }
        public string TargetField_alias { get; set; }
        public string field_alias_name { get; set; }
        public string Order { get; set; }
        public string status { get; set; }
        public string groupflag { get; set; }
        public string Recontype { get; set; }
        public string AccountnoRecName { get; set; }
        public string dbsource { get; set; }
        public string user_code { get; set; }

        public int comparision_filter { get; set; }
        public int extraction_filter { get; set; }
        public int filter_flag { get; set; }
        public string filter_desc { get; set; }

        public int result { get; set; }
        public string msg { get; set; }
        public string ip_address { get; set; }
        public int applyruledtl_gid { get; set; }
        public string in_action { get; set; }
        public string BaseCriteria { get; set; }
        public string IdentityCriteria { get; set; }
        public string filter_appliedon { get; set; }
        public int applyrule_basefilter_gid { get; set; }
        public int applyrule_basesele_gid { get; set; }
        public string target_grpfield { get; set; }
        public int target_grpfield_gid { get; set; }
        public int targetField_gid { get; set; }
    }
}
