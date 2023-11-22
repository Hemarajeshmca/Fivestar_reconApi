using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon_api_model
{
 public class FileConvTemp_model
    {

     public Int64 Template_gid { get; set; }
     public string Template_name { get; set; }
     public string Template_type { get; set; }
     public string Template_type_desc { get; set; }
     public string FileType { get; set; }
     public string FileType_desc { get; set; }
     public string Hflag { get; set; }
     public int Csv_Columns { get; set; }
     public string Csv_seperator { get; set; }
     public string Action { get; set; }
     public string Acflag { get; set; }
     public string Transaction_Amount_type { get; set; }
     public string Active_status { get; set; }
     public string Blflag { get; set; }
     public string Balance_Amount_type { get; set; }
     public string Tran_date_format { get; set; }

     public string parent_master_syscode { get; set; }

     public int result { get; set; }
     public string msg { get; set; }

     public Int64 TemplateField_Gid { get; set; }
     public string field_name { get; set; }
     public Int32  Csv_Column_No { get; set; }
     public Int32 Txt_Start_Position { get; set; }
     public Int32 Txt_End_Position { get; set; }
     public string field_alias_name { get; set; }
     public string Mandatory_Field { get; set; }
     public string Field_Active_Status { get; set; }
     public Int64 FileTemplatefield_gid { get; set; }
     public string fieldmappingtype { get; set; }

     public string Sourcefieldname { get; set; }

     public string ip_address { get; set; }
     public string user_code { get; set; }

     public string dropdowntype { get; set; }
     public string param_1 { get; set; }
     public int applyrule_basesele_gid { get; set; }
    }
}
