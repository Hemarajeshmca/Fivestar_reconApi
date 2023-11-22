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
    public class ApplyruleController : ApiController
    {
        [Route("ApplyruleList")]
        [HttpPost]
        public DataTable ApplyruleList(Applyrule_model user)
        {
            DataTable response = new DataTable();
            try
            {
                response = ApplyRule_service.ApplyruleList(user);
            }
            catch (Exception e) { 

            }
            return response;
        }
        [Route("ApplyruleDrop")]
        [HttpPost]
        public DataTable ApplyruleDrop(Applyrule_model user)
        {
            DataTable response = new DataTable();
            try
            {
                response = ApplyRule_service.ApplyruleDrop(user);
            }
            catch (Exception e) { 
            
            }
            return response;
        }
        [Route("ApplyruleSUPDrop")]
        [HttpPost]
        public DataTable ApplyruleSUPDrop(Applyrule_model user)
        {
            DataTable response = new DataTable();
            try
            {
                response = ApplyRule_service.ApplyruleSUPDrop(user);
            }
            catch (Exception e) { 
            
            }
            return response;
        }
        [Route("ApplyruleCreate")]
        [HttpPost]
        public string[] ApplyruleCreate(Applyrule_model objmodel)
        {
            string[] response = { };
            try
            {
                Applyrule_model users = new Applyrule_model();
                Applyrule_model user = new Applyrule_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Applyrule_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = ApplyRule_service.ApplyruleCreate(objmodel);      
            }
            catch (Exception e)
            { 
            }
            return response;
        }
        [Route("Applyrule_listEdit")]
        [HttpPost]  
        public DataTable Applyrule_listEdit(Applyrule_model user)
        {
            DataTable response = new DataTable();
            try
            {
                response = ApplyRule_service.Applyrule_listEdit(user);
            }
            catch (Exception e) { 
            
            }
            return response;
        }
        [Route("ApplyruleUpdate")]
        [HttpPost]
        public string[] ApplyruleUpdate(Applyrule_model objmodel)
        {
            string[] response = { };
            try
            {
                Applyrule_model users = new Applyrule_model();
                Applyrule_model user = new Applyrule_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Applyrule_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = ApplyRule_service.ApplyruleUpdate(objmodel);
                //response = users.msg;
            }
            catch (Exception e)
            { 
            }
            return response;
        }
        [Route("Applyrulegriddtl")]
        [HttpPost]
        public DataTable Applyrulegriddtl(Applyrule_model user)
        {
            DataTable response = new DataTable();
            try
            {
                response = ApplyRule_service.Applyrulegriddtl(user);
            }
            catch (Exception e)
            { 
            }
            return response;
        }
        [Route("Applyrulegridadd")]
        [HttpPost]
        public DataTable Applyrulegridadd(Applyrule_model user)
        {
            DataTable response = new DataTable();
            try
            {
                response = ApplyRule_service.Applyrulegridadd(user);
            }
            catch (Exception e) { 
            
            }
            return response;
        }
        [Route("Applyrulegridgroup")]
        [HttpPost]
        public DataTable Applyrulegridgroup(Applyrule_model user)
        {
            DataTable response = new DataTable();
            try
            {
                response = ApplyRule_service.Applyrulegridgroup(user);
            }
            catch (Exception e) 
            { 
            
            }
            return response;
        }
        [Route("Applyrulegridgroup_New")]
        [HttpPost]
        public DataTable Applyrulegridgroup_New(Applyrule_model user)
        {
            DataTable response = new DataTable();
            try
            {
                response = ApplyRule_service.Applyrulegridgroup_New(user);
            }
            catch (Exception e)
            {

            }
            return response;
        }
        [Route("ApplyRuleGridCreate")]
        [HttpPost]
        public string[] ApplyRuleGridCreate(Applyrule_model objmodel)
        {
            string[] response = { };
            try 
            {
                Applyrule_model users = new Applyrule_model();
                Applyrule_model user = new Applyrule_model();
                ApplyRule_service ob_service = new ApplyRule_service();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Applyrule_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = ob_service.ApplyRuleGridCreate(objmodel);
                //response = users.msg;
            }
            catch (Exception e)
            {

            }
            return response;
        }
        [Route("ApplyRuleGridUpdate")]
        [HttpPost]
        public string ApplyRuleGridUpdate(Applyrule_model objmodel)
        {
            Applyrule_model users = new Applyrule_model();
            Applyrule_model user = new Applyrule_model();
            string response = string.Empty;
            try
            {
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Applyrule_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                users = ApplyRule_service.ApplyRuleGridUpdate(objmodel);
                response = users.msg;
            }
            catch (Exception e)
            { 
            
            }
            return response;
        }
        [Route("ApplyRuleGridCreateAdd")]
        [HttpPost]
        public string[] ApplyRuleGridCreateAdd(Applyrule_model objmodel)
        {
            string[] response = { };
            try
            {
                Applyrule_model users = new Applyrule_model();
                Applyrule_model user = new Applyrule_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Applyrule_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = ApplyRule_service.ApplyRuleGridCreateAdd(objmodel);
            }
            catch (Exception e)
            { 
            }
            return response;
        }
        [Route("ApplyRuleGridUpdateAddBaseFilter")]
        [HttpPost]
        public string[] ApplyRuleGridUpdateAddBaseFilter(Applyrule_model objmodel)
        {
            string[] response = { };
            try
            {
                Applyrule_model users = new Applyrule_model();
                Applyrule_model user = new Applyrule_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Applyrule_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = ApplyRule_service.ApplyRuleGridUpdateAddBaseFilter(objmodel);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("ApplyRuleGridUpdateAdd")]
        [HttpPost]
        public string[] ApplyRuleGridUpdateAdd(Applyrule_model objmodel)
        {
            string[] response = { };
            try
            {
                Applyrule_model users = new Applyrule_model();
                Applyrule_model user = new Applyrule_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Applyrule_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = ApplyRule_service.ApplyRuleGridUpdateAdd(objmodel);  
            }
            catch (Exception e)
            {

            }
            return response;
        }
        [Route("ApplyRuleGridCreateBase")]
        [HttpPost]
        public string[] ApplyRuleGridCreateBase(Applyrule_model objmodel)
        {
            string[] response = { };
            try 
            {
                Applyrule_model users = new Applyrule_model();
                Applyrule_model user = new Applyrule_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Applyrule_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = ApplyRule_service.ApplyRuleGridCreateBase(objmodel); 
            }     
            catch
            {

            }
            return response;
        }
        [Route("ApplyRuleGridUpdateBase")]
        [HttpPost]
        public string[] ApplyRuleGridUpdateBase(Applyrule_model objmodel)
        {
            string[] response = { };
            try
            {
                Applyrule_model users = new Applyrule_model();
                Applyrule_model user = new Applyrule_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Applyrule_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = ApplyRule_service.ApplyRuleGridUpdateBase(objmodel);       
            }
            catch
            {

            }
            return response;
        }
        [Route("ApplyrulegridRule")]
        [HttpPost]
        public DataTable ApplyrulegridRule(Applyrule_model user)
        {
            DataTable response = new DataTable();
            try
            {
                response = ApplyRule_service.ApplyrulegridRule(user);
            }
            catch (Exception e)
            { }
            return response;
        }
        [Route("ApplyruleBaseFilterRule")]
        [HttpPost]
        public DataTable ApplyruleBaseFilterRule(Applyrule_model user)
        {
            DataTable response = new DataTable();
            try
            {
                response = ApplyRule_service.ApplyruleBaseFilterRule(user);
            }
            catch(Exception e)
            {

            }
            return response;
        }
        [Route("ApplyruleBaseFilterRule_New")]
        [HttpPost]
        public DataTable ApplyruleBaseFilterRule_New(Applyrule_model user)
        {
            DataTable response = new DataTable();
            try
            {
                response = ApplyRule_service.ApplyruleBaseFilterRule_New(user);
            }
            catch (Exception e)
            {

            }
            return response;
        }
        [Route("getApplyrule_targetgrpgrid")]
        [HttpPost]
        public DataTable getApplyrule_targetgrpgrid(Applyrule_model user)
        {
            DataTable response = new DataTable();
            try
            {
                response = ApplyRule_service.getApplyrule_targetgrpgrid(user);
            }
            catch (Exception e)
            {

            }
            return response;
        }
        [Route("AccountNodrop")]
        [HttpPost]
        public DataTable AccountNodrop(Applyrule_model user)
        {
            DataTable response = new DataTable();
            try
            {
                response = ApplyRule_service.AccountNodrop(user);
            }
            catch (Exception e)
            { 
            
            }
            return response;
        }
        [Route("ApplyRuleListDelete")]
        [HttpPost]
        public string[] ApplyRuleListDelete(Applyrule_model objmodel)
        {
            string[] response = { };
            try
            {
                Applyrule_model users = new Applyrule_model();
                Applyrule_model user = new Applyrule_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Applyrule_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = ApplyRule_service.ApplyRuleListDelete(objmodel);
            }
            catch(Exception e)
            { 
            }
            return response;
        }
        [Route("ApplyRuledtlDelete")]
        [HttpPost]
        public string[] ApplyRuledtlDelete(Applyrule_model objmodel)
        {
            string[] response = { };
            try
            {
                Applyrule_model users = new Applyrule_model();
                Applyrule_model user = new Applyrule_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Applyrule_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = ApplyRule_service.ApplyRuledtlDelete(objmodel);
            }
            catch (Exception e)
            { 
            }
            return response;
        }
        [Route("ApplyRuleBaseSelDelete")]
        [HttpPost]
        public string[] ApplyRuleBaseSelDelete(Applyrule_model objmodel)
        {
            string[] response = { };
            try
            {
                Applyrule_model users = new Applyrule_model();
                Applyrule_model user = new Applyrule_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Applyrule_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = ApplyRule_service.ApplyRuleBaseSelDelete(objmodel);
            }
            catch (Exception e)
            { 
            
            }
            return response;
        }
        [Route("ApplyRuleAddConDelete")]
        [HttpPost]
        public string[] ApplyRuleAddConDelete(Applyrule_model objmodel)
        {
            string[] response = { };
            try
            {
                Applyrule_model users = new Applyrule_model();
                Applyrule_model user = new Applyrule_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Applyrule_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = ApplyRule_service.ApplyRuleAddConDelete(objmodel);
            }
            catch (Exception e)
            { 
            }
            return response;
        }

        [Route("DropDownBinding_sourceTarget")]
        [HttpPost]
        public DataTable DropDownBinding_sourceTarget(FileConvTemp_model objmodel)
        {
            DataTable response = new DataTable();
            try
            {
                response = ApplyRule_service.DropDownBinding_sourceTarget(objmodel);
            }
            catch (Exception e)
            {
            }
            return response;
        }


         [Route("AppylyruleTargetgrp_create")]
        [HttpPost]
        public string[] AppylyruleTargetgrp_create(Applyrule_model objmodel)
        {
            string[] response = { };
            try
            {
                Applyrule_model users = new Applyrule_model();
                Applyrule_model user = new Applyrule_model();
                Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                StreamReader reader = new StreamReader(data);
                string post_data = reader.ReadToEnd();
                user = (Applyrule_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                response = ApplyRule_service.AppylyruleTargetgrp_create(objmodel);
            }
            catch
            {

            }
            return response;
        }

         [Route("AppylyruleTargetgrp_Delete")]
         [HttpPost]
         public string[] AppylyruleTargetgrp_Delete(Applyrule_model objmodel)
         {
             string[] response = { };
             try
             {
                 Applyrule_model users = new Applyrule_model();
                 Applyrule_model user = new Applyrule_model();
                 Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                 StreamReader reader = new StreamReader(data);
                 string post_data = reader.ReadToEnd();
                 user = (Applyrule_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                 response = ApplyRule_service.AppylyruleTargetgrp_Delete(objmodel);
             }
             catch
             {

             }
             return response;
         }

         [Route("ApplyRuleAddtarget_Update")]
         [HttpPost]
         public string[] ApplyRuleAddtarget_Update(Applyrule_model objmodel)
         {
             string[] response = { };
             try
             {
                 Applyrule_model users = new Applyrule_model();
                 Applyrule_model user = new Applyrule_model();
                 Stream data = this.Request.Content.ReadAsStreamAsync().Result;
                 StreamReader reader = new StreamReader(data);
                 string post_data = reader.ReadToEnd();
                 user = (Applyrule_model)JsonConvert.DeserializeObject(post_data, objmodel.GetType());
                 response = ApplyRule_service.ApplyRuleAddtarget_Update(objmodel);
             }
             catch
             {

             }
             return response;
         }

      
    }
}
