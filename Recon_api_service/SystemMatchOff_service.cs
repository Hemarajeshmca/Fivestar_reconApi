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
    public class SystemMatchOff_service
    {
        public static DataTable WithinAccList(Systemmatchoff_model objmodel1)
        {
            DataTable ds = new DataTable();
            SystemmatchOff_datamodel objproduct = new SystemmatchOff_datamodel();
            ds = objproduct.WithinAccList(objmodel1);
            return ds;
        }
        public static Systemmatchoff_model SystemMatchoffWith(Systemmatchoff_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Systemmatchoff_model user = new Systemmatchoff_model();
            try
            {
                SystemmatchOff_datamodel objproduct1 = new SystemmatchOff_datamodel();
                result = objproduct1.SystemMatchoffWith(objmodel);
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

                return user;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}
