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
    public class ManualMatchOff_service
    {
        public static DataTable ExceptionGrid(ManualMatchOff_model objmodel1)
        {
            DataTable ds = new DataTable();
            ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
            ds = objproduct1.ExceptionGrid(objmodel1);
            return ds;
        }
		
        public static DataTable SupFileExcpSummGrid(ManualMatchOff_model objmodel1)
        {
            DataTable ds = new DataTable();
            ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
            ds = objproduct1.SupFileExcpSummGrid(objmodel1);
            return ds;
        }
		
        public static string[] AddMatchOff(ManualMatchOff_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            ManualMatchOff_model user = new ManualMatchOff_model();
            try
            {
                ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
                result = objproduct1.AddMatchOff(objmodel);
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
        public static DataTable SelectedMatchOff(ManualMatchOff_model objmodel1)
        {
            DataTable ds = new DataTable();
            ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
            ds = objproduct1.SelectedMatchOff(objmodel1);
            return ds;
        }

        public static DataTable SelectedMatchOffgrid(ManualMatchOff_model objmodel1)
        {
            DataTable ds = new DataTable();
            ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
            ds = objproduct1.SelectedMatchOffgrid(objmodel1);
            return ds;
        }

        public static DataTable SelectedMatchOff_gridsec(ManualMatchOff_model objmodel1)
        {
            DataTable ds = new DataTable();
            ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
            ds = objproduct1.SelectedMatchOff_grid(objmodel1);
            return ds;
        }

        public static string[] SelectedMatchOffcreate(ManualMatchOff_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            ManualMatchOff_model user = new ManualMatchOff_model();
            try
            {
                ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
                result = objproduct1.SelectedMatchOffcreate(objmodel);
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
        public static ManualMatchOff_model SelectedMatchOffdel(ManualMatchOff_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            ManualMatchOff_model user = new ManualMatchOff_model();
            try
            {
                ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
                result = objproduct1.SelectedMatchOffdel(objmodel);
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
                throw ex;
            }
        }

        public static string[] ManulaMatchselected(ManualMatchOff_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            ManualMatchOff_model user = new ManualMatchOff_model();
            try
            {
                ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
                result = objproduct1.ManulaMatchsel(objmodel);
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

        public static string[] ManulaMatch_firstload(ManualMatchOff_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            ManualMatchOff_model user = new ManualMatchOff_model();
            try
            {
                ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
                result = objproduct1.ManulaMatch_firstloadser(objmodel);
                if (result.Length == 2)
                {
                    user.result = Convert.ToInt32(result[1]);
                    user.msg = result[0];
                    user.count = Convert.ToInt32(result[2]);
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

        public static string[] RunMatch_file(ManualMatchOff_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            ManualMatchOff_model user = new ManualMatchOff_model();
            try
            {
                ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
                result = objproduct1.RunMatch_file(objmodel);
                if (result.Length == 2)
                {
                    user.result = Convert.ToInt32(result[1]);
                    user.msg = result[0];
                    //user.count = Convert.ToInt32(result[2]);
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

        public static DataTable AmountMatched(ManualMatchOff_model objmodel1)
        {
            DataTable ds = new DataTable();
            ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
            ds = objproduct1.AmountMatched(objmodel1);
            return ds;
        }
        public static DataTable AmountMatchedAll(ManualMatchOff_model objmodel1)
        {
            DataTable ds = new DataTable();
            ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
            ds = objproduct1.AmountMatchedAll(objmodel1);
            return ds;
        }
        public static ManualMatchOff_model AmountMatchedSave(ManualMatchOff_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            ManualMatchOff_model user = new ManualMatchOff_model();
            try
            {
                ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
                result = objproduct1.AmountMatchedSave(objmodel);
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
                throw ex;
            }
        }
        public static DataTable RuleGrid(ManualMatchOff_model objmodel1)
        {
            DataTable ds = new DataTable();
            ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
            ds = objproduct1.RuleGrid(objmodel1);
            return ds;
        }
        public static DataTable GetManualmatch(ManualMatchOff_model objmodel1)
        {
            DataTable ds = new DataTable();
            ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
            ds = objproduct1.GetManualmatch(objmodel1);
            return ds;
        }
        public static string[] RuleMatchOff(ManualMatchOff_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            ManualMatchOff_model user = new ManualMatchOff_model();
            try
            {
                ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
                result = objproduct1.RuleMatchOff(objmodel);
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
        public static string[] RuleMatchOffSelction(ManualMatchOff_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            ManualMatchOff_model user = new ManualMatchOff_model();
            try
            {
                ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
                result = objproduct1.RuleMatchOffSelction(objmodel);
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
        public static DataTable ManualSingleView(ManualMatchOff_model objmodel)
        {
            DataTable ds = new DataTable();
            ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
            ds = objproduct1.ManualSingleView(objmodel);
            return ds;
        }
        public static string[] MatchOffReason(ManualMatchOff_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            ManualMatchOff_model user = new ManualMatchOff_model();
            try
            {
                ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
                result = objproduct1.MatchOffReason(objmodel);
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
        public static DataTable SupFilemappingRead(ManualMatchOff_model objmodel)
        {
            DataTable ds = new DataTable();
            ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
            ds = objproduct1.SupFilemappingRead(objmodel);
            return ds;
        }
        public static string[] SupFilemappingcreate(ManualMatchOff_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            ManualMatchOff_model user = new ManualMatchOff_model();
            try
            {
                ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
                result = objproduct1.SupFilemappingcreate(objmodel);
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
        public static string[] undomatch_off(ManualMatchOff_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            ManualMatchOff_model user = new ManualMatchOff_model();
            try
            {
                ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
                result = objproduct1.undomatch_offmodel(objmodel);
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
        public static string[] SupFilemappingcheck(ManualMatchOff_model objmodel)
        {
            string[] result = { };
            DataTable tab = new DataTable();
            ManualMatchOff_model user = new ManualMatchOff_model();
            try
            {
                ManualMatchOff_datamodel objproduct1 = new ManualMatchOff_datamodel();
                result = objproduct1.SupFilemappingcheck(objmodel);
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
    }
}
