using Newtonsoft.Json;
using Recon.Controllers;
using Recon_api_model;
using Recon_api_service;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Recon_api.Controllers
{
     [Authorize]
    public class ReportController : ApiController
    {

         [Route("dropvalue")]
         [HttpPost]
         public DataTable dropvalue(Report_model user)
         {
             DataTable response = new DataTable();
             try
             {
                 response = Report_Service.dropvalue(user);
             }
             catch (Exception e)
             {

             }
             return response;
         }

         [Route("get_paginationreport")]
         [HttpPost]
         public DataTable get_paginationreport(Report_model user)
         {
             DataTable response = new DataTable();
             try
             {
                 response = Report_Service.get_paginationreport(user);
             }
             catch (Exception e)
             {

             }
             return response;
         }

         [Route("bindropvalue")]
         [HttpPost]
         public DataTable bindropvalue(Report_model user)
         {
             DataTable response = new DataTable();
             try
             {
                 response = Report_Service.bindropvalue(user);
             }
             catch (Exception e)
             {

             }
             return response;
         }

         [Route("Exection_Report")]
         [HttpPost]
         public DataTable Exection_Report(Report_model user)
         {
             DataTable response = new DataTable();
             response = Report_Service.Exection_Report(user);
             return response;
         }

         [Route("KoHead_Report")]
         [HttpPost]
         public DataTable KoHead_Report(Report_model user)
         {
             DataTable response = new DataTable();
             response = Report_Service.KoHead_Report(user);
             return response;
         }

         [Route("ReportView")]
         [HttpPost]
         public DataTable ReportView(Report_model user)
         {
             DataTable response = new DataTable();
             response = Report_Service.ReportView(user);
             return response;
         }


        [Route("ExectionReport")]
        [HttpPost]
         public string[] ExectionReport(Report_model user)
        {
            //DataTable response = new DataTable();
            string[] response = { };
            try
            {
                response = Report_Service.ExectionReport(user);
            }
            catch(Exception e)
            {
                string control = this.ControllerContext.RouteData.Values["controller"].ToString();
                LogHelper.WriteLog(e.ToString(), control);

            }
            return response;
        }
        [Route("AccountBlncMatching")]
        [HttpPost]
        public DataTable AccountBalanceMatching(Report_model ObjRpt_Model)
        {
            DataTable response = new DataTable();
            try
            {
                response = Report_Service.AccountBlncMatching(ObjRpt_Model);
            }catch(Exception e)
            {

            }
            return response;
        }
        [Route("KnockOffDel")]
        [HttpPost]
        public string KnockOffDel(Report_model objmodel)
        {
            string response = string.Empty;
            try
            {
                Report_model users = new Report_model();
                Report_model user = new Report_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Report_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                users = Report_Service.KnockOffDel(objmodel);
                response = users.msg;
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("FilereportRead")]
        [HttpPost]
        public DataTable FilereportRead(Report_model ObjRpt_Model)
        {
            DataTable response = new DataTable();
            try
            {
                response = Report_Service.FilereportRead(ObjRpt_Model);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("FilereportDel")]
        [HttpPost]
        public string FilereportDel(Report_model objmodel)
        {
            string response = string.Empty;
            try
            {
                Report_model users = new Report_model();
                Report_model user = new Report_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Report_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                users = Report_Service.FilereportDel(objmodel);
                response = users.msg;
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("ReportBrsRead")]
        [HttpPost]
        public DataTable ReportBrsRead(Report_model ObjRpt_Model)
        {
            DataTable response = new DataTable();
            try
            {
                response = Report_Service.ReportBrsRead(ObjRpt_Model);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("ReportBrsRead_new")]
        [HttpPost]
        public DataTable ReportBrsRead_new(Report_model ObjRpt_Model)
        {
            DataTable response = new DataTable();
            try
            {
                response = Report_Service.ReportBrsRead_new(ObjRpt_Model);
            }
            catch (Exception e)
            {

            }
            return response;
        }

        [Route("Repotr_getrecon")]
        [HttpPost]
        public DataTable Repotr_getrecon(Report_model ObjRpt_Model)
        {
            DataTable response = new DataTable();
            try
            {
                response = Report_Service.Repotr_getrecon(ObjRpt_Model);
            }
            catch (Exception e)
            {

            }
            return response;
        }


        [Route("postSupportfileRead")]
        [HttpPost]
        public DataTable postSupportfileRead(Report_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = Report_Service.postSupportfileRead(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("postSupportfilecreate")]
        [HttpPost]
        public string postSupportfilecreate(Report_model objmodel)
        {
            string response = string.Empty;
            try
            {
                Report_model users = new Report_model();
                Report_model user = new Report_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Report_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                users = Report_Service.postSupportfilecreate(objmodel);
                response = users.msg;
            }
            catch(Exception e)
            {

            }
            return response;
        }

        [Route("ProcessLogReport")]
        [HttpPost]
        public DataTable ProcessLogReport(Report_model user)
        {
            DataTable response = new DataTable();
            try
            {
                response = Report_Service.ProcessLogReport(user);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("ProgressViewList")]
        [HttpPost]
        public DataTable ProgressViewList(Job_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = Report_Service.ProgressViewList(objmodel);
            }catch(Exception e)
            {

            }
            return response;
        }
        [Route("ReportFieldtype")]
        [HttpPost]
        public DataTable ReportFieldtype(Report_model user)
        {
            DataTable response = new DataTable();
            try
            {
                response = Report_Service.ReportFieldtype(user);
            }catch(Exception e)
            {

            }
            return response;
        }
        [Route("withinBrsRead")]
        [HttpPost]
        public DataTable withinBrsRead(Report_model ObjRpt_Model)
        {
            DataTable response = new DataTable();
            try
            {
                response = Report_Service.withinBrsRead(ObjRpt_Model);
            }catch(Exception e)
            {

            }
            return response;
        }
        [Route("ReportFilename")]
        [HttpPost]
        public DataTable ReportFilename(Report_model ObjRpt_Model)
        {
            DataTable response = new DataTable();
            try
            {
                response = Report_Service.ReportFilename(ObjRpt_Model);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("ReportFileError")]
        [HttpPost]
        public DataTable ReportFileError(Report_model ObjRpt_Model)
        {
            DataTable response = new DataTable();
            try
            {
                response = Report_Service.ReportFileError(ObjRpt_Model);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("ReportErrorLog")]
        [HttpPost]
        public DataTable ReportErrorLog(Report_model ObjRpt_Model)
        {
            DataTable response = new DataTable();
            try
            {
                response = Report_Service.ReportErrorLog(ObjRpt_Model);
            }
            catch(Exception e)
            {

            }
            return response;
        }

        [Route("ReportMonthbrs_Download")]
        [HttpPost]
        public DataSet ReportMonthbrs_Download(Report_model ObjRpt_Model)
        {
            DataSet response = new DataSet();
            try
            {
                response = Report_Service.ReportMonthbrs_Download(ObjRpt_Model);
            }
            catch (Exception e)
            {

            }
            return response;
        }

        [Route("ReportMonthbrs_Download_summary")]
        [HttpPost]
        public DataSet ReportMonthbrs_Download_summary(Report_model ObjRpt_Model)
        {
            DataSet response = new DataSet();
            try
            {
                response = Report_Service.ReportMonthbrs_Download_summary(ObjRpt_Model);
            }
            catch (Exception e)
            {

            }
            return response;
        }

   


        [Route("ReportMonthbrs_Download_daily")]
        [HttpPost]
        public DataSet ReportMonthbrs_Download_daily(Report_model ObjRpt_Model)
        {
            DataSet response = new DataSet();
            try
            {
                response = Report_Service.ReportMonthbrs_Download_daily(ObjRpt_Model);
            }
            catch (Exception e)
            {

            }
            return response;
        }

        [Route("Reportbetween_download_1")]
        [HttpPost]
        public DataSet Reportbetween_download_1(Report_model ObjRpt_Model)
        {
            DataSet response = new DataSet();
            try
            {
                response = Report_Service.Reportbetween_download_1(ObjRpt_Model);
            }
            catch (Exception e)
            {

            }
            return response;
        }

        [Route("ReportMonthbrs_Daily_aging")]
        [HttpPost]
        public DataSet ReportMonthbrs_Daily_aging(Report_model ObjRpt_Model)
        {
            DataSet response = new DataSet();
            try
            {
                response = Report_Service.ReportMonthbrs_Daily_aging(ObjRpt_Model);
            }
            catch (Exception e)
            {

            }
            return response;
        }
        [Route("Reportpercentage_overall")]
        [HttpPost]
        public DataSet Reportpercentage_overall(Report_model ObjRpt_Model)
        {
            DataSet response = new DataSet();
            try
            {
                response = Report_Service.Reportpercentage_overall(ObjRpt_Model);
            }
            catch (Exception e)
            {

            }
            return response;
        }

        [Route("ReportKnocoffMIS")]
        [HttpPost]
        public DataSet ReportKnocoffMIS(Report_model ObjRpt_Model)
        {
            DataSet response = new DataSet();
            try
            {
                response = Report_Service.ReportKnocoffMIS(ObjRpt_Model);
            }
            catch (Exception e)
            {

            }
            return response;
        }


        [Route("Getuserrecon")]
        [HttpPost]
        public DataTable Getuserrecon(Report_model ObjRpt_Model)
        {
            DataTable response = new DataTable();
            try
            {
                response = Report_Service.Getuserrecon(ObjRpt_Model);
            }
            catch (Exception e)
            {

            }
            return response;
        }

        [Route("getfieldtype")]
        [HttpPost]
        public DataTable getfieldtype(Report_model ObjRpt_Model)
        {
            DataTable response = new DataTable();
            try
            {
                response = Report_Service.getfieldtype(ObjRpt_Model);
            }
            catch (Exception e)
            {

            }
            return response;
        }

        [Route("Getuserrecon_tallied")]
        [HttpPost]
        public DataTable Getuserrecon_tallied(Report_model ObjRpt_Model)
        {
            DataTable response = new DataTable();
            try
            {
                response = Report_Service.Getuserrecon_tallied(ObjRpt_Model);
            }
            catch (Exception e)
            {

            }
            return response;
        }

        [Route("Report_recontallied")]
        [HttpPost]
        public string[] Report_recontallied(Report_model objmodel)
        {
            string[] response = { };
            try
            {
                Report_model users = new Report_model();
                Report_model user = new Report_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Report_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Report_Service.Report_recontallied(objmodel);
                return response;
            }
            catch (Exception e)
            {

            }
            return response;
        }
    }
}
