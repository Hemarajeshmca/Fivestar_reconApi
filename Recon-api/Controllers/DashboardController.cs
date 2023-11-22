using Newtonsoft.Json;
using Recon_api_model;
using Recon_api_service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using Newtonsoft.Json;
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
    public class DashboardController : ApiController
    {
        CommonController objcommon = new CommonController();
        // GET: Dashboard
        [Route("DashboardList")]
        [HttpPost]
        public DataSet DashboardList(Dashboard_model objmodel)
        {
            DataSet response = new DataSet();
            try
            {
                response = Dashboard_Service.DashboardList(objmodel);
                return response;
            }
            catch (Exception er)
            {
                return response;
            }
        }
    }
}