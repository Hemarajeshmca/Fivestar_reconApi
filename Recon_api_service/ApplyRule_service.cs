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
   public class ApplyRule_service
    {
       public static DataTable ApplyruleList(Applyrule_model objmodel1)
       {
           DataTable ds = new DataTable();
           try
           {
               ApplyRule_datamodel objproduct = new ApplyRule_datamodel();
               ds = objproduct.ApplyruleList(objmodel1);
           }
           catch (Exception e)
           { 
           
           }
           return ds;
       }
       public static DataTable ApplyruleDrop(Applyrule_model objmodel1)
       {
           DataTable ds = new DataTable();
           try
           {
               ApplyRule_datamodel objproduct1 = new ApplyRule_datamodel();
               ds = objproduct1.ApplyruleDrop(objmodel1);
           }
           catch (Exception e) 
           { 
           
           }
           return ds;
       }
       public static DataTable ApplyruleSUPDrop(Applyrule_model objmodel1)
       {
           DataTable ds = new DataTable();
           try
           {
               ApplyRule_datamodel objproduct1 = new ApplyRule_datamodel();
               ds = objproduct1.ApplyruleSUPDrop(objmodel1);
           }
           catch (Exception e)
           { 
           }
           return ds;
       }
       public static string[] ApplyruleCreate(Applyrule_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Applyrule_model user = new Applyrule_model();
           try
           {
               ApplyRule_datamodel objproduct1 = new ApplyRule_datamodel();
               result = objproduct1.ApplyruleCreate(objmodel);
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
       public static DataTable Applyrule_listEdit(Applyrule_model objmodel1)
       {
           DataTable ds = new DataTable();
           try
           {
               ApplyRule_datamodel objproduct1 = new ApplyRule_datamodel();
               ds = objproduct1.Applyrule_listEdit(objmodel1);
           }
           catch (Exception e)
           { 
           }
           return ds;
       }
       public static string[] ApplyruleUpdate(Applyrule_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Applyrule_model user = new Applyrule_model();
           try
           {
               ApplyRule_datamodel objproduct1 = new ApplyRule_datamodel();
               result = objproduct1.ApplyruleUpdate(objmodel);
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
               //  throw ex; 
               return result;
           }
       }
       public static DataTable Applyrulegriddtl(Applyrule_model objmodel1)
       {
           DataTable ds = new DataTable();
           try
           {
               ApplyRule_datamodel objproduct = new ApplyRule_datamodel();
               ds = objproduct.Applyrulegriddtl(objmodel1);
           }
           catch (Exception e)
           { 
           }
           return ds;
       }
       public static DataTable Applyrulegridadd(Applyrule_model objmodel1)
       {
           DataTable ds = new DataTable();
           try
           {
               ApplyRule_datamodel objproduct = new ApplyRule_datamodel();
               ds = objproduct.Applyrulegridadd(objmodel1);
           }
           catch (Exception e)
           { 
           }
           return ds;
       }
       public static DataTable Applyrulegridgroup(Applyrule_model objmodel1)
       {
           DataTable ds = new DataTable();
           try
           {
               ApplyRule_datamodel objproduct = new ApplyRule_datamodel();
               ds = objproduct.Applyrulegridgroup(objmodel1);
           }
           catch (Exception e)
           { 
           }
           return ds;
       }
       public static DataTable Applyrulegridgroup_New(Applyrule_model objmodel1)
       {
           DataTable ds = new DataTable();
           try
           {
               ApplyRule_datamodel objproduct = new ApplyRule_datamodel();
               ds = objproduct.Applyrulegridgroup_New(objmodel1);
           }
           catch (Exception e)
           {
           }
           return ds;
       }
       public string[]  ApplyRuleGridCreate(Applyrule_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Applyrule_model user = new Applyrule_model();
           try
           {
               ApplyRule_datamodel objproduct1 = new ApplyRule_datamodel();
               result = objproduct1.ApplyRuleGridCreate(objmodel);
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
       public static Applyrule_model ApplyRuleGridUpdate(Applyrule_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Applyrule_model user = new Applyrule_model();
           try
           {
               ApplyRule_datamodel objproduct1 = new ApplyRule_datamodel();
               result = objproduct1.ApplyRuleGridUpdate(objmodel);
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
              // throw ex;
               return user;
           }
       }
       public static string[] ApplyRuleGridCreateAdd(Applyrule_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Applyrule_model user = new Applyrule_model();
           try
           {
               ApplyRule_datamodel objproduct1 = new ApplyRule_datamodel();
               result = objproduct1.ApplyRuleGridCreateAdd(objmodel);
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

       public static string[] ApplyRuleGridUpdateAddBaseFilter(Applyrule_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Applyrule_model user = new Applyrule_model();
           try
           {
               ApplyRule_datamodel objproduct1 = new ApplyRule_datamodel();
               result = objproduct1.ApplyRuleGridUpdateAddBaseFilter(objmodel);
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
       public static string[] ApplyRuleGridUpdateAdd(Applyrule_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Applyrule_model user = new Applyrule_model();
           try
           {
               ApplyRule_datamodel objproduct1 = new ApplyRule_datamodel();
               result = objproduct1.ApplyRuleGridUpdateAdd(objmodel);
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
       public static string[] ApplyRuleGridCreateBase(Applyrule_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Applyrule_model user = new Applyrule_model();
           try
           {
               ApplyRule_datamodel objproduct1 = new ApplyRule_datamodel();
               result = objproduct1.ApplyRuleGridCreateBase(objmodel);
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
             //  throw ex;
               return result;
           }
       }
       public static string[] ApplyRuleGridUpdateBase(Applyrule_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Applyrule_model user = new Applyrule_model();
           try
           {
               ApplyRule_datamodel objproduct1 = new ApplyRule_datamodel();
               result = objproduct1.ApplyRuleGridUpdateBase(objmodel);
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
       public static string[] AppylyruleTargetgrp_create(Applyrule_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Applyrule_model user = new Applyrule_model();
           try
           {
               ApplyRule_datamodel objproduct1 = new ApplyRule_datamodel();
               result = objproduct1.AppylyruleTargetgrp_create(objmodel);
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

       public static string[] AppylyruleTargetgrp_Delete(Applyrule_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Applyrule_model user = new Applyrule_model();
           try
           {
               ApplyRule_datamodel objproduct1 = new ApplyRule_datamodel();
               result = objproduct1.AppylyruleTargetgrp_Delete(objmodel);
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
       public static string[] ApplyRuleAddtarget_Update(Applyrule_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Applyrule_model user = new Applyrule_model();
           try
           {
               ApplyRule_datamodel objproduct1 = new ApplyRule_datamodel();
               result = objproduct1.ApplyRuleAddtarget_Update(objmodel);
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
       public static DataTable ApplyrulegridRule(Applyrule_model objmodel1)
       {
           DataTable ds = new DataTable();
           try
           {
               ApplyRule_datamodel objproduct = new ApplyRule_datamodel();
               ds = objproduct.ApplyrulegridRule(objmodel1);
           }
           catch
           { 
           }
           return ds;
       }

       public static DataTable ApplyruleBaseFilterRule(Applyrule_model objmodel1)
       {
           DataTable ds = new DataTable();
           ApplyRule_datamodel objproduct = new ApplyRule_datamodel();
           ds = objproduct.ApplyruleBaseFilterRule(objmodel1);
           return ds;
       }
       public static DataTable ApplyruleBaseFilterRule_New(Applyrule_model objmodel1)
       {
           DataTable ds = new DataTable();
           ApplyRule_datamodel objproduct = new ApplyRule_datamodel();
           ds = objproduct.ApplyruleBaseFilterRule_New(objmodel1);
           return ds;
       }
       public static DataTable getApplyrule_targetgrpgrid(Applyrule_model objmodel1)
       {
           DataTable ds = new DataTable();
           ApplyRule_datamodel objproduct = new ApplyRule_datamodel();
           ds = objproduct.getApplyrule_targetgrpgrid(objmodel1);
           return ds;
       }
       public static DataTable AccountNodrop(Applyrule_model objmodel1)
       {
           DataTable ds = new DataTable();
           try
           {
               ApplyRule_datamodel objproduct1 = new ApplyRule_datamodel();
               ds = objproduct1.AccountNodrop(objmodel1);
           }
           catch
           { 
           }
           return ds;
       }
       public static string[] ApplyRuleListDelete(Applyrule_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Applyrule_model user = new Applyrule_model();
           try
           {
               ApplyRule_datamodel objproduct1 = new ApplyRule_datamodel();
               result = objproduct1.ApplyRuleListDelete(objmodel);
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
             //  throw ex;
               return result;
           }
       }
       public static string[] ApplyRuledtlDelete(Applyrule_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Applyrule_model user = new Applyrule_model();
           try
           {
               ApplyRule_datamodel objproduct1 = new ApplyRule_datamodel();
               result = objproduct1.ApplyRuledtlDelete(objmodel);
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
       public static string[] ApplyRuleBaseSelDelete(Applyrule_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Applyrule_model user = new Applyrule_model();
           try
           {
               ApplyRule_datamodel objproduct1 = new ApplyRule_datamodel();
               result = objproduct1.ApplyRuleBaseSelDelete(objmodel);
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
       public static string[] ApplyRuleAddConDelete(Applyrule_model objmodel)
       {
           string[] result = { };
           DataTable tab = new DataTable();
           Applyrule_model user = new Applyrule_model();
           try
           {
               ApplyRule_datamodel objproduct1 = new ApplyRule_datamodel();
               result = objproduct1.ApplyRuleAddConDelete(objmodel);
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
               //throw ex;
               return result;
           }
       }
       public static DataTable DropDownBinding_sourceTarget(FileConvTemp_model objmodel)
       {
           DataTable ds = new DataTable();
           try
           {
               ApplyRule_datamodel objproduct = new ApplyRule_datamodel();
               ds = objproduct.DropDownBinding_sourceTarget(objmodel);
           }
           catch (Exception e)
           {

           }
           return ds;
       }

      
    }
}
