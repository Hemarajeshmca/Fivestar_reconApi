using Newtonsoft.Json;
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
    public class FileImportController : ApiController
    {
        [Route("FileTemplateList")]
        [HttpPost]
        public DataTable ResponsibilityList(FileImport_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = FileImport_service.FileTemplateList(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("ReconNameList")]
        [HttpPost]
        public DataTable ReconNameLists(FileImport_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = FileImport_service.GetReconType(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("SupportingFileList")]
        [HttpPost]
        public DataTable GetSupportingFile(FileImport_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = FileImport_service.GetSupportingFile(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("ReconAccNoList")]
        [HttpPost]
        public DataTable GetReconAccNoList(FileImport_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = FileImport_service.GetReconAccNoList(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("FileHeaderList")]
        [HttpPost]
        public string[] FileHeaderVaild(FileImport_model objmodel)
        {
            string[] response = { };
            try
            {
                FileImport_model users = new FileImport_model();
                FileImport_model user = new FileImport_model();
                //string response = string.Empty;
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (FileImport_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                FileImport_service objservice = new FileImport_service();
                response = objservice.GetExcelField(objmodel);
                //response = users.msg;
            }
            catch(Exception e)
            {

            }
            return response;
        }

        [Route("GetDBFieldList")]
        [HttpPost]
        public DataTable GetdbFieldList(FileImport_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = FileImport_service.GetTemplatedbField(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }

        [Route("InsertFileDetails")]
        [HttpPost]
        public string[] InsertFiledt(FileImport_model objmodel)
        {
            string[] response = { };
            try
            {
                FileImport_model users = new FileImport_model();
                FileImport_model user = new FileImport_model();
                //string response = string.Empty;
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (FileImport_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                FileImport_service objservice = new FileImport_service();
                response = objservice.InsFiles_details(objmodel);
            }
            catch(Exception e)
            {

            }
            //response = users.msg;
            return response;
        }


        [Route("InsertFileTransfer")]
        [HttpPost]

        public string[] Inserttransfer(FileImport_model objmodel)
        {
            string[] response = { };
            try
            {
                FileImport_model users = new FileImport_model();
                FileImport_model user = new FileImport_model();
                //string response = string.Empty;
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (FileImport_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                FileImport_service objservice = new FileImport_service();
                response = objservice.infiletransfer(objmodel);
            }
            catch (Exception e)
            {

            }
            //response = users.msg;
            return response;
        }

        [Route("InsertFileTransfer_update")]
        [HttpPost]

        public string[] InsertFileTransfer_update(FileImport_model objmodel)
        {
            string[] response = { };
            try
            {
                FileImport_model users = new FileImport_model();
                FileImport_model user = new FileImport_model();
                //string response = string.Empty;
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (FileImport_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                FileImport_service objservice = new FileImport_service();
                response = objservice.InsertFileTransfer_update(objmodel);
            }
            catch (Exception e)
            {

            }
            //response = users.msg;
            return response;
        }


        [Route("InsertJob")]
        [HttpPost]
        public string[] InsertJobdt(Job_model objmodel) {
            string[] response = { };
            try
            {
                Job_model user = new Job_model();
                //string response = string.Empty;
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Job_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                FileImport_service objservice = new FileImport_service();
                response = objservice.InsJob_details(objmodel);
            }
            catch (Exception e)
            {

            }
            return response;
        }

        [Route("InsertTranFile")]
        [HttpPost]
        public string InsetTranFiles(FileImport_model objmodel)
        {
            string response = string.Empty;
            try
            {
                FileImport_model users = new FileImport_model();
                FileImport_model user = new FileImport_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (FileImport_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                users = FileImport_service.InsTranFile_details(objmodel);
                response = users.msg;
            }
            catch(Exception e)
            {

            }
            return response;
        }

        [Route ("GetMaxEndPosition")]
        [HttpPost]
        public string GetMaxEndPosition(FileImport_model objmodel)
        {
            string response = string.Empty;
            try
            {
                FileImport_model users = new FileImport_model();
                FileImport_model user = new FileImport_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (FileImport_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                users = FileImport_service.GetMaxEndPosition(objmodel);
                response = Convert.ToString(users.result.ToString());
            }
            catch(Exception e)
            {

            }
            return response;
        }

        [Route("InsertBalFile")]
        [HttpPost]
        public string InsertBalFiles(FileImport_model objmodel)
        {
            string response = string.Empty;
            try
            {
                FileImport_model users = new FileImport_model();
                FileImport_model user = new FileImport_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (FileImport_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                users = FileImport_service.InsBalanceFile_details(objmodel);
                response = users.msg;
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("InsertSupportFile")]
        [HttpPost]
        public string InsertSuportFiles(FileImport_model objmodel)
        {
            string response = string.Empty;
            try
            {
                FileImport_model users = new FileImport_model();
                FileImport_model user = new FileImport_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (FileImport_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                users = FileImport_service.InsSupportFile_details(objmodel);
                response = users.msg;
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("Importerrorline")]
        [HttpPost]
        public string[] Importerrorline(FileImport_model objmodel)
        {
            string[] response = { };
            try
            {
                FileImport_model users = new FileImport_model();
                FileImport_model user = new FileImport_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (FileImport_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = FileImport_service.Importerrorline(objmodel); 
            }
            catch(Exception e)
            {

            }
            return response;
        }

        [Route("Movetemptotran")]
        [HttpPost]
        public string[] Movetemptotran(FileImport_model objmodel)
        {
            string[] response = { };
            try
            {
                FileImport_model users = new FileImport_model();
                FileImport_model user = new FileImport_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (FileImport_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = FileImport_service.Movetemptotran(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }

        [Route("Movetemptotranbrkp")]
        [HttpPost]
        public string[] Movetemptotranbrkp(FileImport_model objmodel)
        {
            string[] response = { };
            try 
            {
                FileImport_model users = new FileImport_model();
                FileImport_model user = new FileImport_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (FileImport_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = FileImport_service.Movetemptotranbrkp(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
    
    }

}