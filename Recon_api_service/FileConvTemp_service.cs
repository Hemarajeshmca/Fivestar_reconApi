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
    public class FileConvTemp_service
    {
        public static DataTable TemplateFileType(FileConvTemp_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                FileConvTemp_datamodel objproduct = new FileConvTemp_datamodel();
                ds = objproduct.TemplateFileType(objmodel);
            }
            catch (Exception e)
            { 
            }
            return ds;
        }
        public static DataTable TemplateType(FileConvTemp_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                FileConvTemp_datamodel objproduct = new FileConvTemp_datamodel();
                ds = objproduct.TemplateType(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }
        public static DataTable Trandatedrop(FileConvTemp_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                FileConvTemp_datamodel objproduct = new FileConvTemp_datamodel();
                ds = objproduct.Trandatformatbinding(objmodel);
            }
            catch (Exception e)
            {

            }
            return ds;
        }

        public static DataTable DropdownBinding(FileConvTemp_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                FileConvTemp_datamodel objproduct = new FileConvTemp_datamodel();
                ds = objproduct.DropdownBinding(objmodel);
            }
            catch (Exception e)
            {

            }
            return ds;
        }
        public string[] FileConvTempCreate(FileConvTemp_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            FileConvTemp_model user = new FileConvTemp_model();
            try
            {
                FileConvTemp_datamodel objproduct1 = new FileConvTemp_datamodel();
                result = objproduct1.FileConvTempCreate(objmodel);
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
        public string[] FileConvTempDelete(FileConvTemp_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            FileConvTemp_model user = new FileConvTemp_model();
            try
            {
                FileConvTemp_datamodel objproduct1 = new FileConvTemp_datamodel();
                result = objproduct1.FileConvTempDelete(objmodel);
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
        public static DataTable GetFieldStru(FileConvTemp_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                FileConvTemp_datamodel objproduct = new FileConvTemp_datamodel();
                ds = objproduct.GetFieldStru(objmodel);
            }
            catch (Exception e)
            { 
            }
            return ds;
        }
        public string[] FileTemplateField(FileConvTemp_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            FileConvTemp_model user = new FileConvTemp_model();
            try
            {
                FileConvTemp_datamodel objproduct1 = new FileConvTemp_datamodel();
                result = objproduct1.FileTemplateFiled(objmodel);
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
        public static DataTable GetFieldGridDt(FileConvTemp_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                FileConvTemp_datamodel objproduct = new FileConvTemp_datamodel();
                ds = objproduct.GetFieldGrid(objmodel);
            }
            catch (Exception e) { 
            
            }
            return ds;
        }

        public static DataTable GetTemplateListDt(FileConvTemp_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                FileConvTemp_datamodel objproduct = new FileConvTemp_datamodel();
                ds = objproduct.FileTemplateLists(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }
        public string[] FileTemplateField_update(FileConvTemp_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            FileConvTemp_model user = new FileConvTemp_model();
            try
            {
                FileConvTemp_datamodel objproduct1 = new FileConvTemp_datamodel();
                result = objproduct1.FileTemplateFiled_Update(objmodel);
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
        public string[] FileConvTempFiledDelete(FileConvTemp_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            FileConvTemp_model user = new FileConvTemp_model();
            try
            {
                FileConvTemp_datamodel objproduct1 = new FileConvTemp_datamodel();
                result = objproduct1.FileConvTempFiledDelete(objmodel);
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
        public static DataTable LookupMasterdrop(Formula_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                FileConvTemp_datamodel objproduct = new FileConvTemp_datamodel();
                ds = objproduct.LookupMasterdrop(objmodel);
            }
            catch (Exception e)
            { 
            }
            return ds;
        }
        public string[] LookupMasterSave(Formula_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            FileConvTemp_model user = new FileConvTemp_model();
            try
            {
                FileConvTemp_datamodel objproduct1 = new FileConvTemp_datamodel();
                result = objproduct1.LookupMasterSave(objmodel);
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

        public static DataTable FileTemplateFieldFormulaRead(Formula_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                FileConvTemp_datamodel objproduct = new FileConvTemp_datamodel();
                ds = objproduct.FileTemplateFieldFormulaRead(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }


        public static DataTable LookupMasterRead(Formula_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                FileConvTemp_datamodel objproduct = new FileConvTemp_datamodel();
                ds = objproduct.LookupMasterRead(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }

        public string[] LookupMasterUpdate(Formula_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            FileConvTemp_model user = new FileConvTemp_model();
            try
            {
                FileConvTemp_datamodel objproduct1 = new FileConvTemp_datamodel();
                result = objproduct1.LookupMasterUpdate(objmodel);
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
        public string[] LookupMasterDelete(Formula_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            FileConvTemp_model user = new FileConvTemp_model();
            try
            {
                FileConvTemp_datamodel objproduct1 = new FileConvTemp_datamodel();
                result = objproduct1.LookupMasterDelete(objmodel);
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
