using Newtonsoft.Json;
using Recon_api_model;
using Recon_api_service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Recon_api.Controllers
{
    public class CommonController : ApiController
    {
        public string GetPost_data(Stream _data) {
            StreamReader reader = new StreamReader(_data);
            string post_data = reader.ReadToEnd();
            return post_data;
        }
    }
}
