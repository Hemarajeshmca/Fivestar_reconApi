using Recon.Controllers;
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
    public class FileImport_service
    {

        public static DataTable FileTemplateList(FileImport_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                FileImport_datamodel objproduct = new FileImport_datamodel();
                ds = objproduct.FileImportList(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }
        public static DataTable GetReconType(FileImport_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                FileImport_datamodel objproduct = new FileImport_datamodel();
                ds = objproduct.GetReconType(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }
        public static DataTable GetSupportingFile(FileImport_model objmodel)
        {
            DataTable ds = new DataTable();
            try 
            {
                FileImport_datamodel objproduct = new FileImport_datamodel();
                ds = objproduct.GetSupportingFile(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }
        public static DataTable GetReconAccNoList(FileImport_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                FileImport_datamodel objproduct = new FileImport_datamodel();
                ds = objproduct.GetReconAccNoList(objmodel);
            }catch(Exception e)
            {

            }
            return ds;
        }
        public static DataTable GetTemplatedbField(FileImport_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                FileImport_datamodel objproduct = new FileImport_datamodel();
                ds = objproduct.GetdbTemplateField(objmodel);
            }
            catch(Exception e)
            {

            }
            return ds;
        }
        public string[] GetExcelField(FileImport_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            FileImport_model user = new FileImport_model();
            try
            {
                FileImport_datamodel objproduct1 = new FileImport_datamodel();
                result = objproduct1.FileImportdata(objmodel);
                if (result.Length == 3)
                {
                    user.TranFldName = result[0];
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
                return result;
            }
        }
        public string[] InsFiles_details(FileImport_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            FileImport_model user = new FileImport_model();
            try
            {
                FileImport_datamodel objproduct1 = new FileImport_datamodel();
                result = objproduct1.InsFiles_details(objmodel);
                if (result.Length == 3)
                {

                    user.file_gid = result[0];
                    user.msg = result[1];
                    user.result = Convert.ToInt32(result[2]);

                }
                else
                {
                    user.file_gid = "0";
                    user.result = 0;
                    user.msg = "Process Failed";
                }

                return result;
            }
            catch (Exception ex)
            {
                string control = "FileImport Services";
                LogHelper.WriteLog(ex.ToString(), control);

                return result;
            }
        }

        public string[] infiletransfer(FileImport_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            FileImport_model user = new FileImport_model();
            try
            {
                FileImport_datamodel objproduct1 = new FileImport_datamodel();
                result = objproduct1.Infile_transfer(objmodel);
                if (result.Length == 3)
                {
                    user.file_gid = result[0];
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
                return result;
            }
        }


        public string[] InsertFileTransfer_update(FileImport_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            FileImport_model user = new FileImport_model();
            try
            {
                FileImport_datamodel objproduct1 = new FileImport_datamodel();
                result = objproduct1.InsertFileTransfer_update(objmodel);
                if (result.Length == 3)
                {
                    user.file_gid = result[0];
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
                return result;
            }
        }

        public string[] InsJob_details(Job_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Job_model user = new Job_model();
            try
            {
                FileImport_datamodel objproduct1 = new FileImport_datamodel();
                result = objproduct1.InsJob_details(objmodel);
                if (result.Length == 3)
                {
                    user.Job_gid = Convert.ToInt64(result[0].ToString());
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
                return result;
            }
        }
        public static FileImport_model InsTranFile_details(FileImport_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            FileImport_model user = new FileImport_model();
            try
            {
                FileImport_datamodel objproduct1 = new FileImport_datamodel();
                result = objproduct1.InsTranFiles(objmodel);
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

        public static FileImport_model GetMaxEndPosition(FileImport_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            FileImport_model user = new FileImport_model();
            try
            {
                FileImport_datamodel objproduct1 = new FileImport_datamodel();
                result = objproduct1.GetMaxTextField(objmodel);
                if (result.Length == 1)
                {
                    user.result = Convert.ToInt32(result[0]);                   
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

        public static FileImport_model InsBalanceFile_details(FileImport_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            FileImport_model user = new FileImport_model();
            try
            {
                FileImport_datamodel objproduct1 = new FileImport_datamodel();
                result = objproduct1.InsBalFile(objmodel);
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
        public static FileImport_model InsSupportFile_details(FileImport_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            FileImport_model user = new FileImport_model();
            try
            {
                FileImport_datamodel objproduct1 = new FileImport_datamodel();
                result = objproduct1.InsSupportFiles(objmodel);
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
        public static string[] Importerrorline(FileImport_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            AcMaster_model user = new AcMaster_model();
            try
            {                
                FileImport_datamodel objproduct1 = new FileImport_datamodel();
                result = objproduct1.errorline(objmodel.LineNo,  Convert.ToInt32(objmodel.file_gid), objmodel.error_line);
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
        public static string[] Movetemptotran(FileImport_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            AcMaster_model user = new AcMaster_model();
            try
            {
                FileImport_datamodel objproduct1 = new FileImport_datamodel();
                result = objproduct1.Movetemptotran(Convert.ToInt32(objmodel.file_gid));
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
        public static string[] Movetemptotranbrkp(FileImport_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            AcMaster_model user = new AcMaster_model();
            try
            {
                FileImport_datamodel objproduct1 = new FileImport_datamodel();
                result = objproduct1.Movetemptotranbrkp(Convert.ToInt32(objmodel.file_gid),Convert.ToInt32(objmodel.recon_gid),Convert.ToInt32(objmodel.tranbrkptype_gid));
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

        public static DataTable FileTemplatefromtype(FileImport_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                FileImport_datamodel objproduct = new FileImport_datamodel();
                ds = objproduct.FileTemplatefromtype(objmodel);
            }
            catch (Exception e)
            {

            }
            return ds;
        }
    
    }
}
