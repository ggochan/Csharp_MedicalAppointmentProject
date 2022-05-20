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
    public partial class membership_form : Form
    {
        private bool information_event = false; // 동의여부
        private bool pwd_view_event = true; // * 글자 변경 이벤트
        private bool id_check_event = false; // id 중복체크 이벤트
        private bool email_check_event = false; // email 중복체크 이벤트
        private bool name_check_event = false; // name 한글 체크 이벤트
        //DB setting
        private OracleConnection conn;
        private OracleCommand cmd;
        private OracleDataAdapter oda;
        private DataSet ds;
        private string strConn = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = ghcoracle))); User Id=ghc;Password=1234;";
        private string select_text = ""; // select query
        private string insert_text = ""; // insert query
        //membership_from setting
        private int check=0;
        private string login_id = "";
        private string login_values = "";
        private string email_check = "";
        private string mem_str = ""; // overlab search
        private Color priColor; // color 
        //primary str_setting
        private string id = "";
        private string password = "";
        private string name = "";
        private string email = "";
        private string front = "";
        private int sex = 0;
        private string phone = "";
        private string home_num = "";
        private string email_inco = "0";
        private string phone_inco = "0";
        //message
        private string message_check = "";
        public membership_form(string sId, int form_check_num)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            priColor = new Color();
            priColor = Color.FromArgb(44, 125, 179);
            check = form_check_num;
            login_id = sId;
            if (check == 1)
            {
                call_login_data();
            }
        }
        private void call_login_data()
        {
            try
            {
                login_values = select_db_reservation_infor(login_id);
                string[] sp_str = login_values.Split(',');
                tb_member_id.Text = sp_str[0];
                tb_member_name.Text = sp_str[1];
                tb_member_pwd.Text = tb_member_pwdend.Text = sp_str[2];
                tb_member_front.Text = sp_str[3];
                tb_member_sex.Text = sp_str[4];
                tb_member_email.Text = email_check =sp_str[5];
                tb_member_phonenum1.Text = sp_str[6].Substring(0, 3);
                tb_member_phonenum2.Text = sp_str[6].Substring(3, 4);
                tb_member_phonenum3.Text = sp_str[6].Substring(7, 4);
                if (sp_str[7] != "0")
                {
                    tb_member_housenum1.Text = sp_str[7].Substring(0, 3);
                    tb_member_housenum2.Text = sp_str[7].Substring(3, 4);
                    tb_member_housenum3.Text = sp_str[7].Substring(7, 4);
                }
                else
                {
                    tb_member_housenum1.Text = tb_member_housenum2.Text = tb_member_housenum3.Text = "";
                }
                mem_update_btn.Visible = true;
                mem_update_cancle_btn.Visible = true;
                mem_delete_btn.Visible = true;
                tb_member_id.Enabled = false;
                pa_information.Visible = false;
                mem_completion_btn.Visible = false;
                mem_cancel_btn.Visible = false;
                id_overlap_btn.Visible = false;
                id_la.Visible = false;
                if (tb_member_pwd.Text == tb_member_pwdend.Text)
                {
     
                    la_pwdend_check.Text = "";
                }
                email_la.ForeColor = priColor;
                email_la.Text = "";
                //user_id,user_name,user_password,user_frontnum,user_sex,user_email,user_phone,user_home_num,user_email_inco,user_phone_inco
            }
            catch (Exception ex) { }
        }
        private void mem_completion_btn_Click(object sender, EventArgs e)
        {
            if (id_check_event == true) {   id = tb_member_id.Text; } //id 입력
            else { message_check += "중복확인을 해주세요.\n"; }
            if (tb_member_pwd.TextLength >= 8 && tb_member_pwdend.TextLength >= 8){password = tb_member_pwd.Text; } //password
            else {message_check += "비밀번호 양식에 맞게 입력해주세요.\n"; } //password end
            char[] charArr = tb_member_name.Text.ToCharArray();//name
            foreach (char c in charArr)
            {
                if(char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.OtherLetter) { name_check_event = true;}
                else{ name_check_event = false; break; }
            }
            if(name_check_event == true){name = tb_member_name.Text;}
            else
            {
                message_check += "한글만 입력해주세요.";
            }
            email = tb_member_email.Text; //email
            front = tb_member_front.Text; //front
            sex = Int32.Parse(tb_member_sex.Text); //sex
            phone = tb_member_phonenum1.Text + tb_member_phonenum2.Text + tb_member_phonenum3.Text; //phone
            if (phone.Length == 10 || phone.Length == 11)
            {
                Regex phone_regex = new Regex(@"01{1}[016789]{1}[0-9]{7,8}");
                Match phone_match = phone_regex.Match(phone);
                if (!phone_match.Success)
                {
                    message_check += "휴대전화번호가 아닙니다\n";
                    phone = null;}
            }
            home_num = tb_member_housenum1.Text + tb_member_housenum2.Text + tb_member_housenum3.Text; //home_num
            if (home_num == ""){home_num = "0"; }
            //email_inco,phone_inco radio event check
            if(message_check == "")
            {
                string str1 = "";
                if (home_num == "0")
                    str1 = "집전화 없음";
                else
                    str1 = home_num;
                string str2 = "";
                    if (email_inco == "0")
                        str2 = "이메일 거부";
                    else if (email_inco == "1")
                        str2 = "이메일 동의";
                string str3 = "";
                    if (phone_inco == "0")
                        str3 = "SNS 거부";
                    else if (phone_inco == "1")
                        str3 = "SNS 동의";
                if (MessageBox.Show("입력하신 정보가 맞습니까?\n" + id + "\n" + password + "\n" + name + "\n" + email  + "\n" + phone + "\n" + str1 + "\n" + str2 + "\n" + str3, "회원가입 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    insert_db_query(id, name, password, email, phone, email_inco, phone_inco, home_num, front, sex);
                    MessageBox.Show("회원가입완료!");
                    this.Close();
                }
            }
            else if(message_check != "") {  MessageBox.Show(message_check); }
            message_check = "";
        }

        private void mem_cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void information_true_btn_Click(object sender, EventArgs e)
        {
            if (information_event == true)
            {
                pa_information.Visible = false;
                tb_member_id.Focus();
            }
            else if (information_event == false)
            {
                MessageBox.Show("동의를 하셔야 회원가입이 가능합니다.");
            }
        } // true button insert query

        private void information_false_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        } // close button

        private void ra_information_true_CheckedChanged(object sender, EventArgs e)
        {
            information_event = true;
        } // check true

        private void ra_information_false_CheckedChanged(object sender, EventArgs e)
        {
            information_event = false;
        } // check false
        private void pwd_view_btn_Click(object sender, EventArgs e)
        {
            if(pwd_view_event == false)
            {
                pwd_view_event = true;
                tb_member_pwd.PasswordChar = '*';
                tb_member_pwdend.PasswordChar = '*';
            }
            else if (pwd_view_event == true)
            {
                pwd_view_event = false;
                tb_member_pwd.PasswordChar = '\0';
                tb_member_pwdend.PasswordChar = '\0';
            }
        }
        private void id_overlap_btn_Click(object sender, EventArgs e)
        {
            mem_str = select_db_check("user_id", tb_member_id.Text);
            if(mem_str != tb_member_id.Text)
            {
                id_la.ForeColor = priColor;
                id_la.Text = "사용가능한 아이디입니다.";
                tb_member_pwd.Focus();
                id_check_event = true;
            }
            else
            {
                id_la.ForeColor = Color.Red;
                id_la.Text = "중복된 아이디입니다.";
                tb_member_id.Focus();
                id_check_event = false;
            }
        }
        private void email_overlap_btn_Click(object sender, EventArgs e)
        {
            mem_str = select_db_check("user_email", tb_member_email.Text);

            string check_email = tb_member_email.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(check_email);
            if (match.Success)
            {
                if (mem_str != tb_member_email.Text)
                {
                    priColor = new Color();
                    priColor = Color.FromArgb(44, 125, 179);
                    email_la.ForeColor = priColor;
                    email_la.Text = "사용가능한 이메일입니다.";
                    email_check_event = true;
                }
                else
                {
                    if (check == 1 && mem_str == tb_member_email.Text)
                    {
                        priColor = new Color();
                        priColor = Color.FromArgb(44, 125, 179);
                        email_la.ForeColor = priColor;
                        email_la.Text = "본인이 사용중인 이메일";
                        email_check_event = true;
                    }
                    else
                    {
                        email_la.ForeColor = Color.Red;
                        email_la.Text = "중복된 이메일입니다.";
                        email_check_event = false;
                    }
                }
            }
            else
            {
                email_la.Text = "이메일형식이 틀렸습니다.";
            }
           
        }
        private void tb_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        } // 숫자만 입력받기

        private void tb_english_num_Leave(object sender, EventArgs e)
        {
            Regex idregex = new Regex(@"[a-zA-Z][0-9]"); 
            Boolean ismatch = idregex.IsMatch(tb_member_id.Text);
        }// 영어+숫자만
        private void tb_english_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && e.KeyChar != 8) //영어
            {
                if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8) //숫자
                {
                    e.Handled = true;
                }
            }
        }// 한글 막기 ImeMode = Disable로 바꾸기

        private void tb_korea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsPunctuation(e.KeyChar) || Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar) || Char.IsSymbol(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }//한글만
        private void radio_member_email_CheckedChanged(object sender, EventArgs e)
        {
            email_inco = "1";
            phone_inco = "0";
        }
        private void radio_member_sms_CheckedChanged(object sender, EventArgs e)
        {
            email_inco = "0";
            phone_inco = "1";
        }
        private void radio_member_false_CheckedChanged(object sender, EventArgs e)
        {
            email_inco = "0";
            phone_inco = "0";
        }
        private void tb_member_pwdend_KeyDown(object sender, KeyEventArgs e)
        {
            string member_pwd_check=tb_member_pwd.Text;
            member_pwd_check = member_pwd_check.Substring(0,tb_member_pwd.TextLength);
            if (tb_member_pwd.Text != "" && tb_member_pwdend.Text != "" )
            {      
                if (member_pwd_check == tb_member_pwdend.Text)
                {
                    la_pwdend_check.ForeColor = priColor;
                    la_pwdend_check.Text = "일치";
                }
                else if(tb_member_pwd.TextLength < 7 && tb_member_pwdend.TextLength < 7)
                {
                    la_pwdend_check.ForeColor = Color.Red;
                    la_pwdend_check.Text = "형식 불일치";
                }
                else
                {
                    la_pwdend_check.ForeColor = Color.Red;
                    la_pwdend_check.Text = "불일치";
                }
                if (e.KeyCode == Keys.Enter && la_pwdend_check.Text =="일치")
                {
                    e.Handled = true;
                    Control control = GetNextControl(sender as Control, true);
                    if (control != null)
                    {
                        control.Focus();
                    }
                }
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
        private string select_db_check(string select_type, string select_value)
        {
            string data = "";
            try
            {
                db_connection();
                select_text = "select " + select_type + " \n"
                                   + "from USER_TB \n"
                                   + "where " + select_type + " = '" + select_value + "'";
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
            return data;
        } // select default
        private void insert_db_query(string id, string name ,string pwd, string email, string phone, string email_inco, string sns_inco, string hone_num, string front, int sex)
        {
            insert_text = "INSERT INTO USER_TB VALUES ('"+id+"','"+name+"','" + pwd+ "','"+email+ "','" + phone +"','" 
                + email_inco +"','"+ sns_inco +"','" + home_num+ "','"+ front+"',"+sex+")";
            
                conn = new OracleConnection(strConn);
                cmd = new OracleCommand(insert_text);
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            
        }

        private void tb_member_front_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private string select_db_reservation_infor(string select_value)
        {
            string data = "";
            try
            {
                db_connection();
                select_text = "SELECT user_id,user_name,user_password,user_frontnum,user_sex,user_email,user_phone,user_home_num,user_email_inco,user_phone_inco \n"
                                   + "FROM USER_TB \n"
                                   + "WHERE user_id = '" + select_value + "'";
                ds = new DataSet();
                ds.Clear();
                oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand(select_text, conn);
                oda.Fill(ds);
                for (short i = 0; i < 10; i++)
                {
                    data += ds.Tables[0].Rows[0][i].ToString();
                    if (i == 9)
                        break;
                    data += ",";
                }
                conn.Close();
            }
            catch (Exception e) { MessageBox.Show("전송실패"); }
            if (data == null) { return "0"; }
            return data;
        } // data information select

        private void tb_member_email_KeyDown(object sender, KeyEventArgs e)
        {
            if(tb_member_email.Text == email_check)
            {
                email_la.ForeColor = priColor;
                email_la.Text = "";
            }
            email_la.ForeColor = Color.Red;
            email_la.Text = "중복확인을 해주세요.";
        }
        private void delete_db_query(string lo_id)
        {
            string delete_text = "delete from user_tb where user_id = '"+lo_id+"'";
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
        private void mem_delete_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_db_query(login_id);
            login_id = "";
            MessageBox.Show("회원탈퇴가 완료되었습니다.");
            main_form mainform = new main_form(login_id);
            mainform.ShowDialog();
            this.Close();

        } // 회원탈퇴

        private void mem_update_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("회원수정 후 다시 로그인 해야합니다. \n회원수정을 완료하시겠습니까?", "회원수정", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                delete_db_query(login_id);
                phone = tb_member_phonenum1.Text + tb_member_phonenum2.Text + tb_member_phonenum3.Text;
                home_num = tb_member_housenum1.Text + tb_member_housenum2.Text + tb_member_housenum3.Text;
                if (home_num == "")
                {
                    home_num = "0";
                }
                insert_db_query(tb_member_id.Text, tb_member_name.Text, tb_member_pwd.Text, tb_member_email.Text, phone, email_inco, phone_inco, home_num, tb_member_front.Text, Int32.Parse(tb_member_sex.Text));
                login_id = "";
                MessageBox.Show("수정되었습니다. \n다시 로그인 해주세요.");
                this.Hide();
                main_form mainform = new main_form(login_id);
                mainform.ShowDialog();
                this.Close();
            }
        } // 회원수정

        private void mem_update_cancle_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_form mainform = new main_form(login_id);
            mainform.ShowDialog();
            this.Close();
        } // 돌아가기
    }
}
