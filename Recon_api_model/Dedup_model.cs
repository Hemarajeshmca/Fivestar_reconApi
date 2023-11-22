using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon_api_model
{
    public class Dedup_model
    {
        public int slno { get; set; }
        public string field_name { get; set; }
        public int slnolist { get; set; }
        public string field_alias_name { get; set; }
        public string ConditionCriteria { get; set; }
        public string Select { get; set; }
        public string ExtractionCriteria { get; set; }
        public string ComparisonCriteria { get; set; }
        public string TargetField { get; set; }
        public string field_type { get; set; }
        public string Name { get; set; }
        public string Deduperule { get; set; }
        public string status { get; set; }
        public string status_desc { get; set; }
        public string period_from { get; set; }
        public string period_To { get; set; }
        public string Rule_name { get; set; }
        public string dbsource { get; set; }
        public string group_flag { get; set; }
        public string untillactive { get; set; }
        public int comparision_filter { get; set; }
        public int extraction_filter { get; set; }
        public int filter_flag { get; set; }
        public string filter_desc { get; set; }
        public string target_ident_flag { get; set; }
        public string target_ident_value { get; set; }
        public string source_ident_flag { get; set; }
        public string source_ident_value { get; set; }
     
        public int result { get; set; }
        public string msg { get; set; }

        public string ip_address { get; set; }
        public string user_code { get; set; }
    }
}
