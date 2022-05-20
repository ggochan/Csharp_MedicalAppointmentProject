namespace medical__appointment_project
{
    partial class reservation_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.la_reservation_name = new System.Windows.Forms.Label();
            this.la_reservation_sex = new System.Windows.Forms.Label();
            this.la_reservation_phone = new System.Windows.Forms.Label();
            this.pa_reservation_part1 = new System.Windows.Forms.Panel();
            this.reservation_ok_btn = new System.Windows.Forms.Button();
            this.tb_reservation_phonenum1 = new System.Windows.Forms.TextBox();
            this.la_pa1 = new System.Windows.Forms.Label();
            this.bar_2 = new System.Windows.Forms.Label();
            this.bar_1 = new System.Windows.Forms.Label();
            this.tb_reservation_phonenum3 = new System.Windows.Forms.TextBox();
            this.tb_reservation_phonenum2 = new System.Windows.Forms.TextBox();
            this.tb_reservation_name = new System.Windows.Forms.TextBox();
            this.la_pa2 = new System.Windows.Forms.Label();
            this.pa_reservation_part2 = new System.Windows.Forms.Panel();
            this.reservation_all_btn = new System.Windows.Forms.Button();
            this.reservation_search_btn = new System.Windows.Forms.Button();
            this.tb_dep_search = new System.Windows.Forms.TextBox();
            this.listview_dep = new System.Windows.Forms.ListView();
            this.pa_reservation_part3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.listview_doctor = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.pa_reservation_part4 = new System.Windows.Forms.Panel();
            this.datetime_ok_btn = new System.Windows.Forms.Button();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pa_reservation_part5 = new System.Windows.Forms.Panel();
            this.reser_end_datetime = new System.Windows.Forms.Label();
            this.reser_end_doctor = new System.Windows.Forms.Label();
            this.reser_end_dep = new System.Windows.Forms.Label();
            this.reser_end_name = new System.Windows.Forms.Label();
            this.reservation_end_no = new System.Windows.Forms.Button();
            this.reservation_end_ok = new System.Windows.Forms.Button();
            this.la_reser_end_datetime = new System.Windows.Forms.Label();
            this.la_reser_end_doctor = new System.Windows.Forms.Label();
            this.la_reser_end_dep = new System.Windows.Forms.Label();
            this.la_reser_end_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_member_front = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_member_sex = new System.Windows.Forms.TextBox();
            this.two_reservation_ok_btn2 = new System.Windows.Forms.Button();
            this.two_reservation_ok_listview = new System.Windows.Forms.ListView();
            this.pa_reservation_part1.SuspendLayout();
            this.pa_reservation_part2.SuspendLayout();
            this.pa_reservation_part3.SuspendLayout();
            this.pa_reservation_part4.SuspendLayout();
            this.pa_reservation_part5.SuspendLayout();
            this.SuspendLayout();
            // 
            // la_reservation_name
            // 
            this.la_reservation_name.AutoSize = true;
            this.la_reservation_name.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_reservation_name.Location = new System.Drawing.Point(23, 74);
            this.la_reservation_name.Name = "la_reservation_name";
            this.la_reservation_name.Size = new System.Drawing.Size(88, 23);
            this.la_reservation_name.TabIndex = 0;
            this.la_reservation_name.Text = "이름(실명)";
            // 
            // la_reservation_sex
            // 
            this.la_reservation_sex.AutoSize = true;
            this.la_reservation_sex.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_reservation_sex.Location = new System.Drawing.Point(472, 74);
            this.la_reservation_sex.Name = "la_reservation_sex";
            this.la_reservation_sex.Size = new System.Drawing.Size(112, 23);
            this.la_reservation_sex.TabIndex = 1;
            this.la_reservation_sex.Text = "주민등록번호";
            // 
            // la_reservation_phone
            // 
            this.la_reservation_phone.AutoSize = true;
            this.la_reservation_phone.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_reservation_phone.Location = new System.Drawing.Point(23, 124);
            this.la_reservation_phone.Name = "la_reservation_phone";
            this.la_reservation_phone.Size = new System.Drawing.Size(95, 23);
            this.la_reservation_phone.TabIndex = 2;
            this.la_reservation_phone.Text = "핸드폰번호";
            // 
            // pa_reservation_part1
            // 
            this.pa_reservation_part1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pa_reservation_part1.Controls.Add(this.two_reservation_ok_listview);
            this.pa_reservation_part1.Controls.Add(this.two_reservation_ok_btn2);
            this.pa_reservation_part1.Controls.Add(this.tb_member_front);
            this.pa_reservation_part1.Controls.Add(this.label8);
            this.pa_reservation_part1.Controls.Add(this.label7);
            this.pa_reservation_part1.Controls.Add(this.tb_member_sex);
            this.pa_reservation_part1.Controls.Add(this.reservation_ok_btn);
            this.pa_reservation_part1.Controls.Add(this.tb_reservation_phonenum1);
            this.pa_reservation_part1.Controls.Add(this.la_pa1);
            this.pa_reservation_part1.Controls.Add(this.bar_2);
            this.pa_reservation_part1.Controls.Add(this.la_reservation_phone);
            this.pa_reservation_part1.Controls.Add(this.bar_1);
            this.pa_reservation_part1.Controls.Add(this.la_reservation_name);
            this.pa_reservation_part1.Controls.Add(this.tb_reservation_phonenum3);
            this.pa_reservation_part1.Controls.Add(this.la_reservation_sex);
            this.pa_reservation_part1.Controls.Add(this.tb_reservation_phonenum2);
            this.pa_reservation_part1.Controls.Add(this.tb_reservation_name);
            this.pa_reservation_part1.Location = new System.Drawing.Point(1, 0);
            this.pa_reservation_part1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pa_reservation_part1.Name = "pa_reservation_part1";
            this.pa_reservation_part1.Size = new System.Drawing.Size(1396, 190);
            this.pa_reservation_part1.TabIndex = 3;
            // 
            // reservation_ok_btn
            // 
            this.reservation_ok_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(125)))), ((int)(((byte)(179)))));
            this.reservation_ok_btn.FlatAppearance.BorderSize = 0;
            this.reservation_ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservation_ok_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reservation_ok_btn.ForeColor = System.Drawing.Color.White;
            this.reservation_ok_btn.Location = new System.Drawing.Point(1266, 124);
            this.reservation_ok_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reservation_ok_btn.Name = "reservation_ok_btn";
            this.reservation_ok_btn.Size = new System.Drawing.Size(114, 46);
            this.reservation_ok_btn.TabIndex = 6;
            this.reservation_ok_btn.TabStop = false;
            this.reservation_ok_btn.Text = "확인";
            this.reservation_ok_btn.UseVisualStyleBackColor = false;
            this.reservation_ok_btn.Click += new System.EventHandler(this.reservation_ok_btn_Click);
            // 
            // tb_reservation_phonenum1
            // 
            this.tb_reservation_phonenum1.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_reservation_phonenum1.Location = new System.Drawing.Point(145, 120);
            this.tb_reservation_phonenum1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_reservation_phonenum1.MaxLength = 3;
            this.tb_reservation_phonenum1.Name = "tb_reservation_phonenum1";
            this.tb_reservation_phonenum1.Size = new System.Drawing.Size(70, 30);
            this.tb_reservation_phonenum1.TabIndex = 3;
            this.tb_reservation_phonenum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // la_pa1
            // 
            this.la_pa1.AutoSize = true;
            this.la_pa1.Font = new System.Drawing.Font("Malgun Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_pa1.Location = new System.Drawing.Point(13, 21);
            this.la_pa1.Name = "la_pa1";
            this.la_pa1.Size = new System.Drawing.Size(172, 30);
            this.la_pa1.TabIndex = 3;
            this.la_pa1.Text = "1. 환자정보입력";
            // 
            // bar_2
            // 
            this.bar_2.AutoSize = true;
            this.bar_2.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bar_2.ForeColor = System.Drawing.Color.DimGray;
            this.bar_2.Location = new System.Drawing.Point(326, 124);
            this.bar_2.Name = "bar_2";
            this.bar_2.Size = new System.Drawing.Size(17, 23);
            this.bar_2.TabIndex = 20;
            this.bar_2.Text = "-";
            // 
            // bar_1
            // 
            this.bar_1.AutoSize = true;
            this.bar_1.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bar_1.ForeColor = System.Drawing.Color.DimGray;
            this.bar_1.Location = new System.Drawing.Point(223, 124);
            this.bar_1.Name = "bar_1";
            this.bar_1.Size = new System.Drawing.Size(17, 23);
            this.bar_1.TabIndex = 19;
            this.bar_1.Text = "-";
            // 
            // tb_reservation_phonenum3
            // 
            this.tb_reservation_phonenum3.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_reservation_phonenum3.Location = new System.Drawing.Point(355, 120);
            this.tb_reservation_phonenum3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_reservation_phonenum3.MaxLength = 4;
            this.tb_reservation_phonenum3.Name = "tb_reservation_phonenum3";
            this.tb_reservation_phonenum3.Size = new System.Drawing.Size(70, 30);
            this.tb_reservation_phonenum3.TabIndex = 5;
            this.tb_reservation_phonenum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_reservation_phonenum2
            // 
            this.tb_reservation_phonenum2.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_reservation_phonenum2.Location = new System.Drawing.Point(248, 120);
            this.tb_reservation_phonenum2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_reservation_phonenum2.MaxLength = 4;
            this.tb_reservation_phonenum2.Name = "tb_reservation_phonenum2";
            this.tb_reservation_phonenum2.Size = new System.Drawing.Size(70, 30);
            this.tb_reservation_phonenum2.TabIndex = 4;
            this.tb_reservation_phonenum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_reservation_name
            // 
            this.tb_reservation_name.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_reservation_name.Location = new System.Drawing.Point(145, 70);
            this.tb_reservation_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_reservation_name.Name = "tb_reservation_name";
            this.tb_reservation_name.Size = new System.Drawing.Size(99, 30);
            this.tb_reservation_name.TabIndex = 0;
            this.tb_reservation_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // la_pa2
            // 
            this.la_pa2.AutoSize = true;
            this.la_pa2.Font = new System.Drawing.Font("Malgun Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_pa2.Location = new System.Drawing.Point(13, 21);
            this.la_pa2.Name = "la_pa2";
            this.la_pa2.Size = new System.Drawing.Size(150, 30);
            this.la_pa2.TabIndex = 23;
            this.la_pa2.Text = "2. 진료과선택";
            // 
            // pa_reservation_part2
            // 
            this.pa_reservation_part2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pa_reservation_part2.Controls.Add(this.reservation_all_btn);
            this.pa_reservation_part2.Controls.Add(this.reservation_search_btn);
            this.pa_reservation_part2.Controls.Add(this.tb_dep_search);
            this.pa_reservation_part2.Controls.Add(this.listview_dep);
            this.pa_reservation_part2.Controls.Add(this.la_pa2);
            this.pa_reservation_part2.Location = new System.Drawing.Point(1, 192);
            this.pa_reservation_part2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pa_reservation_part2.Name = "pa_reservation_part2";
            this.pa_reservation_part2.Size = new System.Drawing.Size(359, 604);
            this.pa_reservation_part2.TabIndex = 24;
            this.pa_reservation_part2.Visible = false;
            // 
            // reservation_all_btn
            // 
            this.reservation_all_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(125)))), ((int)(((byte)(179)))));
            this.reservation_all_btn.FlatAppearance.BorderSize = 0;
            this.reservation_all_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservation_all_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reservation_all_btn.ForeColor = System.Drawing.Color.White;
            this.reservation_all_btn.Location = new System.Drawing.Point(285, 70);
            this.reservation_all_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reservation_all_btn.Name = "reservation_all_btn";
            this.reservation_all_btn.Size = new System.Drawing.Size(59, 31);
            this.reservation_all_btn.TabIndex = 9;
            this.reservation_all_btn.TabStop = false;
            this.reservation_all_btn.Text = "전체";
            this.reservation_all_btn.UseVisualStyleBackColor = false;
            this.reservation_all_btn.Click += new System.EventHandler(this.reservation_all_btn_Click);
            // 
            // reservation_search_btn
            // 
            this.reservation_search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(132)))), ((int)(((byte)(21)))));
            this.reservation_search_btn.FlatAppearance.BorderSize = 0;
            this.reservation_search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservation_search_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reservation_search_btn.ForeColor = System.Drawing.Color.White;
            this.reservation_search_btn.Location = new System.Drawing.Point(218, 70);
            this.reservation_search_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reservation_search_btn.Name = "reservation_search_btn";
            this.reservation_search_btn.Size = new System.Drawing.Size(59, 31);
            this.reservation_search_btn.TabIndex = 8;
            this.reservation_search_btn.TabStop = false;
            this.reservation_search_btn.Text = "검색";
            this.reservation_search_btn.UseVisualStyleBackColor = false;
            this.reservation_search_btn.Click += new System.EventHandler(this.reservation_search_btn_Click);
            // 
            // tb_dep_search
            // 
            this.tb_dep_search.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_dep_search.Location = new System.Drawing.Point(11, 69);
            this.tb_dep_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_dep_search.Name = "tb_dep_search";
            this.tb_dep_search.Size = new System.Drawing.Size(199, 30);
            this.tb_dep_search.TabIndex = 7;
            this.tb_dep_search.TabStop = false;
            this.tb_dep_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_dep_search_KeyDown);
            // 
            // listview_dep
            // 
            this.listview_dep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listview_dep.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listview_dep.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listview_dep.Location = new System.Drawing.Point(11, 108);
            this.listview_dep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listview_dep.MultiSelect = false;
            this.listview_dep.Name = "listview_dep";
            this.listview_dep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listview_dep.Size = new System.Drawing.Size(332, 482);
            this.listview_dep.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listview_dep.TabIndex = 10;
            this.listview_dep.UseCompatibleStateImageBehavior = false;
            this.listview_dep.View = System.Windows.Forms.View.Details;
            this.listview_dep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listview_dep_MouseClick);
            // 
            // pa_reservation_part3
            // 
            this.pa_reservation_part3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pa_reservation_part3.Controls.Add(this.label4);
            this.pa_reservation_part3.Controls.Add(this.listview_doctor);
            this.pa_reservation_part3.Controls.Add(this.label1);
            this.pa_reservation_part3.Location = new System.Drawing.Point(363, 192);
            this.pa_reservation_part3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pa_reservation_part3.Name = "pa_reservation_part3";
            this.pa_reservation_part3.Size = new System.Drawing.Size(505, 604);
            this.pa_reservation_part3.TabIndex = 27;
            this.pa_reservation_part3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(266, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "※ 두번 클릭 = 상세정보 보기";
            // 
            // listview_doctor
            // 
            this.listview_doctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listview_doctor.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listview_doctor.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listview_doctor.Location = new System.Drawing.Point(9, 70);
            this.listview_doctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listview_doctor.MultiSelect = false;
            this.listview_doctor.Name = "listview_doctor";
            this.listview_doctor.Size = new System.Drawing.Size(484, 518);
            this.listview_doctor.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listview_doctor.TabIndex = 24;
            this.listview_doctor.TabStop = false;
            this.listview_doctor.UseCompatibleStateImageBehavior = false;
            this.listview_doctor.View = System.Windows.Forms.View.Details;
            this.listview_doctor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listview_doctor_MouseClick);
            this.listview_doctor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listview_doctor_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "3. 의료진선택";
            // 
            // pa_reservation_part4
            // 
            this.pa_reservation_part4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pa_reservation_part4.Controls.Add(this.datetime_ok_btn);
            this.pa_reservation_part4.Controls.Add(this.timePicker);
            this.pa_reservation_part4.Controls.Add(this.datePicker);
            this.pa_reservation_part4.Controls.Add(this.label2);
            this.pa_reservation_part4.Location = new System.Drawing.Point(871, 192);
            this.pa_reservation_part4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pa_reservation_part4.Name = "pa_reservation_part4";
            this.pa_reservation_part4.Size = new System.Drawing.Size(525, 358);
            this.pa_reservation_part4.TabIndex = 28;
            this.pa_reservation_part4.Visible = false;
            // 
            // datetime_ok_btn
            // 
            this.datetime_ok_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(125)))), ((int)(((byte)(179)))));
            this.datetime_ok_btn.FlatAppearance.BorderSize = 0;
            this.datetime_ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.datetime_ok_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.datetime_ok_btn.ForeColor = System.Drawing.Color.White;
            this.datetime_ok_btn.Location = new System.Drawing.Point(383, 306);
            this.datetime_ok_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datetime_ok_btn.Name = "datetime_ok_btn";
            this.datetime_ok_btn.Size = new System.Drawing.Size(127, 36);
            this.datetime_ok_btn.TabIndex = 40;
            this.datetime_ok_btn.TabStop = false;
            this.datetime_ok_btn.Text = "예약내용확인";
            this.datetime_ok_btn.UseVisualStyleBackColor = false;
            this.datetime_ok_btn.Click += new System.EventHandler(this.datetime_ok_btn_Click);
            // 
            // timePicker
            // 
            this.timePicker.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(259, 70);
            this.timePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(146, 30);
            this.timePicker.TabIndex = 25;
            this.timePicker.TabStop = false;
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.datePicker.Location = new System.Drawing.Point(18, 70);
            this.datePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(237, 30);
            this.datePicker.TabIndex = 24;
            this.datePicker.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "4. 시간선택";
            // 
            // pa_reservation_part5
            // 
            this.pa_reservation_part5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pa_reservation_part5.Controls.Add(this.reser_end_datetime);
            this.pa_reservation_part5.Controls.Add(this.reser_end_doctor);
            this.pa_reservation_part5.Controls.Add(this.reser_end_dep);
            this.pa_reservation_part5.Controls.Add(this.reser_end_name);
            this.pa_reservation_part5.Controls.Add(this.reservation_end_no);
            this.pa_reservation_part5.Controls.Add(this.reservation_end_ok);
            this.pa_reservation_part5.Controls.Add(this.la_reser_end_datetime);
            this.pa_reservation_part5.Controls.Add(this.la_reser_end_doctor);
            this.pa_reservation_part5.Controls.Add(this.la_reser_end_dep);
            this.pa_reservation_part5.Controls.Add(this.la_reser_end_name);
            this.pa_reservation_part5.Controls.Add(this.label3);
            this.pa_reservation_part5.Location = new System.Drawing.Point(871, 554);
            this.pa_reservation_part5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pa_reservation_part5.Name = "pa_reservation_part5";
            this.pa_reservation_part5.Size = new System.Drawing.Size(525, 242);
            this.pa_reservation_part5.TabIndex = 29;
            this.pa_reservation_part5.Visible = false;
            // 
            // reser_end_datetime
            // 
            this.reser_end_datetime.AutoSize = true;
            this.reser_end_datetime.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reser_end_datetime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(113)))), ((int)(((byte)(156)))));
            this.reser_end_datetime.Location = new System.Drawing.Point(289, 139);
            this.reser_end_datetime.Name = "reser_end_datetime";
            this.reser_end_datetime.Size = new System.Drawing.Size(209, 23);
            this.reser_end_datetime.TabIndex = 39;
            this.reser_end_datetime.Text = "00년 00월 00일 00시 00분";
            // 
            // reser_end_doctor
            // 
            this.reser_end_doctor.AutoSize = true;
            this.reser_end_doctor.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reser_end_doctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(113)))), ((int)(((byte)(156)))));
            this.reser_end_doctor.Location = new System.Drawing.Point(119, 139);
            this.reser_end_doctor.Name = "reser_end_doctor";
            this.reser_end_doctor.Size = new System.Drawing.Size(44, 23);
            this.reser_end_doctor.TabIndex = 38;
            this.reser_end_doctor.Text = "의사";
            // 
            // reser_end_dep
            // 
            this.reser_end_dep.AutoSize = true;
            this.reser_end_dep.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reser_end_dep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(113)))), ((int)(((byte)(156)))));
            this.reser_end_dep.Location = new System.Drawing.Point(288, 85);
            this.reser_end_dep.Name = "reser_end_dep";
            this.reser_end_dep.Size = new System.Drawing.Size(27, 23);
            this.reser_end_dep.TabIndex = 37;
            this.reser_end_dep.Text = "과";
            // 
            // reser_end_name
            // 
            this.reser_end_name.AutoSize = true;
            this.reser_end_name.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reser_end_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(113)))), ((int)(((byte)(156)))));
            this.reser_end_name.Location = new System.Drawing.Point(119, 85);
            this.reser_end_name.Name = "reser_end_name";
            this.reser_end_name.Size = new System.Drawing.Size(44, 23);
            this.reser_end_name.TabIndex = 36;
            this.reser_end_name.Text = "이름";
            // 
            // reservation_end_no
            // 
            this.reservation_end_no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(132)))), ((int)(((byte)(21)))));
            this.reservation_end_no.FlatAppearance.BorderSize = 0;
            this.reservation_end_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservation_end_no.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reservation_end_no.ForeColor = System.Drawing.Color.White;
            this.reservation_end_no.Location = new System.Drawing.Point(414, 189);
            this.reservation_end_no.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reservation_end_no.Name = "reservation_end_no";
            this.reservation_end_no.Size = new System.Drawing.Size(96, 39);
            this.reservation_end_no.TabIndex = 35;
            this.reservation_end_no.TabStop = false;
            this.reservation_end_no.Text = "예약취소";
            this.reservation_end_no.UseVisualStyleBackColor = false;
            this.reservation_end_no.Click += new System.EventHandler(this.reservation_end_no_Click);
            // 
            // reservation_end_ok
            // 
            this.reservation_end_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(125)))), ((int)(((byte)(179)))));
            this.reservation_end_ok.FlatAppearance.BorderSize = 0;
            this.reservation_end_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservation_end_ok.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reservation_end_ok.ForeColor = System.Drawing.Color.White;
            this.reservation_end_ok.Location = new System.Drawing.Point(311, 189);
            this.reservation_end_ok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reservation_end_ok.Name = "reservation_end_ok";
            this.reservation_end_ok.Size = new System.Drawing.Size(96, 39);
            this.reservation_end_ok.TabIndex = 31;
            this.reservation_end_ok.TabStop = false;
            this.reservation_end_ok.Text = "예약완료";
            this.reservation_end_ok.UseVisualStyleBackColor = false;
            this.reservation_end_ok.Click += new System.EventHandler(this.reservation_end_ok_Click);
            // 
            // la_reser_end_datetime
            // 
            this.la_reser_end_datetime.AutoSize = true;
            this.la_reser_end_datetime.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_reser_end_datetime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(113)))), ((int)(((byte)(156)))));
            this.la_reser_end_datetime.Location = new System.Drawing.Point(201, 138);
            this.la_reser_end_datetime.Name = "la_reser_end_datetime";
            this.la_reser_end_datetime.Size = new System.Drawing.Size(88, 25);
            this.la_reser_end_datetime.TabIndex = 34;
            this.la_reser_end_datetime.Text = "진료시간";
            // 
            // la_reser_end_doctor
            // 
            this.la_reser_end_doctor.AutoSize = true;
            this.la_reser_end_doctor.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_reser_end_doctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(113)))), ((int)(((byte)(156)))));
            this.la_reser_end_doctor.Location = new System.Drawing.Point(22, 138);
            this.la_reser_end_doctor.Name = "la_reser_end_doctor";
            this.la_reser_end_doctor.Size = new System.Drawing.Size(69, 25);
            this.la_reser_end_doctor.TabIndex = 33;
            this.la_reser_end_doctor.Text = "의료진";
            // 
            // la_reser_end_dep
            // 
            this.la_reser_end_dep.AutoSize = true;
            this.la_reser_end_dep.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_reser_end_dep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(113)))), ((int)(((byte)(156)))));
            this.la_reser_end_dep.Location = new System.Drawing.Point(201, 84);
            this.la_reser_end_dep.Name = "la_reser_end_dep";
            this.la_reser_end_dep.Size = new System.Drawing.Size(69, 25);
            this.la_reser_end_dep.TabIndex = 32;
            this.la_reser_end_dep.Text = "진료과";
            // 
            // la_reser_end_name
            // 
            this.la_reser_end_name.AutoSize = true;
            this.la_reser_end_name.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_reser_end_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(113)))), ((int)(((byte)(156)))));
            this.la_reser_end_name.Location = new System.Drawing.Point(22, 84);
            this.la_reser_end_name.Name = "la_reser_end_name";
            this.la_reser_end_name.Size = new System.Drawing.Size(102, 25);
            this.la_reser_end_name.TabIndex = 31;
            this.la_reser_end_name.Text = "이름(실명)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(13, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 30);
            this.label3.TabIndex = 23;
            this.label3.Text = "5. 예약내용 확인";
            // 
            // tb_member_front
            // 
            this.tb_member_front.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_member_front.Location = new System.Drawing.Point(609, 70);
            this.tb_member_front.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_member_front.MaxLength = 6;
            this.tb_member_front.Name = "tb_member_front";
            this.tb_member_front.Size = new System.Drawing.Size(129, 30);
            this.tb_member_front.TabIndex = 1;
            this.tb_member_front.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(799, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 32);
            this.label8.TabIndex = 49;
            this.label8.Text = "* * * * * *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(745, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 23);
            this.label7.TabIndex = 47;
            this.label7.Text = "-";
            // 
            // tb_member_sex
            // 
            this.tb_member_sex.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_member_sex.Location = new System.Drawing.Point(769, 70);
            this.tb_member_sex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_member_sex.MaxLength = 1;
            this.tb_member_sex.Name = "tb_member_sex";
            this.tb_member_sex.Size = new System.Drawing.Size(26, 30);
            this.tb_member_sex.TabIndex = 2;
            this.tb_member_sex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // two_reservation_ok_btn2
            // 
            this.two_reservation_ok_btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(125)))), ((int)(((byte)(179)))));
            this.two_reservation_ok_btn2.FlatAppearance.BorderSize = 0;
            this.two_reservation_ok_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two_reservation_ok_btn2.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.two_reservation_ok_btn2.ForeColor = System.Drawing.Color.White;
            this.two_reservation_ok_btn2.Location = new System.Drawing.Point(800, 129);
            this.two_reservation_ok_btn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.two_reservation_ok_btn2.Name = "two_reservation_ok_btn2";
            this.two_reservation_ok_btn2.Size = new System.Drawing.Size(114, 36);
            this.two_reservation_ok_btn2.TabIndex = 50;
            this.two_reservation_ok_btn2.Text = "확인";
            this.two_reservation_ok_btn2.UseVisualStyleBackColor = false;
            this.two_reservation_ok_btn2.Visible = false;
            // 
            // two_reservation_ok_listview
            // 
            this.two_reservation_ok_listview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.two_reservation_ok_listview.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.two_reservation_ok_listview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.two_reservation_ok_listview.Location = new System.Drawing.Point(929, 2);
            this.two_reservation_ok_listview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.two_reservation_ok_listview.MultiSelect = false;
            this.two_reservation_ok_listview.Name = "two_reservation_ok_listview";
            this.two_reservation_ok_listview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.two_reservation_ok_listview.Size = new System.Drawing.Size(457, 175);
            this.two_reservation_ok_listview.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.two_reservation_ok_listview.TabIndex = 27;
            this.two_reservation_ok_listview.UseCompatibleStateImageBehavior = false;
            this.two_reservation_ok_listview.View = System.Windows.Forms.View.Details;
            this.two_reservation_ok_listview.Visible = false;
            // 
            // reservation_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.pa_reservation_part5);
            this.Controls.Add(this.pa_reservation_part4);
            this.Controls.Add(this.pa_reservation_part3);
            this.Controls.Add(this.pa_reservation_part2);
            this.Controls.Add(this.pa_reservation_part1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "reservation_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.reservation_form_Load);
            this.pa_reservation_part1.ResumeLayout(false);
            this.pa_reservation_part1.PerformLayout();
            this.pa_reservation_part2.ResumeLayout(false);
            this.pa_reservation_part2.PerformLayout();
            this.pa_reservation_part3.ResumeLayout(false);
            this.pa_reservation_part3.PerformLayout();
            this.pa_reservation_part4.ResumeLayout(false);
            this.pa_reservation_part4.PerformLayout();
            this.pa_reservation_part5.ResumeLayout(false);
            this.pa_reservation_part5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label la_reservation_name;
        private System.Windows.Forms.Label la_reservation_sex;
        private System.Windows.Forms.Label la_reservation_phone;
        private System.Windows.Forms.Panel pa_reservation_part1;
        private System.Windows.Forms.Label la_pa1;
        private System.Windows.Forms.TextBox tb_reservation_phonenum1;
        private System.Windows.Forms.Label bar_2;
        private System.Windows.Forms.Label bar_1;
        private System.Windows.Forms.TextBox tb_reservation_phonenum3;
        private System.Windows.Forms.TextBox tb_reservation_phonenum2;
        private System.Windows.Forms.TextBox tb_reservation_name;
        private System.Windows.Forms.Label la_pa2;
        private System.Windows.Forms.Panel pa_reservation_part2;
        private System.Windows.Forms.TextBox tb_dep_search;
        private System.Windows.Forms.ListView listview_dep;
        private System.Windows.Forms.Button reservation_all_btn;
        private System.Windows.Forms.Button reservation_search_btn;
        private System.Windows.Forms.Panel pa_reservation_part3;
        private System.Windows.Forms.ListView listview_doctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pa_reservation_part4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pa_reservation_part5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button reservation_ok_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button datetime_ok_btn;
        private System.Windows.Forms.Label reser_end_datetime;
        private System.Windows.Forms.Label reser_end_doctor;
        private System.Windows.Forms.Label reser_end_dep;
        private System.Windows.Forms.Label reser_end_name;
        private System.Windows.Forms.Button reservation_end_no;
        private System.Windows.Forms.Button reservation_end_ok;
        private System.Windows.Forms.Label la_reser_end_datetime;
        private System.Windows.Forms.Label la_reser_end_doctor;
        private System.Windows.Forms.Label la_reser_end_dep;
        private System.Windows.Forms.Label la_reser_end_name;
        private System.Windows.Forms.TextBox tb_member_front;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_member_sex;
        private System.Windows.Forms.ListView two_reservation_ok_listview;
        private System.Windows.Forms.Button two_reservation_ok_btn2;
    }
}