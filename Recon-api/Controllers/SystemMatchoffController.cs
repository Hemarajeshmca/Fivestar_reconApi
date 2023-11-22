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
    public class SystemMatchoffController : ApiController
    {
        [Route("WithinAccList")]
        [HttpPost]
        public DataTable WithinAccList(Systemmatchoff_model user)
        {
            DataTable response = new DataTable();
            response = SystemMatchOff_service.WithinAccList(user);
            return response;
        }
        [Route("BetweenAccList")]
        [HttpPost]
        public DataTable BetweenAccList(Systemmatchoff_model user)
        {
            DataTable response = new DataTable();
            response = SystemMatchOff_service.WithinAccList(user);
            return response;
        }
        [Route("SystemMatchoffWith")]
        [HttpPost]
        public string SystemMatchoffWith(Systemmatchoff_model objmodel)
        {
            Systemmatchoff_model users = new Systemmatchoff_model();
            Systemmatchoff_model user = new Systemmatchoff_model();
            string response = string.Empty;
            Stream data = this.Request.Content.ReadAsStreamAsync().Result;

            StreamReader reader = new StreamReader(data);
            string post_data = reader.ReadToEnd();
            user = (Systemmatchoff_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
            users = SystemMatchOff_service.SystemMatchoffWith(objmodel);
            response = users.msg;
            return response;
        }
    }
}
