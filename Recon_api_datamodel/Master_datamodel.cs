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
   public class Master_datamodel
    {
       public string[] GetMasterData(Master_model mastermodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(mastermodel.ip_address, mastermodel.user_code);
               values.Add("in_table_code", mastermodel.table_code);
               values.Add("in_lookup_field", mastermodel.lookup_field);
               values.Add("in_return_field", mastermodel.return_field);
               values.Add("in_lookup_value", mastermodel.lookup_value);
               values.Add("out_value", "out");
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProcNew("pr_get_masterdata", values);
               return result;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataTable GetMasterList(Master_model mastermodel)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(mastermodel.ip_address, mastermodel.user_code);
               values.Add("in_master_gid", mastermodel.master_gid);
               values.Add("in_sys_code", mastermodel.parent_master_syscode);
               values.Add("in_master_syscode", mastermodel.master_syscode);
               values.Add("in_master_code", mastermodel.master_code);
               values.Add("in_master_short_code", mastermodel.master_short_code);
               values.Add("in_master_name", mastermodel.master_name);
               values.Add("in_active_status", mastermodel.active_status);
               values.Add("in_action", "SELECT");
               values.Add("in_action_by", mastermodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");              
               result = con.RunDataSetProc("pr_recon_mst_tmaster", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(mastermodel.ip_address, mastermodel.user_code);
               con.errorlog(mastermodel.user_code, mastermodel.ip_address, method_name, error, source_name);
               throw ex;
           }
       }
       public string[] GetMasterCreate(Master_model mastermodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(mastermodel.ip_address, mastermodel.user_code);
               values.Add("in_master_gid", mastermodel.master_gid);
               values.Add("in_sys_code", mastermodel.parent_master_syscode);
               values.Add("in_master_syscode", mastermodel.master_syscode);
               values.Add("in_master_code", mastermodel.master_code);
               values.Add("in_master_short_code", mastermodel.master_short_code);
               values.Add("in_master_name", mastermodel.master_name);
               values.Add("in_active_status", mastermodel.active_status);
               values.Add("in_action", "INSERT");
               values.Add("in_action_by", mastermodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_tmaster", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(mastermodel.ip_address, mastermodel.user_code);
               con.errorlog(mastermodel.user_code, mastermodel.ip_address, method_name, error, source_name);
               throw ex;
           }
       }
       public string[] GetMasterUpdate(Master_model mastermodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(mastermodel.ip_address, mastermodel.user_code);
               values.Add("in_master_gid", mastermodel.master_gid);
               values.Add("in_sys_code", mastermodel.parent_master_syscode);
               values.Add("in_master_syscode", mastermodel.master_syscode);
               values.Add("in_master_code", mastermodel.master_code);
               values.Add("in_master_short_code", mastermodel.master_short_code);
               values.Add("in_master_name", mastermodel.master_name);
               values.Add("in_active_status", mastermodel.active_status);
               values.Add("in_action", "UPDATE");
               values.Add("in_action_by", mastermodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_tmaster", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(mastermodel.ip_address, mastermodel.user_code);
               con.errorlog(mastermodel.user_code, mastermodel.ip_address, method_name, error, source_name);
               throw ex;
           }
       }
       public string[] GetMasterDelete(Master_model mastermodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(mastermodel.ip_address, mastermodel.user_code);
               values.Add("in_master_gid", mastermodel.master_gid);
               values.Add("in_sys_code", mastermodel.parent_master_syscode);
               values.Add("in_master_syscode", mastermodel.master_syscode);
               values.Add("in_master_code", mastermodel.master_code);
               values.Add("in_master_short_code", mastermodel.master_short_code);
               values.Add("in_master_name", mastermodel.master_name);
               values.Add("in_active_status", mastermodel.active_status);
               values.Add("in_action", "DELETE");
               values.Add("in_action_by", mastermodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_tmaster", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(mastermodel.ip_address, mastermodel.user_code);
               con.errorlog(mastermodel.user_code, mastermodel.ip_address, method_name, error, source_name);
               throw ex;
           }
       }
    }
}
