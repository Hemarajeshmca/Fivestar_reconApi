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
    public class QcdMasterController : ApiController
    {
        CommonController objcommon = new CommonController();

        [Route("QcdMasterRead")]
        [HttpPost]
        public DataTable QcdMasterRead(Qcdmodel objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = QcdMaster_Service.QcdMasterRead(objmodel);

            }
            catch (Exception e)
            {

            }
            return response;
        }

        [Route("QcdMasterGridRead")]
        [HttpPost]
        public DataTable QcdMasterGridRead(Qcdmodel objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = QcdMaster_Service.QcdMasterGridRead(objmodel);

            }
            catch (Exception e)
            {

            }
            return response;
        }

        [Route("Qcdmaster_Create")]
        [HttpPost]
        public string[] Qcdmaster_Create(Qcdmodel objmodel)
        {
            //DataTable response = new DataTable();
            string[] response = { };
            try
            {
                Qcdmodel users = new Qcdmodel();
                Qcdmodel user = new Qcdmodel();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Qcdmodel)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = QcdMaster_Service.Qcdmaster_Create(objmodel);
                
            }
            catch (Exception er)
            {
                
            }
            return response;
        }



        [Route("Qcdmaster_Delete")]
        [HttpPost]
        public string[] Qcdmaster_Delete(Qcdmodel objmodel)
        {
            //DataTable response = new DataTable();
            string[] response = { };
            try
            {
                Qcdmodel users = new Qcdmodel();
                Qcdmodel user = new Qcdmodel();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Qcdmodel)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = QcdMaster_Service.Qcdmaster_Delete(objmodel);

            }
            catch (Exception er)
            {

            }
            return response;
        }

        [Route("QcdExcelFile")]
        [HttpPost]
        public string[] QcdFile(Qcdmodel objmodel)
        {
            //DataTable response = new DataTable();
            string[] response = { };
            try
            {
                Qcdmodel users = new Qcdmodel();
                Qcdmodel user = new Qcdmodel();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Qcdmodel)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = QcdMaster_Service.QcdFile(objmodel);

            }
            catch (Exception er)
            {

            }
            return response;
        }

        [Route("QcdExcelFile_select")]
        [HttpPost]
        public DataTable QcdFile_select(Qcdmodel objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = QcdMaster_Service.QcdFile_select(objmodel);

            }
            catch (Exception e)
            {

            }
            return response;
        }

    }
}