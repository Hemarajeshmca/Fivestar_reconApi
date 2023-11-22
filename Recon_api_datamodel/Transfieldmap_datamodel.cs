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
    public class Transfieldmap_datamodel
    {
        public DataTable Transfielddrop(TransFieldmap_model TransField_model)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(TransField_model.ip_address, TransField_model.user_code);
                values.Add("in_field_type", "");
                result = con.RunDataSetProc("pr_get_tablefieldtype", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(TransField_model.ip_address, TransField_model.user_code);
                con.errorlog(TransField_model.ip_address, TransField_model.user_code, method_name, error, source_name);
                return result;
            }
        }
        public DataTable DbAliasDropTemp(TransFieldmap_model TransField_model)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(TransField_model.ip_address, TransField_model.user_code);;
                result = con.RunDataSetProc("pr_get_fieldaliasname_template");
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(TransField_model.ip_address, TransField_model.user_code);
                con.errorlog(TransField_model.ip_address, TransField_model.user_code, method_name, error, source_name);
                return result;
            }
        }
        public DataTable TransFieldGridRead(TransFieldmap_model TransField_model)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(TransField_model.ip_address, TransField_model.user_code);;
                values.Add("in_field_name", "");
                values.Add("in_mapping_flag", "Y");
                values.Add("in_template_flag", "");
                result = con.RunDataSetProc("pr_get_fieldstru", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(TransField_model.ip_address, TransField_model.user_code);
                con.errorlog(TransField_model.ip_address, TransField_model.user_code, method_name, error, source_name);
                return result;
            }
        }
        public string[] TransFieldGridUpdate(TransFieldmap_model TransField_model)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(TransField_model.ip_address, TransField_model.user_code);;

                values.Add("in_field_name", TransField_model.DBfieldName);
                values.Add("in_field_alias_name", TransField_model.Alias);
                values.Add("in_field_type", TransField_model.Type);
                values.Add("in_field_length", TransField_model.Length);
                values.Add("in_field_format", TransField_model.Format);
                values.Add("in_template_flag", TransField_model.temflag);
                values.Add("in_action_by", TransField_model.user_code);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_upd_fieldstru", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(TransField_model.ip_address, TransField_model.user_code);
                con.errorlog(TransField_model.ip_address, TransField_model.user_code, method_name, error, source_name);
                return result;
            }
        }
    }
}
