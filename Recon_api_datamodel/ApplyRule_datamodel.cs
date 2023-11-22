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
    public class ApplyRule_datamodel
    {
        public DataTable ApplyruleList(Applyrule_model Applyrule)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                values.Add("in_applyrule_gid", Applyrule.slno);
                values.Add("in_active_status", Applyrule.status);
                result = con.RunDataSetProc("pr_get_applyrule", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        public DataTable ApplyruleDrop(Applyrule_model Applymodel)
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
                con.errorlog(Applymodel.user_code, Applymodel.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        public DataTable ApplyruleSUPDrop(Applyrule_model Applymodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applymodel.ip_address, Applymodel.user_code);
                values.Add("in_tranbrkptype_gid", Applymodel.slno);
                values.Add("in_active_status", Applymodel.status);
                result = con.RunDataSetProc("pr_get_tranbrkptype", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applymodel.ip_address, Applymodel.user_code);
                con.errorlog(Applymodel.user_code, Applymodel.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        public string[] ApplyruleCreate(Applyrule_model Applyrule)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);


                values.Add("in_applyrule_gid", Applyrule.slno);
                values.Add("in_recon_gid", Applyrule.ReconName_id);
                values.Add("in_recon_type", Applyrule.Recontype);
                values.Add("in_tranbrkptype_gid", Applyrule.supporting_file_id);
                values.Add("in_system_matchoff", Applyrule.matchoffSys);
                values.Add("in_manual_matchoff", Applyrule.matchoffMan);
                values.Add("in_period_from", Applyrule.period_from);
                values.Add("in_period_to", Applyrule.period_to);
                values.Add("in_until_active_flag", Applyrule.untillactive);
                values.Add("in_active_status", Applyrule.status);
                values.Add("in_action", "INSERT");
                values.Add("in_action_by", Applyrule.user_code);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProcNew("pr_recon_mst_tapplyrule", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        public DataTable Applyrule_listEdit(Applyrule_model Applyrule)
        {

            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                values.Add("in_applyrule_gid", Applyrule.slno);
                values.Add("in_active_status", "");
                result = con.RunDataSetProc("pr_get_applyrule", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        public string[] ApplyruleUpdate(Applyrule_model Applyrule)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);


                values.Add("in_applyrule_gid", Applyrule.slno);
                values.Add("in_recon_gid", Applyrule.ReconName_id);
                values.Add("in_recon_type", Applyrule.Recontype);
                values.Add("in_tranbrkptype_gid", Applyrule.supporting_file_id);
                values.Add("in_system_matchoff", Applyrule.matchoffSys);
                values.Add("in_manual_matchoff", Applyrule.matchoffMan);
                values.Add("in_period_from", Applyrule.period_from);
                values.Add("in_period_to", Applyrule.period_to);
                values.Add("in_until_active_flag", Applyrule.untillactive);
                values.Add("in_active_status", Applyrule.status);
                values.Add("in_action", "UPDATE");
                values.Add("in_action_by", Applyrule.user_code);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_recon_mst_tapplyrule", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        public DataTable Applyrulegriddtl(Applyrule_model Applyrule)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                values.Add("in_applyruledtl_gid", 0);
                values.Add("in_applyrule_gid", Applyrule.slno);
                values.Add("in_active_status", "");
                result = con.RunDataSetProc("pr_get_applyruledtl", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        public DataTable Applyrulegridadd(Applyrule_model Applyrule)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                values.Add("in_applyrule_addcond_gid", 0);
                values.Add("in_applyruledtl_gid", Applyrule.Rulegid);
                values.Add("in_applyrule_gid", Applyrule.slno);
                values.Add("in_active_status", "");
                result = con.RunDataSetProc("pr_get_applyrule_addcond", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        public DataTable Applyrulegridgroup(Applyrule_model Applyrule)
        {
            var ipaddrss = Applyrule.ip_address;
            var user_code = Applyrule.user_code;
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                values.Add("in_applyrule_basesele_gid", 0);
                values.Add("in_applyruledtl_gid", Applyrule.Rulegid);
                values.Add("in_applyrule_gid", Applyrule.slno);
                values.Add("in_active_status", "");
                result = con.RunDataSetProc("pr_get_applyrule_basesele", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        public string[] ApplyRuleGridCreate(Applyrule_model Applyrule)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);

                values.Add("in_applyrule_gid", Applyrule.listslno);
                values.Add("in_rule_gid", Applyrule.Rulegid);
                values.Add("in_reversal_flag", Applyrule.reversl_flag);
                values.Add("in_group_flag", Applyrule.group_flag);
                values.Add("in_group_method", Applyrule.group_method);
                values.Add("in_manytomany_match_flag", Applyrule.group_many);
                values.Add("in_rule_order", Applyrule.Ruleorder);
                values.Add("in_active_status", Applyrule.status);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_ins_applyruledtl_new", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        public string[] ApplyRuleGridUpdate(Applyrule_model Applyrule)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);

                values.Add("in_applyruledtl_gid", Applyrule.slno);
                values.Add("in_applyrule_gid", Applyrule.listslno);
                values.Add("in_rule_gid", Applyrule.Rulegid);
                values.Add("in_reversal_flag", Applyrule.reversl_flag);
                values.Add("in_group_flag", Applyrule.group_flag);
                values.Add("in_group_method", Applyrule.group_method);
                values.Add("in_manytomany_match_flag", Applyrule.group_many);
                values.Add("in_rule_order", Applyrule.Ruleorder);
                values.Add("in_active_status", Applyrule.status);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_upd_applyruledtl_new", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        public string[] ApplyRuleGridCreateAdd(Applyrule_model Applyrule)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);

                values.Add("in_applyrule_gid", Applyrule.listslno);
                values.Add("in_applyruledtl_gid", Applyrule.applyruledtl_gid);
                values.Add("in_source_field", Applyrule.field_name);
                values.Add("in_extraction_criteria", Applyrule.ExtractionCriteria);
                values.Add("in_extraction_filter", Applyrule.extraction_filter);
                values.Add("in_target_field", Applyrule.TargetField);
                values.Add("in_comparison_criteria", Applyrule.ComparisonCriteria);
                values.Add("in_comparison_filter", Applyrule.comparision_filter);
                //  values.Add("in_group_flag", Applyrule.groupflag);
                values.Add("in_active_status", Applyrule.status);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_ins_applyrule_addcond", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }

        public string[] ApplyRuleGridUpdateAddBaseFilter(Applyrule_model Applyrule)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);

                values.Add("in_applyrule_basefilter_gid", Applyrule.slnobaseFilter);
                values.Add("in_applyrule_basesele_gid", Applyrule.slnobase);
                values.Add("in_base_field", Applyrule.field_name);
                values.Add("in_base_criteria", Applyrule.BaseCriteria);
                values.Add("in_base_filter", Applyrule.extraction_filter);
                values.Add("in_ident_criteria", Applyrule.IdentityCriteria);
                values.Add("in_ident_value", Applyrule.TargetField);
                values.Add("in_filter_applied_on", Applyrule.filter_appliedon);
                values.Add("in_active_status", Applyrule.status);
                // values.Add("in_action", Applyrule.in_action);

                if (Applyrule.in_action == "DELETE")
                {
                    values.Add("in_action", "DELETE");
                }
                else
                {
                    if (Applyrule.slnobaseFilter == 0)
                    {
                        values.Add("in_action", "INSERT");
                    }
                    else
                    {
                        values.Add("in_action", "UPDATE");
                    }
                }
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_recon_mst_tapplyrule_basefilter", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                throw ex;
            }
        }

        public string[] ApplyRuleGridUpdateAdd(Applyrule_model Applyrule)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);

                values.Add("in_applyrule_addcond_gid", Applyrule.slnoadd);
                values.Add("in_applyrule_gid", Applyrule.listslno);
                values.Add("in_applyruledtl_gid", Applyrule.slno);
                values.Add("in_source_field", Applyrule.field_name);
                values.Add("in_extraction_criteria", Applyrule.ExtractionCriteria);
                values.Add("in_extraction_filter", Applyrule.extraction_filter);
                values.Add("in_target_field", Applyrule.TargetField);
                values.Add("in_comparison_criteria", Applyrule.ComparisonCriteria);
                values.Add("in_comparison_filter", Applyrule.comparision_filter);
                //values.Add("in_group_flag", Applyrule.groupflag);
                values.Add("in_active_status", Applyrule.status);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_upd_applyrule_addcond", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        public string[] ApplyRuleGridCreateBase(Applyrule_model Applyrule)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);


                values.Add("in_applyrule_gid", Applyrule.listslno);
                values.Add("in_applyruledtl_gid", Applyrule.slno);
                //values.Add("in_applyrule_gid", 7);
                //values.Add("in_applyruledtl_gid", 23);
                values.Add("in_acc_no", Applyrule.account1);
                // values.Add("in_comp_crteria", Applyrule.comparecrtieria);
                //  values.Add("in_comp_crteria", Applyrule.ComparisonCriteria);
                values.Add("in_acc_mode", Applyrule.Accountmode);
                values.Add("in_sele_order", Applyrule.Order);
                values.Add("in_active_status", Applyrule.status);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_ins_applyrule_basesele", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        public string[] ApplyRuleGridUpdateBase(Applyrule_model Applyrule)
         {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);


                values.Add("in_applyrule_basesele_gid", Applyrule.slnobase);
                values.Add("in_applyrule_gid", Applyrule.listslno);
                values.Add("in_applyruledtl_gid", Applyrule.slno);
                values.Add("in_acc_no", Applyrule.account1);
                values.Add("in_acc_mode", Applyrule.Accountmode);
                values.Add("in_sele_order", Applyrule.Order);
                values.Add("in_active_status", Applyrule.status);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_upd_applyrule_basesele", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }

        public string[] AppylyruleTargetgrp_create(Applyrule_model Applyrule)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);


                values.Add("in_applyrule_targetgrpfield_gid",Applyrule.target_grpfield_gid);
                values.Add("in_applyrule_basesele_gid", Applyrule.applyrule_basesele_gid);
                values.Add("in_target_grpfield", Applyrule.target_grpfield);
                values.Add("in_active_status", Applyrule.status);
                values.Add("in_action", Applyrule.in_action);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_recon_mst_applyrule_targetgrpfield", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        public string[] AppylyruleTargetgrp_Delete(Applyrule_model Applyrule)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);


                values.Add("in_applyrule_targetgrpfield_gid", Applyrule.target_grpfield_gid);
                values.Add("in_applyrule_basesele_gid", Applyrule.applyrule_basesele_gid);
                values.Add("in_target_grpfield", Applyrule.target_grpfield);
                values.Add("in_active_status", Applyrule.status);
                values.Add("in_action", Applyrule.in_action);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_recon_mst_applyrule_targetgrpfield", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }

        public string[] ApplyRuleAddtarget_Update(Applyrule_model Applyrule)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);


                values.Add("in_applyrule_targetgrpfield_gid", Applyrule.target_grpfield_gid);
                values.Add("in_applyrule_basesele_gid", Applyrule.applyrule_basesele_gid);
                values.Add("in_target_grpfield", Applyrule.target_grpfield);
                values.Add("in_active_status", Applyrule.status);
                values.Add("in_action", Applyrule.in_action);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_recon_mst_applyrule_targetgrpfield", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        public DataTable ApplyrulegridRule(Applyrule_model Applyrule)
        {

            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                values.Add("in_rulefield_gid", 0);
                values.Add("in_rule_gid", Applyrule.Rulegid);
                result = con.RunDataSetProc("pr_get_rulefieldrecord", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        public DataTable ApplyruleBaseFilterRule(Applyrule_model Applyrule)
        {

            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);

                values.Add("in_applyrule_basesele_gid", Applyrule.Rulegid);
                values.Add("in_Action", Applyrule.in_action);
                result = con.RunDataSetProc("pr_get_applyrule_basefilter_tb", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                throw ex;
            }
        }
        public DataTable AccountNodrop(Applyrule_model Applymodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applymodel.ip_address, Applymodel.user_code);
                values.Add("in_recon_gid", Applymodel.ReconName_id);
                result = con.RunDataSetProc("pr_get_reconacc", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applymodel.ip_address, Applymodel.user_code);
                con.errorlog(Applymodel.user_code, Applymodel.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        public string[] ApplyRuleListDelete(Applyrule_model Applyrule)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);


                values.Add("in_applyrule_gid", Applyrule.listslno);
                values.Add("in_user_code", Applyrule.user_code);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProcNew("pr_del_applyrule", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        public string[] ApplyRuledtlDelete(Applyrule_model Applyrule)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);


                values.Add("in_applyruledtl_gid", Applyrule.slno);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProcNew("pr_del_applyruledtl", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        public string[] ApplyRuleBaseSelDelete(Applyrule_model Applyrule)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);


                values.Add("in_applyrule_basesele_gid", Applyrule.slnobase);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProcNew("pr_del_applyrule_basesele", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        public string[] ApplyRuleAddConDelete(Applyrule_model Applyrule)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);

                values.Add("in_applyrule_addcond_gid", Applyrule.slnoadd);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProcNew("pr_del_applyrule_addcond", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }

        public DataTable DropDownBinding_sourceTarget(FileConvTemp_model FileConvTemp)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(FileConvTemp.ip_address, FileConvTemp.user_code);
                values.Add("in_applyrule_basesele_gid", FileConvTemp.applyrule_basesele_gid);
                //values.Add("in_param", FileConvTemp.param_1);
                result = con.RunDataSetProc("pr_get_applyrule_sourcetarget", values);
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

        public DataTable ApplyruleBaseFilterRule_New(Applyrule_model Applyrule)
        {

            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);

                values.Add("in_applyrule_basesele_gid", Applyrule.Rulegid);
                values.Add("in_applyrule_basefilter_gid", Applyrule.applyrule_basefilter_gid);
                result = con.RunDataSetProc("pr_get_applyrule_basefilter_new", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                throw ex;
            }
        }
        public DataTable getApplyrule_targetgrpgrid(Applyrule_model Applyrule)
        {

            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                values.Add("in_applyrule_targetgrpfield_gid", Applyrule.target_grpfield_gid);
                values.Add("in_applyrule_basesele_gid", Applyrule.applyrule_basesele_gid);
                values.Add("in_active_status", "Y");
                result = con.RunDataSetProc("pr_get_applyrule_targetgrpfield", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                throw ex;
            }
        }

        public DataTable Applyrulegridgroup_New(Applyrule_model Applyrule)
        {
            var ipaddrss = Applyrule.ip_address;
            var user_code = Applyrule.user_code;
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                values.Add("in_applyrule_basesele_gid", 0);
                values.Add("in_applyruledtl_gid", Applyrule.Rulegid);
                values.Add("in_applyrule_gid", Applyrule.slno);
                values.Add("in_active_status", "");
                result = con.RunDataSetProc("pr_get_applyrule_basesele_new", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Applyrule.ip_address, Applyrule.user_code);
                con.errorlog(Applyrule.user_code, Applyrule.ip_address, method_name, error, source_name);
                // throw ex;
                return result;
            }
        }
        
    }
}
