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
    public class Dashboard_datamodel
    {

        public DataSet DashboardList(Dashboard_model ObjModel)
        {
           DataSet result = new DataSet();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON("", "");
                values.Add("in_recon_gid", ObjModel.recon_gid);
                values.Add("in_period_from", ObjModel.periodfrom);//"2000-01-01"
                values.Add("in_period_to",ObjModel.periodto);//"2024-01-01"
                values.Add("in_user_code",ObjModel.user_code);
                values.Add("out_msg","out");
                values.Add("out_result","out");
                result = con.RunDataSetProcDash("pr_get_dashboard_new", values);
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
