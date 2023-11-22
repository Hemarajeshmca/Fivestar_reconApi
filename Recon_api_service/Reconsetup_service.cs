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
   public class Reconsetup_service
    {
       public static DataTable RecontypeList(Reconsetup_model objmodel)
       {
           DataTable ds = new DataTable();
           try
           {
               Reconsetup_datamodel objproduct = new Reconsetup_datamodel();
               ds = objproduct.RecontypeList(objmodel);
           }
           catch(Exception e)
           {

           }
           return ds;
       }
       public static DataTable AccName(Reconsetup_model objmodel)
       {
           DataTable ds = new DataTable();
           try
           {
               Reconsetup_datamodel objproduct1 = new Reconsetup_datamodel();
               ds = objproduct1.AccName(objmodel);
           }
           catch(Exception e)
           {

           }
           return ds;
       }
       public static string[] RecontypeCreate(Reconsetup_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Reconsetup_model user = new Reconsetup_model();
           try
           {
               Reconsetup_datamodel objproduct1 = new Reconsetup_datamodel();
               result = objproduct1.RecontypeCreate(objmodel);
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
       public static string[] RecontypeUpdate(Reconsetup_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Reconsetup_model user = new Reconsetup_model();
           try
           {
               Reconsetup_datamodel objproduct1 = new Reconsetup_datamodel();
               result = objproduct1.RecontypeUpdate(objmodel);
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
       public static string[] RecontypeDelete(Reconsetup_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Reconsetup_model user = new Reconsetup_model();
           try
           {
               Reconsetup_datamodel objproduct1 = new Reconsetup_datamodel();
               result = objproduct1.RecontypeDelete(objmodel);
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
