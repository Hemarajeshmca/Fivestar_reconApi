using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using Recon.Controllers;

namespace Recon_api_datamodel
{
    public class MSQLCON
    {

        private MySqlConnection con;
        private MySqlCommand cmd;
        private string ip_address;
        private string user_code;
        MySqlTransaction myTrans;

        public MSQLCON(string _ip_address,string _user_code)
        {
            con = new MySqlConnection(ConfigurationManager.AppSettings["ConnectionString"].ToString());
            cmd = new MySqlCommand();
            cmd.CommandTimeout = 0;
            cmd.Connection = con;
            ip_address = _ip_address;
            user_code = _user_code;
        }
       
        public MSQLCON(string dbsource)
        {
            con = new MySqlConnection();
            cmd = new MySqlCommand();
            cmd.CommandTimeout = 0;
            cmd.Connection = con;
        }

        public DataTable RunDataSetProcnew(string command, Dictionary<string, Object> values = null)
        {
            DataTable temp = new DataTable();
            cmd.CommandText = command;
            cmd.CommandType = CommandType.StoredProcedure;
            string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
            string source_name = this.GetType().ToString();
            string retmsg = string.Empty;
            string retresult = string.Empty;
            try
            {
                if (values != null)
                {
                    foreach (string key in values.Keys)
                    {
                        if (values[key] == "out")
                        {
                            cmd.Parameters.Add(key, MySqlDbType.VarChar);
                            cmd.Parameters[key].Direction = ParameterDirection.Output;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(key, values[key]);
                        }
                    }
                }
                try
                {
                    myTrans = con.BeginTransaction();
                    cmd.Transaction = myTrans;
                }
                catch (Exception er) {
                    con.Open();
                    myTrans = con.BeginTransaction();
                    cmd.Transaction = myTrans;
                }
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(temp);
                myTrans.Commit();
                retmsg = (string)cmd.Parameters["out_msg"].Value;
                retresult = (string)cmd.Parameters["out_result"].Value;
               // return temp;
            }
            catch (Exception ex)
            {
                myTrans.Rollback();
                string error = ex.ToString();
                con.Open();
                errorlog(user_code, ip_address, method_name, error, source_name);
                cmd.Parameters.Clear();
                cmd.Dispose();
              //  return temp;
            }
            finally {
                con.Close(); 
            }
            return temp; 
        }

        public DataSet RunDataSetProcDash(string command, Dictionary<string, Object> values = null)
        {
            DataSet temp = new DataSet();
            cmd.CommandText = command;
            //cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.StoredProcedure;
            string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
            string source_name = this.GetType().ToString();
            string retmsg = string.Empty;
            string retresult = string.Empty;
            Recon.Controllers.LogHelper.WriteLog("con beforeopen", "Loginrunmethod");
            con.Close();
            Recon.Controllers.LogHelper.WriteLog("con open", "Loginrunmethod");
            try
            {

                if (values != null)
                {

                    foreach (string key in values.Keys)
                    {

                        if (values[key] == "out")
                        {
                            cmd.Parameters.Add(key, MySqlDbType.VarChar);
                            cmd.Parameters[key].Direction = ParameterDirection.Output;

                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(key, values[key]);
                        }
                    }
                }
                con.Open();
                myTrans = con.BeginTransaction();
                cmd.Transaction = myTrans;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(temp);
                //retmsg = (string)cmd.Parameters["out_msg"].Value;
                //retresult = (string)cmd.Parameters["out_result"].Value;
                cmd.Parameters.Clear();
                cmd.Dispose();
                myTrans.Commit();
                // con.Close();
                //  return temp;
            }
            catch (Exception ex)
            {
                myTrans.Rollback();
                string error = ex.ToString();
                errorlog(user_code, ip_address, method_name, error, source_name);
                cmd.Parameters.Clear();
                cmd.Dispose();
                //  return temp;

            }
            finally
            {
                con.Close();
            }
            return temp;
        }

        public DataTable RunDataSetProc(string command, Dictionary<string, Object> values = null)
           {
            DataTable temp = new DataTable();
            cmd.CommandText = command;
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.StoredProcedure;
            string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
            string source_name = this.GetType().ToString();
            string retmsg = string.Empty;
            string retresult = string.Empty;
            Recon.Controllers.LogHelper.WriteLog("con beforeopen", "Loginrunmethod");
            con.Close();
            Recon.Controllers.LogHelper.WriteLog("con open", "Loginrunmethod");
            try
            {
                Recon.Controllers.LogHelper.WriteLog("con open_1", "Loginrunmethod");

                if (values != null)
                {
                    Recon.Controllers.LogHelper.WriteLog("con open_2", "Loginrunmethod");
                    foreach (string key in values.Keys)
                    {
                        Recon.Controllers.LogHelper.WriteLog("con open_3 "  + key, " Loginrunmethod");
                        if (values[key] == "out")
                        {
                            cmd.Parameters.Add(key, MySqlDbType.VarChar);
                            cmd.Parameters[key].Direction = ParameterDirection.Output;

                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(key, values[key]);
                        }
                    }
                }
                 con.Open();
                myTrans = con.BeginTransaction();
                cmd.Transaction = myTrans;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(temp);
                //retmsg = (string)cmd.Parameters["out_msg"].Value;
                //retresult = (string)cmd.Parameters["out_result"].Value;
                cmd.Parameters.Clear();
                cmd.Dispose();
                myTrans.Commit();
               // con.Close();
              //  return temp;
            }
            catch (Exception ex)
            {
                Recon.Controllers.LogHelper.WriteLog("catchMSQLCON" + ex.InnerException.ToString(), "MSQLCON");
                myTrans.Rollback();
                string error = ex.ToString();
                errorlog(user_code, ip_address, method_name, error, source_name);
                cmd.Parameters.Clear();
                cmd.Dispose();
              //  return temp;

            }
            finally {
                con.Close();
            }
            return temp;
        }
        
        public DataTable RunProc(string command, Dictionary<string, Object> values = null)
        {
            DataTable temp = new DataTable();
            cmd.CommandText = command;
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                if (values != null)
                {
                    foreach (string key in values.Keys)
                    {
                        cmd.Parameters.AddWithValue(key, values[key]);
                    }
                }

                try
                {
                    myTrans = con.BeginTransaction();
                    cmd.Transaction = myTrans;
                }
                catch (Exception er)
                {
                    con.Open();
                    myTrans = con.BeginTransaction();
                    cmd.Transaction = myTrans;
                }
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(temp);
                myTrans.Commit();
               // return temp;
            }
            catch (Exception ex)
            {
                myTrans.Rollback();
                string error = ex.ToString();
              //  errorlog(user_code, ip_address, method_name, error, source_name);
                cmd.Parameters.Clear();
                cmd.Dispose();

            }
            finally {
                con.Close();
            }
            return temp;

        }
        public string[] RunDmlProcMultiple(string command, Dictionary<string, Object> values = null)
        {
            int rowsChanged = 0;
            cmd.CommandText = command;
            cmd.CommandType = CommandType.StoredProcedure;

            string retmsg = string.Empty;
            string retresult = string.Empty;
            string tranfield = string.Empty;
            string[] outreturnvalues = {};

            try
            {

                if (values != null)
                {

                    foreach (string key in values.Keys)
                    {

                        if (values[key] == "out")
                        {
                            cmd.Parameters.Add(key, MySqlDbType.VarChar);
                            cmd.Parameters[key].Direction = ParameterDirection.Output;

                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(key, values[key]);
                        }
                    }
                }
                con.Open();
                myTrans = con.BeginTransaction();
                cmd.Transaction = myTrans;
                rowsChanged = cmd.ExecuteNonQuery();
                myTrans.Commit();
                tranfield = (string)cmd.Parameters["out_field_name"].Value;
                retmsg = (string)cmd.Parameters["out_msg"].Value;
                retresult = (string)cmd.Parameters["out_result"].Value;
                string[] returnvalues = { tranfield, retmsg, retresult };
                outreturnvalues = returnvalues;
            }
            catch (Exception ex)
            {
                myTrans.Rollback();
                string[] returnvalues = { };
                outreturnvalues = returnvalues;
            }
            finally {
                con.Close();
            }
            return outreturnvalues;
        }

   
        public string[] RunDmlProc_FileConvert(string command, Dictionary<string, Object> values = null)
        {
            int rowsChanged = 0;
            cmd.CommandText = command;
            cmd.CommandType = CommandType.StoredProcedure;
            string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
            string source_name = this.GetType().ToString();

            string retmsg = string.Empty;
            string retresult = string.Empty;

            try
            {

                if (values != null)
                {

                    foreach (string key in values.Keys)
                    {

                        if (values[key] == "out")
                        {
                            cmd.Parameters.Add(key, MySqlDbType.VarChar);
                            cmd.Parameters[key].Direction = ParameterDirection.Output;


                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(key, values[key]);

                        }
                    }
                }
                string control = "RunDmlProc_FileConvert";
                LogHelper.WriteLog("connopen", control);
                con.Open();
               string control1 = "RunDmlProc_FileConvert";
               LogHelper.WriteLog("connclose", control1);
                myTrans = con.BeginTransaction();
                cmd.Transaction = myTrans;
                rowsChanged = cmd.ExecuteNonQuery();
                myTrans.Commit();
                retmsg = (string)cmd.Parameters["out_msg"].Value;
                retresult = (string)cmd.Parameters["out_result"].Value;
                string[] returnvalues = { retmsg, retresult };
                return returnvalues;
            }

            catch (Exception ex)
            {
                string control = "RunDmlProc_FileConvert";
                LogHelper.WriteLog(ex.ToString(), control);
                myTrans.Rollback();
                string error = ex.ToString();
                errorlog(user_code, ip_address, method_name, error, source_name);
                string[] returnvalues = { "failed", "0" };
                return returnvalues;

            }
            finally
            {
                con.Close();
            }

        }


        
       
        public string[] RunDmlProc(string command, Dictionary<string, Object> values = null)
        {
            int rowsChanged = 0;
            cmd.CommandText = command;
            cmd.CommandType = CommandType.StoredProcedure;
            string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
            string source_name = this.GetType().ToString();  
            string retmsg = string.Empty;
            string retresult = string.Empty;
            
            try
            {

                if (values != null)
                {

                    foreach (string key in values.Keys)
                    {

                        if (values[key] == "out")
                        {
                            cmd.Parameters.Add(key, MySqlDbType.VarChar);
                            cmd.Parameters[key].Direction = ParameterDirection.Output;
                        }
                        else
                        {
                            if (values[key] == null)
                            {
                                cmd.Parameters.AddWithValue(key, null);
                            }
                            else if (values[key].ToString() != "null")
                            {
                                cmd.Parameters.AddWithValue(key, values[key]);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue(key, null);
                            }
                        }
                    }
                }
                con.Open();
                myTrans = con.BeginTransaction();
                cmd.Transaction = myTrans;
                rowsChanged = cmd.ExecuteNonQuery();
                 myTrans.Commit();
                retmsg = (string)cmd.Parameters["out_msg"].Value;
                retresult = (string)cmd.Parameters["out_result"].Value;
                string[] returnvalues = { retmsg, retresult };
                return returnvalues;
            }
            catch (Exception ex)
            {
                myTrans.Rollback();
                string error = ex.ToString();
                errorlog(user_code, ip_address, method_name, error, source_name);
                string[] returnvalues = { "failed", "0" };
                return returnvalues;
            }
            finally {
                con.Close();
            }
        }

        public string[] RunDmlProcload(string command, Dictionary<string, Object> values = null)
        {
            int rowsChanged = 0;
            cmd.CommandText = command;
            cmd.CommandType = CommandType.StoredProcedure;
            string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
            string source_name = this.GetType().ToString();
            string retmsg = string.Empty;
            string retresult = string.Empty;
            string reccount = string.Empty;

            try
            {

                if (values != null)
                {

                    foreach (string key in values.Keys)
                    {

                        if (values[key] == "out")
                        {
                            cmd.Parameters.Add(key, MySqlDbType.VarChar);
                            cmd.Parameters[key].Direction = ParameterDirection.Output;
                        }
                        else
                        {
                            if (values[key] == null)
                            {
                                cmd.Parameters.AddWithValue(key, null);
                            }
                            else if (values[key].ToString() != "null")
                            {
                                cmd.Parameters.AddWithValue(key, values[key]);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue(key, null);
                            }
                        }
                    }
                }
                con.Open();
                myTrans = con.BeginTransaction();
                cmd.Transaction = myTrans;
                rowsChanged = cmd.ExecuteNonQuery();
                myTrans.Commit();
                reccount = (string)cmd.Parameters["out_rec_count"].Value;
                retmsg = (string)cmd.Parameters["out_msg"].Value;
                retresult = (string)cmd.Parameters["out_result"].Value;
                string[] returnvalues = { retmsg, retresult,reccount };
                return returnvalues;
            }
            catch (Exception ex)
            {
                myTrans.Rollback();
                string error = ex.ToString();
                errorlog(user_code, ip_address, method_name, error, source_name);
                string[] returnvalues = { "failed", "0" };
                return returnvalues;
            }
            finally
            {
                con.Close();
            }
        }


        public string[] RunDmlProcNew(string command, Dictionary<string, Object> values = null)
        {
            int rowsChanged = 0;
            cmd.CommandText = command;
            cmd.CommandType = CommandType.StoredProcedure;
            string retmsg = string.Empty;
            string retresult = string.Empty;
            string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
            string source_name = this.GetType().ToString();
            List<string> outfield = new List<string>();
            List<string> outresult = new List<string>();
            string outvalue;
            try
            {
                if (values != null)
                {
                    foreach (string key in values.Keys)
                    {
                        if (values[key] == "out")
                        {
                            cmd.Parameters.Add(key, MySqlDbType.VarChar);
                            cmd.Parameters[key].Direction = ParameterDirection.Output;
                            outfield.Add(key);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(key, values[key]);
                        }
                    }
                }
                con.Open();
                myTrans = con.BeginTransaction();
                cmd.Transaction = myTrans;
                rowsChanged = cmd.ExecuteNonQuery();
                myTrans.Commit();
                for (int i = 0; i < outfield.Count; i++)
                {
                    outvalue = (string)cmd.Parameters[outfield[i]].Value;
                    outresult.Add(outvalue);
                }
                return outresult.ToArray();
                //return returnvalues;
            }

            catch (Exception ex)
            {
                myTrans.Rollback();
                string error = ex.ToString();
                errorlog(user_code, ip_address, method_name, error, source_name);
                string[] returnvalues = { "failed", "0" };
                return returnvalues;
            }
            finally {
                con.Close();
            }

        }
        public string[] Runfieldtype(string command, Dictionary<string, Object> values = null)
        {
            int rowsChanged = 0;
            cmd.CommandText = command;
            cmd.CommandType = CommandType.StoredProcedure;
            string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
            string source_name = this.GetType().ToString();
            string retmsg = string.Empty;
            string retresult = string.Empty;
            try
            {
                if (values != null)
                {
                    foreach (string key in values.Keys)
                    {
                        if (values[key] == "out")
                        {
                            cmd.Parameters.Add(key, MySqlDbType.VarChar);
                            cmd.Parameters[key].Direction = ParameterDirection.Output;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(key, values[key]);
                        }
                    }
                }
                con.Open();
                myTrans = con.BeginTransaction();
                cmd.Transaction = myTrans;
                rowsChanged = cmd.ExecuteNonQuery();
                myTrans.Commit();
                retmsg = (string)cmd.Parameters["out_field_type"].Value;
                retresult = "0";
                string[] returnvalues = { retmsg, retresult };
                return returnvalues;
            }
            catch (Exception ex)
            {
                myTrans.Rollback();
                string error = ex.ToString();
                errorlog(user_code, ip_address, method_name, error, source_name);
                string[] returnvalues = { "failed", "0" };
                return returnvalues;
            }
            finally
            {
                con.Close();
            }
        }

        public string[] RunDmlProcFileInsdetails(string command, Dictionary<string, Object> values = null)
        {
            int rowsChanged = 0;
            cmd.CommandText = command;
            cmd.CommandType = CommandType.StoredProcedure;

            string retmsg = string.Empty;
            string retresult = string.Empty;
            string tranfield = string.Empty;
            string[] Out_values = { };
            //List<string> Out_values = new List<string>();

            try
            {
                if (values != null)
                {
                    foreach (string key in values.Keys)
                    {
                        if (values[key] == "out")
                        {
                            //Out_values.Add(key);
                            cmd.Parameters.Add(key, MySqlDbType.VarChar);
                            cmd.Parameters[key].Direction = ParameterDirection.Output;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(key, values[key]);
                        }
                    }
                }
                con.Open();
                myTrans = con.BeginTransaction();
                cmd.Transaction = myTrans;
                rowsChanged = cmd.ExecuteNonQuery();
                myTrans.Commit();
                tranfield = (string)cmd.Parameters["in_file_gid"].Value;
                retmsg = (string)cmd.Parameters["out_msg"].Value;
                retresult = (string)cmd.Parameters["out_result"].Value;
                string[] returnvalues = { tranfield, retmsg, retresult };
                return returnvalues;
            }
            catch (Exception ex)
            {
                myTrans.Rollback();
                string error = ex.ToString();
                string[] returnvalues = { error, command };
                return returnvalues;
            }
            finally
            {
                con.Close();
            }

        }

        public string[] RunDmlProcFileInsimpo(string command, Dictionary<string, Object> values = null)
        {
            int rowsChanged = 0;
            cmd.CommandText = command;
            cmd.CommandType = CommandType.StoredProcedure;

            string retmsg = string.Empty;
            string retresult = string.Empty;
            string tranfield = string.Empty;
            string[] Out_values = { };
            //List<string> Out_values = new List<string>();

            try
            {
                if (values != null)
                {
                    foreach (string key in values.Keys)
                    {
                        if (values[key] == "out")
                        {
                            //Out_values.Add(key);
                            cmd.Parameters.Add(key, MySqlDbType.VarChar);
                            cmd.Parameters[key].Direction = ParameterDirection.Output;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(key, values[key]);
                        }
                    }
                }
                con.Open();
                myTrans = con.BeginTransaction();
                cmd.Transaction = myTrans;
                rowsChanged = cmd.ExecuteNonQuery();
                myTrans.Commit();
                tranfield = (string)cmd.Parameters["out_file_gid"].Value;
                retmsg = (string)cmd.Parameters["out_msg"].Value;
                retresult = (string)cmd.Parameters["out_result"].Value;
                string[] returnvalues = { tranfield, retmsg, retresult };
                return returnvalues;
            }
            catch (Exception ex)
            {
                myTrans.Rollback();
                string error = ex.ToString();
                string[] returnvalues = { error, command };
                return returnvalues;
            }
            finally
            {
                con.Close();
            }

        }
        public string[] RunDmlProcFileIns(string command, Dictionary<string, Object> values = null)
        {
            int rowsChanged = 0;
            cmd.CommandText = command;
            cmd.CommandType = CommandType.StoredProcedure;

            string retmsg = string.Empty;
            string retresult = string.Empty;
            string tranfield = string.Empty;
            string[] Out_values = { };
            //List<string> Out_values = new List<string>();

            try
            {
                if (values != null)
                {
                    foreach (string key in values.Keys)
                    {
                        if (values[key] == "out")
                        {
                            //Out_values.Add(key);
                            cmd.Parameters.Add(key, MySqlDbType.VarChar);
                            cmd.Parameters[key].Direction = ParameterDirection.Output;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(key, values[key]);
                        }
                    }
                }
                con.Open();
                myTrans = con.BeginTransaction();
                cmd.Transaction = myTrans;
                rowsChanged = cmd.ExecuteNonQuery();
                myTrans.Commit();
                tranfield = (string)cmd.Parameters["out_job_gid"].Value;
                retmsg = (string)cmd.Parameters["out_msg"].Value;
                retresult = (string)cmd.Parameters["out_result"].Value;
                string[] returnvalues = { tranfield, retmsg, retresult };
                return returnvalues;
            }
            catch (Exception ex)
            {
                myTrans.Rollback();
                string error = ex.ToString();
                string[] returnvalues = { error, command };
                return returnvalues;
            }
            finally {
                con.Close();
            }

        }
        public string[] errorlog(string user_code, string ip_address, string method_name, string error, string source_name)
        {    
            string retmsg = string.Empty;
            string retresult = string.Empty;
            try
            {

                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand("pr_ins_errorlog", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("in_user_code", MySqlDbType.VarChar).Value = user_code;
                cmd.Parameters.Add("in_ip_addr", MySqlDbType.VarChar).Value = ip_address;
                cmd.Parameters.Add("in_source_name", MySqlDbType.VarChar).Value = source_name;
                cmd.Parameters.Add("in_proc_name", MySqlDbType.VarChar).Value = method_name;
                cmd.Parameters.Add("in_errorlog_text", MySqlDbType.VarChar).Value = error;
                cmd.Parameters.Add("out_msg", MySqlDbType.VarChar).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("out_result", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                myTrans = con.BeginTransaction();
                cmd.Transaction = myTrans;
                cmd.ExecuteNonQuery();
                myTrans.Commit();
                string str = cmd.Parameters["out_msg"].Value.ToString();
                string[] returnvalues = { "failed", "0" };
                return returnvalues;
            }
            catch (Exception e)
            {
                myTrans.Rollback();
                string[] returnvalues = { "failed", "0" };
                return returnvalues;
            }
            finally {
                con.Close();
            }
            //return str;
        }
    }

}

