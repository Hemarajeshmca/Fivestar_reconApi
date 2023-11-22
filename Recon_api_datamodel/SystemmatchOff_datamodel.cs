using Recon_api_model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Recon_api_datamodel
{
   public class SystemmatchOff_datamodel
    {
       public DataTable WithinAccList(Systemmatchoff_model Applymodel)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(Applymodel.ip_address, Applymodel.user_code);
               values.Add("in_recon_type", Applymodel.Select);
               values.Add("in_active_status", Applymodel.status);
               result = con.RunDataSetProc("pr_get_reconbytype", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(Applymodel.ip_address, Applymodel.user_code);
               con.errorlog(Applymodel.ip_address, Applymodel.user_code, method_name, error, source_name);
               throw ex;
           }
       }
       public  string[] SystemMatchoffWith(Systemmatchoff_model Systemmatchoff)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(Systemmatchoff.ip_address, Systemmatchoff.user_code);
               
               values.Add("in_recon_gid", Systemmatchoff.Select);
               values.Add("in_recon_type", Systemmatchoff.Recontype);
               values.Add("in_period_from", Systemmatchoff.period_from);
               values.Add("in_period_to", Systemmatchoff.period_to);
               values.Add("in_automatch_flag", Systemmatchoff.status);
               values.Add("in_ip_addr", Systemmatchoff.ip_address);
               values.Add("in_user_code", Systemmatchoff.createdby);             
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_run_match", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(Systemmatchoff.ip_address, Systemmatchoff.user_code);
               con.errorlog(Systemmatchoff.ip_address, Systemmatchoff.user_code, method_name, error, source_name);
               throw ex;
           }
       }
    }
}
