using Newtonsoft.Json;
using Recon.Controllers;
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
    public class LoginController : ApiController
    {
        [Route("Loginvalidation")]
        [HttpPost]
         public DataTable Loginvalidation(Login_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
            //    HttpRequestMessage re = new HttpRequestMessage();
              //  var hesders = re.Headers;
                //IEnumerable<string> usercode;
                //Request.Headers.TryGetValues("user_code",out usercode);
                //string user_ = ((string[])(usercode))[0];
                //HttpRequestHeader re = new HttpRequestHeader();
                //var usercode__ =  ("user_code");
                string controls = "Login";
                LogHelper.WriteLog("UserId" + objmodel.user_id, controls);
                LogHelper.WriteLog("UserName" + objmodel.user_name, controls);
                response = login_serivce.Loginvalidation(objmodel);
            }
            catch (Exception e) 
            {
            }
            return response;
        }

        [Route("changepass_save")]
        [HttpPost]
        public string[] changepass_save(User_model objmodel)
        {
            User_model users = new User_model();
            User_model user = new User_model();
            string[] response = { };
            Stream data = this.Request.Content.ReadAsStreamAsync().Result;

            StreamReader reader = new StreamReader(data);
            string post_data = reader.ReadToEnd();
            user = (User_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
            response = login_serivce.changepass_save(objmodel);
            //response = users.msg;
            return response;
        }

        [Route("forgotpassword")]
        [HttpPost]
        public DataTable forgotpassword(Login_model objmodel)
        {
            DataTable response = new DataTable();
            response = login_serivce.forgotpassword(objmodel);
            return response;
        }
    }
}
