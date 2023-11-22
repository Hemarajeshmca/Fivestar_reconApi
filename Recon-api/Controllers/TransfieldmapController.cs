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
    public class TransfieldmapController : ApiController
    {
        [Route("Transfielddrop")]
        [HttpPost]
        public DataTable Transfielddrop(TransFieldmap_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = Transfieldmap_service.Transfielddrop(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("DbAliasDropTemp")]
        [HttpPost]
        public DataTable DbAliasDropTemp(TransFieldmap_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = Transfieldmap_service.DbAliasDropTemp(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("TransFieldGridRead")]
        [HttpPost]
        public DataTable TransFieldGridRead(TransFieldmap_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = Transfieldmap_service.TransFieldGridRead(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("TransFieldGridUpdate")]
        [HttpPost]
        public string TransFieldGridUpdate(TransFieldmap_model objmodel)
        {
            string response = string.Empty;
            try
            {
                TransFieldmap_model users = new TransFieldmap_model();
                TransFieldmap_model user = new TransFieldmap_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (TransFieldmap_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                users = Transfieldmap_service.TransFieldGridUpdate(objmodel);
                response = users.msg;
            }
            catch(Exception e)
            {

            }
            return response;
        }
    }
}
