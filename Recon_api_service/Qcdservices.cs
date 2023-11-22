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
    public class QcdMaster_Service
    {
        public static DataTable QcdMasterRead(Qcdmodel ObjModel)
        {
            DataTable dt = new DataTable();
            try
            {
                QcdMaster_datamodel objproduct = new QcdMaster_datamodel();
                dt = objproduct.QcdModeldataRead(ObjModel);
            }
            catch (Exception e)
            {

            }
            return dt;

        }

        public static DataTable QcdMasterGridRead(Qcdmodel ObjModel)
        {
            DataTable dt = new DataTable();
            try
            {
                QcdMaster_datamodel objproduct = new QcdMaster_datamodel();
                dt = objproduct.QcdModeldataGridRead(ObjModel);
            }
            catch (Exception e)
            {

            }
            return dt;

        }

        public static DataTable QcdFile_select(Qcdmodel ObjModel)
        {
            DataTable dt = new DataTable();
            try
            {
                QcdMaster_datamodel objproduct = new QcdMaster_datamodel();
                dt = objproduct.QcdFile_select(ObjModel);
            }
            catch (Exception e)
            {

            }
            return dt;

        }

        public static string[] Qcdmaster_Create(Qcdmodel objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Qcdmodel user = new Qcdmodel();
            try
            {
                QcdMaster_datamodel objproduct1 = new QcdMaster_datamodel();
                result = objproduct1.Qcdmaster_Create(objmodel);
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

        public static string[] Qcdmaster_Delete(Qcdmodel objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Qcdmodel user = new Qcdmodel();
            try
            {
                QcdMaster_datamodel objproduct1 = new QcdMaster_datamodel();
                result = objproduct1.Qcdmaster_Delete(objmodel);
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
        public static string[] QcdFile(Qcdmodel objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Qcdmodel user = new Qcdmodel();
            try
            {
                QcdMaster_datamodel objproduct1 = new QcdMaster_datamodel();
                result = objproduct1.QcdFile(objmodel);
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

        //public static DataTable Qcdmastercreate(Qcdmodel objmodel)
        //{
        //    DataTable ds = new DataTable();
        //    try
        //    {
        //        QcdMaster_datamodel objproduct = new QcdMaster_datamodel();
        //        ds = objproduct.Qcdmaster_create(objmodel);
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    return ds;
        //}


       
        


    }
}
