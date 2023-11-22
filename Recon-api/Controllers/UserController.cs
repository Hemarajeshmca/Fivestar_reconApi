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
    public class UserController : ApiController
    {
        [Route("UserRead")]
        [HttpPost]
        public DataTable UserRead(User_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = User_Service.UserRead(objmodel);
            }
            catch (Exception n)
            {

            }
            return response;
        }
        [Route("UserSave")]
        [HttpPost]
        public string[] UserSave(User_model objmodel)
        {
            string[] response = { };
            try
            {
                User_model users = new User_model();
                User_model user = new User_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (User_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = User_Service.UserSave(objmodel);
                //response = users.msg;
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("UserTypeDROP")]
        [HttpPost]
        public DataTable UserTypeDROP(User_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = User_Service.UserTypeDROP(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("usergroupdrop")]
        [HttpPost]
        public DataTable usergroupdrop(User_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = User_Service.usergroupdrop(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("userStatusdrop")]
        [HttpPost]
        public DataTable userStatusdrop(User_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = User_Service.userStatusdrop(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("UserStatusSave")]
        [HttpPost]
        public string[] UserStatusSave(User_model objmodel)
        {
            string[] response = { };
            try
            {
                User_model users = new User_model();
                User_model user = new User_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (User_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = User_Service.UserStatusSave(objmodel);
                //response = users.msg;
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("usergroupsave")]
        [HttpPost]
        public string[] usergroupsave(User_model objmodel)
        {
            string[] response = { };
            try
            {
                User_model users = new User_model();
                User_model user = new User_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (User_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = User_Service.usergroupsave(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }

        [Route("usergroupList")]
        [HttpPost]
        public DataTable usergroupList(User_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = User_Service.usergroupList(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }

        [Route("usergroupUpdate")]
        [HttpPost]
        public string[] usergroupUpdate(User_model objmodel)
        {
            string[] response = { };
            try
            {
                User_model users = new User_model();
                User_model user = new User_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (User_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = User_Service.usergroupUpdate(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("usergroupDelete")]
        [HttpPost]
        public string[] usergroupDelete(User_model objmodel)
        {
            string[] response = { };
            try
            {
                User_model users = new User_model();
                User_model user = new User_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (User_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = User_Service.usergroupDelete(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("GetTreeview")]
        [HttpPost]
        public DataTable GetTreeview(User_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = User_Service.GetTreeview(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("usertreeviewsave")]
        [HttpPost]
        public string[] usertreeviewsave(User_model objmodel)
        {
            string[] response = { };
            try
            {
                User_model users = new User_model();
                User_model user = new User_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (User_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = User_Service.usertreeviewsave(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
    }
}
