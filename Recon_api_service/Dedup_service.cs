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
    public class Dedup_service
    {
        public static DataTable DedupList(Dedup_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                Dedup_datamodel objproduct = new Dedup_datamodel();
                ds = objproduct.DedupList(objmodel);
            }
            catch (Exception e)
            { 
            }
            return ds;
        }
        public static DataTable DbAliasDrop(Dedup_model objmodel)
        {
            DataTable ds = new DataTable();
            try
            {
                Dedup_datamodel objproduct = new Dedup_datamodel();
                ds = objproduct.DbAliasDrop(objmodel);
            }
            catch (Exception e)
            { 
            }
            return ds;
        }
        public static string[] Dedupcreate(Dedup_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Dedup_model user = new Dedup_model();
            try
            {
                Dedup_datamodel objproduct1 = new Dedup_datamodel();
                result = objproduct1.Dedupcreate(objmodel);
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
        public static string[] DedupGridCreate(Dedup_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Dedup_model user = new Dedup_model();
            try
            {
                Dedup_datamodel objproduct1 = new Dedup_datamodel();
                result = objproduct1.DedupGridCreate(objmodel);
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
        public static DataTable DedupgridList(Dedup_model objmodel2)
        {
            DataTable ds = new DataTable();
            try
            {
                Dedup_datamodel objproduct = new Dedup_datamodel();
                ds = objproduct.DedupgridList(objmodel2);
            }
            catch (Exception e)
            { 
            
            }
            return ds;
        }
        public static Dedup_model Fieldtype(Dedup_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Dedup_model user = new Dedup_model();
            try
            {
                Dedup_datamodel objproduct1 = new Dedup_datamodel();
                result = objproduct1.Fieldtype(objmodel);
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
        public static DataTable certiaDrop(Dedup_model objmodel1)
        {
            DataTable ds = new DataTable();
            try
            {
                Dedup_datamodel objproduct1 = new Dedup_datamodel();
                ds = objproduct1.certiaDrop(objmodel1);
            }
            catch (Exception e)
            { 
            }
            return ds;
        }
        public static DataTable Dedupgrid_listEdit(Dedup_model objmodel1)
        {
            DataTable ds = new DataTable();
            try
            {
                Dedup_datamodel objproduct1 = new Dedup_datamodel();
                ds = objproduct1.Dedupgrid_listEdit(objmodel1);
            }
            catch (Exception e)
            { 
            }
            return ds;
        }
        public static string[] DedupUpdate(Dedup_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Dedup_model user = new Dedup_model();
            try
            {
                Dedup_datamodel objproduct1 = new Dedup_datamodel();
                result = objproduct1.DedupUpdate(objmodel);
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
        public static string[] DedupGridupdate(Dedup_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            Dedup_model user = new Dedup_model();
            try
            {
                Dedup_datamodel objproduct1 = new Dedup_datamodel();
                result = objproduct1.DedupGridupdate(objmodel);
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

    }
}
