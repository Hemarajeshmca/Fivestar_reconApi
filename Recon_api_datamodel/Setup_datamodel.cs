using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recon_api_model;
using System.Diagnostics;

namespace Recon_api_datamodel
{
   public class Setup_datamodel
    {
       public string[] categorycreate(Setup_model catemodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(catemodel.ip_address,catemodel.user_code);
              
               values.Add("in_category_gid", catemodel.category_id);
               values.Add("in_category_name", catemodel.Category_name);
               values.Add("in_active_status", catemodel.Status);
               values.Add("in_action", "INSERT");
               values.Add("in_action_by", catemodel.user_code);               
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_tcategory", values);
               

               //values.Add("in_text", "1|2|3");
               //values.Add("in_split_char", "|");
               //result = con.RunDmlProc("pr_get_split", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);
               con.errorlog(catemodel.ip_address, catemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public DataTable categoryList(Setup_model catemodel)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);

               values.Add("in_category_gid", catemodel.category_id);
               values.Add("in_category_name", " ");
               values.Add("in_active_status", "");
               values.Add("in_action", "SELECT");
               values.Add("in_action_by", catemodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDataSetProc("pr_recon_mst_tcategory", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);
               con.errorlog(catemodel.ip_address, catemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public DataTable categoryDROP(Setup_model catemodel)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);

               values.Add("in_category_gid", 0);
               values.Add("in_category_name", " ");
               values.Add("in_active_status", "");
               values.Add("in_action", "SELECT");
               values.Add("in_action_by", catemodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDataSetProc("pr_recon_mst_tcategory", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);
               con.errorlog(catemodel.ip_address, catemodel.user_code, method_name, error, source_name);
               return result;
           }
       }

       public string[] categoryUpdate(Setup_model catemodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code); 

               values.Add("in_category_gid", catemodel.category_id);
               values.Add("in_category_name", catemodel.Category_name);
               values.Add("in_active_status", catemodel.Status);
               values.Add("in_action", "UPDATE");
               values.Add("in_action_by", catemodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_tcategory", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);
               con.errorlog(catemodel.ip_address, catemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] CategoryDelete(Setup_model catemodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code); ;

               values.Add("in_category_gid", catemodel.category_id);
               values.Add("in_category_name", catemodel.Category_name);
               values.Add("in_active_status", catemodel.Status);
               values.Add("in_action", "DELETE");
               values.Add("in_action_by", catemodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_tcategory", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);
               con.errorlog(catemodel.ip_address, catemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] Responsibilitycreate(Setup_model catemodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);;

               values.Add("in_responsibility_gid", catemodel.Respon_id);
               values.Add("in_responsibility_name", catemodel.Respon_name);
               values.Add("in_active_status", catemodel.Status);
               values.Add("in_action", "INSERT");
               values.Add("in_action_by", catemodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_tresponsibility", values);          
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);
               con.errorlog(catemodel.ip_address, catemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public DataTable ResponsibilityList(Setup_model catemodel)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);;

               values.Add("in_responsibility_gid", catemodel.Respon_id);
               values.Add("in_responsibility_name", " ");
               values.Add("in_active_status", "");
               values.Add("in_action", "SELECT");
               values.Add("in_action_by", catemodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDataSetProc("pr_recon_mst_tresponsibility", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);
               con.errorlog(catemodel.ip_address, catemodel.user_code, method_name, error, source_name);
               return result;
           }
       }

       public string[] ResponsibilityUpdate(Setup_model catemodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);;

               values.Add("in_responsibility_gid", catemodel.Respon_id);
               values.Add("in_responsibility_name", catemodel.Respon_name);
               values.Add("in_active_status", catemodel.Status);
               values.Add("in_action", "UPDATE");
               values.Add("in_action_by", catemodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_tresponsibility", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);
               con.errorlog(catemodel.ip_address, catemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] ResponsibilityDelete(Setup_model catemodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);;

               values.Add("in_responsibility_gid", catemodel.Respon_id);
               values.Add("in_responsibility_name", catemodel.Respon_name);
               values.Add("in_active_status", catemodel.Status);
               values.Add("in_action", "DELETE");
               values.Add("in_action_by", catemodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_tresponsibility", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);
               con.errorlog(catemodel.ip_address, catemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public DataTable SupportfiletypeList(Setup_model catemodel)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);;

               values.Add("in_tranbrkptype_gid", catemodel.tranbrkptype_gid);
               values.Add("in_tranbrkptype_name", " ");
               values.Add("in_active_status", "");
               values.Add("in_action", "SELECT");
               values.Add("in_action_by", catemodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDataSetProc("pr_recon_mst_ttranbrkptype", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);
               con.errorlog(catemodel.ip_address, catemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] SupportfiletypeCreate(Setup_model supfiletypemodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(supfiletypemodel.ip_address, supfiletypemodel.user_code); ;

               values.Add("in_tranbrkptype_gid", supfiletypemodel.tranbrkptype_gid);
               values.Add("in_tranbrkptype_name", supfiletypemodel.tranbrkptype_name);
               values.Add("in_active_status", supfiletypemodel.Status);
               values.Add("in_action", "INSERT");
               values.Add("in_action_by", supfiletypemodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_ttranbrkptype", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(supfiletypemodel.ip_address, supfiletypemodel.user_code);
               con.errorlog(supfiletypemodel.ip_address, supfiletypemodel.user_code, method_name, error, source_name);
               return result;
           }
       }


       public string[] SupportfiletypeUpdate(Setup_model supfiletypemodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(supfiletypemodel.ip_address, supfiletypemodel.user_code); ;

               values.Add("in_tranbrkptype_gid", supfiletypemodel.tranbrkptype_gid);
               values.Add("in_tranbrkptype_name", supfiletypemodel.tranbrkptype_name);
               values.Add("in_active_status", supfiletypemodel.Status);
               values.Add("in_action", "UPDATE");
               values.Add("in_action_by", supfiletypemodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_ttranbrkptype", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(supfiletypemodel.ip_address, supfiletypemodel.user_code);
               con.errorlog(supfiletypemodel.ip_address, supfiletypemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] Supportfiletype_Delete(Setup_model supfiletypemodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(supfiletypemodel.ip_address, supfiletypemodel.user_code); ;

               values.Add("in_tranbrkptype_gid", supfiletypemodel.tranbrkptype_gid);
               values.Add("in_tranbrkptype_name", supfiletypemodel.tranbrkptype_name);
               values.Add("in_active_status", supfiletypemodel.Status);
               values.Add("in_action", "DELETE");
               values.Add("in_action_by", supfiletypemodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_ttranbrkptype", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(supfiletypemodel.ip_address, supfiletypemodel.user_code);
               con.errorlog(supfiletypemodel.ip_address, supfiletypemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] Remarkcreate(Setup_model catemodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);;

               values.Add("in_remark_gid", catemodel.remark_gid);
               values.Add("in_remark_desc", catemodel.remark_desc);
               values.Add("in_active_status", catemodel.Status);
               values.Add("in_action", "INSERT");
               values.Add("in_action_by", catemodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_tremark", values);

               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);
               con.errorlog(catemodel.ip_address, catemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public DataTable RemarkList(Setup_model catemodel)
        {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);;

               values.Add("in_remark_gid", catemodel.remark_gid);
               values.Add("in_remark_desc", "");
               values.Add("in_active_status", "");
               values.Add("in_action", "SELECT");
               values.Add("in_action_by", catemodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDataSetProc("pr_recon_mst_tremark", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);
               con.errorlog(catemodel.ip_address, catemodel.user_code, method_name, error, source_name);
               return result;
           }
       }

       public string[] RemarkUpdate(Setup_model catemodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);;

               values.Add("in_remark_gid", catemodel.remark_gid);
               values.Add("in_remark_desc", catemodel.remark_desc);
               values.Add("in_active_status", catemodel.Status);
               values.Add("in_action", "UPDATE");
               values.Add("in_action_by", catemodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_tremark", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);
               con.errorlog(catemodel.ip_address, catemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] RemarkDelete(Setup_model catemodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);;

               values.Add("in_remark_gid", catemodel.remark_gid);
               values.Add("in_remark_desc", catemodel.remark_desc);
               values.Add("in_active_status", catemodel.Status);
               values.Add("in_action", "DELETE");
               values.Add("in_action_by", catemodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_tremark", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);
               con.errorlog(catemodel.ip_address, catemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] RemarkReason(Setup_model catemodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);;

              // values.Add("in_tranrecon_gid", catemodel.tranrecon_gid);
               values.Add("in_tran_gid", catemodel.tran_gid);
               values.Add("in_remark1", catemodel.remark1);
               values.Add("in_user_code", catemodel.user_code);              
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_set_tranremark1", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);
               con.errorlog(catemodel.ip_address, catemodel.user_code, method_name, error, source_name);
               return result;
           }
       }

       public string[] RemarkReason_new(Setup_model catemodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code); ;

               // values.Add("in_tranrecon_gid", catemodel.tranrecon_gid);
               values.Add("in_tran_gid", catemodel.tran_gid);
               values.Add("in_remark1", catemodel.remark1);
               values.Add("in_remark2", catemodel.remark2);
               values.Add("in_user_code", catemodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_set_tranremark_new", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(catemodel.ip_address, catemodel.user_code);
               con.errorlog(catemodel.ip_address, catemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
    }
}
