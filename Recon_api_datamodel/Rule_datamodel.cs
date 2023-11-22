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
   public class Rule_datamodel
    {
       public DataTable RuleList(Dedup_model rulemodel)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(rulemodel.ip_address,rulemodel.user_code);
               values.Add("in_rule_gid", 0);
               values.Add("in_active_status", "");
               result = con.RunDataSetProc("pr_get_rule", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(rulemodel.ip_address, rulemodel.user_code);
               con.errorlog(rulemodel.ip_address, rulemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] RuleCreate(Dedup_model rulemodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(rulemodel.ip_address,rulemodel.user_code);

               values.Add("in_rule_gid", rulemodel.slno);
               values.Add("in_rule_name", rulemodel.Rule_name);
               values.Add("in_period_from", rulemodel.period_from);
               values.Add("in_period_to", rulemodel.period_To);
               values.Add("in_until_active_flag", rulemodel.untillactive);
               values.Add("in_group_flag", rulemodel.group_flag);      
               values.Add("in_active_status", rulemodel.status);                       
               values.Add("in_action", "INSERT");
               values.Add("in_action_by", rulemodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_trule", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(rulemodel.ip_address, rulemodel.user_code);
               con.errorlog(rulemodel.ip_address, rulemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] RuleDelete(Dedup_model rulemodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(rulemodel.ip_address,rulemodel.user_code);

               values.Add("in_rule_gid", rulemodel.slno);
               values.Add("in_user_code", rulemodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProcNew("pr_del_rule", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(rulemodel.ip_address, rulemodel.user_code);
               con.errorlog(rulemodel.ip_address, rulemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] RuleUpdate(Dedup_model rulemodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(rulemodel.ip_address,rulemodel.user_code);

               values.Add("in_rule_gid", rulemodel.slno);
               values.Add("in_rule_name", rulemodel.Rule_name);
               values.Add("in_period_from", rulemodel.period_from);
               values.Add("in_period_to", rulemodel.period_To);
               values.Add("in_until_active_flag", rulemodel.untillactive);
               values.Add("in_group_flag", rulemodel.group_flag);
               values.Add("in_active_status", rulemodel.status);
               values.Add("in_action", "UPDATE");
               values.Add("in_action_by", rulemodel.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_recon_mst_trule", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(rulemodel.ip_address, rulemodel.user_code);
               con.errorlog(rulemodel.ip_address, rulemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public DataTable RuleGridList(Dedup_model dedupmodel)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);
               values.Add("in_rulefield_gid", 0);
               values.Add("in_rule_gid", dedupmodel.slno);
               result = con.RunDataSetProc("pr_get_rulefieldrecord", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);
               con.errorlog(dedupmodel.ip_address, dedupmodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public DataTable RuleGrid_listEdit(Dedup_model dedupmodel)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);
               values.Add("in_rule_gid", dedupmodel.slno);
               values.Add("in_active_status", "");
               result = con.RunDataSetProc("pr_get_rule", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);
               con.errorlog(dedupmodel.ip_address, dedupmodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] RulegridCreate(Dedup_model rulemodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(rulemodel.ip_address,rulemodel.user_code);

               values.Add("in_rule_gid", rulemodel.slnolist);
               values.Add("in_source_field", rulemodel.field_name);
               values.Add("in_extraction_criteria", rulemodel.ExtractionCriteria);
               values.Add("in_extraction_filter", rulemodel.extraction_filter);
               values.Add("in_target_field", rulemodel.TargetField);
               values.Add("in_comparison_criteria", rulemodel.ComparisonCriteria);
               values.Add("in_comparison_filter", rulemodel.comparision_filter);
               values.Add("in_active_status", rulemodel.status);               
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_ins_rulefield", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(rulemodel.ip_address, rulemodel.user_code);
               con.errorlog(rulemodel.ip_address, rulemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] RulegridDelete(Dedup_model rulemodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(rulemodel.ip_address,rulemodel.user_code);

               values.Add("in_rulefield_gid", rulemodel.slno);               
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_del_rulefield", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(rulemodel.ip_address, rulemodel.user_code);
               con.errorlog(rulemodel.ip_address, rulemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public string[] RulegridUpdate(Dedup_model rulemodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(rulemodel.ip_address,rulemodel.user_code);

               values.Add("in_rulefield_gid", rulemodel.slno);
               values.Add("in_rule_gid", rulemodel.slnolist);              
               values.Add("in_source_field", rulemodel.field_name);
               values.Add("in_extraction_criteria", rulemodel.ExtractionCriteria);
               values.Add("in_extraction_filter", rulemodel.extraction_filter);
               values.Add("in_target_field", rulemodel.TargetField);
               values.Add("in_comparison_criteria", rulemodel.ComparisonCriteria);
               values.Add("in_comparison_filter", rulemodel.comparision_filter);
               values.Add("in_active_status", rulemodel.status);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_upd_rulefield", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(rulemodel.ip_address, rulemodel.user_code);
               con.errorlog(rulemodel.ip_address, rulemodel.user_code, method_name, error, source_name);
               return result;
           }
       }
       public DataTable ExtractioncertiaDrop(Dedup_model dedupmodel)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);
               values.Add("in_field_type", dedupmodel.field_type);
               values.Add("in_condition_type", dedupmodel.Name);
               result = con.RunDataSetProc("pr_get_conditioncriteria", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);
               con.errorlog(dedupmodel.ip_address, dedupmodel.user_code, method_name, error, source_name);
               return result;
           }
       }
      
    }
}
