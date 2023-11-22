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
   public class Rule_service
    {
       public static DataTable RuleList(Dedup_model objmodel)
       {
           DataTable ds = new DataTable();
           try
           {
               Rule_datamodel objproduct = new Rule_datamodel();
               ds = objproduct.RuleList(objmodel);
           }
           catch(Exception e)
           {

           }
           return ds;
       }
       public static string[] RuleCreate(Dedup_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Dedup_model user = new Dedup_model();
           try
           {
               Rule_datamodel objproduct1 = new Rule_datamodel();
               result = objproduct1.RuleCreate(objmodel);
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
       public static string[] RuleDelete(Dedup_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Dedup_model user = new Dedup_model();
           try
           {
               Rule_datamodel objproduct1 = new Rule_datamodel();
               result = objproduct1.RuleDelete(objmodel);
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
       public static string[] RulegridDelete(Dedup_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Dedup_model user = new Dedup_model();
           try
           {
               Rule_datamodel objproduct1 = new Rule_datamodel();
               result = objproduct1.RulegridDelete(objmodel);
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
       public static string[] RuleUpdate(Dedup_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Dedup_model user = new Dedup_model();
           try
           {
               Rule_datamodel objproduct1 = new Rule_datamodel();
               result = objproduct1.RuleUpdate(objmodel);
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

       public static string[] RulegridCreate(Dedup_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Dedup_model user = new Dedup_model();
           try
           {
               Rule_datamodel objproduct1 = new Rule_datamodel();
               result = objproduct1.RulegridCreate(objmodel);
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
       public static string[] RulegridUpdate(Dedup_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Dedup_model user = new Dedup_model();
           try
           {
               Rule_datamodel objproduct1 = new Rule_datamodel();
               result = objproduct1.RulegridUpdate(objmodel);
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
       public static DataTable RuleGrid_listEdit(Dedup_model objmodel1)
       {
           DataTable ds = new DataTable();
           try
           {
               Rule_datamodel objproduct1 = new Rule_datamodel();
               ds = objproduct1.RuleGrid_listEdit(objmodel1);
           }
           catch(Exception e)
           {

           }
           return ds;
       }
       public static DataTable RuleGridList(Dedup_model objmodel2)
       {
           DataTable ds = new DataTable();
           try
           {
               Rule_datamodel objproduct = new Rule_datamodel();
               ds = objproduct.RuleGridList(objmodel2);
           }
           catch(Exception e)
           {

           }
           return ds;
       }

       public static DataTable ExtractioncertiaDrop(Dedup_model objmodel1)
       {
           DataTable ds = new DataTable();
           try
           {
               Rule_datamodel objproduct1 = new Rule_datamodel();
               ds = objproduct1.ExtractioncertiaDrop(objmodel1);
           }
           catch(Exception e)
           {

           }
           return ds;
       }
    }
}
