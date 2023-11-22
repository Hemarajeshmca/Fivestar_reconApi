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
   public class Common_Service
    {
       public string[] GetFilterValue(Common_model Commonmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Common_model user = new Common_model();
           try
           {
               Common_datamodel objproduct1 = new Common_datamodel();
               result = objproduct1.GetFilterValue(Commonmodel);
               if (result.Length == 3)
               {
                   user.result_value = result[0];
                   user.msg = result[1];
                   user.result = Convert.ToInt32(result[2]);
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
    }
}
