using Recon_api_model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Recon_api_datamodel
{
   public class AcMaster_datamodel
   {

       public DataTable AcMasterList(AcMaster_model Acmodel)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(Acmodel.ip_address, Acmodel.user_code);
               values.Add("in_acc_gid", Acmodel.Account_id);
               values.Add("in_active_status", Acmodel.Status);
               result = con.RunDataSetProc("pr_get_acc", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(Acmodel.ip_address, Acmodel.user_code);
               con.errorlog(Acmodel.user_code, Acmodel.ip_address, method_name, error, source_name);
               return result;
           }
       }
       public DataTable getacc_no(AcMaster_model Acmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Acmodel.ip_address, Acmodel.user_code);
                values.Add("in_recon_gid", Acmodel.recon_gid);

                result = con.RunDataSetProc("pr_get_reconacc", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Acmodel.ip_address, Acmodel.user_code);
                con.errorlog(Acmodel.user_code, Acmodel.ip_address, method_name, error, source_name);
                throw ex;
                return result;
            }
        }
       public string[] AcMastercreate(AcMaster_model Acmodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(Acmodel.ip_address, Acmodel.user_code);

               var ipaddrss = Acmodel.ip_address;
               var user_code = Acmodel.user_code;
               values.Add("in_acc_gid", Acmodel.Account_id);
               values.Add("in_acc_no", Acmodel.AccountNo);
               values.Add("in_acc_name", Acmodel.AccountName);
               values.Add("in_acc_category", Acmodel.Category_name);
               values.Add("in_acc_responsibility", Acmodel.Respon_name);
               values.Add("in_within_acc_flag", Acmodel.withinflag);
               values.Add("in_between_acc_flag", Acmodel.Recontype);
               values.Add("in_acc_type", Acmodel.Accounttype);
               values.Add("in_deduprule_validation", Acmodel.Dedupvalidateion);
               values.Add("in_deduprule_gid", Acmodel.Deduperule_id);
               values.Add("in_active_status", Acmodel.Status);
               values.Add("in_action", Acmodel.action);
               values.Add("in_action_by", Acmodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_tacc", values);
               return result;             
           }
           catch (Exception ex)
           {
              
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(Acmodel.ip_address, Acmodel.user_code);
               con.errorlog(Acmodel.user_code, Acmodel.ip_address, method_name, error, source_name);
               //throw ex;
               return result;
           }
       }
       public string[] AcMasterUpdate(AcMaster_model Acmodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(Acmodel.ip_address, Acmodel.user_code);
               var ipaddrss = Acmodel.ip_address;
               var user_code = Acmodel.user_code;
               values.Add("in_acc_gid", Acmodel.Account_id);
               values.Add("in_acc_no", Acmodel.AccountNo);
               values.Add("in_acc_name", Acmodel.AccountName);
               values.Add("in_acc_category", Acmodel.Category_name);
               values.Add("in_acc_responsibility", Acmodel.Respon_name);
               values.Add("in_within_acc_flag", Acmodel.withinflag);
               values.Add("in_between_acc_flag", Acmodel.Recontype);
               values.Add("in_acc_type", Acmodel.Accounttype);
               values.Add("in_deduprule_validation", Acmodel.Dedupvalidateion);
               values.Add("in_deduprule_gid", Acmodel.Deduperule_id);
               values.Add("in_active_status", Acmodel.Status);
               values.Add("in_action", Acmodel.action);
               values.Add("in_action_by", Acmodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_tacc", values);
               return result;
           }
           catch (Exception ex)
           {
              
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(Acmodel.ip_address, Acmodel.user_code);
               con.errorlog(Acmodel.user_code, Acmodel.ip_address, method_name, error, source_name);
               //throw ex;
               return result;
           }
       }
       public string[] AcMasterDelete(AcMaster_model Acmodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(Acmodel.ip_address, Acmodel.user_code);
               var ipaddrss = Acmodel.ip_address;
               var user_code = Acmodel.user_code;
               values.Add("in_acc_gid", Acmodel.Account_id);
               values.Add("in_acc_no", Acmodel.AccountNo);
               values.Add("in_acc_name", Acmodel.AccountName);
               values.Add("in_acc_category", Acmodel.Category_name);
               values.Add("in_acc_responsibility", Acmodel.Respon_name);
               values.Add("in_within_acc_flag", Acmodel.withinflag);
               values.Add("in_between_acc_flag", Acmodel.Recontype);
               values.Add("in_acc_type", Acmodel.Accounttype);
               values.Add("in_deduprule_validation", Acmodel.Dedupvalidateion);
               values.Add("in_deduprule_gid", Acmodel.Deduperule_id);
               values.Add("in_active_status", Acmodel.Status);
               values.Add("in_action", Acmodel.action);
               values.Add("in_action_by", Acmodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_tacc", values);
               return result;
           }
           catch (Exception ex)
           {
               
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(Acmodel.ip_address, Acmodel.user_code);
               con.errorlog(Acmodel.user_code, Acmodel.ip_address, method_name, error, source_name);
               //throw ex;
               return result;
           }
       }
    }
}
