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
    public class ReconsetupController : ApiController
    {

        [Route("RecontypeList")]
        [HttpPost]
        public DataTable RecontypeList(Reconsetup_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = Reconsetup_service.RecontypeList(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("AccName")]
        [HttpPost]
        public DataTable AccName(Reconsetup_model objmodel)
        {
            DataTable response = new DataTable();
            try 
            {
                response = Reconsetup_service.AccName(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("RecontypeCreate")]
        [HttpPost]
        public string[] RecontypeCreate(Reconsetup_model objmodel)
        {
            string[] response = { };
            try
            {
                Reconsetup_model users = new Reconsetup_model();
                Reconsetup_model user = new Reconsetup_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Reconsetup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Reconsetup_service.RecontypeCreate(objmodel);    
            }      
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("RecontypeUpdate")]
        [HttpPost]
        public string[] RecontypeUpdate(Reconsetup_model objmodel)
        {
            string[] response = { };
            try
            {
                Reconsetup_model users = new Reconsetup_model();
                Reconsetup_model user = new Reconsetup_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Reconsetup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Reconsetup_service.RecontypeUpdate(objmodel);   
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("RecontypeDelete")]
        [HttpPost]
        public string[] RecontypeDelete(Reconsetup_model objmodel)
        {
            string[] response = { };
            try
            {
                Reconsetup_model users = new Reconsetup_model();
                Reconsetup_model user = new Reconsetup_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Reconsetup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Reconsetup_service.RecontypeDelete(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
    }
}
