
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recon_api_model;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Diagnostics;
//using System.Web.Http;
//using System.Net.Http;

namespace Recon_api_datamodel
{
   public class Login_datamodel 
    {
       /*
       string user_ = "";
       public class getuser_code : ApiController
       {
        IEnumerable<string> usercode = null;
           Request.Headers.TryGetValues("user_code", out usercode);
           var user_ = ((string[])(usercode))[0];
       }
        */
       public DataTable Loginvalidation(Login_model Objmodel)
       {
          /* HttpRequestMessage objreq = new HttpRequestMessage();
          //  var re = objreq.Headers;
    var headers = objreq.Headers;
    IEnumerable<string> usercode = null;
    var re = objreq.Headers.TryGetValues("user_code", out usercode);
  var user_ = ((string[])(usercode))[0];
    */
           DataTable result = new DataTable();
           try
           {
               //Recon.Controllers.LogHelper.WriteLog("UserName" + Objmodel.user_name, "Login_datamodel");
               //Recon.Controllers.LogHelper.WriteLog("UserID" + Objmodel.user_id, "Login_datamodel");
               //Recon.Controllers.LogHelper.WriteLog("Password" + Objmodel.password, "Login_datamodel");
               Dictionary<string, Object> values = new Dictionary<string, object>();

               MSQLCON con = new MSQLCON(Objmodel.ip, Objmodel.user_id);
             //  Recon.Controllers.LogHelper.WriteLog("connection", "Login_datamodel");
               values.Add("in_user_code", Objmodel.user_id);
               values.Add("in_password", Objmodel.password);
               values.Add("in_ip_addr", Objmodel.ip);
              // Recon.Controllers.LogHelper.WriteLog("in_user_code" + Objmodel.user_id, "Login_datamodel");

               //Recon.Controllers.LogHelper.WriteLog("in_password" + Objmodel.password, "Login_datamodel");
               //Recon.Controllers.LogHelper.WriteLog("in_ip_addr" + Objmodel.ip, "Login_datamodel");


               //Recon.Controllers.LogHelper.WriteLog("Before result", "Login_datamodel");
                

               result = con.RunDataSetProc("pr_get_loginvalidation_new", values);
               ///Recon.Controllers.LogHelper.WriteLog("result", "Login_datamodel");
               return result;
           }
           catch (Exception ex)
           {

               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               Recon.Controllers.LogHelper.WriteLog("catchdatamodel" + error, "Login_datamodel");
               MSQLCON con = new MSQLCON(Objmodel.ip, Objmodel.user_id);
               con.errorlog(Objmodel.ip, Objmodel.user_id, method_name, error, source_name);
               return result;
           }
       }

       public string[] changepass_save(User_model Usermodel)
       {
           string[] result = { };
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(Usermodel.ip_address, Usermodel.user_code);

               values.Add("in_user_gid", Usermodel.user_gid);
               values.Add("in_old_password", Usermodel.oldpassworrd);
               values.Add("in_new_password", Usermodel.newpassword);
               values.Add("out_msg", "out");
               values.Add("out_result", "out");
               result = con.RunDmlProc("pr_set_password", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(Usermodel.ip_address, Usermodel.user_code);
               con.errorlog(Usermodel.ip_address, Usermodel.user_code, method_name, error, source_name);
               throw ex;
           }
       }
        /*
        public string[] changepass_save(User_model Usermodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Usermodel.ip_address, Usermodel.user_code);

                values.Add("in_user_gid", Usermodel.user_gid);
                values.Add("in_old_password", Usermodel.oldpassworrd);
                values.Add("in_new_password", Usermodel.newpassword);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_set_password", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Usermodel.ip_address, Usermodel.user_code);
                con.errorlog(Usermodel.ip_address, Usermodel.user_code, method_name, error, source_name);
               return result;
            }
        }
        
        public DataTable forgotpassword(Login_model Objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Objmodel.ip, Objmodel.user_id);
                values.Add("in_user_code", Objmodel.user_id);
                result = con.RunDataSetProc("pr_get_useremail", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Objmodel.ip, Objmodel.user_id);
                con.errorlog(Objmodel.ip, Objmodel.user_id, method_name, error, source_name);
                return result;
            }
        }
        */

       public DataTable forgotpassword(Login_model Objmodel)
       {
           DataTable result = new DataTable();
           try
           {
               Dictionary<string, Object> values = new Dictionary<string, object>();
               MSQLCON con = new MSQLCON(Objmodel.ip, Objmodel.user_id);
               values.Add("in_user_code", Objmodel.user_id);
               result = con.RunDataSetProc("pr_get_useremail", values);
               return result;
           }
           catch (Exception ex)
           {
               string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
               string source_name = this.GetType().ToString();
               string error = ex.ToString();
               MSQLCON con = new MSQLCON(Objmodel.ip, Objmodel.user_id);
               con.errorlog(Objmodel.ip, Objmodel.user_id, method_name, error, source_name);
               throw ex;
           }
       }
    }
}
