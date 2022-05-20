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
    public partial class reservation_form : Form
    {
        // data move delegate event
        //public delegate void FormSendDataHandler(string sendstring);
        //public event FormSendDataHandler formsendevent;
        private bool infor_all_check = true; // 전체 정보 확인완료
        private int pa3_cnt = 1;
        //db setting
        private string select_text = "";
        private string insert_text = "";
        // reservation_from setting str
        private string primary_id = "";
        private string select_values = "";
        private string phone = ""; // phone number
        private string selected_list_str = "";
        private string selected_doctor_str = "";
        private string selected_doctor_phone_str = "";
        private string date_time = "";
        private string date_time_end = "";
        private OracleConnection conn;
        private OracleCommand cmd;
        private OracleDataAdapter oda;
        private DataSet ds;
        private string strConn = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = orcl))); User Id=ghc;Password=1234;";
        private void db_connection()
        {
            conn = new OracleConnection(strConn);
            cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
        } // db connect
        private string select_db_reservation_infor(string select_value)
        {
            string data = "";
            try
            {
                db_connection();
                select_text = "SELECT user_name,user_phone,user_frontnum,user_sex \n"
                                   + "FROM USER_TB \n"
                                   + "WHERE user_id = '" + select_value + "'";
                ds = new DataSet();
                ds.Clear();
                oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand(select_text, conn);
                oda.Fill(ds);
                for (short i = 0; i < 4; i++)
                {
                    data += ds.Tables[0].Rows[0][i].ToString();
                    if (i == 3)
                        break;
                    data += ",";
                }
                conn.Close();
            }
            catch (Exception e) { MessageBox.Show("전송실패"); }
            if (data == null) { return "0"; }
            return data;
        } // data information select
        public reservation_form(string sId, int form_num)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            dep_list();
            //date and time setting
            timePicker.ShowUpDown = true;
            date_time = datePicker.Value.ToString("yyyyMMdd")+ timePicker.Value.ToString("HHmm");
            date_time_end = datePicker.Value.ToString("yyyy년 MM월 dd일") + timePicker.Value.ToString(" HH시 mm분");
            primary_id = sId;
            if (sId != "blogin") {
                call_login_data();
            }
            if(form_num == 1)
            {
                pa_reservation_part1.Visible = true;
                pa_reservation_part2.Visible = true;
                pa_reservation_part3.Visible = true;
                pa_reservation_part4.Visible = true;
                pa_reservation_part5.Visible = true;
                
            }
        }
        private void call_login_data()
        {
            try
            {
                select_values = select_db_reservation_infor(primary_id);
                string[] sp_str = select_values.Split(',');
                tb_reservation_name.Text = sp_str[0];
                tb_reservation_phonenum1.Text = sp_str[1].Substring(0, 3);
                tb_reservation_phonenum2.Text = sp_str[1].Substring(3, 4);
                tb_reservation_phonenum3.Text = sp_str[1].Substring(7, 4);
                tb_member_front.Text = sp_str[2];
                tb_member_sex.Text = sp_str[3];

            }
            catch (Exception ex) { }
        }
        private void reservation_ok_btn_Click(object sender, EventArgs e)
        {
            if(tb_reservation_name.Text != "")
            {//name
                char[] charArr = tb_reservation_name.Text.ToCharArray();
                foreach (char c in charArr)
                {
                    if (char.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.OtherLetter)
                    {
                        MessageBox.Show("이름은 한글만 입력가능합니다.");
                        infor_all_check = false;
                        break;
                    }
                }
                    if (tb_member_front.Text != "" && infor_all_check == true && tb_member_sex.Text != "")
                    {
                        if(tb_reservation_phonenum1.Text != "" || tb_reservation_phonenum2.Text != "" || tb_reservation_phonenum3.Text != "" && infor_all_check == true)
                        {
                            phone = tb_reservation_phonenum1.Text + tb_reservation_phonenum2.Text + tb_reservation_phonenum3.Text;
                            if (phone.Length == 10 || phone.Length == 11)
                            {
                                Regex phone_regex = new Regex(@"01{1}[016789]{1}[0-9]{7,8}");
                                Match phone_match = phone_regex.Match(phone);
                                if (!phone_match.Success)
                                {
                                    MessageBox.Show("휴대폰 번호 형식에 맞지 않습니다.");
                                    phone = "";
                                }
                                else
                                {
                                        pa_reservation_part2.Visible = true;
                                }// 모든 오류처리 완료
                            }
                      }
                    else{ MessageBox.Show("모두 입력해주세요"); }
                }
                else  { MessageBox.Show("모두 입력해주세요"); }
            }
            else   { MessageBox.Show("모두 입력해주세요"); }
        }
        private void reservation_all_btn_Click(object sender, EventArgs e)
        {
            dep_list();
        } // 리스트 전체
        private void reservation_search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                db_connection();
                select_text = "SELECT dep_name \n"
                            +"FROM medical_department_tb \n"
                            +"WHERE dep_name LIKE '"+ tb_dep_search.Text + "%'";
                ds = new DataSet();
                ds.Clear();
                oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand(select_text, conn);
                oda.Fill(ds);
                listview_dep.BeginUpdate();
                listview_dep.Clear();
                listview_dep.Columns.Add("진료과", 200);
                ListViewItem liv;
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    liv = new ListViewItem(ds.Tables[0].Rows[i][0].ToString());
                    listview_dep.Items.Add(liv);
                }
                listview_dep.EndUpdate();
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        } // 리스트 검색
       
        

        private void dep_list()
        {
            try
            {
                db_connection();
                select_text = "SELECT dep_name FROM medical_department_tb";
                ds = new DataSet();
                ds.Clear();
                oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand(select_text, conn);
                oda.Fill(ds);
                listview_dep.BeginUpdate();
                listview_dep.Clear();
                listview_dep.Columns.Add("진료과", 200);
                ListViewItem liv;
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    liv = new ListViewItem(ds.Tables[0].Rows[i][0].ToString());
                    listview_dep.Items.Add(liv);
                }
                listview_dep.EndUpdate();
                conn.Close();
            }
            catch (Exception e) { MessageBox.Show("리스트 전송실패"); }
        } // dep_listview selected event
        private void listview_dep_MouseClick(object sender, MouseEventArgs e)
        {
            ListView.SelectedListViewItemCollection items = listview_dep.SelectedItems;
            ListViewItem lviitem = items[0];
            selected_list_str = lviitem.SubItems[0].Text;
            if (pa3_cnt == 1) {
                pa_reservation_part3.Visible = true;
                pa3_cnt = 0;
              }
            reservation_list(dep_id(selected_list_str));
        }// dep_listview click event  

        private void tb_dep_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                reservation_search_btn_Click(sender, e);
            }
            if(e.KeyCode == Keys.Back)
            {
                if (tb_dep_search.TextLength <= 1)
                {
                    reservation_all_btn_Click(sender, e);
                }
            }
        } // search event 
        private int dep_id(string select_value)
        {
            int data=0;
            try
            {
                db_connection();
                select_text = "SELECT dep_id \n"
                    + "FROM medical_department_tb \n"
                    + "WHERE dep_name = '"+select_value+"'";
                ds = new DataSet();
                ds.Clear();
                oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand(select_text, conn);
                oda.Fill(ds);
                data = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                conn.Close();
                
            }
            catch (Exception e) { MessageBox.Show("리스트 전송실패"); }
            return data;
        } // dep_id select
        private string reservation_list(int depid)
        {
            string data = "";
            try
            {
                db_connection();
                select_text = "SELECT m.dep_name,d.doc_name,d.doc_phone,d.doc_email \n"
                    + "FROM medical_department_tb m \n"
                    + ",doctor_tb d \n"
                    + "WHERE d.dep_id = m.dep_id \n"
                    + "AND d.dep_id =" + depid;
                ds = new DataSet();
                ds.Clear();
                oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand(select_text, conn);
                oda.Fill(ds);
                listview_doctor.BeginUpdate();
                listview_doctor.Clear();
                listview_doctor.Columns.Add("진료과", 120);
                listview_doctor.Columns.Add("성명", 60);
                listview_doctor.Columns.Add("핸드폰번호", 90);
                listview_doctor.Columns.Add("이메일", 170);
                ListViewItem liv;
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    liv = new ListViewItem(ds.Tables[0].Rows[i][0].ToString());
                    for(int j=1; j< ds.Tables[0].Columns.Count; j++)
                    {
                        liv.SubItems.Add(ds.Tables[0].Rows[i][j].ToString());
                    }
                    listview_doctor.Items.Add(liv);
                }
                listview_doctor.EndUpdate();
                conn.Close();
            }
            catch (Exception e) { MessageBox.Show("리스트 전송실패"); }
            return data;
        } // reservation_listview selected event

        private void listview_doctor_MouseClick(object sender, MouseEventArgs e)
        {
            pa_reservation_part4.Visible = true;
            selected_doctor_str = listview_doctor.FocusedItem.SubItems[1].Text;
            selected_doctor_phone_str = listview_doctor.FocusedItem.SubItems[2].Text;
        }
        private void listview_doctor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            doctor_detail_form doctordetailform = new doctor_detail_form(doctor_id_check(selected_doctor_str, selected_doctor_phone_str));
            doctordetailform.ShowDialog();//모달
        }
        private string doctor_id_check(string select_value1, string select_value2)
        {
            string data = "0";
            try
            {
                db_connection();
                select_text = "SELECT doc_id \n"
                    + "FROM doctor_tb \n"
                    + "WHERE doc_name = '" + select_value1 + "' and doc_phone = '" + select_value2 + "'";
                ds = new DataSet();
                ds.Clear();
                oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand(select_text, conn);
                oda.Fill(ds);
                data = ds.Tables[0].Rows[0][0].ToString();
                conn.Close();
            }
            catch (Exception e) { MessageBox.Show("리스트 전송실패"); }
            return data;
        } // dep_id select
        private void datetime_ok_btn_Click(object sender, EventArgs e)
        {
            pa_reservation_part5.Visible = true;
            reser_end_name.Text = tb_reservation_name.Text;
            reser_end_dep.Text = selected_list_str;
            reser_end_doctor.Text = selected_doctor_str;
            reser_end_datetime.Text = date_time_end;
        }
        private void reservation_end_ok_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("예약하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                insert_db_query(date_time, reser_end_name.Text,phone,primary_id, dep_id(selected_list_str), selected_doctor_str, Int32.Parse(tb_member_sex.Text),tb_member_front.Text);
                this.Close();
                MessageBox.Show("예약되었습니다");
                //insert
            }
            else
            {
                pa_reservation_part5.Visible = false;
            }
        }
        private void reservation_end_no_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("예약을 취소하겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                MessageBox.Show("취소되었습니다.");
            }
        }
        private void insert_db_query(string date, string name,string phone, string user_id, int dep_id, string doctor, int sex, string front)
        {
            insert_text = "INSERT INTO reservation_tb VALUES (ID_SEQ.nextval,1,'"+ date + "','"+ name + "','" + phone + "','"+ user_id +"'," + dep_id + ",'"+ doctor + "',"+sex+",'"+ front + "')";
           
                conn = new OracleConnection(strConn);
                cmd = new OracleCommand(insert_text);
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            
            
        }

        private void reservation_form_Load(object sender, EventArgs e)
        {
 
        }

       
    }
}
