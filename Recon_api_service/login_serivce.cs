using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recon_api_model;
using System.Data;
using Recon_api_datamodel;

namespace Recon_api_service
{
    public class login_serivce
    {
        public static DataTable Loginvalidation(Login_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                Recon.Controllers.LogHelper.WriteLog("UserName" + objmodel.user_name, "LoginService");
                Recon.Controllers.LogHelper.WriteLog("UserID" + objmodel.user_id, "LoginService");
                Recon.Controllers.LogHelper.WriteLog("Password" + objmodel.password, "LoginService");
                Login_datamodel objproduct = new Login_datamodel();
                ds = objproduct.Loginvalidation(objmodel);
            }
            catch (Exception e)
            {
                Recon.Controllers.LogHelper.WriteLog("Catch Service" + e.ToString(), "LoginService");
            }
            return ds;
        }

        public static string[] changepass_save(User_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            User_model user = new User_model();
            try
            {
                Login_datamodel objproduct1 = new Login_datamodel();
                result = objproduct1.changepass_save(objmodel);
                if (result.Length == 2)
                {
                    user.result = Convert.ToInt32(result[1]);
                    user.msg = result[0];
                }
                else
                {
                    user.result = 0;
                    user.msg = "Process Failed";
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable forgotpassword(Login_model objmodel)
        {
            DataTable ds = new DataTable();
            Login_datamodel objproduct = new Login_datamodel();
            ds = objproduct.forgotpassword(objmodel);
            return ds;
        }
    }
}
