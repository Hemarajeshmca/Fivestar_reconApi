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
   public class Transfieldmap_service
    {
       public static DataTable Transfielddrop(TransFieldmap_model objmodel)
       {
           DataTable ds = new DataTable();
           try
           {
               Transfieldmap_datamodel objproduct = new Transfieldmap_datamodel();
               ds = objproduct.Transfielddrop(objmodel);
           }
           catch(Exception e)
           {

           }
           return ds;
       }
       public static DataTable DbAliasDropTemp(TransFieldmap_model objmodel)
       {
           DataTable ds = new DataTable();
           try
           {
               Transfieldmap_datamodel objproduct = new Transfieldmap_datamodel();
               ds = objproduct.DbAliasDropTemp(objmodel);
           }
           catch(Exception e)
           {

           }
           return ds;
       }
       public static DataTable TransFieldGridRead(TransFieldmap_model objmodel)
       {
           DataTable ds = new DataTable();
           try
           {
               Transfieldmap_datamodel objproduct = new Transfieldmap_datamodel();
               ds = objproduct.TransFieldGridRead(objmodel);
           }
           catch(Exception e)
           {

           }
           return ds;
       }
       public static TransFieldmap_model TransFieldGridUpdate(TransFieldmap_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           TransFieldmap_model user = new TransFieldmap_model();
           try
           {
               Transfieldmap_datamodel objproduct1 = new Transfieldmap_datamodel();
               result = objproduct1.TransFieldGridUpdate(objmodel);
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
               return user;
           }
       }
    }
}
