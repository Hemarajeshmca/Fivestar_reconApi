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
    public class Dedup_datamodel
    {
        public DataTable DedupList(Dedup_model dedupmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);
                values.Add("in_deduprule_gid", 0);
                values.Add("in_active_status", "");
                result = con.RunDataSetProc("pr_get_deduprule", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);
                con.errorlog(dedupmodel.user_code, dedupmodel.ip_address, method_name, error, source_name);
                return result;
            }
        }
        public DataTable DbAliasDrop(Dedup_model dedupmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);

                result = con.RunDataSetProc("pr_get_fieldaliasname_mapping");
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);
                con.errorlog(dedupmodel.user_code, dedupmodel.ip_address, method_name, error, source_name);
                return result;
            }
        }
        public string[] Dedupcreate(Dedup_model dedupmodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);

                values.Add("in_deduprule_gid", dedupmodel.slno);
                values.Add("in_deduprule_name", dedupmodel.Rule_name);
                values.Add("in_period_from", dedupmodel.period_from);
                values.Add("in_period_to", dedupmodel.period_To);
                values.Add("in_until_active_flag", dedupmodel.untillactive);
                values.Add("in_active_status", dedupmodel.status);
                values.Add("in_action", "INSERT");
                values.Add("in_action_by", dedupmodel.user_code);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProcNew("pr_recon_mst_tdeduprule", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);
                con.errorlog(dedupmodel.user_code, dedupmodel.ip_address, method_name, error, source_name);
                return result;
            }
        }
        public string[] DedupGridCreate(Dedup_model dedupmodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);

                values.Add("in_deduprule_gid", dedupmodel.slnolist);
                values.Add("in_source_field", dedupmodel.field_name);
                values.Add("in_extraction_criteria", dedupmodel.ExtractionCriteria);
                values.Add("in_comparison_criteria", dedupmodel.ComparisonCriteria);
                values.Add("in_active_status", dedupmodel.status);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_ins_deduprulefield", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);
                con.errorlog(dedupmodel.user_code, dedupmodel.ip_address, method_name, error, source_name);
                return result;
            }
        }
        public DataTable DedupgridList(Dedup_model dedupmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);
                values.Add("in_deduprulefield_gid", 0);
                values.Add("in_deduprule_gid", dedupmodel.slno);
                result = con.RunDataSetProc("pr_get_deduprulefield", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);
                con.errorlog(dedupmodel.user_code, dedupmodel.ip_address, method_name, error, source_name);
                return result;
            }
        }
        public string[] Fieldtype(Dedup_model dedupmodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);

                values.Add("in_field_name", dedupmodel.field_type);
                values.Add("out_field_type", "out");
                result = con.Runfieldtype("pr_get_fieldtype", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);
                con.errorlog(dedupmodel.user_code, dedupmodel.ip_address, method_name, error, source_name);
                return result;
            }
        }
        public DataTable certiaDrop(Dedup_model dedupmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);
                values.Add("in_field_type", dedupmodel.field_type);
                values.Add("in_filter_flag", dedupmodel.filter_flag);
                result = con.RunDataSetProc("pr_get_fieldfilter", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);
                con.errorlog(dedupmodel.user_code, dedupmodel.ip_address, method_name, error, source_name);
                return result;
            }
        }
        public DataTable Dedupgrid_listEdit(Dedup_model dedupmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);
                values.Add("in_deduprule_gid", dedupmodel.slno);
                values.Add("in_active_status", "");
                result = con.RunDataSetProc("pr_get_deduprule", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);
                con.errorlog(dedupmodel.user_code, dedupmodel.ip_address, method_name, error, source_name);
                return result;
            }
        }
        public string[] DedupUpdate(Dedup_model dedupmodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);

                values.Add("in_deduprule_gid", dedupmodel.slno);
                values.Add("in_deduprule_name", dedupmodel.Rule_name);
                values.Add("in_period_from", dedupmodel.period_from);
                values.Add("in_period_to", dedupmodel.period_To);
                values.Add("in_until_active_flag", dedupmodel.untillactive);
                values.Add("in_active_status", dedupmodel.status);
                values.Add("in_action", "UPDATE");
                values.Add("in_action_by", dedupmodel.user_code);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_recon_mst_tdeduprule", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);
                con.errorlog(dedupmodel.user_code, dedupmodel.ip_address, method_name, error, source_name);
                return result;
            }
        }
        public string[] DedupGridupdate(Dedup_model dedupmodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);

                values.Add("in_deduprule_gid", dedupmodel.slnolist);
                values.Add("in_deduprulefield_gid", dedupmodel.slno);
                values.Add("in_source_field", dedupmodel.field_name);
                values.Add("in_extraction_criteria", dedupmodel.ExtractionCriteria);
                values.Add("in_comparison_criteria", dedupmodel.ComparisonCriteria);
                values.Add("in_active_status", dedupmodel.status);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_upd_deduprulefield", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(dedupmodel.ip_address, dedupmodel.user_code);
                con.errorlog(dedupmodel.user_code, dedupmodel.ip_address, method_name, error, source_name);
                return result;
            }
        }
    }
}
