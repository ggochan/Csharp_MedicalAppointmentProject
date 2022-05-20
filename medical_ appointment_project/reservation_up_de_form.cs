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
namespace medical__appointment_project
{
    public partial class reservation_up_de_form : Form
    {
        //db setting
        private OracleConnection conn;
        private OracleCommand cmd;
        private OracleDataAdapter oda;
        private DataSet ds;
        private string strConn = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = ghcoracle))); User Id=ghc;Password=1234;";
        private string select_text = "";
        private string selected_list_str = "";
        private string phone = "";
        private string datetime = "";
        private string id = "";
        public reservation_up_de_form(string sId)
        {
            InitializeComponent();
            id = sId;
            reservation_list(sId);
        }
        private void db_connection()
        {
            conn = new OracleConnection(strConn);
            cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
        } // db connect
        private string select_db1(string select_type, string select_value)
        {
            string data = "";
            try
            {
                db_connection();
                select_text = "select " + select_type + " \n"
                                   + "from reservation_tb \n"
                                   + "where reservation_id = " + select_value ;
                ds = new DataSet();
                ds.Clear();
                oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand(select_text, conn);
                oda.Fill(ds);
                data = ds.Tables[0].Rows[0][0].ToString();
                conn.Close();
            }
            catch (Exception e) {}
            if (data == null){return "0"; }
            return data;
        } // data select 
        private string select_db2(string select_value,string select_value2)
        {
            string data = "";
            try
            {
                db_connection();
                select_text = "SELECT d.dep_name \n"
                                   + "from medical_department_tb d, reservation_tb r \n"
                                   + "where r.fk_dep_id = d.dep_id and r.fk_user_id = '" + select_value+"' and reservation_id = "+select_value2;
                ds = new DataSet();
                ds.Clear();
                oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand(select_text, conn);
                oda.Fill(ds);
                data = ds.Tables[0].Rows[0][0].ToString();
                conn.Close();
            }
            catch (Exception e){}if (data == null) {  return "0"; }
            return data;
        } // data select 

        private string reservation_list(string reid)
        {
            string data = "";
           
                db_connection();
                select_text = "SELECT r.reservation_name,m.dep_name,r.reservation_date,r.reservation_id \n"
                    + "FROM reservation_tb r \n"
                    + ",medical_department_tb m \n"
                    + "WHERE m.dep_id = r.fk_dep_id \n"
                    + "AND fk_user_id = '" + reid +"'";
                ds = new DataSet();
                ds.Clear();
                oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand(select_text, conn);
                oda.Fill(ds);
                sel_listview.BeginUpdate();
                sel_listview.Clear();
                sel_listview.Columns.Add("성명", 60);
                sel_listview.Columns.Add("진료과", 90);
                sel_listview.Columns.Add("진료시간", 120);
                sel_listview.Columns.Add("", 20);
            ListViewItem liv;
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    liv = new ListViewItem(ds.Tables[0].Rows[i][0].ToString());
                    for (int j = 1; j < ds.Tables[0].Columns.Count; j++)
                    {
                        liv.SubItems.Add(ds.Tables[0].Rows[i][j].ToString());
                    }
                    sel_listview.Items.Add(liv);
                }
                sel_listview.EndUpdate();
                conn.Close();
           
            return data;
        } // up_de_listview selected event

        private void sel_listview_MouseClick(object sender, MouseEventArgs e)
        {
            ListView.SelectedListViewItemCollection items = sel_listview.SelectedItems;
            ListViewItem lviitem = items[0];
            selected_list_str = lviitem.SubItems[3].Text;
            sel_name.Text = select_db1("reservation_name",selected_list_str);
            phone = select_db1("reservation_phone", selected_list_str);
            sel_phone1.Text = phone.Substring(0,3);
            sel_phone2.Text = phone.Substring(3, 4);
            sel_phone3.Text = phone.Substring(7, 4);
            sel_front.Text = select_db1("reservation_front", selected_list_str); 
            sel_sex.Text = select_db1("reservation_sex", selected_list_str); 
            sel_dep.Text = select_db2(id,selected_list_str); 
            sel_doc.Text = select_db1("reservation_doctor", selected_list_str);
            sel_datetime.Text = select_db1("reservation_date", selected_list_str);
            datetime += sel_datetime.Text.Substring(0, 4);
            datetime += "년 ";
            datetime += sel_datetime.Text.Substring(4, 2);
            datetime += "월 ";
            datetime += sel_datetime.Text.Substring(6, 2);
            datetime += "일 ";
            datetime += sel_datetime.Text.Substring(8, 2);
            datetime += "시 ";
            datetime += sel_datetime.Text.Substring(10, 2);
            datetime += "분 ";
            sel_datetime.Text = datetime;
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("예약을 취소하겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                delete_db_query(selected_list_str);
                MessageBox.Show("취소되었습니다.");
                reservation_list(id);
                sel_name.Text = "";
                sel_phone1.Text = "";
                sel_phone2.Text = "";
                sel_phone3.Text = "";
                sel_front.Text = "";
                sel_sex.Text = "";
                sel_dep.Text = "";
                sel_doc.Text = "";
                sel_datetime.Text = "";
            }
        }
        private void delete_db_query(string lo_id)
        {
            string delete_text = "delete from reservation_tb where reservation_id= '" + lo_id + "'";
            try
            {
                conn = new OracleConnection(strConn);
                cmd = new OracleCommand(delete_text);
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("탈퇴실패");
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            reservation_form reform = new reservation_form(id, 1);
            reform.ShowDialog();
            reform.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }
    }
}
