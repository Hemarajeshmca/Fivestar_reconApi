using Recon_api_model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon_api_datamodel
{
   public class Common_datamodel
    {
       public string[] GetFilterValue(Common_model Commonmodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Commonmodel.ip_address, Commonmodel.user_code);
                values.Add("in_field_value", Commonmodel.field_value);
                values.Add("in_filter_flag", Commonmodel.filter_flag);               
                values.Add("out_value", "out");
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProcNew("pr_get_filtervalue", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Commonmodel.ip_address, Commonmodel.user_code);
                con.errorlog(Commonmodel.user_code, Commonmodel.ip_address, method_name, error, source_name);
                throw ex;
            }
        }
    }
}
