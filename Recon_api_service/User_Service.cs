using Recon_api_datamodel;
using Recon_api_model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon_api_service
{
    public class User_Service
    {
        public static DataTable UserRead(User_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                User_datamodel objproduct = new User_datamodel();
                ds = objproduct.UserRead(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }
        public static string[] UserSave(User_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            User_model user = new User_model();
            try
            {
                User_datamodel objproduct1 = new User_datamodel();
                result = objproduct1.UserSave(objmodel);
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
                return result;
            }
        }
        public static DataTable UserTypeDROP(User_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                User_datamodel objproduct = new User_datamodel();
                ds = objproduct.UserTypeDROP(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }
        public static DataTable usergroupdrop(User_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                User_datamodel objproduct = new User_datamodel();
                ds = objproduct.usergroupdrop(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }
        public static DataTable userStatusdrop(User_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                User_datamodel objproduct = new User_datamodel();
                ds = objproduct.userStatusdrop(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }
        public static string[] UserStatusSave(User_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            User_model user = new User_model();
            try
            {
                User_datamodel objproduct1 = new User_datamodel();
                result = objproduct1.UserStatusSave(objmodel);
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
                return result;
            }
        }
        public static string[] usergroupsave(User_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            User_model user = new User_model();
            try
            {
                User_datamodel objproduct = new User_datamodel();
                result = objproduct.usergroupsave(objmodel);
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
                return result;
            }
        }
        public static DataTable usergroupList(User_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                User_datamodel objproduct = new User_datamodel();
                ds = objproduct.usergroupList(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }

        public static string[] usergroupDelete(User_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            User_model user = new User_model();
            try
            {
                User_datamodel objproduct = new User_datamodel();
                result = objproduct.usergroupDelete(objmodel);
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
                return result;
            }
        }
        public static string[] usergroupUpdate(User_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            User_model user = new User_model();
            try
            {
                User_datamodel objproduct = new User_datamodel();
                result = objproduct.usergroupUpdate(objmodel);
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
                return result;
            }
        }
        public static DataTable GetTreeview(User_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                User_datamodel objproduct = new User_datamodel();
                ds = objproduct.GetTreeview(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }
        public static string[] usertreeviewsave(User_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            User_model user = new User_model();
            try
            {
                User_datamodel objproduct = new User_datamodel();
                result = objproduct.usertreeviewsave(objmodel);
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
                return result;
            }
        }
    }
}
