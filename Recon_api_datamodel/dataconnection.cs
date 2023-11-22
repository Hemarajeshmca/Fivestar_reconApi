using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using Recon_api_model;
using System.Data.Odbc;

namespace Recon_api_datamodel
{
    public class dataconnection
    {

        public OdbcConnection con;
        private OdbcCommand cmd;      
        public dataconnection(Login_model Objmodel)
        {
            var dbsource = Objmodel.datasource.ToString();
            var con = new OdbcConnection();
            if (dbsource == "MYSQL")
            {
                con.ConnectionString =ConfigurationManager.AppSettings["ConnectionString"].ToString();                
                con.Open();
                cmd = new OdbcCommand();
                cmd.Connection = con;              
            }
            else
            {
                con.ConnectionString =ConfigurationManager.AppSettings["ConnectionString1"].ToString();
                con.Open();
                cmd.Connection = con;
            }  
        }
        public dataconnection(string dbsource)
        {         
            var con = new OdbcConnection();
            if (dbsource == "MYSQL")
            {
                con.ConnectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();
                con.Open();
                cmd = new OdbcCommand();
                cmd.Connection = con;             
               
            }
            else
            {
                con.ConnectionString = ConfigurationManager.AppSettings["ConnectionString1"].ToString();
                con.Open();
                cmd.Connection = con;
                  con = new OdbcConnection();
                cmd = new OdbcCommand();
                cmd.Connection = con;
            }
        }
     
       

        public DataSet RunDataSetProc(string command, Dictionary<string, Object> values = null)
        {
            DataSet temp = new DataSet();
            cmd.CommandText = command;
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                foreach (string key in values.Keys)
                {
                    cmd.Parameters.AddWithValue(key, values[key]);
                }
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(temp);
                return temp;
            }
            catch (Exception ex)
            {
                return temp;

            }
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
                //cmd = new OdbcCommand(command,con);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(temp);
                return temp;
            }
            catch (Exception ex)
            {
                return temp;

            }

        }
        public string[] RunDmlProc(string command, Dictionary<string, Object> values = null)
        {
            int rowsChanged = 0;
            cmd.CommandText = command;
            cmd.CommandType = CommandType.StoredProcedure;
            OdbcDataAdapter adp = new OdbcDataAdapter();
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
                            //cmd.Parameters.Add(key, MySqlDbType.VarChar);
                            //cmd.Parameters[key].Direction = ParameterDirection.Output;
                            cmd.Parameters.Add(key, OdbcType.VarChar, 20).Direction = ParameterDirection.Output;
                            //
                        } if (values[key] == "out1")
                        {
                            cmd.Parameters.Add(key, OdbcType.Int).Direction = ParameterDirection.Output;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(key, values[key]);
                        }
                    }
                }

                rowsChanged=cmd.ExecuteNonQuery();              
                retmsg = cmd.Parameters[0].Value.ToString();
                retresult = cmd.Parameters[1].Value.ToString();
                
                string[] returnvalues = { retmsg, retresult };
                con.Close();
                return returnvalues;
            }
            catch (Exception ex)
            {
                string[] returnvalues = { };
                return returnvalues;

            }

        }


       
    }
}
