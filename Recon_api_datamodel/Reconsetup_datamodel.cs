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
   public class Reconsetup_datamodel
    {
       public DataTable RecontypeList(Reconsetup_model Reconsetup)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(Reconsetup.ip_address,Reconsetup.user_code);
               values.Add("in_recon_gid", Reconsetup.recon_id);
               values.Add("in_active_status", "");
               result = con.RunDataSetProc("pr_get_recon", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(Reconsetup.ip_address, Reconsetup.user_code);
               con.errorlog(Reconsetup.ip_address, Reconsetup.user_code, method_name, error, source_name);
               return result;
           }
       }
       public DataTable AccName(Reconsetup_model Reconsetup)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(Reconsetup.ip_address,Reconsetup.user_code);
               values.Add("in_acc_no", Reconsetup.account1_code);
               result = con.RunDataSetProc("pr_get_accname", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(Reconsetup.ip_address, Reconsetup.user_code);
               con.errorlog(Reconsetup.ip_address, Reconsetup.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] RecontypeCreate(Reconsetup_model Recon_model)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(Recon_model.ip_address, Recon_model.user_code);

               values.Add("in_recon_gid", Recon_model.recon_id);
               values.Add("in_recon_name", Recon_model.ReconName);
               values.Add("in_recon_type", Recon_model.Recon_type);
               values.Add("in_acc_no1", Recon_model.account1_desc);
               values.Add("in_acc_no2", Recon_model.account2_desc);
               values.Add("in_mapping_type", Recon_model.MappingType_code);
               values.Add("in_period_from", Recon_model.period_from);
               values.Add("in_period_to", Recon_model.period_to);
               values.Add("in_until_active_flag", Recon_model.untillactive);            
               values.Add("in_active_status", Recon_model.Status_code);
               values.Add("in_action", "INSERT");
               values.Add("in_action_by", Recon_model.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_trecon", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(Recon_model.ip_address, Recon_model.user_code);
               con.errorlog(Recon_model.ip_address, Recon_model.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] RecontypeUpdate(Reconsetup_model Recon_model)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(Recon_model.ip_address, Recon_model.user_code);

               values.Add("in_recon_gid", Recon_model.recon_id);
               values.Add("in_recon_name", Recon_model.ReconName);
               values.Add("in_recon_type", Recon_model.Recon_type);
               values.Add("in_acc_no1", Recon_model.account1_desc);
               values.Add("in_acc_no2", Recon_model.account2_desc);
               values.Add("in_mapping_type", Recon_model.MappingType_code);
               values.Add("in_period_from", Recon_model.period_from);
               values.Add("in_period_to", Recon_model.period_to);
               values.Add("in_until_active_flag", Recon_model.untillactive);
               values.Add("in_active_status", Recon_model.Status_code);
               values.Add("in_action", "UPDATE");
               values.Add("in_action_by", Recon_model.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_trecon", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(Recon_model.ip_address, Recon_model.user_code);
               con.errorlog(Recon_model.ip_address, Recon_model.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] RecontypeDelete(Reconsetup_model Recon_model)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(Recon_model.ip_address, Recon_model.user_code);

               values.Add("in_recon_gid", Recon_model.recon_id);
               values.Add("in_recon_name", Recon_model.ReconName);
               values.Add("in_recon_type", Recon_model.Recon_type);
               values.Add("in_acc_no1", Recon_model.account1_desc);
               values.Add("in_acc_no2", Recon_model.account2_desc);
               values.Add("in_mapping_type", Recon_model.MappingType_code);
               values.Add("in_period_from", Recon_model.period_from);
               values.Add("in_period_to", Recon_model.period_to);
               values.Add("in_until_active_flag", Recon_model.untillactive);
               values.Add("in_active_status", Recon_model.Status_code);
               values.Add("in_action", "DELETE");
               values.Add("in_action_by", Recon_model.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_trecon", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(Recon_model.ip_address, Recon_model.user_code);
               con.errorlog(Recon_model.ip_address, Recon_model.user_code, method_name, error, source_name);
               return result;
           }
       }
    }
}
