using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Text.RegularExpressions;

namespace medical__appointment_project
{
    public partial class doctor_detail_form : Form
    {
        //db setting
        private OracleConnection conn;
        private OracleCommand cmd;
        private OracleDataAdapter oda;
        private DataSet ds;
        private string strConn = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = ghcoracle))); User Id=ghc;Password=1234;";
        private string select_text = "";
        private Color color;
        private Font font;
        public doctor_detail_form(string dId)
        {
            color = new Color();
            color = Color.FromArgb(65, 113, 156);
            font = new Font("맑은고딕", 11, FontStyle.Bold);
            string str_default = "";
            string str_add = "";
            InitializeComponent();
            detail_name.Text = Select_db1("doc_name", dId);
            detail_dep.Text = Select_db1("doc_department", dId);
            detail_email.Text = Select_db1("doc_email", dId);
            str_default = Select_db1("doc_phone", dId);
            str_add += str_default.Substring(0, 3);
            str_add += " - ";
            str_add += str_default.Substring(3, 4);
            str_add += " - ";
            str_add += str_default.Substring(7, 4);
            detail_phone.Text = str_add;
            MatchCollection matches1 = Regex.Matches(Select_db1("doc_career", dId), ",");
            Label[] la1 = new Label[matches1.Count + 1];
            string[] sp_str1 = Select_db1("doc_career", dId).Split(',');
            for (int i = 0; i < matches1.Count + 1; i++)
            {
                int j = i + 1;
                la1[i] = new Label();
                la1[i].Location = new System.Drawing.Point(62, 295 + 25 * j);
                la1[i].Size = new System.Drawing.Size(200, 20);
                la1[i].ForeColor = color;
                la1[i].Font = font;
                la1[i].Name = "la" + i;
                la1[i].Text = sp_str1[i].TrimStart().TrimEnd();
                this.Controls.Add(la1[i]);
            }
            MatchCollection matches2 = Regex.Matches(Select_db1("doc_activity", dId), ",");
            Label[] la2 = new Label[matches2.Count + 1];
            string[] sp_str2 = Select_db1("doc_activity", dId).Split(',');
            for (int i = 0; i < matches2.Count + 1; i++)
            {
                int j = i + 1;
                la1[i] = new Label();
                la1[i].Location = new System.Drawing.Point(62, 455 + 25 * j);
                la1[i].Size = new System.Drawing.Size(200, 20);
                la1[i].ForeColor = color;
                la1[i].Font = font;
                la1[i].Name = "la" + i;
                la1[i].Text = sp_str2[i].TrimStart().TrimEnd();
                this.Controls.Add(la1[i]);
            }
        }
        private string Select_db1(string select_type, string select_value)
        {
            string data = "";
            try
            {
                db_connection();
                select_text = "select " + select_type + "\n"
                                   + "from doctor_tb \n"
                                   + "where doc_id = " + select_value + "";
                ds = new DataSet();
                ds.Clear();
                oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand(select_text, conn);
                oda.Fill(ds);
                data = ds.Tables[0].Rows[0][0].ToString();
                conn.Close();
            }
            catch (Exception e)
            {

            }
            if (data == null)
            {
                return "0";
            }
            else
            {
                return data;
            }
        }
        private void db_connection()
        {
            conn = new OracleConnection(strConn);
            cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
        } // db connect
    }
}
