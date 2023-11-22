using Recon.Controllers;
using Recon_api_datamodel;
using Recon_api_model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon_api_service
{
    public class Report_Service
    {
        public static string[] ExectionReport(Report_model objmodel)
        {
            string[] result = { };
            FileConvTemp_model user = new FileConvTemp_model();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();

                result = objproduct.ExectionReport(objmodel);
                if (result.Length == 2)
                {
                    user.result = Convert.ToInt32(result[1]);
                    user.msg = result[0];
                }
                else
                {
                    user.result = 0;
                    user.msg = "Process Failed";
                }

                return result;
            }
            catch(Exception e)
            {
                string control = "ReportService";
                LogHelper.WriteLog(e.ToString(), control);

            }
            return result;
        }

        public static DataTable Exection_Report(Report_model objmodel)
        {
            DataTable ds = new DataTable();
            Report_datamodel objproduct = new Report_datamodel();
            ds = objproduct.Exection_Report(objmodel);
            return ds;
        }

        public static DataTable KoHead_Report(Report_model objmodel)
        {
            DataTable ds = new DataTable();
            Report_datamodel objproduct = new Report_datamodel();
            ds = objproduct.KoHead_Report(objmodel);
            return ds;
        }

        public static DataTable ReportView(Report_model objmodel)
        {
            DataTable ds = new DataTable();
            Report_datamodel objproduct = new Report_datamodel();
            ds = objproduct.ReportView(objmodel);
            return ds;
        }

        public static DataTable dropvalue(Report_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                ds = objproduct.droprt(objmodel);
            }
            catch (Exception e)
            {

            }
            return ds;
        }

        public static DataTable get_paginationreport(Report_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                ds = objproduct.get_paginationreport(objmodel);
            }
            catch (Exception e)
            {

            }
            return ds;
        }

        public static DataTable bindropvalue(Report_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                ds = objproduct.seconddrop(objmodel);
            }
            catch (Exception e)
            {

            }
            return ds;
        }
        public static DataTable AccountBlncMatching(Report_model ObjModel)
        {
            DataTable dt = new DataTable();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                dt = objproduct.AccountBlncMatching_Rpt(ObjModel);
            }
            catch(Exception e)
            {

            }
            return dt;

        }
        public static Report_model KnockOffDel(Report_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Report_model user = new Report_model();
            try
            {
                Report_datamodel objproduct1 = new Report_datamodel();
                result = objproduct1.KnockOffDel(objmodel);
                if (result.Length == 2)
                {
                    user.result = Convert.ToInt32(result[1]);
                    user.msg = result[0];
                }
                else
                {
                    user.result = 0;
                    user.msg = "Process Failed";
                }

                return user;
            }
            catch (Exception ex)
            {
                return user;
            }
        }
        public static DataTable FilereportRead(Report_model ObjModel)
        {
            DataTable dt = new DataTable();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                dt = objproduct.FilereportRead(ObjModel);
            }
            catch(Exception e)
            {

            }
            return dt;

        }
        public static Report_model FilereportDel(Report_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Report_model user = new Report_model();
            try
            {
                Report_datamodel objproduct1 = new Report_datamodel();
                result = objproduct1.FilereportDel(objmodel);
                if (result.Length == 2)
                {
                    user.result = Convert.ToInt32(result[1]);
                    user.msg = result[0];
                }
                else
                {
                    user.result = 0;
                    user.msg = "Process Failed";
                }
                return user;
            }
            catch (Exception ex)
            {
                return user;
            }
        }
        public static string[]  Report_recontallied(Report_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Report_model user = new Report_model();
            try
            {
                Report_datamodel objproduct1 = new Report_datamodel();
                result = objproduct1.Report_recontallied(objmodel);
                if (result.Length == 2)
                {
                    user.result = Convert.ToInt32(result[1]);
                    user.msg = result[0];
                }
                else
                {
                    user.result = 0;
                    user.msg = "Process Failed";
                }
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }
        public static DataTable ReportBrsRead(Report_model ObjModel)
        {
            DataTable dt = new DataTable();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                dt = objproduct.ReportBrsRead(ObjModel);
            }
            catch(Exception e)
            {

            }
            return dt;
        }
        public static DataTable ReportBrsRead_new(Report_model ObjModel)
        {
            DataTable dt = new DataTable();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                dt = objproduct.ReportBrsRead_new(ObjModel);
            }
            catch (Exception e)
            {

            }
            return dt;
        }

        public static DataTable Repotr_getrecon(Report_model ObjModel)
        {
            DataTable dt = new DataTable();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                dt = objproduct.Repotr_getrecon(ObjModel);
            }
            catch (Exception e)
            {

            }
            return dt;
        }

        public static DataTable withinBrsRead(Report_model ObjModel)
        {
            DataTable dt = new DataTable();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                dt = objproduct.withinBrsRead(ObjModel);
            }
            catch(Exception e)
            {

            }
            return dt;
        }
        public static DataTable postSupportfileRead(Report_model objmodel)
        {
            DataTable dt = new DataTable();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                dt = objproduct.postSupportfileRead(objmodel);
            }
            catch(Exception e)
            {

            }
            return dt;

        }
        public static Report_model postSupportfilecreate(Report_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Report_model user = new Report_model();
            try
            {
                Report_datamodel objproduct1 = new Report_datamodel();
                result = objproduct1.postSupportfilecreate(objmodel);
                if (result.Length == 2)
                {
                    user.result = Convert.ToInt32(result[1]);
                    user.msg = result[0];
                }
                else
                {
                    user.result = 0;
                    user.msg = "Process Failed";
                }

                return user;
            }
            catch (Exception ex)
            {
                return user;
            }
        }
        public static DataTable ProcessLogReport(Report_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                ds = objproduct.ProcessLogReport(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }
        public static DataTable ProgressViewList(Job_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                ds = objproduct.ProgressViewList(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }
        public static DataTable ReportFieldtype(Report_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                ds = objproduct.ReportFieldtype(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }
        public static DataTable ReportFilename(Report_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                ds = objproduct.ReportFilename(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }

        public static DataTable Getuserrecon(Report_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                ds = objproduct.Getuserrecon(objmodel);
            }
            catch (Exception e)
            {

            }
            return ds;
        }

        public static DataTable getfieldtype(Report_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                ds = objproduct.getfieldtype(objmodel);
            }
            catch (Exception e)
            {

            }
            return ds;
        }
        public static DataTable Getuserrecon_tallied(Report_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                ds = objproduct.Getuserrecon_tallied(objmodel);
            }
            catch (Exception e)
            {

            }
            return ds;
        }
        public static DataTable ReportFileError(Report_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                ds = objproduct.ReportFileError(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }
        public static DataTable ReportErrorLog(Report_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                ds = objproduct.ReportErrorLog(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }

        public static DataSet ReportMonthbrs_Download(Report_model objmodel)
        {
            DataSet ds = new DataSet();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                ds = objproduct.ReportMonthbrs_Download(objmodel);
            }
            catch (Exception e)
            {

            }
            return ds;
        }
     

        public static DataSet ReportMonthbrs_Download_summary(Report_model objmodel)
        {
            DataSet ds = new DataSet();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                ds = objproduct.ReportMonthbrs_Download_summary(objmodel);
            }
            catch (Exception e)
            {

            }
            return ds;
        }

        public static DataSet ReportMonthbrs_Download_daily(Report_model objmodel)
        {
            DataSet ds = new DataSet();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                ds = objproduct.ReportMonthbrs_Download_daily(objmodel);
            }
            catch (Exception e)
            {

            }
            return ds;
        }

        public static DataSet Reportbetween_download_1(Report_model objmodel)
        {
            DataSet ds = new DataSet();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                ds = objproduct.Reportbetween_download_1(objmodel);
            }
            catch (Exception e)
            {

            }
            return ds;
        }

        public static DataSet ReportMonthbrs_Daily_aging(Report_model objmodel)
        {
            DataSet ds = new DataSet();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                ds = objproduct.ReportMonthbrs_Daily_aging(objmodel);
            }
            catch (Exception e)
            {

            }
            return ds;
        }
        public static DataSet Reportpercentage_overall(Report_model objmodel)
        {
            DataSet ds = new DataSet();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                ds = objproduct.Reportpercentage_overall(objmodel);
            }
            catch (Exception e)
            {

            }
            return ds;
        }

        public static DataSet ReportKnocoffMIS(Report_model objmodel)
        {
            DataSet ds = new DataSet();
            try
            {
                Report_datamodel objproduct = new Report_datamodel();
                ds = objproduct.ReportKnocoffMIS(objmodel);
            }
            catch (Exception e)
            {

            }
            return ds;
        }
    }
}
