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
   public class AcMaster_service
    {
       public static DataTable AcMasterList(AcMaster_model objmodel)
       {
           DataTable ds = new DataTable();
           try
           {
               AcMaster_datamodel objproduct = new AcMaster_datamodel();
               ds = objproduct.AcMasterList(objmodel);
           }
           catch (Exception e) { 
           
           }
           return ds;
       }
       public static DataTable Getacconuntnowithreconid(AcMaster_model objmodel)
       {
           DataTable ds = new DataTable();
           try
           {
               AcMaster_datamodel objproduct = new AcMaster_datamodel();
               ds = objproduct.getacc_no(objmodel);
           }
           catch (Exception e)
           {

           }
           return ds;
       }
       public static string[] AcMastercreate(AcMaster_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           AcMaster_model user = new AcMaster_model();
           try
           {
               AcMaster_datamodel objproduct1 = new AcMaster_datamodel();
               result = objproduct1.AcMastercreate(objmodel);
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
              // throw ex;
               return result;
           }
       }
       public static string[] AcMasterUpdate(AcMaster_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           AcMaster_model user = new AcMaster_model();
           try
           {
               AcMaster_datamodel objproduct1 = new AcMaster_datamodel();
               result = objproduct1.AcMasterUpdate(objmodel);
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
              // throw ex;
               return result;
           }
       }
       public static string[] AcMasterDelete(AcMaster_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           AcMaster_model user = new AcMaster_model();
           try
           {
               AcMaster_datamodel objproduct1 = new AcMaster_datamodel();
               result = objproduct1.AcMasterDelete(objmodel);
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
            //   throw ex;
               return result;
           }
       }
    }
}
