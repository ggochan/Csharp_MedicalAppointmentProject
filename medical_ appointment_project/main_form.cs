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
using System.Diagnostics;

namespace medical__appointment_project
{
    public partial class main_form : Form
    {
        bool login_event = false; // login 여부 확인
        private int form_check_num = 0; // form check
        private string member_up = "0"; // 회원가입 확인여부
        //db setting
        private OracleConnection conn;
        private OracleCommand cmd;
        private OracleDataAdapter oda;
        private DataSet ds;
        private string strConn = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = ghcoracle))); User Id=ghc;Password=1234;";
        private string select_text = "";
        private string up_id = "";
        //string setting
        private string login_id_compare = ""; // id check string
        private string login_pwd_compare = ""; // pwd check string
        private string login_same_check1 = ""; // name number check = id
        private string login_same_check2 = ""; // name number check = pwd
        public main_form(string update_id)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            pa_login_true.Visible = false;
            up_id = update_id;
        }
        private void main_form_Load(object sender, EventArgs e)
        {
            if(up_id != "")
            {
                select_db2(up_id);
                pa_login.Visible = false; // 처음 로그인 화면
                pa_login_true.Visible = true; // 로그인 완료 화면
                login_id_compare = select_db1("user_id", up_id);
                string[] sp_str = login_id_compare.Split(',');
                la_login.Text = sp_str[1] + " 님";
                login_id_compare = up_id;
            }
        }
        private void login_btn_Click(object sender, EventArgs e)
        {
            login_event = true;
            login_id_compare = select_db1("user_id", id_textbox.Text);
            login_pwd_compare = select_db1("user_password", pwd_textbox.Text);
            try
            {
                string[] sp_str = login_id_compare.Split(',');
                login_id_compare = sp_str[0];
                login_same_check1 = sp_str[1];

                string[] sp_str2 = login_pwd_compare.Split(',');
                login_pwd_compare = sp_str2[0];
                login_same_check2 = sp_str2[1];
            }
            catch(Exception ex)
            {
            }
            if (id_textbox.Text == login_id_compare && id_textbox.Text !="")
            {
                if (pwd_textbox.Text == login_pwd_compare && pwd_textbox.Text != "")
                {
                    if (login_same_check1 == login_same_check2)
                    {
                        MessageBox.Show("로그인 완료 \nid = " + login_id_compare +"\npwd = " + login_pwd_compare +"\n체크여부 : 성공");
                        pa_login.Visible = false; // 처음 로그인 화면
                        pa_login_true.Visible = true; // 로그인 완료 화면
                        la_login.Text = login_same_check1 + " 님";
                    }
                    else if(login_same_check1 != login_same_check2)
                    {
                        MessageBox.Show("아이디와 비밀번호가 일치하지 않습니다.");
                    }
                }
                else if(pwd_textbox.Text != login_pwd_compare)
                {
                    MessageBox.Show("비밀번호가 틀렸습니다.");
                }
            }
            else if(id_textbox.Text != login_id_compare)
            {
                MessageBox.Show("일치하는 아이디가 없습니다.");
            }
            else if(id_textbox.Text == "" || pwd_textbox.Text == "")
            {
                MessageBox.Show("입력해주세요.");
            }
        } // login button if && err 

        private void membership_btn_Click(object sender, EventArgs e)
        {
            form_check_num = 0;
            membership_form membershipform = new membership_form(member_up, form_check_num);
            membershipform.Show();
        } // membership_form page move button

        private void reservation_btn_Click(object sender, EventArgs e)
        {
            form_check_num = 0;
            reservation_form reservationform = new reservation_form(login_id_compare, form_check_num);
            reservationform.Show();
        } // reservation_form page move button
        private void db_connection()
        {
            conn = new OracleConnection(strConn);
            cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
        } // db connect
        private string select_db1(string select_type,string select_value)
        {
            string data = "";
            try
            {
                db_connection();
                select_text = "select " + select_type + ",user_name \n"
                                   + "from USER_TB \n"
                                   + "where " + select_type + " = '" + select_value + "'";
                ds = new DataSet();
                ds.Clear();
                oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand(select_text, conn);
                oda.Fill(ds);
                data = ds.Tables[0].Rows[0][0].ToString();
                data += ",";
                data += ds.Tables[0].Rows[0][1].ToString();
                conn.Close();
            }
            catch(Exception e)
            {

            }
            if(data == null)
            {
                return "0";
            }
            return data;
        } // data select 
        private string select_db2(string select_id)
        {
            string data = "";
            try
            {
                db_connection();
                select_text = "select user_id \n"
                                   + "from USER_TB \n"
                                   + "where user_id = '" + select_id + "'";
                ds = new DataSet();
                ds.Clear();
                oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand(select_text, conn);
                oda.Fill(ds);
                data = ds.Tables[0].Rows[0][0].ToString();
                conn.Close();
            }
            catch (Exception e)  { }
            if (data == null){return "0";}
            return data;
        } // data select
        private void pwd_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                login_btn_Click(sender, e);
        } // pwd tb => btn event true

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("로그아웃하시겠습니까??", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pa_login.Visible = true;
                pa_login_true.Visible = false;
                id_textbox.Text = "";
                pwd_textbox.Text = "";
                MessageBox.Show("로그아웃되었습니다");
            }
        } // 로그아웃

        private void member_up_de_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_check_num = 1;
            member_up = id_textbox.Text;
            membership_form membershipform = new membership_form(member_up, form_check_num);
            membershipform.ShowDialog();
            this.Close();
        }// 정보수정

        private void select_btn_Click(object sender, EventArgs e)
        {
            if (up_id == "")
            {
                reservation_up_de_form rudf = new reservation_up_de_form(login_id_compare);
                rudf.ShowDialog();
            }
            else
            {
                reservation_up_de_form rudf = new reservation_up_de_form(up_id);
                rudf.ShowDialog();
            }
        } // 예약조회

        private void b_login_btn_Click(object sender, EventArgs e)
        {
            reservation_form reservationform = new reservation_form("blogin", form_check_num);
            reservationform.Show();
        }
    }
}
