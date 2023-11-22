using Recon_api_model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon_api_datamodel
{
   public  class FileConvTemp_datamodel
    {
       public DataTable TemplateType(FileConvTemp_model FileConvTemp)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);
               values.Add("in_template_type", "");
               result = con.RunDataSetProc("pr_get_templatetype", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);
               con.errorlog(FileConvTemp.ip_address, FileConvTemp.user_code, method_name, error, source_name);
               return result;
           }
       }

       public DataTable Trandatformatbinding(FileConvTemp_model FileConvTemp)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);
               values.Add("in_parent_master_syscode","QCD_DATE_FORMAT");
               values.Add("in_master_syscode","");
               values.Add("in_active_status","");
               result = con.RunDataSetProc("pr_get_master", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);
               con.errorlog(FileConvTemp.ip_address, FileConvTemp.user_code, method_name, error, source_name);
               return result;
           }
       }


       public DataTable DropdownBinding(FileConvTemp_model FileConvTemp)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);
               values.Add("in_dropdowname", FileConvTemp.dropdowntype);
               values.Add("in_param", FileConvTemp.param_1);
               result = con.RunDataSetProc("pr_get_amountypedropdown", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);
               con.errorlog(FileConvTemp.ip_address, FileConvTemp.user_code, method_name, error, source_name);
               return result;
           }
       }
      
       public DataTable TemplateFileType(FileConvTemp_model FileConvTemp)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);
               values.Add("in_file_type", "");
               result = con.RunDataSetProc("pr_get_filetype", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);
               con.errorlog(FileConvTemp.ip_address, FileConvTemp.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] FileConvTempCreate(FileConvTemp_model  FileConvTemp)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);

               values.Add("in_filetemplate_gid", FileConvTemp.Template_gid );
               values.Add("in_filetemplate_name", FileConvTemp.Template_name);
               values.Add("in_template_type", FileConvTemp.Template_type);
               values.Add("in_file_type", FileConvTemp.FileType );
               values.Add("in_csv_seperator", FileConvTemp.Csv_seperator);
               values.Add("in_csv_columns", FileConvTemp.Csv_Columns);
               values.Add("in_hflag", FileConvTemp.Hflag);
               values.Add("in_acflag", FileConvTemp.Acflag);
               values.Add("in_blflag", FileConvTemp.Blflag);
               values.Add("in_tran_amount_type", FileConvTemp.Transaction_Amount_type);
               values.Add("in_bl_amount_type", FileConvTemp.Balance_Amount_type);
               values.Add("in_active_status", FileConvTemp.Active_status);
               values.Add("in_action", FileConvTemp.Action);
               values.Add("in_action_by", FileConvTemp.user_code);
               values.Add("in_tran_date_format", FileConvTemp.Tran_date_format);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc_FileConvert("pr_recon_mst_tfiletemplate", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);
               con.errorlog(FileConvTemp.ip_address, FileConvTemp.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] FileConvTempDelete(FileConvTemp_model FileConvTemp)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);

               values.Add("in_filetemplate_gid", FileConvTemp.Template_gid);
               values.Add("in_filetemplate_name", FileConvTemp.Template_name);
               values.Add("in_template_type", FileConvTemp.Template_type);
               values.Add("in_file_type", FileConvTemp.FileType);
               values.Add("in_csv_seperator", FileConvTemp.Csv_seperator);
               values.Add("in_active_status", FileConvTemp.Active_status);
               values.Add("in_action", "DELETE");
               values.Add("in_action_by", FileConvTemp.user_code);
               values.Add("in_csv_columns", FileConvTemp.Csv_Columns);
               values.Add("in_hflag", FileConvTemp.Hflag);
               values.Add("in_acflag", FileConvTemp.Acflag);
               values.Add("in_blflag", FileConvTemp.Blflag);
               values.Add("in_tran_amount_type", FileConvTemp.Transaction_Amount_type);
               values.Add("in_bl_amount_type", "");
               values.Add("in_tran_date_format", FileConvTemp.Tran_date_format);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc_FileConvert("pr_recon_mst_tfiletemplate", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);
               con.errorlog(FileConvTemp.ip_address, FileConvTemp.user_code, method_name, error, source_name);
               return result;
           }
       }
       public DataTable GetFieldStru(FileConvTemp_model FileConvTemp)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);
               values.Add("in_field_name", "");
               values.Add("in_mapping_flag", "Y");
               values.Add("in_template_flag", "Y");
               result = con.RunDataSetProc("pr_get_fieldstru", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);
               con.errorlog(FileConvTemp.ip_address, FileConvTemp.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] FileTemplateFiled(FileConvTemp_model FileConvTemp)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);

               values.Add("in_filetemplate_gid", FileConvTemp.Template_gid);
               values.Add("in_excel_field", FileConvTemp.Sourcefieldname);
               values.Add("in_csv_column_no", FileConvTemp.Csv_Column_No );
               values.Add("in_txt_start_position", FileConvTemp.Txt_Start_Position);
               values.Add("in_txt_end_position", FileConvTemp.Txt_End_Position );
               values.Add("in_tran_field", FileConvTemp.field_name);
               values.Add("in_field_mapping_type", FileConvTemp.fieldmappingtype);
               values.Add("in_mandatory_field", FileConvTemp .Mandatory_Field );
               values.Add("in_active_status", FileConvTemp .Field_Active_Status );
               //values.Add("in_action", "INSERT");
               //values.Add("in_action_by", "admin");
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc_FileConvert("pr_ins_filetemplatefield", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);
               con.errorlog(FileConvTemp.ip_address, FileConvTemp.user_code, method_name, error, source_name);
               return result;
           }
       }
       public DataTable GetFieldGrid(FileConvTemp_model ObjFileConvModel)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ObjFileConvModel.ip_address, ObjFileConvModel.user_code);
               values.Add("in_filetemplate_gid", ObjFileConvModel .Template_gid );
               values.Add("in_filetemplatefield_gid", ObjFileConvModel .TemplateField_Gid );
               values.Add("in_active_status", "");
               result = con.RunDataSetProc("pr_get_filetemplatefield", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ObjFileConvModel.ip_address, ObjFileConvModel.user_code);
               con.errorlog(ObjFileConvModel.ip_address, ObjFileConvModel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public DataTable FileTemplateLists(FileConvTemp_model ObjFileConvModel)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ObjFileConvModel.ip_address, ObjFileConvModel.user_code);
               values.Add("in_filetemplate_gid", ObjFileConvModel .Template_gid );
               values.Add("in_active_status", "");
               result = con.RunDataSetProc("pr_get_filetemplate", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ObjFileConvModel.ip_address, ObjFileConvModel.user_code);
               con.errorlog(ObjFileConvModel.ip_address, ObjFileConvModel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] FileTemplateFiled_Update(FileConvTemp_model FileConvTemp)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);

               values.Add("in_filetemplatefield_gid", FileConvTemp.FileTemplatefield_gid);
               values.Add("in_filetemplate_gid", FileConvTemp.Template_gid);
               values.Add("in_excel_field", FileConvTemp.Sourcefieldname);
               values.Add("in_csv_column_no", FileConvTemp.Csv_Column_No);
               values.Add("in_txt_start_position", FileConvTemp.Txt_Start_Position);
               values.Add("in_txt_end_position", FileConvTemp.Txt_End_Position);
               values.Add("in_tran_field", FileConvTemp.field_name);
               values.Add("in_field_mapping_type", FileConvTemp.fieldmappingtype);
               values.Add("in_mandatory_field", FileConvTemp.Mandatory_Field);
               values.Add("in_active_status", FileConvTemp.Field_Active_Status);
               //values.Add("in_action", "INSERT");
               //values.Add("in_action_by", "admin");
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc_FileConvert("pr_upd_filetemplatefield", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);
               con.errorlog(FileConvTemp.ip_address, FileConvTemp.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] FileConvTempFiledDelete(FileConvTemp_model FileConvTemp)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);

               values.Add("in_filetemplatefield_gid", FileConvTemp.FileTemplatefield_gid);              
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_del_filetemplatefield", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);
               con.errorlog(FileConvTemp.ip_address, FileConvTemp.user_code, method_name, error, source_name);
               return result;
           }
       }
       public DataTable LookupMasterdrop(Formula_model Formulamodel)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(Formulamodel.ip_address, Formulamodel.user_code);
               values.Add("in_parent_master_syscode", Formulamodel.parent_master_syscode);
               values.Add("in_master_syscode", Formulamodel.master_syscode);
               values.Add("in_active_status", Formulamodel.active_status);
               result = con.RunDataSetProc("pr_get_master", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(Formulamodel.ip_address, Formulamodel.user_code);
               con.errorlog(Formulamodel.ip_address, Formulamodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] LookupMasterSave(Formula_model Formulamodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(Formulamodel.ip_address, Formulamodel.user_code);
               values.Add("in_filetemplatefield_gid", Formulamodel.filetemplatefield_gid);
               values.Add("in_formula_order", Formulamodel.formula_order);
               values.Add("in_source_field", Formulamodel.Sourcefieldname);
               values.Add("in_source_csv_column", Formulamodel.source_csv_column);
               values.Add("in_source_txt_start", Formulamodel.source_txt_start);
               values.Add("in_source_txt_end", Formulamodel.source_txt_end);
               values.Add("in_extraction_criteria", Formulamodel.ExtractionCriteria);
               values.Add("in_extraction_filter", Formulamodel.extraction_filter);
               values.Add("in_lookup_flag", Formulamodel.lookup_flag);
               values.Add("in_lookup_table_code", Formulamodel.lookup_table_code);
               values.Add("in_lookup_field", Formulamodel.lookup_field);
               values.Add("in_lookup_extraction_field", Formulamodel.lookup_extraction_field);
               values.Add("in_lookup_extraction_criteria", Formulamodel.lookup_extraction_criteria);
               values.Add("in_lookup_extraction_filter", Formulamodel.lookup_extraction_filter);
               values.Add("in_prefix_value", Formulamodel.prefix_value);
               values.Add("in_suffix_value", Formulamodel.suffix_value);
               values.Add("in_active_status", Formulamodel.active_status);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_ins_filetemplatefieldformula", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(Formulamodel.ip_address, Formulamodel.user_code);
               con.errorlog(Formulamodel.ip_address, Formulamodel.user_code, method_name, error, source_name);
               return result;
           }
       }

       public DataTable FileTemplateFieldFormulaRead(Formula_model Formulamodel)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(Formulamodel.ip_address, Formulamodel.user_code);
               values.Add("in_filetemplatefield_gid", Formulamodel.filetemplatefield_gid);
               values.Add("in_filetemplatefieldformula_gid", Formulamodel.filetemplatefieldformula_gid);
               values.Add("in_active_status", Formulamodel.active_status);
               result = con.RunDataSetProc("pr_get_filetemplatefieldformula", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(Formulamodel.ip_address, Formulamodel.user_code);
               con.errorlog(Formulamodel.ip_address, Formulamodel.user_code, method_name, error, source_name);
               return result;
           }
       }

       public DataTable LookupMasterRead(Formula_model Formulamodel)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(Formulamodel.ip_address, Formulamodel.user_code);
               values.Add("in_filetemplatefield_gid", Formulamodel.filetemplatefield_gid);
               values.Add("in_filetemplatefieldformula_gid", Formulamodel.filetemplatefieldformula_gid);
               values.Add("in_active_status", Formulamodel.active_status);
               result = con.RunDataSetProc("pr_get_filetemplatefieldformula", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(Formulamodel.ip_address, Formulamodel.user_code);
               con.errorlog(Formulamodel.ip_address, Formulamodel.user_code, method_name, error, source_name);
               return result;
           }
       }

       public string[] LookupMasterUpdate(Formula_model Formulamodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(Formulamodel.ip_address, Formulamodel.user_code);
               values.Add("in_filetemplatefieldformula_gid", Formulamodel.filetemplatefieldformula_gid);
               values.Add("in_filetemplatefield_gid", Formulamodel.filetemplatefield_gid);
               values.Add("in_formula_order", Formulamodel.formula_order);
               values.Add("in_source_field", Formulamodel.Sourcefieldname);
               values.Add("in_source_csv_column", Formulamodel.source_csv_column);
               values.Add("in_source_txt_start", Formulamodel.source_txt_start);
               values.Add("in_source_txt_end", Formulamodel.source_txt_end);
               values.Add("in_extraction_criteria", Formulamodel.ExtractionCriteria);
               values.Add("in_extraction_filter", Formulamodel.extraction_filter);
               values.Add("in_lookup_flag", Formulamodel.lookup_flag);
               values.Add("in_lookup_table_code", Formulamodel.lookup_table_code);
               values.Add("in_lookup_field", Formulamodel.lookup_field);
               values.Add("in_lookup_extraction_field", Formulamodel.lookup_extraction_field);
               values.Add("in_lookup_extraction_criteria", Formulamodel.lookup_extraction_criteria);
               values.Add("in_lookup_extraction_filter", Formulamodel.lookup_extraction_filter);
               values.Add("in_prefix_value", Formulamodel.prefix_value);
               values.Add("in_suffix_value", Formulamodel.suffix_value);
               values.Add("in_active_status", Formulamodel.active_status);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_upd_filetemplatefieldformula", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(Formulamodel.ip_address, Formulamodel.user_code);
               con.errorlog(Formulamodel.ip_address, Formulamodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] LookupMasterDelete(Formula_model Formulamodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(Formulamodel.ip_address, Formulamodel.user_code);
               values.Add("in_filetemplatefieldformula_gid", Formulamodel.filetemplatefieldformula_gid);              
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_del_filetemplatefieldformula", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(Formulamodel.ip_address, Formulamodel.user_code);
               con.errorlog(Formulamodel.ip_address, Formulamodel.user_code, method_name, error, source_name);
               return result;
           }
       }
    }
}
