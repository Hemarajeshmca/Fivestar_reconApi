using Recon.Controllers;
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
    public class Report_datamodel
    {
        public DataTable droprt(Report_model objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_report_gid", 0);
                values.Add("in_action", "Select");
                
                result = con.RunDataSetProc("pr_recon_mst_treport", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }

        public DataTable get_paginationreport(Report_model objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                //values.Add("in_report_gid", 0);
                //values.Add("in_action", "Select");

                result = con.RunDataSetProc("pr_get_paginationreport", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }

        public DataTable seconddrop(Report_model objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_reportparam_gid", 0);
              values.Add("in_report_gid", objmodel.valuedrop);
              //values.Add("in_report_gid",0);
                values.Add("in_action", "Select");

                result = con.RunDataSetProc("pr_recon_mst_treportparam", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }
        //public DataTable Exection_Report(Report_model objmodel)
        //{
        //    DataTable result = new DataTable();
        //    try
        //    {
        //        Dictionary<string, Object> values = new Dictionary<string, object>();
        //        MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
        //        values.Add("in_table_name", objmodel.table_name);
        //        values.Add("in_condition", objmodel.Report_condition);
        //        values.Add("in_outfile_flag", objmodel.in_outfile_flag);
        //        values.Add("in_report_gid", objmodel.report_gid);
        //        values.Add("in_user_code", objmodel.user_code);
        //        values.Add("in_ip_address", objmodel.ip_address);
        //        values.Add("out_msg", "out");
        //        values.Add("out_result", "out");
        //        result = con.RunDataSetProc("pr_get_tablequery", values);
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
        //        string source_name = this.GetType().ToString();
        //        string error = ex.ToString();
        //        MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
        //        con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
        //        throw ex;
        //    }
        //}
        public DataTable Exection_Report(Report_model objmodel)
        {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
               values.Add("in_report_code", "RPT_UNDOKO");
               values.Add("in_recon_gid", objmodel.recon_gid);
               values.Add("in_condition", objmodel.Report_condition);
               values.Add("in_resultset_flag", objmodel.in_outfile_flag);
               values.Add("in_ip_addr", objmodel.ip_address);
               values.Add("in_user_code", objmodel.user_code);
               values.Add("out_rec_count", "out");
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDataSetProc("pr_run_pagereport", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
               con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
               throw ex;
           }
       
        }
        public DataTable KoHead_Report(Report_model objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_report_code", "RPT_KOHEAD");
                values.Add("in_recon_gid", objmodel.recon_gid);
                values.Add("in_condition", objmodel.Report_condition);
                values.Add("in_resultset_flag", objmodel.resultset_flag);
              
                values.Add("in_ip_addr", objmodel.ip_address);
                values.Add("in_user_code", objmodel.user_code);
                values.Add("out_rec_count", "out");
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDataSetProc("pr_run_pagereport", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                throw ex;
            }

        }
        public DataTable ReportView(Report_model objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_report_code", objmodel.report_code);
                values.Add("in_recon_gid", objmodel.recon_gid);
                values.Add("in_condition", objmodel.Report_condition);
                values.Add("in_resultset_flag", objmodel.resultset_flag);
                values.Add("in_ip_addr", objmodel.ip_address);
                values.Add("in_user_code", objmodel.user_code);
                values.Add("out_rec_count", "out");
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDataSetProc("pr_run_pagereport", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                throw ex;
            }

        }
        public string[] ExectionReport(Report_model objmodel)
        {
            // DataTable result = new DataTable();
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address,objmodel.user_code);
                values.Add("in_report_code", objmodel.report_gid);
                values.Add("in_recon_gid", objmodel.recon_gid);
                values.Add("in_condition", objmodel.Report_condition);
                values.Add("in_ip_addr", objmodel.ip_address);
                values.Add("in_outputfile_flag", objmodel.in_outfile_flag);
                values.Add("in_user_code", objmodel.user_code);
               // values.Add("out_job_gid", "out");
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc_FileConvert("pr_run_report", values);
                  string control = "Reportdatamodel";
                LogHelper.WriteLog("reportdatamodelresult", control);
                return result;
            }
            catch (Exception ex)
            {
                string control = "Reportdatamodel";
                LogHelper.WriteLog(ex.ToString(), control);
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }
        public DataTable AccountBlncMatching_Rpt(Report_model ObjModel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(ObjModel.ip_address, ObjModel.user_code);
                values.Add("in_recon_gid", ObjModel.recon_gid);
                values.Add("in_acc_no", ObjModel.account1_desc);
                values.Add("in_tran_date", ObjModel.tran_date);
                values.Add("in_match_flag", ObjModel.status_flag);
                result = con.RunDataSetProc("pr_get_accbalmatch", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(ObjModel.ip_address, ObjModel.user_code);
                con.errorlog(ObjModel.ip_address, ObjModel.user_code, method_name, error, source_name);
                return result;
            }
        }
        public string[] KnockOffDel(Report_model ObjModel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(ObjModel.ip_address, ObjModel.user_code);

                values.Add("in_ko_gid", ObjModel.koid);
                values.Add("in_undo_ko_reason", ObjModel.review);
                values.Add("in_user_code", ObjModel.user_code);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_set_undoko", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(ObjModel.ip_address, ObjModel.user_code);
                con.errorlog(ObjModel.ip_address, ObjModel.user_code, method_name, error, source_name);
                return result;
            }
        }
        public DataTable FilereportRead(Report_model ObjModel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(ObjModel.ip_address, ObjModel.user_code);
                values.Add("in_period_from", ObjModel.period_from);
                values.Add("in_period_to", ObjModel.period_to);
                values.Add("in_file_type", ObjModel.file_type);
                values.Add("in_import_by", ObjModel.user_code);
                result = con.RunDataSetProc("pr_get_file", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(ObjModel.ip_address, ObjModel.user_code);
                con.errorlog(ObjModel.ip_address, ObjModel.user_code, method_name, error, source_name);
                return result;
            }
        }
        public string[] FilereportDel(Report_model ObjModel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(ObjModel.ip_address, ObjModel.user_code);

                values.Add("in_file_gid", ObjModel.file_gid);
                values.Add("in_remark", ObjModel.review);
                values.Add("in_user_code", ObjModel.user_code);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_del_file", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(ObjModel.ip_address, ObjModel.user_code);
                con.errorlog(ObjModel.ip_address, ObjModel.user_code, method_name, error, source_name);
                return result;
            }
        }
        public string[] Report_recontallied(Report_model ObjModel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(ObjModel.ip_address, ObjModel.user_code);

                values.Add("in_recon_gid", ObjModel.Recongid);
                values.Add("in_recon_tallied", ObjModel.recontallied);
                values.Add("in_ip_address", ObjModel.ip_address);
                values.Add("in_delete_flag", 'N');
                values.Add("in_action_by", ObjModel.user_code);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_upd_recontallied", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(ObjModel.ip_address, ObjModel.user_code);
                con.errorlog(ObjModel.ip_address, ObjModel.user_code, method_name, error, source_name);
                return result;
            }
        }
        public DataTable ReportBrsRead(Report_model ObjModel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(ObjModel.ip_address, ObjModel.user_code);
                values.Add("in_recon_gid", ObjModel.recon_gid);
                values.Add("in_tran_date", ObjModel.tran_date);
                result = con.RunDataSetProc("pr_get_brs", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(ObjModel.ip_address, ObjModel.user_code);
                con.errorlog(ObjModel.ip_address, ObjModel.user_code, method_name, error, source_name);
                return result;
            }
        }
        public DataTable ReportBrsRead_new(Report_model ObjModel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(ObjModel.ip_address, ObjModel.user_code);
                values.Add("in_recon_gid", ObjModel.recon_gid);
                values.Add("in_active_status", "");
                result = con.RunDataSetProc("pr_get_recon", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(ObjModel.ip_address, ObjModel.user_code);
                con.errorlog(ObjModel.ip_address, ObjModel.user_code, method_name, error, source_name);
                return result;
            }
        }

        public DataTable Repotr_getrecon(Report_model ObjModel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(ObjModel.ip_address, ObjModel.user_code);
                values.Add("in_recon_gid", ObjModel.recon_gid);
                values.Add("in_active_status", "Y");
                result = con.RunDataSetProc("pr_get_recon_new", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(ObjModel.ip_address, ObjModel.user_code);
                con.errorlog(ObjModel.ip_address, ObjModel.user_code, method_name, error, source_name);
                return result;
            }
        }

        public DataTable withinBrsRead(Report_model ObjModel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(ObjModel.ip_address, ObjModel.user_code);
                values.Add("in_recon_gid", ObjModel.recon_gid);
                values.Add("in_tran_date", ObjModel.tran_date);
                result = con.RunDataSetProc("pr_get_proof", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(ObjModel.ip_address, ObjModel.user_code);
                con.errorlog(ObjModel.ip_address, ObjModel.user_code, method_name, error, source_name);
                return result;
            }
        }
        public DataTable postSupportfileRead(Report_model objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address,objmodel.user_code);
                values.Add("in_recon_gid", 0);
                values.Add("in_active_status", "Y");
                result = con.RunDataSetProc("pr_get_recon", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }
        public string[] postSupportfilecreate(Report_model ObjModel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(ObjModel.ip_address, ObjModel.user_code);

                values.Add("in_recon_gid", ObjModel.rec_id);
                values.Add("in_period_from", ObjModel.period_from);
                values.Add("in_period_to", ObjModel.period_to);
                values.Add("in_user_code", ObjModel.user_code);
                values.Add("in_ip_addr", ObjModel.ip_address);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                //result = con.RunDmlProc("pr_post_tranbrkp", values);
                result = con.RunDmlProc("pr_post_bulk_tranbrkp", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(ObjModel.ip_address, ObjModel.user_code);
                con.errorlog(ObjModel.ip_address, ObjModel.user_code, method_name, error, source_name);
                return result;
            }
        }
        public DataTable ProcessLogReport(Report_model objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address,objmodel.user_code);
                values.Add("in_period_from", objmodel.period_from);
                values.Add("in_period_to", objmodel.period_to);
                values.Add("in_process_status",objmodel.process_status);
                values.Add("in_user_code", objmodel.InitiatedBy);
                result = con.RunDataSetProc("pr_get_process", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }
        public DataTable ProgressViewList(Job_model objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.Job_ip_addr,objmodel.Job_initiated_by);
                values.Add("in_job_status", objmodel.Job_status);
                values.Add("in_job_type", objmodel.Job_type);
                values.Add("in_From_date", objmodel.Job_start_date);
                values.Add("in_To_date", objmodel.Job_end_date);
                values.Add("in_user_code", objmodel.Job_initiated_by);
                result = con.RunDataSetProc("pr_get_jobprocess", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.Job_ip_addr, objmodel.Job_initiated_by);
                con.errorlog(objmodel.Job_ip_addr, objmodel.Job_initiated_by, method_name, error, source_name);
                return result;
            }
        }
        public DataTable ReportFieldtype(Report_model objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address,objmodel.user_code);
                values.Add("in_field_name", objmodel.file_type);
                result = con.RunDataSetProc("pr_get_fieldprop", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }
        public DataTable ReportFilename(Report_model objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_period_from", objmodel.period_from);
                result = con.RunDataSetProc("pr_get_filename", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }

        public DataTable Getuserrecon(Report_model objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_user_code", objmodel.user_code);
                values.Add("in_recon_type", objmodel.recontype);
                values.Add("in_active_status", objmodel.active_status);
                result = con.RunDataSetProc("pr_get_userrecon", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }


        public DataTable getfieldtype(Report_model objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_update_flag", objmodel.update_flag);
                values.Add("in_filetype_gid", 0);
                result = con.RunDataSetProc("pr_get_filetype_new", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }

        public DataTable Getuserrecon_tallied(Report_model objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_user_code", objmodel.user_code);
                values.Add("in_recon_type", objmodel.recontype);
                values.Add("in_active_status", objmodel.active_status);
                result = con.RunDataSetProc("pr_get_userrecontallied", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }
        public DataTable ReportFileError(Report_model objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_file_gid", objmodel.file_gid);
                result = con.RunDataSetProc("pr_get_fileerror", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }
        public DataTable ReportErrorLog(Report_model objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_period_from", objmodel.period_from);
                values.Add("in_period_to", objmodel.period_to);
                result = con.RunDataSetProc("pr_get_errorlog", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }

        public DataSet ReportMonthbrs_Download(Report_model objmodel)
        {
            DataSet result = new DataSet();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_recon_gid", objmodel.Recongid);
                values.Add("in_tran_date", objmodel.Trandate);
                result = con.RunDataSetProcDash("pr_get_brsmonthend", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }

        public DataSet ReportMonthbrs_Download_summary(Report_model objmodel)
        {
            DataSet result = new DataSet();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_recon_gid", objmodel.Recon_gid);
                values.Add("in_no_recons", objmodel.no_of_recons);
                values.Add("in_tran_date", objmodel.Trandate);
                result = con.RunDataSetProcDash("pr_get_brsmonthend_summary", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }

        public DataSet ReportMonthbrs_Download_daily(Report_model objmodel)
        {
            DataSet result = new DataSet();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_recon_gid", objmodel.recondaily_gid);
                values.Add("in_no_recons", objmodel.no_of_recons);
                values.Add("in_tran_date", objmodel.Trandate);
                result = con.RunDataSetProcDash("pr_get_brsmonthend_daily", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }

        public DataSet Reportbetween_download_1(Report_model objmodel)
        {
            DataSet result = new DataSet();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_recon_gid", objmodel.recon_gid);
                values.Add("in_tran_date", objmodel.tran_date);
                result = con.RunDataSetProcDash("pr_get_reportdownload", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }

        public DataSet ReportMonthbrs_Daily_aging(Report_model objmodel)
        {
            DataSet result = new DataSet();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_recon_gid", objmodel.recondaily_gid);
                values.Add("in_tran_date", objmodel.Trandate);
                result = con.RunDataSetProcDash("pr_get_brsdaily_new", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }

        public DataSet Reportpercentage_overall(Report_model objmodel)
        {
            DataSet result = new DataSet();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_recon_gid", objmodel.Recon_gid);
                values.Add("in_no_recons", objmodel.no_of_recons);
                values.Add("in_tran_date", objmodel.Trandate);
                result = con.RunDataSetProcDash("pr_get_knockmis_count_new", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }

        //public DataSet ReportKnocoffMIS(Report_model objmodel)
        //{
        //    DataSet result = new DataSet();
        //    try
        //    {
        //        Dictionary<string, Object> values = new Dictionary<string, object>();
        //        MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
        //        values.Add("in_recon_gid", objmodel.Recon_gid);
        //        values.Add("in_period_from",objmodel.period_from);
        //        values.Add("in_period_to", objmodel.period_to);
        //        values.Add("in_ip_addr", objmodel.ip_address);
        //        values.Add("in_user_code", objmodel.user_code);
        //        values.Add("out_msg", "out");
        //        values.Add("out_result","out");
        //        result = con.RunDataSetProcDash("pr_get_kosumm", values);
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
        //        string source_name = this.GetType().ToString();
        //        string error = ex.ToString();
        //        MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
        //        con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
        //        return result;
        //    }
        //}
        public DataSet ReportKnocoffMIS(Report_model objmodel)
        {
            DataSet result = new DataSet();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_recon_gid", objmodel.Recon_gid);
                values.Add("in_period_from", objmodel.period_from);
                values.Add("in_period_to", objmodel.period_to);
                values.Add("in_ip_addr", objmodel.ip_address);
                values.Add("in_user_code", objmodel.user_code);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDataSetProcDash("pr_get_kosummaccwise", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }
    }
}
