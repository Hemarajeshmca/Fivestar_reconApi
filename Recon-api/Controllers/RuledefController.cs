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
    public class RuledefController : ApiController
    {
        [Route("RuleList")]
        [HttpPost]
        public DataTable RuleList(Dedup_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = Rule_service.RuleList(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("RuleCreate")]
        [HttpPost]
        public string[] RuleCreate(Dedup_model objmodel)
        {
            string[] response = { };
            try
            {
                Dedup_model users = new Dedup_model();
                Dedup_model user = new Dedup_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Dedup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Rule_service.RuleCreate(objmodel); 
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("RuleDelete")]
        [HttpPost]
        public string[] RuleDelete(Dedup_model objmodel)
        {
            string[] response = { };
            try
            {
                Dedup_model users = new Dedup_model();
                Dedup_model user = new Dedup_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Dedup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Rule_service.RuleDelete(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("RuleUpdate")]
        [HttpPost]
        public string[] RuleUpdate(Dedup_model objmodel)
        {
            string[] response = { };
            try
            {
                Dedup_model users = new Dedup_model();
                Dedup_model user = new Dedup_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Dedup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Rule_service.RuleUpdate(objmodel);  
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("RulegridCreate")]
        [HttpPost]
        public string[] RulegridCreate(Dedup_model objmodel)
        {
            string[] response = { };
            try
            {
                Dedup_model users = new Dedup_model();
                Dedup_model user = new Dedup_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Dedup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Rule_service.RulegridCreate(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("RuleGrid_listEdit")]
        [HttpPost]
        public DataTable RuleGrid_listEdit(Dedup_model user)
        {
            DataTable response = new DataTable();
            try
            {
                response = Rule_service.RuleGrid_listEdit(user);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("RuleGridList")]
        [HttpPost]
        public DataTable RuleGridList(Dedup_model user1)
        {
            DataTable response = new DataTable();
            try
            {
                response = Rule_service.RuleGridList(user1);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("RulegridUpdate")]
        [HttpPost]
        public string[] RulegridUpdate(Dedup_model objmodel)
        {
            string[] response = { };
            try
            {
                Dedup_model users = new Dedup_model();
                Dedup_model user = new Dedup_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Dedup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Rule_service.RulegridUpdate(objmodel);   
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("RulegridDelete")]
        [HttpPost]
        public string[] RulegridDelete(Dedup_model objmodel)
        {
            string[] response = { };
            try
            {
                Dedup_model users = new Dedup_model();
                Dedup_model user = new Dedup_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Dedup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = Rule_service.RulegridDelete(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("ExtractioncertiaDrop")]
        [HttpPost]
        public DataTable DbAliasDrop(Dedup_model user)
        {
            DataTable response = new DataTable();
            try
            {
                response = Rule_service.ExtractioncertiaDrop(user);
            }
            catch(Exception e)
            {

            }
            return response;
        }
    }
}
