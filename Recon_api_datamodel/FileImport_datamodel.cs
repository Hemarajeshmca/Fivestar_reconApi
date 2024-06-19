using Recon.Controllers;
using Recon_api_model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon_api_datamodel
{
    public class FileImport_datamodel
    {

        //FileTemplatefromtype
        public DataTable FileImportList(FileImport_model objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_filetemplate_gid", 0);
                values.Add("in_active_status", "");
                result = con.RunDataSetProc("pr_get_filetemplate", values);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        public DataTable GetReconType(FileImport_model objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_recon_type", "S");
                values.Add("in_active_status", "Y");
                result = con.RunDataSetProc("pr_get_reconbytype", values);
                return result;

            }
            catch (Exception ex)
            {
                return result;
            }
        }
        public DataTable GetSupportingFile(FileImport_model objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_tranbrkptype_gid", 0);
                values.Add("in_active_status", "Y");
                result = con.RunDataSetProc("pr_get_tranbrkptype", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }
        public DataTable GetReconAccNoList(FileImport_model objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_recon_gid", objmodel.recon_gid);
                result = con.RunDataSetProc("pr_get_reconacc", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                con.errorlog(objmodel.ip_address, objmodel.user_code, method_name, error, source_name);
                return result;
            }
        }

        public string[] FileImportdata(FileImport_model Fileimpmodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Fileimpmodel.ip_address, Fileimpmodel.user_code);

                values.Add("in_filetemplate_gid", Fileimpmodel.Template_id);
                values.Add("in_excel_field", Fileimpmodel.ExFieldName);
                values.Add("out_field_name", "out");
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProcMultiple("pr_get_excelfield", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Fileimpmodel.ip_address, Fileimpmodel.user_code);
                con.errorlog(Fileimpmodel.ip_address, Fileimpmodel.user_code, method_name, error, source_name);
                return result;
            }
        }

        public DataTable GetdbTemplateField(FileImport_model Fileimpmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Fileimpmodel.ip_address, Fileimpmodel.user_code);
                values.Add("in_filetemplate_gid", Fileimpmodel.Template_id);
                values.Add("in_filetemplatefield_gid", 0);
                values.Add("in_active_status", "Y");
                result = con.RunDataSetProc("pr_get_filetemplatefield", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Fileimpmodel.ip_address, Fileimpmodel.user_code);
                con.errorlog(Fileimpmodel.ip_address, Fileimpmodel.user_code, method_name, error, source_name);
                return result;
            }

        }
        public string[] GetMaxTextField(FileImport_model Fileimpmodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(Fileimpmodel.ip_address, Fileimpmodel.user_code);
                values.Add("in_filetemplate_gid", Fileimpmodel.Template_id);               
                values.Add("out_max_txt_endposition", "out");
                result = con.RunDmlProcNew("pr_get_maxtxtendposition", values);
                return result;

            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(Fileimpmodel.ip_address, Fileimpmodel.user_code);
                con.errorlog(Fileimpmodel.ip_address, Fileimpmodel.user_code, method_name, error, source_name);
                return result;
            }
        }

        public string[] InsFiles_details(FileImport_model FileImpmodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(FileImpmodel.ip_address, FileImpmodel.user_code);

                values.Add("in_file_name", FileImpmodel.FileName);
                values.Add("in_file_type", FileImpmodel.FileType);
                values.Add("in_filetemplate_gid", FileImpmodel.filetemplate_gid);
                values.Add("in_csv_columns", FileImpmodel.Csv_Columns);
                values.Add("in_acno", FileImpmodel.acc_no);
                values.Add("in_action_by", FileImpmodel.Actionby);
                values.Add("in_recon_gid", FileImpmodel.recon_gid);
                values.Add("in_tranbrkptype_gid", FileImpmodel.tranbrkptype_gid);
                values.Add("out_file_gid", "out");
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProcFileInsimpo("pr_ins_file", values);

                
                
                return result;
            }
            catch (Exception ex)
            {
                string control = "FileImport dataModel";
                LogHelper.WriteLog(ex.ToString(), control);

                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(FileImpmodel.ip_address, FileImpmodel.user_code);
                con.errorlog(FileImpmodel.ip_address, FileImpmodel.user_code, method_name, error, source_name);
                return result;
            }
        }


        public string[] Infile_transfer(FileImport_model FileImpmodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(FileImpmodel.ip_address, FileImpmodel.user_code);

                values.Add("in_file_gid", FileImpmodel.file_gid);
                values.Add("out_msg","out");
                values.Add("out_result","out");

                result = con.RunDmlProcFileInsdetails("pr_set_bcptransfer", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(FileImpmodel.ip_address, FileImpmodel.user_code);
                con.errorlog(FileImpmodel.ip_address, FileImpmodel.user_code, method_name, error, source_name);
                return result;
            }
        }

        public string[] InsertFileTransfer_update(FileImport_model FileImpmodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(FileImpmodel.ip_address, FileImpmodel.user_code);

                values.Add("in_file_gid", FileImpmodel.file_gid);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");

                result = con.RunDmlProcFileInsdetails("pr_set_tran_updafile", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(FileImpmodel.ip_address, FileImpmodel.user_code);
                con.errorlog(FileImpmodel.ip_address, FileImpmodel.user_code, method_name, error, source_name);
                return result;
            }
        }


        public string[] InsJob_details(Job_model objmodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.Job_ip_addr, objmodel.Job_initiated_by);

                values.Add("in_job_type", objmodel.Job_type);
                values.Add("in_job_ref_gid", objmodel.Job_ref_gid);
                values.Add("in_job_name", objmodel.Job_name);
                values.Add("in_job_initiated_by", objmodel.Job_initiated_by);
                values.Add("in_ip_addr", objmodel.Job_ip_addr);
                values.Add("in_job_status", objmodel.Job_status);
                values.Add("in_job_remark", objmodel.Job_remark);
                values.Add("out_job_gid", "out");
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProcFileIns("pr_ins_job", values);
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(objmodel.Job_ip_addr, objmodel.Job_initiated_by);
                con.errorlog(objmodel.Job_ip_addr, objmodel.Job_initiated_by, method_name, error, source_name);
                return result;
            }
        }

        public string[] InsTranFiles(FileImport_model FileImpmodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(FileImpmodel.ip_address, FileImpmodel.user_code);
                if (!string.IsNullOrEmpty(FileImpmodel.acc_mode))
                {
                    FileImpmodel.acc_mode = FileImpmodel.acc_mode.Substring(1, 1).ToUpper();
                }


                if (!string.IsNullOrEmpty(FileImpmodel.amount_reverse_signed))
                {
                    if (Convert.ToDecimal(FileImpmodel.amount_reverse_signed) != 0)
                    {
                        FileImpmodel.amount_signed = (Convert.ToDecimal(FileImpmodel.amount_reverse_signed) * -1).ToString();
                    }
                }

                if (string.IsNullOrEmpty(FileImpmodel.amount_signed))
                {
                    if (Convert.ToDecimal(FileImpmodel.amount_debit) > 0)
                    {

                        FileImpmodel.amount = FileImpmodel.amount_debit;
                        FileImpmodel.acc_mode = "D";
                    }
                    else if (Convert.ToDecimal(FileImpmodel.amount_credit) > 0)
                    {
                        FileImpmodel.amount = FileImpmodel.amount_credit;
                        FileImpmodel.acc_mode = "C";
                    }
                }
                else
                {
                    if (Convert.ToDecimal(FileImpmodel.amount_signed) != 0)
                    {
                        if (Convert.ToDecimal(FileImpmodel.amount_signed) > 0)
                        {
                            FileImpmodel.amount = FileImpmodel.amount_signed;
                            FileImpmodel.acc_mode = "C";
                        }
                        else
                        {
                            Double amt_dbt = Convert.ToDouble(FileImpmodel.amount_signed);
                            amt_dbt = amt_dbt * -1;
                            FileImpmodel.amount = amt_dbt.ToString("0.00");
                            //FileImpmodel.amount = Math.Abs(Convert.ToDecimal(FileImpmodel.amount_signed)).ToString();
                            FileImpmodel.acc_mode = "D";
                        }
                    }
                }

                // balance amount validation
                FileImpmodel.balance_flag = false;
                if (!string.IsNullOrEmpty(FileImpmodel.bal_amount))
                {
                    switch (FileImpmodel.bal_amount_acc_mode.Substring(1, 1))
                    {
                        case "C":
                            FileImpmodel.balance_flag = true;
                            break;
                        case "D":
                            FileImpmodel.balance_flag = true;
                            FileImpmodel.bal_amount = (Convert.ToDecimal(FileImpmodel.bal_amount) * -1).ToString();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(FileImpmodel.bal_amount_reverse_signed))
                    {
                        FileImpmodel.bal_amount_signed = (Convert.ToDecimal(FileImpmodel.bal_amount_reverse_signed) * -1).ToString();
                    }

                    if (!string.IsNullOrEmpty(FileImpmodel.bal_amount_signed))
                    {
                        FileImpmodel.bal_amount = FileImpmodel.bal_amount_signed;
                        FileImpmodel.balance_flag = true;
                    }
                }

                values.Add("in_file_gid", FileImpmodel.file_gid);
                values.Add("in_acc_no", FileImpmodel.acc_no);
                values.Add("in_tran_date", FileImpmodel.tran_date);
                values.Add("in_value_date", FileImpmodel.value_date);
                values.Add("in_tran_desc", FileImpmodel.tran_desc);
                values.Add("in_tran_amount", FileImpmodel.amount);
                values.Add("in_acc_mode", FileImpmodel.acc_mode);
                values.Add("in_ref_col1", FileImpmodel.ref_col1);
                values.Add("in_ref_col2", FileImpmodel.ref_col2);
                values.Add("in_ref_col3", FileImpmodel.ref_col3);
                values.Add("in_ref_col4", FileImpmodel.ref_col4);
                values.Add("in_ref_col5", FileImpmodel.ref_col5);
                values.Add("in_ref_col6", FileImpmodel.ref_col6);
                values.Add("in_ref_col7", FileImpmodel.ref_col7);
                values.Add("in_ref_col8", FileImpmodel.ref_col8);
                values.Add("in_ref_col9", FileImpmodel.ref_col9);
                values.Add("in_ref_col10", FileImpmodel.ref_col10);
                values.Add("in_ref_col11", FileImpmodel.ref_col11);
                values.Add("in_ref_col12", FileImpmodel.ref_col12);
                values.Add("in_ref_col13", FileImpmodel.ref_col13);
                values.Add("in_ref_col14", FileImpmodel.ref_col14);
                values.Add("in_ref_col15", FileImpmodel.ref_col15);
                values.Add("in_ref_col16", FileImpmodel.ref_col16);
                values.Add("in_ref_col17", FileImpmodel.ref_col17);
                values.Add("in_ref_col18", FileImpmodel.ref_col18);
                values.Add("in_ref_col19", FileImpmodel.ref_col19);
                values.Add("in_ref_col20", FileImpmodel.ref_col20);
                values.Add("in_ref_col21", FileImpmodel.ref_col21);
                values.Add("in_ref_col22", FileImpmodel.ref_col22);
                values.Add("in_ref_col23", FileImpmodel.ref_col23);
                values.Add("in_ref_col24", FileImpmodel.ref_col24);
                values.Add("in_ref_col25", FileImpmodel.ref_col25);
                values.Add("in_ref_col26", FileImpmodel.ref_col26);
                values.Add("in_ref_col27", FileImpmodel.ref_col27);
                values.Add("in_ref_col28", FileImpmodel.ref_col28);
                values.Add("in_ref_col29", FileImpmodel.ref_col29);
                values.Add("in_ref_col30", FileImpmodel.ref_col30);
                values.Add("in_ref_col31", FileImpmodel.ref_col31);
                values.Add("in_ref_col32", FileImpmodel.ref_col32);
                values.Add("in_balance_flag", FileImpmodel.balance_flag);
                values.Add("in_balance_amount", FileImpmodel.bal_amount);
                values.Add("in_dedup_flag", FileImpmodel.debug_flag);

                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_ins_tran", values);
                if (result[1] == "0")
                {
                    errorline(FileImpmodel.LineNo, Convert.ToInt32(FileImpmodel.file_gid), result[0]);
                }
                return result;
               
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(FileImpmodel.ip_address, FileImpmodel.user_code);
                con.errorlog(FileImpmodel.ip_address, FileImpmodel.user_code, method_name, error, source_name);
                return result;
            }
        }

        public string[] InsBalFile(FileImport_model FileImpmodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(FileImpmodel.ip_address, FileImpmodel.user_code);
                /*
                if (string.IsNullOrEmpty(FileImpmodel.amount_signed))
                {
                    if (Convert.ToDecimal(FileImpmodel.amount_debit) > 0)
                    {

                        FileImpmodel.amount = FileImpmodel.amount_debit;
                        FileImpmodel.acc_mode = "D";
                    }
                    else if (Convert.ToDecimal(FileImpmodel.amount_credit) > 0)
                    {
                        FileImpmodel.amount = FileImpmodel.amount_credit;
                        FileImpmodel.acc_mode = "C";
                    }
                }
                else
                {
                    if (Convert.ToDecimal(FileImpmodel.amount_signed) != 0)
                    {
                        if (Convert.ToDecimal(FileImpmodel.amount_signed) > 0)
                        {
                            FileImpmodel.amount = FileImpmodel.amount_signed;
                            FileImpmodel.acc_mode = "C";
                        }
                        else
                        {
                            Double amt_dbt = Convert.ToDouble(FileImpmodel.amount_signed);
                            //amt_dbt = amt_dbt * -1;
                            FileImpmodel.amount = amt_dbt.ToString("0.00");
                            FileImpmodel.acc_mode = "D";
                        }
                    }
                }
                */

                if (!string.IsNullOrEmpty(FileImpmodel.bal_amount))
                {
                    switch (FileImpmodel.bal_amount_acc_mode.Substring(1, 1))
                    {
                        case "C":
                            break;
                        case "D":
                            FileImpmodel.bal_amount = (Convert.ToDecimal(FileImpmodel.bal_amount) * -1).ToString();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(FileImpmodel.bal_amount_reverse_signed))
                    {
                        FileImpmodel.bal_amount_signed = (Convert.ToDecimal(FileImpmodel.bal_amount_reverse_signed) * -1).ToString();
                    }

                    if (!string.IsNullOrEmpty(FileImpmodel.bal_amount_signed))
                    {
                        FileImpmodel.bal_amount = FileImpmodel.bal_amount_signed;
                    }
                }


                values.Add("in_file_gid", FileImpmodel.file_gid);
                values.Add("in_tran_date", FileImpmodel.tran_date);
                values.Add("in_acc_no", FileImpmodel.acc_no);
                values.Add("in_acc_balance", FileImpmodel.bal_amount);

                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_ins_accbal", values);

            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(FileImpmodel.ip_address, FileImpmodel.user_code);
                con.errorlog(FileImpmodel.ip_address, FileImpmodel.user_code, method_name, error, source_name);
                return result;
            }
            return result;
        }
        public string[] InsSupportFiles(FileImport_model FileImpmodel)
        {
            string[] result = { };
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(FileImpmodel.ip_address, FileImpmodel.user_code);

                if (!string.IsNullOrEmpty(FileImpmodel.acc_mode))
                {
                    FileImpmodel.acc_mode = FileImpmodel.acc_mode.Substring(1, 1).ToUpper();
                }

                if (!string.IsNullOrEmpty(FileImpmodel.amount_reverse_signed))
                {
                    if (Convert.ToDecimal(FileImpmodel.amount_reverse_signed) != 0)
                    {
                        FileImpmodel.amount_signed = (Convert.ToDecimal(FileImpmodel.amount_reverse_signed) * -1).ToString();
                    }
                }

                if (string.IsNullOrEmpty(FileImpmodel.amount_signed))
                {
                    if (Convert.ToDecimal(FileImpmodel.amount_debit) > 0)
                    {

                        FileImpmodel.amount = FileImpmodel.amount_debit;
                        FileImpmodel.acc_mode = "D";
                    }
                    else if (Convert.ToDecimal(FileImpmodel.amount_credit) > 0)
                    {
                        FileImpmodel.amount = FileImpmodel.amount_credit;
                        FileImpmodel.acc_mode = "C";
                    }
                }
                else
                {
                    if (Convert.ToDecimal(FileImpmodel.amount_signed) != 0)
                    {
                        if (Convert.ToDecimal(FileImpmodel.amount_signed) > 0)
                        {
                            FileImpmodel.amount = FileImpmodel.amount_signed;
                            FileImpmodel.acc_mode = "C";
                        }
                        else
                        {
                            Double amt_dbt = Convert.ToDouble(FileImpmodel.amount_signed);
                            amt_dbt = amt_dbt * -1;
                            FileImpmodel.amount = amt_dbt.ToString("0.00");
                            //FileImpmodel.amount = Math.Abs(Convert.ToDecimal(FileImpmodel.amount_signed)).ToString();
                            FileImpmodel.acc_mode = "D";
                        }
                    }
                }

                values.Add("in_file_gid", FileImpmodel.file_gid);
                values.Add("in_recon_gid", FileImpmodel.recon_gid);
                values.Add("in_tranbrkptype_gid", FileImpmodel.tranbrkptype_gid);
                values.Add("in_acc_no", FileImpmodel.acc_no);
                values.Add("in_tran_date", FileImpmodel.tran_date);
                values.Add("in_value_date", FileImpmodel.value_date);
                values.Add("in_tran_desc", FileImpmodel.tran_desc);
                values.Add("in_tran_amount", FileImpmodel.amount);
                values.Add("in_acc_mode", FileImpmodel.acc_mode);
                values.Add("in_ref_col1", FileImpmodel.ref_col1);
                values.Add("in_ref_col2", FileImpmodel.ref_col2);
                values.Add("in_ref_col3", FileImpmodel.ref_col3);
                values.Add("in_ref_col4", FileImpmodel.ref_col4);
                values.Add("in_ref_col5", FileImpmodel.ref_col5);
                values.Add("in_ref_col6", FileImpmodel.ref_col6);
                values.Add("in_ref_col7", FileImpmodel.ref_col7);
                values.Add("in_ref_col8", FileImpmodel.ref_col8);
                values.Add("in_ref_col9", FileImpmodel.ref_col9);
                values.Add("in_ref_col10", FileImpmodel.ref_col10);
                values.Add("in_ref_col11", FileImpmodel.ref_col11);
                values.Add("in_ref_col12", FileImpmodel.ref_col12);
                values.Add("in_ref_col13", FileImpmodel.ref_col13);
                values.Add("in_ref_col14", FileImpmodel.ref_col14);
                values.Add("in_ref_col15", FileImpmodel.ref_col15);
                values.Add("in_ref_col16", FileImpmodel.ref_col16);
                values.Add("in_ref_col17", FileImpmodel.ref_col17);
                values.Add("in_ref_col18", FileImpmodel.ref_col18);
                values.Add("in_ref_col19", FileImpmodel.ref_col19);
                values.Add("in_ref_col20", FileImpmodel.ref_col20);
                values.Add("in_ref_col21", FileImpmodel.ref_col21);
                values.Add("in_ref_col22", FileImpmodel.ref_col22);
                values.Add("in_ref_col23", FileImpmodel.ref_col23);
                values.Add("in_ref_col24", FileImpmodel.ref_col24);
                values.Add("in_ref_col25", FileImpmodel.ref_col25);
                values.Add("in_ref_col26", FileImpmodel.ref_col26);
                values.Add("in_ref_col27", FileImpmodel.ref_col27);
                values.Add("in_ref_col28", FileImpmodel.ref_col28);
                values.Add("in_ref_col29", FileImpmodel.ref_col29);
                values.Add("in_ref_col30", FileImpmodel.ref_col30);
                values.Add("in_ref_col31", FileImpmodel.ref_col31);
                values.Add("in_ref_col32", FileImpmodel.ref_col32);
                values.Add("in_dedup_flag", FileImpmodel.debug_flag);

                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProc("pr_ins_tranbrkp", values);
                return result;

            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(FileImpmodel.ip_address, FileImpmodel.user_code);
                con.errorlog(FileImpmodel.ip_address, FileImpmodel.user_code, method_name, error, source_name);
                return result;
            }
        }
        public string[] errorline(int lineno,int filegid,string errorline)
        {
            string[] result = { };
            string ip = "";
            string user_code = "";
            try
            {               
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(ip, user_code);

                values.Add("in_file_gid", filegid);
                values.Add("in_errline_no", lineno);
                values.Add("in_errline_desc", errorline);
                result = con.RunDmlProcNew("pr_ins_errline", values);
                string[] result1 = { "failed", "0" };
                return result1;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(ip, user_code);
                con.errorlog(ip, user_code, method_name, error, source_name);
                return result;
            }
        }
        public string[] Movetemptotran(int filegid)
        {
            string[] result = { };
            string ip = "";
            string user_code = "";
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(ip, user_code);

                values.Add("in_file_gid", filegid);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProcNew("pr_run_tran", values);
                //string[] result1 = { "failed", "0" };
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(ip, user_code);
                con.errorlog(ip, user_code, method_name, error, source_name);
                return result;
            }
        }
        public string[] Movetemptotranbrkp(int filegid, int recon_gid, int tranbrkptype_gid)
        {
            string[] result = { };
            string ip = "";
            string user_code = "";
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(ip, user_code);

                values.Add("in_file_gid", filegid);
                values.Add("in_recon_gid", recon_gid);
                values.Add("in_tranbrkptype_gid", tranbrkptype_gid);
                values.Add("out_msg", "out");
                values.Add("out_result", "out");
                result = con.RunDmlProcNew("pr_run_tranbrkp", values);
                //string[] result1 = { "failed", "0" };
                return result;
            }
            catch (Exception ex)
            {
                string method_name = (new StackTrace()).GetFrame(0).GetMethod().Name;
                string source_name = this.GetType().ToString();
                string error = ex.ToString();
                MSQLCON con = new MSQLCON(ip, user_code);
                con.errorlog(ip, user_code, method_name, error, source_name);
                return result;
            }
        }

        public DataTable FileTemplatefromtype(FileImport_model objmodel)
        {
            DataTable result = new DataTable();
            try
            {
                Dictionary<string, Object> values = new Dictionary<string, object>();
                MSQLCON con = new MSQLCON(objmodel.ip_address, objmodel.user_code);
                values.Add("in_file_type", objmodel.FileType);
                values.Add("in_active_status", objmodel.active_status);
                result = con.RunDataSetProc("pr_get_filetemplate_fromtype", values);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

    }
}
