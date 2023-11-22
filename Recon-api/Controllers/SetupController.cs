using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Recon_api_model;
using System.IO;
using Newtonsoft.Json;
using Recon_api_service;
using System.Data;

namespace Recon_api.Controllers
{
     [Authorize]
    public class SetupController : ApiController
    {
        Setup_model users = new Setup_model();
        Setup_model user = new Setup_model();

        [Route("Category")]
        [HttpPost]
        public string[] categorycreate(Setup_model objmodel)
        {
            string[] response = { };
            try
            {
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Setup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Setup_service.categorycreate(objmodel); 
            }
            catch(Exception e)
            {

            }
            return response;
        }

        [Route("CategoryList")]
        [HttpPost]
        public DataTable categoryList(Setup_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = Setup_service.categoryList(objmodel); 
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("CategoryDROP")]
        [HttpPost]
        public DataTable CategoryDROP(Setup_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = Setup_service.categoryDROP(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("CategoryUpdate")]
        [HttpPost]
        public string[] categoryUpdate(Setup_model objmodel)
        {
            string[] response = { };
            try
            {
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Setup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Setup_service.categoryUpdate(objmodel);  
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("CategoryDelete")]
        [HttpPost]
        public string[] CategoryDelete(Setup_model objmodel)
        {
            string[] response = { };
            try
            {
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Setup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Setup_service.CategoryDelete(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }

        [Route("Responsibility")]
        [HttpPost]
        public string[] Responsibilitycreate(Setup_model objmodel)
        {
            string[] response = { };
            try
            {
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Setup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Setup_service.Responsibilitycreate(objmodel);
            }            
            catch(Exception e)
            {

            }
            return response;
        }

        [Route("ResponsibilityList")]
        [HttpPost]
        public DataTable ResponsibilityList(Setup_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = Setup_service.ResponsibilityList(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("ResponsibilityUpdate")]
        [HttpPost]
        public string[] ResponsibilityUpdate(Setup_model objmodel)
        {
            string[] response = { };
            try
            {
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Setup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Setup_service.ResponsibilityUpdate(objmodel); 
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("ResponsibilityDelete")]
        [HttpPost]
        public string[] ResponsibilityDelete(Setup_model objmodel)
        {
            string[] response = { };
            try
            {
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Setup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Setup_service.ResponsibilityDelete(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("SupportfiletypeCreate")]
        [HttpPost]
        public string[] SupportfiletypeCreate(Setup_model objmodel)
        {
            string[] response = { };
            try
            {
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Setup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Setup_service.SupportfiletypeCreate(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }

        [Route("SupportfiletypeList")]
        [HttpPost]
        public DataTable SupportfiletypeList(Setup_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = Setup_service.SupportfiletypeList(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
      
        [Route("SupportfiletypeUpdate")]
        [HttpPost]
        public string[] SupportfiletypeUpdate(Setup_model objmodel)
        {
            string[] response = { };
            try
            {
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Setup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Setup_service.SupportfiletypeUpdate(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("SupportfiletypeDelete")]
        [HttpPost]
        public string[] Supportfiletype_Delete(Setup_model objmodel)
        {
            string[] response = { };
            try
            {
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Setup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Setup_service.Supportfiletype_Delete(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }

        [Route("Remark")]
        [HttpPost]
        public string[] Remarkcreate(Setup_model objmodel)
        {
            string[] response = { };
            try
            {
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Setup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Setup_service.Remarkcreate(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }

        [Route("RemarkList")]
        [HttpPost]
        public DataTable RemarkList(Setup_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = Setup_service.RemarkList(objmodel);
            }
            catch (Exception e)
            { 
            }
            return response;
        }
        [Route("RemarkUpdate")]
        [HttpPost]
        public string[] RemarkUpdate(Setup_model objmodel)
        {
            string[] response = { };
            try
            {
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Setup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Setup_service.RemarkUpdate(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("RemarkDelete")]
        [HttpPost]
        public string[] RemarkDelete(Setup_model objmodel)
        {
            string[] response = { };
            try
            {
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Setup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Setup_service.RemarkDelete(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("RemarkReason")]
        [HttpPost]
        public string[] RemarkReason(Setup_model objmodel)
        {
            string[] response = { };
            try
            {
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Setup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Setup_service.RemarkReason(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }

        [Route("RemarkReason_new")]
        [HttpPost]
        public string[] RemarkReason_new(Setup_model objmodel)
        {
            string[] response = { };
            try
            {
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Setup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Setup_service.RemarkReason_new(objmodel);
            }
            catch (Exception e)
            {

            }
            return response;
        }
    }
}
