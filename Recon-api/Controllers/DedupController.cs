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
    public class DedupController : ApiController
    {
        [Route("DedupList")]
        [HttpPost]
        public DataTable ResponsibilityList(Dedup_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = Dedup_service.DedupList(objmodel);
            }
            catch (Exception e)
            { 
            
            }
            return response;
        }
        [Route("DedupCreate")]
        [HttpPost]
        public string[] AcMasterCreate(Dedup_model objmodel)
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
                response = Dedup_service.Dedupcreate(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("DbAliasDrop")]
        [HttpPost]
        public DataTable DbAliasDrop(Dedup_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = Dedup_service.DbAliasDrop(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("Fieldtype")]
        [HttpPost]
        public string Fieldtype(Dedup_model objmodel)
        {
            string response = string.Empty;
            try
            {
                Dedup_model users = new Dedup_model();
                Dedup_model user = new Dedup_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Dedup_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                users = Dedup_service.Fieldtype(objmodel);
                response = users.msg;
            }catch(Exception e)
            {

            }
            return response;
        }
        [Route("certiaDrop")]
        [HttpPost]
        public DataTable certiaDrop(Dedup_model user)
        {
            DataTable response = new DataTable();
            try
            {
                response = Dedup_service.certiaDrop(user);
            }
            catch (Exception e)
            {
            
            }
            return response;
        }
        [Route("DedupGridCreate")]
        [HttpPost]
        public string[] DedupGridCreate(Dedup_model objmodel)
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
                response = Dedup_service.DedupGridCreate(objmodel);
            }
            catch(Exception e)
            { 
            }
            return response;
        }
        [Route("DedupgridList")]
        [HttpPost]
        public DataTable DedupgridList(Dedup_model user1)
        {
            DataTable response = new DataTable();
            try
            {
                response = Dedup_service.DedupgridList(user1);
            }
            catch (Exception e)
            { 
            }
            return response;
        }
        [Route("Dedupgrid_listEdit")]
        [HttpPost]
        public DataTable Dedupgrid_listEdit(Dedup_model user)
        {
            DataTable response = new DataTable();
            try
            {
                response = Dedup_service.Dedupgrid_listEdit(user);
            }
            catch (Exception e)
            { 
            }
            return response;
        }
        [Route("DedupUpdate")]
        [HttpPost]
        public string[] DedupUpdate(Dedup_model objmodel)
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
                response = Dedup_service.DedupUpdate(objmodel);
            }
            catch (Exception e)
            { 
            }
            return response;
        }
        [Route("DedupGridupdate")]
        [HttpPost]
        public string[] DedupGridupdate(Dedup_model objmodel)
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
                response = Dedup_service.DedupGridupdate(objmodel);
            }
            catch (Exception e)
            { 
            }
            return response;
        }

    }
}
