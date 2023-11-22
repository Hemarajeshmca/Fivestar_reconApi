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
    public class FileConvTempController : ApiController
    {
        [Route("TemplateFileType")]
        [HttpPost]
        public DataTable GetTemplateFileType(FileConvTemp_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = FileConvTemp_service.TemplateFileType(objmodel);
            }
            catch (Exception e)
            { 
            }
            return response;
        }
        [Route("TemplateType")]
        [HttpPost]
        public DataTable GetTemplateType(FileConvTemp_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = FileConvTemp_service.TemplateType(objmodel);
            }
            catch (Exception e)
            { 
            }
            return response;
        }

        [Route("Trandatedrop")]
        [HttpPost]
        public DataTable Trandatedrop(FileConvTemp_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = FileConvTemp_service.Trandatedrop(objmodel);
            }
            catch (Exception e)
            {
            }
            return response;
        }

        [Route("DropDownBinding")]
        [HttpPost]
        public DataTable DropDownBinding(FileConvTemp_model objmodel) 
        {
            DataTable response = new DataTable();
            try
            {
                response = FileConvTemp_service.DropdownBinding(objmodel);
            }
            catch (Exception e)
            {
            }
            return response;
        }
        [Route ("FileConvTempCreate")]
        [HttpPost]
        public string[] FileConvCreate(FileConvTemp_model objmodel)
        {
            string[] response = { };
            try
            {
                FileConvTemp_model users = new FileConvTemp_model();
                FileConvTemp_model user = new FileConvTemp_model();
                //string response = string.Empty;
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (FileConvTemp_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                FileConvTemp_service objservice = new FileConvTemp_service();
                response = objservice.FileConvTempCreate(objmodel);
            }
            catch(Exception e)
            {

            }
            //response = users.msg;
            return response;
        }
        [Route("FileConvTempDelete")]
        [HttpPost]
        public string[] FileConvTempDelete(FileConvTemp_model objmodel)
        {
            string[] response = { };
            try
            {
                FileConvTemp_model users = new FileConvTemp_model();
                FileConvTemp_model user = new FileConvTemp_model();
                //string response = string.Empty;
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (FileConvTemp_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                FileConvTemp_service objservice = new FileConvTemp_service();
                response = objservice.FileConvTempDelete(objmodel);
                //response = users.msg;
            }
            catch (Exception e)
            { 
            }
            return response;
        }
        [Route("GetFieldStruct")]
        [HttpPost]
        public DataTable GetFieldStruct(FileConvTemp_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = FileConvTemp_service.GetFieldStru(objmodel);
            }
            catch (Exception e)
            { 
            
            }
            return response;
        }
        [Route("FileConvTempFiledCreate")]
        [HttpPost]
        public string[] FileConvFiledCreate(FileConvTemp_model objmodel)
        {
            string[] response = { };
            try
            {
                FileConvTemp_model users = new FileConvTemp_model();
                FileConvTemp_model user = new FileConvTemp_model();
                //string response = string.Empty;
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (FileConvTemp_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                FileConvTemp_service objservice = new FileConvTemp_service();
                response = objservice.FileTemplateField(objmodel);
                //response = users.msg;
            }
            catch (Exception e)
            { 
            }
            return response;
        }
        [Route("GetFieldGridDt")]
        [HttpPost]
        public DataTable GetFieldGridDt(FileConvTemp_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = FileConvTemp_service.GetFieldGridDt(objmodel);
            }
            catch (Exception e)
            { 
            }
            return response;
        }

        [Route("GetTemplateFieldList")]
        [HttpPost]
        public DataTable GetTemplateFieldList(FileConvTemp_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = FileConvTemp_service.GetTemplateListDt(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("FileConvTempFiledUpdate")]
        [HttpPost]
        public string[] FileConvFiledUpdate(FileConvTemp_model objmodel)
        {
            string[] response = { };
            try
            {
                FileConvTemp_model users = new FileConvTemp_model();
                FileConvTemp_model user = new FileConvTemp_model();
                //string response = string.Empty;
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (FileConvTemp_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                FileConvTemp_service objservice = new FileConvTemp_service();
                response = objservice.FileTemplateField_update(objmodel);
                //response = users.msg;
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("FileConvTempFiledDelete")]
        [HttpPost]
        public string[] FileConvTempFiledDelete(FileConvTemp_model objmodel)
        {
            string[] response = { };
            try
            {
                FileConvTemp_model users = new FileConvTemp_model();
                FileConvTemp_model user = new FileConvTemp_model();
                //string response = string.Empty;
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (FileConvTemp_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                FileConvTemp_service objservice = new FileConvTemp_service();
                response = objservice.FileConvTempFiledDelete(objmodel);
                //response = users.msg;
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("LookupMasterdrop")]
        [HttpPost]
        public DataTable LookupMasterdrop(Formula_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = FileConvTemp_service.LookupMasterdrop(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("LookupMasterSave")]
        [HttpPost]
        public string[] LookupMasterSave(Formula_model objmodel)
        {
            string[] response = { };
            try 
            {
                Formula_model users = new Formula_model();
                Formula_model user = new Formula_model();
                //string response = string.Empty;
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Formula_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                FileConvTemp_service objservice = new FileConvTemp_service();
                response = objservice.LookupMasterSave(objmodel);
                //response = users.msg;
            }
            catch(Exception e)
            {

            }
            return response;
        }

        [Route("LookupMasterRead")]
        [HttpPost]
        public DataTable LookupMasterRead(Formula_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = FileConvTemp_service.LookupMasterRead(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }

        [Route("FileTemplateFieldFormulaRead")]
        [HttpPost]
        public DataTable FileTemplateFieldFormulaRead(Formula_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = FileConvTemp_service.FileTemplateFieldFormulaRead(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }

        [Route("LookupMasterUpdate")]
        [HttpPost]
        public string[] LookupMasterUpdate(Formula_model objmodel)
        {
            string[] response = { };
            try
            {
                Formula_model users = new Formula_model();
                Formula_model user = new Formula_model();
                //string response = string.Empty;
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Formula_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                FileConvTemp_service objservice = new FileConvTemp_service();
                response = objservice.LookupMasterUpdate(objmodel);
                //response = users.msg;
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("LookupMasterDelete")]
        [HttpPost]
        public string[] LookupMasterDelete(Formula_model objmodel)
        {
            string[] response = { };         
            try
            {
                Formula_model users = new Formula_model();
                Formula_model user = new Formula_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Formula_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                FileConvTemp_service objservice = new FileConvTemp_service();
                response = objservice.LookupMasterDelete(objmodel);
                //response = users.msg;
            }
            catch(Exception e)
            {

            }
            return response;
        }
    }
}