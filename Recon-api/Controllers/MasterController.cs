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
    public class MasterController : ApiController
    {
        [Route("GetMasterData")]
        [HttpPost]
        public string[] GetMasterData(Master_model mastermodel)
        {
            Master_model users = new Master_model();
            Master_model user = new Master_model();
            string[] response = { };          
            Stream data = this.Request.Content.ReadAsStreamAsync().Result;

            StreamReader reader = new StreamReader(data);
            string post_data = reader.ReadToEnd();
            user = (Master_model)JsonConvert.DeserializeObject(post_data, mastermodel.GetType());
            Master_service objservice = new Master_service();
            response = objservice.GetMasterData(mastermodel);        
            return response;            
        }
        [Route("GetMasterList")]      
        [HttpPost]
        public DataTable GetMasterList(Master_model objmodel)
        {
            DataTable response = new DataTable();
            response = Master_service.GetMasterList(objmodel);
            return response;
        }
        [Route("GetMasterCreate")]
        [HttpPost]
        public string[] GetMasterCreate(Master_model mastermodel)
        {
            Master_model users = new Master_model();
            Master_model user = new Master_model();
            string[] response = { };
            Stream data = this.Request.Content.ReadAsStreamAsync().Result;

            StreamReader reader = new StreamReader(data);
            string post_data = reader.ReadToEnd();
            user = (Master_model)JsonConvert.DeserializeObject(post_data, mastermodel.GetType());
            Master_service objservice = new Master_service();
            response = objservice.GetMasterCreate(mastermodel);
            return response;
        }
        [Route("GetMasterUpdate")]
        [HttpPost]
        public string[] GetMasterUpdate(Master_model mastermodel)
        {
            Master_model users = new Master_model();
            Master_model user = new Master_model();
            string[] response = { };
            Stream data = this.Request.Content.ReadAsStreamAsync().Result;

            StreamReader reader = new StreamReader(data);
            string post_data = reader.ReadToEnd();
            user = (Master_model)JsonConvert.DeserializeObject(post_data, mastermodel.GetType());
            Master_service objservice = new Master_service();
            response = objservice.GetMasterUpdate(mastermodel);
            return response;
        }

        [Route("GetMasterDelete")]
        [HttpPost]
        public string[] GetMasterDelete(Master_model mastermodel)
        {
            Master_model users = new Master_model();
            Master_model user = new Master_model();
            string[] response = { };
            Stream data = this.Request.Content.ReadAsStreamAsync().Result;

            StreamReader reader = new StreamReader(data);
            string post_data = reader.ReadToEnd();
            user = (Master_model)JsonConvert.DeserializeObject(post_data, mastermodel.GetType());
            Master_service objservice = new Master_service();
            response = objservice.GetMasterDelete(mastermodel);
            return response;
        }
    }
}
