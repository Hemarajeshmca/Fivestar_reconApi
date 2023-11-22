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
   public class Master_service
    {
       public string[] GetMasterData(Master_model mastermodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Master_model user = new Master_model();
           try
           {
               Master_datamodel objproduct1 = new Master_datamodel();
               result = objproduct1.GetMasterData(mastermodel);
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
       public static DataTable GetMasterList(Master_model objmodel)
       {
           DataTable ds = new DataTable();
           Master_datamodel objproduct = new Master_datamodel();
           ds = objproduct.GetMasterList(objmodel);
           return ds;
       }
       public string[] GetMasterCreate(Master_model mastermodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Master_model user = new Master_model();
           try
           {
               Master_datamodel objproduct1 = new Master_datamodel();
               result = objproduct1.GetMasterCreate(mastermodel);
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
       public string[] GetMasterUpdate(Master_model mastermodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Master_model user = new Master_model();
           try
           {
               Master_datamodel objproduct1 = new Master_datamodel();
               result = objproduct1.GetMasterUpdate(mastermodel);
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
       public string[] GetMasterDelete(Master_model mastermodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Master_model user = new Master_model();
           try
           {
               Master_datamodel objproduct1 = new Master_datamodel();
               result = objproduct1.GetMasterDelete(mastermodel);
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
    }
}
