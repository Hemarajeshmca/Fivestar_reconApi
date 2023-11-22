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
    public class QcdMaster_datamodel
    {
        public DataTable QcdModeldataRead(Qcdmodel ObjModel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON("", "");
                values.Add("in_user_code", "");
                result = con.RunDataSetProc("pr_get_qcdparent", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON("", "");
                //con.errorlog(ObjModel.masterGid, ObjModel.masterGid, method_name, error, source_name);
                con.errorlog("", "", method_name, error, source_name);
                return result;
            }
        }

        public DataTable QcdModeldataGridRead(Qcdmodel ObjModel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON("", "");
                values.Add("in_user_code", "");
                values.Add("in_master_code", ObjModel.masterCode);
                result = con.RunDataSetProc("pr_get_qcdmaster", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON("", "");
                //con.errorlog(ObjModel.masterGid, ObjModel.masterGid, method_name, error, source_name);
                con.errorlog("", "", method_name, error, source_name);
                return result;
            }
        }

        public DataTable QcdFile_select(Qcdmodel Acmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON("", "");
                var ipaddrss = Acmodel.ip_address;
                var user_code = Acmodel.user_code;
                //  values.Add("in_master_gid", Acmodel.masterGid);
                values.Add("in_master_syscode", Acmodel.masterSyscode);
                values.Add("in_master_code", Acmodel.masterCode);
                values.Add("in_master_short_code", Acmodel.masterShortCode);
                values.Add("in_master_name", Acmodel.masterName);
                values.Add("in_master_multiple_name", Acmodel.mastermutiplename);
                values.Add("in_parent_master_syscode", Acmodel.ParentMasterSyscode);
                values.Add("in_active_status", Acmodel.Status);
                values.Add("in_action", Acmodel.action);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");

                result = con.RunDataSetProc("pr_recon_mst_qcdmaster", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON("", "");
                //con.errorlog(ObjModel.masterGid, ObjModel.masterGid, method_name, error, source_name);
                con.errorlog("", "", method_name, error, source_name);
                return result;
            }
        }
        //public string master_name { get; set; }
        //public DataTable QcdModelRead(QcdMaster_Model ObjModel)
        //{
        //    throw new NotImplementedException();
        //}



        public string[] Qcdmaster_Create(Qcdmodel Acmodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Acmodel.ip_address, Acmodel.user_code);

                var ipaddrss = Acmodel.ip_address;
                var user_code = Acmodel.user_code;
                values.Add("in_master_gid",Acmodel.masterGid);
                values.Add("in_master_syscode", Acmodel.masterSyscode);
                values.Add("in_master_code", Acmodel.masterCode);
                values.Add("in_master_short_code", Acmodel.masterShortCode);
                values.Add("in_master_name", Acmodel.masterName);
                values.Add("in_master_multiple_name", Acmodel.mastermutiplename);
                values.Add("in_parent_master_syscode", Acmodel.ParentMasterSyscode);
                values.Add("in_active_status", Acmodel.Status);
                values.Add("in_action",Acmodel.action);
                values.Add("out_msg", "out");
                values.Add("out_result","out");

                result = con.RunDmlProc("pr_recon_mst_tmaster", values);
                return result;
            }
            catch (Exception ex)
            {

                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON("", "");
                //con.errorlog(ObjModel.masterGid, ObjModel.masterGid, method_name, error, source_name);
                con.errorlog("", "", method_name, error, source_name);
                return result;
            }
        }

        public string[] Qcdmaster_Delete(Qcdmodel Acmodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Acmodel.ip_address, Acmodel.user_code);

                var ipaddrss = Acmodel.ip_address;
                var user_code = Acmodel.user_code;
                values.Add("in_master_gid", Acmodel.masterGid);
                values.Add("in_master_syscode", Acmodel.masterSyscode);
                values.Add("in_master_code", Acmodel.masterCode);
                values.Add("in_master_short_code", Acmodel.masterShortCode);
                values.Add("in_master_name", Acmodel.masterName);
                values.Add("in_master_multiple_name", Acmodel.mastermutiplename);
                values.Add("in_parent_master_syscode", Acmodel.ParentMasterSyscode);
                values.Add("in_active_status", Acmodel.Status);
                values.Add("in_action", Acmodel.action);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");

                result = con.RunDmlProc("pr_recon_mst_tmaster", values);
                return result;
            }
            catch (Exception ex)
            {

                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON("", "");
                //con.errorlog(ObjModel.masterGid, ObjModel.masterGid, method_name, error, source_name);
                con.errorlog("", "", method_name, error, source_name);
                return result;
            }
        }


        public string[] QcdFile(Qcdmodel Acmodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Acmodel.ip_address, Acmodel.user_code);

                var ipaddrss = Acmodel.ip_address;
                var user_code = Acmodel.user_code;
              //  values.Add("in_master_gid", Acmodel.masterGid);
                values.Add("in_master_syscode", Acmodel.masterSyscode);
                values.Add("in_master_code", Acmodel.masterCode);
                values.Add("in_master_short_code", Acmodel.masterShortCode);
                values.Add("in_master_name", Acmodel.masterName);
                values.Add("in_master_multiple_name", Acmodel.mastermutiplename);
                values.Add("in_parent_master_syscode", Acmodel.ParentMasterSyscode);
                values.Add("in_active_status", Acmodel.Status);
                values.Add("in_action", Acmodel.action);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");

                result = con.RunDmlProc("pr_recon_mst_qcdmaster", values);
                return result;
            }
            catch (Exception ex)
            {

                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON("", "");
                //con.errorlog(ObjModel.masterGid, ObjModel.masterGid, method_name, error, source_name);
                con.errorlog("", "", method_name, error, source_name);
                return result;
            }
        }
     
    }
}
