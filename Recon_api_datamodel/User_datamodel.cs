using Recon_api_model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon_api_datamodel
{
    public class User_datamodel
    {
        public DataTable UserRead(User_model Usermodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Usermodel.ip_address, Usermodel.user_code);
                values.Add("in_user_gid", 0);
                result = con.RunDataSetProc("pr_get_user", values);
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

        public string[] UserSave(User_model Usermodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Usermodel.ip_address, Usermodel.user_code);

                values.Add("in_user_code", Usermodel.user_code);
                values.Add("in_user_name", Usermodel.user_name);
                values.Add("in_user_address", Usermodel.user_address);
                values.Add("in_city_name", Usermodel.city_name);
                values.Add("in_pin_code", Usermodel.pin_code);
                values.Add("in_state_name", Usermodel.state_name);
                values.Add("in_user_contactno", Usermodel.user_contact_no);
                values.Add("in_user_emailid", Usermodel.user_emailid);
                values.Add("in_security_question", Usermodel.security_question);
                values.Add("in_security_answer", Usermodel.security_answer);
                values.Add("in_usergroup_gid", Usermodel.usergroup_gid);
                values.Add("in_user_type", Usermodel.user_type);
                values.Add("in_recon_gid", Usermodel.recon_gid);
                values.Add("in_action_by", Usermodel.user_code);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_ins_user_new", values);
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
        public DataTable UserTypeDROP(User_model Usermodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Usermodel.ip_address, Usermodel.user_code);

                result = con.RunDataSetProc("pr_get_usertype");
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
        public DataTable usergroupdrop(User_model Usermodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Usermodel.ip_address, Usermodel.user_code);
                result = con.RunDataSetProc("pr_get_usergroup");
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
        public DataTable userStatusdrop(User_model Usermodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Usermodel.ip_address, Usermodel.user_code);
                result = con.RunDataSetProc("pr_get_userstatus");
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
        public string[] UserStatusSave(User_model Usermodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Usermodel.ip_address, Usermodel.user_code);

                values.Add("in_user_gid", Usermodel.user_gid);
                values.Add("in_user_status", Usermodel.user_status);
                values.Add("in_action_by", Usermodel.user_code);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_set_userstatus", values);
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
        public DataTable usergroupList(User_model Usermodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Usermodel.ip_address, Usermodel.user_code);

                values.Add("in_usergroup_gid", Usermodel.usergroup_gid);
                values.Add("in_usergroup_name", Usermodel.usergroup_code);
                values.Add("in_active_status", Usermodel.user_status);
                values.Add("in_action", "SELECT");
                values.Add("in_action_by", Usermodel.user_code);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDataSetProcnew("pr_ins_usergroup", values);
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
        public string[] usergroupsave(User_model Usermodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Usermodel.ip_address, Usermodel.user_code);

                values.Add("in_usergroup_gid", Usermodel.usergroup_gid);
                values.Add("in_usergroup_name", Usermodel.usergroup_code);
                values.Add("in_active_status", Usermodel.user_status);
                values.Add("in_action", "INSERT");
                values.Add("in_action_by", Usermodel.user_code);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_ins_usergroup", values);
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
        public string[] usergroupUpdate(User_model Usermodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Usermodel.ip_address, Usermodel.user_code);

                values.Add("in_usergroup_gid", Usermodel.usergroup_gid);
                values.Add("in_usergroup_name", Usermodel.usergroup_code);
                values.Add("in_active_status", Usermodel.user_status);
                values.Add("in_action", "UPDATE");
                values.Add("in_action_by", Usermodel.user_code);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_ins_usergroup", values);
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
        public string[] usergroupDelete(User_model Usermodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Usermodel.ip_address, Usermodel.user_code);

                values.Add("in_usergroup_gid", Usermodel.usergroup_gid);
                values.Add("in_usergroup_name", Usermodel.usergroup_code);
                values.Add("in_active_status", Usermodel.user_status);
                values.Add("in_action", "DELETE");
                values.Add("in_action_by", Usermodel.user_code);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_ins_usergroup", values);
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
        public DataTable GetTreeview(User_model Usermodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Usermodel.ip_address, Usermodel.user_code);
                values.Add("in_usergroup_gid", Usermodel.usergroup_gid);
                result = con.RunDataSetProc("pr_get_usertreeview", values);
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

        public string[] usertreeviewsave(User_model Usermodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Usermodel.ip_address, Usermodel.user_code);

                values.Add("in_usergroup_gid", Usermodel.usergroup_gid);
                values.Add("in_menu_gid", Usermodel.treearray);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_ins_userrights", values);
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

    }
}
