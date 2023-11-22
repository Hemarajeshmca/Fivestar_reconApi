using Newtonsoft.Json;
using Recon_api_model;
using Recon_api_service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;

namespace Recon_api.Controllers
{
    [Authorize]
    public class AcMasterController : ApiController
    {
      public static string ip_address = "";
      CommonController objcommon = new CommonController();
      
        [Route("AcMasterList")]
        [HttpPost]       
        public DataTable ResponsibilityList(AcMaster_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = AcMaster_service.AcMasterList(objmodel);
                return response;
            }
            catch (Exception er) {
                return response;
            }
        }

        [Route("GetaccRecon")]
        [HttpPost]
        public DataTable Getacconuntnowithreconid(AcMaster_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = AcMaster_service.Getacconuntnowithreconid(objmodel);
                return response;
            }
            catch (Exception er)
            {
                return response;
            }
        }

        [Route("AcMasterCreate")]
        [HttpPost]
        public string[] AcMasterCreate(AcMaster_model objmodel)
        {
            string[] response = { };
            try
            {

                AcMaster_model users = new AcMaster_model();
                AcMaster_model user = new AcMaster_model();
                string post_data = objcommon.GetPost_data(this.Request.Content.ReadAsStreamAsync().Result);
                user = (AcMaster_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = AcMaster_service.AcMastercreate(objmodel);
                return response;
            }
            catch (Exception er) {
                return response;
            }
        }
        [Route("AcMasterUpdate")]
        [HttpPost]
        public string[] AcMasterUpdate(AcMaster_model objmodel)
        {
            string[] response = { };
            try
            {
                AcMaster_model users = new AcMaster_model();
                AcMaster_model user = new AcMaster_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (AcMaster_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = AcMaster_service.AcMasterUpdate(objmodel);
                return response;
            }
            catch (Exception e) {
                return response;
            }
        }
        [Route("AcMasterDelete")]
        [HttpPost]
        public string[] AcMasterDelete(AcMaster_model objmodel)
        {
            string[] response = { };
            try { 
                AcMaster_model users = new AcMaster_model();
                AcMaster_model user = new AcMaster_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (AcMaster_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = AcMaster_service.AcMasterDelete(objmodel);
                return response;
            }catch(Exception e){
                return response;
            }
        }
    }
}
