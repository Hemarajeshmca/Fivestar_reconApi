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
    public class ManualMatchOffController : ApiController
    {
        [Route("GridManualmatchoff")]
        [HttpPost]
        public DataTable ExceptionGrid(ManualMatchOff_model user)
        {
            DataTable response = new DataTable();
            response = ManualMatchOff_service.ExceptionGrid(user);
            return response;
        }
		
        [Route("GridSupFileExcpSumm")]
        [HttpPost]
        public DataTable SupFileExcpSummGrid(ManualMatchOff_model user)
        {
            DataTable response = new DataTable();
            response = ManualMatchOff_service.SupFileExcpSummGrid(user);
            return response;
        }
		
		
        [Route("AddMatchOff")]
        [HttpPost]
        public string[] AddMatchOff(ManualMatchOff_model objmodel)
        {
            ManualMatchOff_model users = new ManualMatchOff_model();
            ManualMatchOff_model user = new ManualMatchOff_model();
            string[] response = { };
            Stream data = this.Request.Content.ReadAsStreamAsync().Result;

            StreamReader reader = new StreamReader(data);
            string post_data = reader.ReadToEnd();
            user = (ManualMatchOff_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
            response = ManualMatchOff_service.AddMatchOff(objmodel);
            //response = users.msg;
            return response;
        }
        [Route("SelectedMatchOff")]
        [HttpPost]
        public DataTable SelectedMatchOff(ManualMatchOff_model user)
        {
            DataTable response = new DataTable();
            response = ManualMatchOff_service.SelectedMatchOff(user);
            return response;
        }

        [Route("Manualmatchoffgridload")]
        [HttpPost]
        public DataTable Manualmatchoffgridload(ManualMatchOff_model user)
        {
            DataTable response = new DataTable();
            response = ManualMatchOff_service.SelectedMatchOffgrid(user);
            return response;
        }

        [Route("Manualmatchoffgridsec")]
        [HttpPost]
        public DataTable Manualmatchoffgridsec(ManualMatchOff_model user)
        {
            DataTable response = new DataTable();
            response = ManualMatchOff_service.SelectedMatchOff_gridsec(user);
            return response;
        }

        [Route("ManualMatchselected")]
        [HttpPost]
        public string[] ManulaMatch_selected(ManualMatchOff_model objmodel)
        {
            ManualMatchOff_model users = new ManualMatchOff_model();
            ManualMatchOff_model user = new ManualMatchOff_model();
            string[] response = { };
            Stream data = this.Request.Content.ReadAsStreamAsync().Result;

            StreamReader reader = new StreamReader(data);
            string post_data = reader.ReadToEnd();
            user = (ManualMatchOff_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
            response = ManualMatchOff_service.ManulaMatchselected(objmodel);
            //response = users.msg;
            return response;
        }


        [Route("ManulaMatchfirstload")]
        [HttpPost]
        public string[] ManulaMatchfirstload(ManualMatchOff_model objmodel)
        {
            ManualMatchOff_model users = new ManualMatchOff_model();
            ManualMatchOff_model user = new ManualMatchOff_model();
            string[] response = { };
            Stream data = this.Request.Content.ReadAsStreamAsync().Result;

            StreamReader reader = new StreamReader(data);
            string post_data = reader.ReadToEnd();
            user = (ManualMatchOff_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
            response = ManualMatchOff_service.ManulaMatch_firstload(objmodel);
            //response = users.msg;
            return response;
        }

        [Route("RunMatch_file")]
        [HttpPost]
        public string[] RunMatch_file(ManualMatchOff_model objmodel)
        {
            ManualMatchOff_model users = new ManualMatchOff_model();
            ManualMatchOff_model user = new ManualMatchOff_model();
            string[] response = { };
            Stream data = this.Request.Content.ReadAsStreamAsync().Result;

            StreamReader reader = new StreamReader(data);
            string post_data = reader.ReadToEnd();
            user = (ManualMatchOff_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
            response = ManualMatchOff_service.RunMatch_file(objmodel);
            //response = users.msg;
            return response;
        }

        [Route("SelectedMatchOffcreate")]
        [HttpPost]
        public string[] SelectedMatchOffcreate(ManualMatchOff_model objmodel)
        {
            ManualMatchOff_model users = new ManualMatchOff_model();
            ManualMatchOff_model user = new ManualMatchOff_model();
            string[] response = {};
            Stream data = this.Request.Content.ReadAsStreamAsync().Result;

            StreamReader reader = new StreamReader(data);
            string post_data = reader.ReadToEnd();
            user = (ManualMatchOff_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
            response = ManualMatchOff_service.SelectedMatchOffcreate(objmodel);
            //response = users.msg;
            return response;
        }
        [Route("SelectedMatchOffdel")]
        [HttpPost]
        public string SelectedMatchOffdel(ManualMatchOff_model objmodel)
        {
            ManualMatchOff_model users = new ManualMatchOff_model();
            ManualMatchOff_model user = new ManualMatchOff_model();
            string response = string.Empty;
            Stream data = this.Request.Content.ReadAsStreamAsync().Result;

            StreamReader reader = new StreamReader(data);
            string post_data = reader.ReadToEnd();
            user = (ManualMatchOff_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
            users = ManualMatchOff_service.SelectedMatchOffdel(objmodel);
            response = users.msg;
            return response;
        }
        [Route("AmountMatched")]
        [HttpPost]
        public DataTable AmountMatched(ManualMatchOff_model user)
        {
            DataTable response = new DataTable();
            response = ManualMatchOff_service.AmountMatched(user);
            return response;
        }
        [Route("AmountMatchedAll")]
        [HttpPost]
        public DataTable AmountMatchedAll(ManualMatchOff_model user)
        {
            DataTable response = new DataTable();
            response = ManualMatchOff_service.AmountMatchedAll(user);
            return response;
        }
        [Route("AmountMatchedSave")]
        [HttpPost]
        public string AmountMatchedSave(ManualMatchOff_model objmodel)
        {
            ManualMatchOff_model users = new ManualMatchOff_model();
            ManualMatchOff_model user = new ManualMatchOff_model();
            string response = string.Empty;
            Stream data = this.Request.Content.ReadAsStreamAsync().Result;

            StreamReader reader = new StreamReader(data);
            string post_data = reader.ReadToEnd();
            user = (ManualMatchOff_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
            users = ManualMatchOff_service.AmountMatchedSave(objmodel);
            response = users.msg;
            return response;
        }
        [Route("RuleGrid")]
        [HttpPost]
        public DataTable RuleGrid(ManualMatchOff_model user)
        {
            DataTable response = new DataTable();
            response = ManualMatchOff_service.RuleGrid(user);
            return response;
        }

        [Route("GetManualmatch")]
        [HttpPost]
        public DataTable GetManualmatch(ManualMatchOff_model user)
        {
            DataTable response = new DataTable();
            response = ManualMatchOff_service.GetManualmatch(user);
            return response;
        }

        [Route("RuleMatchOff")]
        [HttpPost]
        public string[] RuleMatchOff(ManualMatchOff_model objmodel)
        {
            ManualMatchOff_model users = new ManualMatchOff_model();
            ManualMatchOff_model user = new ManualMatchOff_model();
            string[] response = { };
            Stream data = this.Request.Content.ReadAsStreamAsync().Result;

            StreamReader reader = new StreamReader(data);
            string post_data = reader.ReadToEnd();
            user = (ManualMatchOff_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
            response = ManualMatchOff_service.RuleMatchOff(objmodel);            
            return response;
        }
        [Route("RuleMatchOffSelction")]
        [HttpPost]
        public string[] RuleMatchOffSelction(ManualMatchOff_model objmodel)
        {
            ManualMatchOff_model users = new ManualMatchOff_model();
            ManualMatchOff_model user = new ManualMatchOff_model();
            string[] response = { };
            Stream data = this.Request.Content.ReadAsStreamAsync().Result;

            StreamReader reader = new StreamReader(data);
            string post_data = reader.ReadToEnd();
            user = (ManualMatchOff_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
            response = ManualMatchOff_service.RuleMatchOffSelction(objmodel);
            return response;
        }
        [Route("ManualSingleView")]
        [HttpPost]
        public DataTable ManualSingleView(ManualMatchOff_model user)
        {
            DataTable response = new DataTable();
            response = ManualMatchOff_service.ManualSingleView(user);
            return response;
        }
        [Route("MatchOffReason")]
        [HttpPost]
        public string[] MatchOffReason(ManualMatchOff_model objmodel)
        {
            ManualMatchOff_model users = new ManualMatchOff_model();
            ManualMatchOff_model user = new ManualMatchOff_model();
            string[] response = { };
            Stream data = this.Request.Content.ReadAsStreamAsync().Result;

            StreamReader reader = new StreamReader(data);
            string post_data = reader.ReadToEnd();
            user = (ManualMatchOff_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
            response = ManualMatchOff_service.MatchOffReason(objmodel);
            return response;
        }
        [Route("SupFilemappingRead")]
        [HttpPost]
        public DataTable SupFilemappingRead(ManualMatchOff_model user)
        {
            DataTable response = new DataTable();
            response = ManualMatchOff_service.SupFilemappingRead(user);
            return response;
        }
        [Route("SupFilemappingcreate")]
        [HttpPost]
        public string[] SupFilemappingcreate(ManualMatchOff_model objmodel)
        {
            ManualMatchOff_model users = new ManualMatchOff_model();
            ManualMatchOff_model user = new ManualMatchOff_model();
            string[] response = { };
            Stream data = this.Request.Content.ReadAsStreamAsync().Result;

            StreamReader reader = new StreamReader(data);
            string post_data = reader.ReadToEnd();
            user = (ManualMatchOff_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
            response = ManualMatchOff_service.SupFilemappingcreate(objmodel);
            return response;
        }

        [Route("Undomatchoff")]
        [HttpPost]
        public string[] Undomatchoff(ManualMatchOff_model objmodel)
        {
            ManualMatchOff_model users = new ManualMatchOff_model();
            ManualMatchOff_model user = new ManualMatchOff_model();
            string[] response = { };
            Stream data = this.Request.Content.ReadAsStreamAsync().Result;

            StreamReader reader = new StreamReader(data);
            string post_data = reader.ReadToEnd();
            user = (ManualMatchOff_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
            response = ManualMatchOff_service.undomatch_off(objmodel);
            return response;
        }

        [Route("SupFilemappingcheck")]
        [HttpPost]
        public string[] SupFilemappingcheck(ManualMatchOff_model objmodel)
        {
            ManualMatchOff_model users = new ManualMatchOff_model();
            ManualMatchOff_model user = new ManualMatchOff_model();
            string[] response = { };
            Stream data = this.Request.Content.ReadAsStreamAsync().Result;

            StreamReader reader = new StreamReader(data);
            string post_data = reader.ReadToEnd();
            user = (ManualMatchOff_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
            response = ManualMatchOff_service.SupFilemappingcheck(objmodel);
            return response;
        }
    }
}
