using Recon_api_model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recon_api_datamodel;

namespace Recon_api_service
{
    public class Setup_service
    {
        public static string[] categorycreate(Setup_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Setup_model user = new Setup_model();
            try
            {
                Setup_datamodel objproduct = new Setup_datamodel();
                result = objproduct.categorycreate(objmodel);
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
        public static DataTable categoryList(Setup_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                Setup_datamodel objproduct = new Setup_datamodel();
                ds = objproduct.categoryList(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }
        public static DataTable categoryDROP(Setup_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                Setup_datamodel objproduct = new Setup_datamodel();
                ds = objproduct.categoryDROP(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }
        public static string[] categoryUpdate(Setup_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Setup_model user = new Setup_model();
            try
            {
                Setup_datamodel objproduct = new Setup_datamodel();
                result = objproduct.categoryUpdate(objmodel);
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
        public static string[] CategoryDelete(Setup_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Setup_model user = new Setup_model();
            try
            {
                Setup_datamodel objproduct = new Setup_datamodel();
                result = objproduct.CategoryDelete(objmodel);
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

        public static string[] Responsibilitycreate(Setup_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Setup_model user = new Setup_model();
            try
            {
                Setup_datamodel objproduct = new Setup_datamodel();
                result = objproduct.Responsibilitycreate(objmodel);
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
        public static DataTable ResponsibilityList(Setup_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                Setup_datamodel objproduct = new Setup_datamodel();
                ds = objproduct.ResponsibilityList(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }
        public static string[] ResponsibilityUpdate(Setup_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Setup_model user = new Setup_model();
            try
            {
                Setup_datamodel objproduct = new Setup_datamodel();
                result = objproduct.ResponsibilityUpdate(objmodel);
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
        public static string[] ResponsibilityDelete(Setup_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Setup_model user = new Setup_model();
            try
            {
                Setup_datamodel objproduct = new Setup_datamodel();
                result = objproduct.ResponsibilityDelete(objmodel);
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
        public static string[] SupportfiletypeCreate(Setup_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Setup_model user = new Setup_model();
            try
            {
                Setup_datamodel objproduct = new Setup_datamodel();
                result = objproduct.SupportfiletypeCreate(objmodel);
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
        public static DataTable SupportfiletypeList(Setup_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                Setup_datamodel objproduct = new Setup_datamodel();
                ds = objproduct.SupportfiletypeList(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }

        public static string[] SupportfiletypeUpdate(Setup_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Setup_model user = new Setup_model();
            try
            {
                Setup_datamodel objproduct = new Setup_datamodel();
                result = objproduct.SupportfiletypeUpdate(objmodel);
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
        public static string[] Supportfiletype_Delete(Setup_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Setup_model user = new Setup_model();
            try
            {
                Setup_datamodel objproduct = new Setup_datamodel();
                result = objproduct.Supportfiletype_Delete(objmodel);
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
        public static string[] Remarkcreate(Setup_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Setup_model user = new Setup_model();
            try
            {
                Setup_datamodel objproduct = new Setup_datamodel();
                result = objproduct.Remarkcreate(objmodel);
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
        public static DataTable RemarkList(Setup_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                Setup_datamodel objproduct = new Setup_datamodel();
                ds = objproduct.RemarkList(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }

        public static string[] RemarkUpdate(Setup_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Setup_model user = new Setup_model();
            try
            {
                Setup_datamodel objproduct = new Setup_datamodel();
                result = objproduct.RemarkUpdate(objmodel);
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
        public static string[] RemarkDelete(Setup_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Setup_model user = new Setup_model();
            try
            {
                Setup_datamodel objproduct = new Setup_datamodel();
                result = objproduct.RemarkDelete(objmodel);
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
        public static string[] RemarkReason(Setup_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Setup_model user = new Setup_model();
            try
            {
                Setup_datamodel objproduct = new Setup_datamodel();
                result = objproduct.RemarkReason(objmodel);
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

        public static string[] RemarkReason_new(Setup_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Setup_model user = new Setup_model();
            try
            {
                Setup_datamodel objproduct = new Setup_datamodel();
                result = objproduct.RemarkReason_new(objmodel);
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
