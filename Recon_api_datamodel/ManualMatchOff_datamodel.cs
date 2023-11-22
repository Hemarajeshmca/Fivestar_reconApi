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
   public class ManualMatchOff_datamodel
    {
       public DataTable ExceptionGrid(ManualMatchOff_model ManualMatchOff)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address,ManualMatchOff.user_code);
               values.Add("in_recon_gid", ManualMatchOff.recongid);
               values.Add("in_period_from", ManualMatchOff.periodfrom);
               values.Add("in_period_to", ManualMatchOff.periodto);
               result = con.RunDataSetProc("pr_get_excp_tran", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }
	   
       public DataTable SupFileExcpSummGrid(ManualMatchOff_model ManualMatchOff)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               values.Add("in_recon_gid", ManualMatchOff.recongid);
               values.Add("in_period_from", ManualMatchOff.periodfrom);
               values.Add("in_period_to", ManualMatchOff.periodto);
               values.Add("in_ip_addr", ManualMatchOff.ip_address);
               values.Add("in_user_code", ManualMatchOff.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDataSetProc("pr_get_tranbrkpexcpsumm", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }
	   
       public string[] AddMatchOff(ManualMatchOff_model ManualMatchOff)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address,ManualMatchOff.user_code);

               values.Add("in_recon_gid", ManualMatchOff.recon_gid);
               values.Add("in_file_type", ManualMatchOff.filetype);
               values.Add("in_acc_no", ManualMatchOff.AccountNo);
               values.Add("in_tranrecon_gid", ManualMatchOff.tranrecon_gid);
               values.Add("in_tranbrkp_gid", ManualMatchOff.tranbrkp_gid);
               values.Add("in_ko_amount", ManualMatchOff.Exceptionamountcon);
               values.Add("in_group_sno", ManualMatchOff.group_sno);
               values.Add("in_mapping_user", ManualMatchOff.user_code);
               values.Add("in_applyrule_gid", ManualMatchOff.applyrule_gid);
               values.Add("in_applyruledtl_gid", ManualMatchOff.applyruledtl_gid);
               values.Add("in_rule_gid", ManualMatchOff.rule_gid);
               values.Add("in_reversal_flag", ManualMatchOff.reversal_flag);
               values.Add("in_src_comp_flag", ManualMatchOff.filetype);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_ins_adhoclist", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }
       public DataTable SelectedMatchOff(ManualMatchOff_model ManualMatchOff)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address,ManualMatchOff.user_code);
               values.Add("in_user_code", ManualMatchOff.user_code);
               result = con.RunDataSetProc("pr_get_adhoclist", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }

       public DataTable SelectedMatchOffgrid(ManualMatchOff_model ManualMatchOff)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               values.Add("in_rptsession_gid", ManualMatchOff.outresult);
               values.Add("in_report_code", ManualMatchOff.report_gid);
               values.Add("in_page_no",ManualMatchOff.pageno);
              // values.Add("in_outputfile_flag", ManualMatchOff.in_outfile_flag);
               values.Add("in_page_size",ManualMatchOff.pagesize);
               values.Add("in_tot_records", ManualMatchOff.count);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDataSetProc("pr_get_pagenoreport", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }

       public DataTable SelectedMatchOff_grid(ManualMatchOff_model ManualMatchOff)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               values.Add("in_rptsession_gid",0);
               values.Add("in_tran_gid", ManualMatchOff.attributvalue);
               values.Add("in_usercodes",ManualMatchOff.user_code);
               //values.Add("out_msg", "out");
               //values.Add("out_result", "out");
               result = con.RunDataSetProc("pr_get_AdhocKnockoff", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }

       public string[] SelectedMatchOffcreate(ManualMatchOff_model ManualMatchOff)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address,ManualMatchOff.user_code);

               values.Add("in_recon_gid", ManualMatchOff.recon_gid);
               values.Add("in_ko_amount", ManualMatchOff.ko_amountcon);
               values.Add("in_tranrecon", ManualMatchOff.Comparition);
               values.Add("in_ko_reason", ManualMatchOff.koreason);               
               values.Add("in_user_code", ManualMatchOff.user_code);             
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_set_ko_tranrecon", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }
       public string[] SelectedMatchOffdel(ManualMatchOff_model ManualMatchOff)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address,ManualMatchOff.user_code);
               values.Add("in_user_code", ManualMatchOff.user_code);
               result = con.RunDmlProc("pr_del_adhoclist", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }

       public string[] ManulaMatch_firstloadser(ManualMatchOff_model ManualMatchOff)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               values.Add("in_report_code", ManualMatchOff.report_gid);
               values.Add("in_recon_gid", ManualMatchOff.recongid);
               values.Add("in_condition", ManualMatchOff.Report_condition);
               values.Add("in_resultset_flag", ManualMatchOff.in_outfile_flag);
               values.Add("in_ip_addr", ManualMatchOff.ip_address);
               values.Add("in_user_code", ManualMatchOff.user_code);
               values.Add("out_rec_count", "out");
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProcload("pr_run_pagereport", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }

       public string[] RunMatch_file(ManualMatchOff_model ManualMatchOff)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               values.Add("in_file_gid", ManualMatchOff.file_gid);
               values.Add("in_ip_addr", ManualMatchOff.ip_address);
               values.Add("in_user_code", ManualMatchOff.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_run_manualmatchfile", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }

       public string[] ManulaMatchsel(ManualMatchOff_model ManualMatchOff)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               values.Add("in_recon_gid", ManualMatchOff.recon_gid);
               values.Add("in_ko_amount", ManualMatchOff.debitscore);
               values.Add("in_tran", ManualMatchOff.tranid_frame);
               values.Add("in_ko_reason", ManualMatchOff.knockoffreason);
               values.Add("in_user_code", ManualMatchOff.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_set_ko_tran", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }


       public DataTable AmountMatched(ManualMatchOff_model ManualMatchOff)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address,ManualMatchOff.user_code);
               values.Add("in_recon_gid", ManualMatchOff.recon_gid);
               values.Add("in_period_from", ManualMatchOff.periodfrom);
               values.Add("in_period_to", ManualMatchOff.periodto);            
               values.Add("in_excp_amount", ManualMatchOff.ko_amountcon);
               values.Add("in_user_code", ManualMatchOff.user_code);
               if (ManualMatchOff.grp_field == "S")
               {
                   result = con.RunDataSetProc("pr_get_amountmatchlist", values);
               }
               else
               {
                   result = con.RunDataSetProc("pr_get_amountgrouplist", values);
               }  
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }
       public DataTable AmountMatchedAll(ManualMatchOff_model ManualMatchOff)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address,ManualMatchOff.user_code);
               values.Add("in_recon_gid", ManualMatchOff.recon_gid);
               values.Add("in_period_from", ManualMatchOff.periodfrom);
               values.Add("in_period_to", ManualMatchOff.periodto);
               values.Add("in_excp_amount", ManualMatchOff.ko_amountcon);
               values.Add("in_user_code", ManualMatchOff.user_code);
               if (ManualMatchOff.grp_field == "S")
               {
                   result = con.RunDataSetProc("pr_get_amountmatchlist", values);
               }
               else
               {
                   result = con.RunDataSetProc("pr_get_amountgrouplist", values);
               }

               result.Rows.Clear();
               result.Columns.Clear();

               values = new Dictionary<string, object>();
               values.Add("in_user_code", ManualMatchOff.user_code);
               result = con.RunDataSetProc("pr_get_adhoclist", values);

               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }
       public string[] AmountMatchedSave(ManualMatchOff_model ManualMatchOff)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address,ManualMatchOff.user_code);

               values.Add("in_recon_gid", ManualMatchOff.recon_gid);
               values.Add("in_bulk_tranrecon", ManualMatchOff.Description);             
               values.Add("in_user_code", ManualMatchOff.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_set_bulk_kotranrecon", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }
       public DataTable RuleGrid(ManualMatchOff_model ManualMatchOff)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address,ManualMatchOff.user_code);
               values.Add("in_recon_gid", ManualMatchOff.recongid);              
               result = con.RunDataSetProc("pr_get_reconrule", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }
       public DataTable GetManualmatch(ManualMatchOff_model ManualMatchOff)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
              values.Add("in_user_code", ManualMatchOff.user_code);
               result = con.RunDataSetProc("pr_get_manualmatch", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }
       public string[] RuleMatchOff(ManualMatchOff_model ManualMatchOff)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address,ManualMatchOff.user_code);

               values.Add("in_recon_gid", ManualMatchOff.Rule);
               values.Add("in_recon_type", ManualMatchOff.recontype);
               values.Add("in_period_from", ManualMatchOff.periodfrom);
               values.Add("in_period_to", ManualMatchOff.periodto);
               values.Add("in_automatch_flag", ManualMatchOff.automatchoff);
               values.Add("in_ip_addr", ManualMatchOff.ip_address);
               values.Add("in_user_code", ManualMatchOff.user_code);              
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
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }
       public string[] RuleMatchOffSelction(ManualMatchOff_model ManualMatchOff)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address,ManualMatchOff.user_code);

               values.Add("in_recon_gid", ManualMatchOff.recon_gid);
               values.Add("in_bulk_gid", ManualMatchOff.Description);
               values.Add("in_user_code", ManualMatchOff.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_set_bulk_ko", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }
       public DataTable ManualSingleView(ManualMatchOff_model ManualMatchOff)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address,ManualMatchOff.user_code);

               values.Add("in_file_type", ManualMatchOff.filetype);
               values.Add("in_tranrecon_gid", ManualMatchOff.tranrecon_gid);
               values.Add("in_tranbrkp_gid", ManualMatchOff.tranbrkp_gid);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDataSetProc("pr_get_excp_bygid", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }
       public string[] MatchOffReason(ManualMatchOff_model ManualMatchOff)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address,ManualMatchOff.user_code);

               values.Add("in_ko_gid", ManualMatchOff.recon_gid);
               values.Add("in_ko_reason", ManualMatchOff.Description);
               result = con.RunDmlProc("pr_upd_koreason", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }
       public DataTable SupFilemappingRead(ManualMatchOff_model ManualMatchOff)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address,ManualMatchOff.user_code);
               values.Add("in_tran_gid", ManualMatchOff.tran_gid);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDataSetProc("pr_get_tranbrkpbyfile", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }
       public string[] SupFilemappingcheck(ManualMatchOff_model ManualMatchOff)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address,ManualMatchOff.user_code);
               values.Add("in_tran_gid", ManualMatchOff.tran_gid);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_get_tranbrkpbyfile", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }
       public string[] SupFilemappingcreate(ManualMatchOff_model ManualMatchOff)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address,ManualMatchOff.user_code);

               values.Add("in_file_gid", ManualMatchOff.file_gid);
               values.Add("in_tran_gid", ManualMatchOff.tran_gid);            
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_post_tranbrkpbyfile", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }

       public string[] undomatch_offmodel(ManualMatchOff_model ManualMatchOff)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);

               values.Add("in_job_gid", ManualMatchOff.jobgid);
               values.Add("in_undo_job_reason", ManualMatchOff.knockoffreason);
               values.Add("in_ip_addr", ManualMatchOff.ip_address);
               values.Add("in_user_code", ManualMatchOff.user_code);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_set_undokojob", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(ManualMatchOff.ip_address, ManualMatchOff.user_code);
               con.errorlog(ManualMatchOff.ip_address, ManualMatchOff.user_code, method_name, error, source_name);
               throw ex;
           }
       }
    }
}
