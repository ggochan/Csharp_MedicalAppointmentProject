namespace medical__appointment_project
{
    partial class membership_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(membership_form));
            this.logoimage = new System.Windows.Forms.PictureBox();
            this.la_member_id = new System.Windows.Forms.Label();
            this.tb_member_id = new System.Windows.Forms.TextBox();
            this.tb_member_pwd = new System.Windows.Forms.TextBox();
            this.la_member_pwd = new System.Windows.Forms.Label();
            this.tb_member_email = new System.Windows.Forms.TextBox();
            this.la_member_email = new System.Windows.Forms.Label();
            this.la_member_phonenum = new System.Windows.Forms.Label();
            this.tb_member_phonenum2 = new System.Windows.Forms.TextBox();
            this.tb_member_phonenum3 = new System.Windows.Forms.TextBox();
            this.bar_1 = new System.Windows.Forms.Label();
            this.bar_2 = new System.Windows.Forms.Label();
            this.tb_member_phonenum1 = new System.Windows.Forms.TextBox();
            this.tb_member_pwdend = new System.Windows.Forms.TextBox();
            this.la_member_pwdend = new System.Windows.Forms.Label();
            this.tb_member_name = new System.Windows.Forms.TextBox();
            this.la_member_name = new System.Windows.Forms.Label();
            this.la_inco = new System.Windows.Forms.Label();
            this.radio_member_email = new System.Windows.Forms.RadioButton();
            this.radio_member_sms = new System.Windows.Forms.RadioButton();
            this.la_member_housenum = new System.Windows.Forms.Label();
            this.tb_member_housenum1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_member_housenum3 = new System.Windows.Forms.TextBox();
            this.tb_member_housenum2 = new System.Windows.Forms.TextBox();
            this.mem_completion_btn = new System.Windows.Forms.Button();
            this.mem_cancel_btn = new System.Windows.Forms.Button();
            this.pa_information = new System.Windows.Forms.Panel();
            this.information_false_btn = new System.Windows.Forms.Button();
            this.information_true_btn = new System.Windows.Forms.Button();
            this.ra_information_false = new System.Windows.Forms.RadioButton();
            this.ra_information_true = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pwd_view_btn = new System.Windows.Forms.Button();
            this.id_overlap_btn = new System.Windows.Forms.Button();
            this.email_overlap_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.id_la = new System.Windows.Forms.Label();
            this.email_la = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radio_member_false = new System.Windows.Forms.RadioButton();
            this.la_pwdend_check = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_member_front = new System.Windows.Forms.TextBox();
            this.la_member_front_end_sex = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_member_sex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mem_update_btn = new System.Windows.Forms.Button();
            this.mem_update_cancle_btn = new System.Windows.Forms.Button();
            this.mem_delete_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoimage)).BeginInit();
            this.pa_information.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoimage
            // 
            this.logoimage.BackColor = System.Drawing.Color.White;
            this.logoimage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoimage.BackgroundImage")));
            this.logoimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoimage.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoimage.InitialImage")));
            this.logoimage.Location = new System.Drawing.Point(48, 260);
            this.logoimage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoimage.Name = "logoimage";
            this.logoimage.Size = new System.Drawing.Size(450, 250);
            this.logoimage.TabIndex = 1;
            this.logoimage.TabStop = false;
            // 
            // la_member_id
            // 
            this.la_member_id.AutoSize = true;
            this.la_member_id.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_member_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
            this.la_member_id.Location = new System.Drawing.Point(545, 164);
            this.la_member_id.Name = "la_member_id";
            this.la_member_id.Size = new System.Drawing.Size(69, 23);
            this.la_member_id.TabIndex = 2;
            this.la_member_id.Text = "아이디*";
            // 
            // tb_member_id
            // 
            this.tb_member_id.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_member_id.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_member_id.Location = new System.Drawing.Point(689, 160);
            this.tb_member_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_member_id.MaxLength = 20;
            this.tb_member_id.Name = "tb_member_id";
            this.tb_member_id.Size = new System.Drawing.Size(294, 30);
            this.tb_member_id.TabIndex = 5;
            this.tb_member_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_english_num_KeyPress);
            this.tb_member_id.Leave += new System.EventHandler(this.tb_english_num_Leave);
            // 
            // tb_member_pwd
            // 
            this.tb_member_pwd.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_member_pwd.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_member_pwd.Location = new System.Drawing.Point(689, 210);
            this.tb_member_pwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_member_pwd.MaxLength = 20;
            this.tb_member_pwd.Name = "tb_member_pwd";
            this.tb_member_pwd.PasswordChar = '*';
            this.tb_member_pwd.Size = new System.Drawing.Size(294, 30);
            this.tb_member_pwd.TabIndex = 7;
            this.tb_member_pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_member_pwdend_KeyDown);
            // 
            // la_member_pwd
            // 
            this.la_member_pwd.AutoSize = true;
            this.la_member_pwd.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_member_pwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
            this.la_member_pwd.Location = new System.Drawing.Point(545, 214);
            this.la_member_pwd.Name = "la_member_pwd";
            this.la_member_pwd.Size = new System.Drawing.Size(86, 23);
            this.la_member_pwd.TabIndex = 4;
            this.la_member_pwd.Text = "비밀번호*";
            // 
            // tb_member_email
            // 
            this.tb_member_email.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_member_email.Location = new System.Drawing.Point(689, 410);
            this.tb_member_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_member_email.MaxLength = 30;
            this.tb_member_email.Name = "tb_member_email";
            this.tb_member_email.Size = new System.Drawing.Size(294, 30);
            this.tb_member_email.TabIndex = 13;
            this.tb_member_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_member_email_KeyDown);
            // 
            // la_member_email
            // 
            this.la_member_email.AutoSize = true;
            this.la_member_email.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_member_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
            this.la_member_email.Location = new System.Drawing.Point(545, 414);
            this.la_member_email.Name = "la_member_email";
            this.la_member_email.Size = new System.Drawing.Size(69, 23);
            this.la_member_email.TabIndex = 6;
            this.la_member_email.Text = "이메일*";
            // 
            // la_member_phonenum
            // 
            this.la_member_phonenum.AutoSize = true;
            this.la_member_phonenum.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_member_phonenum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
            this.la_member_phonenum.Location = new System.Drawing.Point(545, 464);
            this.la_member_phonenum.Name = "la_member_phonenum";
            this.la_member_phonenum.Size = new System.Drawing.Size(103, 23);
            this.la_member_phonenum.TabIndex = 10;
            this.la_member_phonenum.Text = "핸드폰번호*";
            // 
            // tb_member_phonenum2
            // 
            this.tb_member_phonenum2.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_member_phonenum2.Location = new System.Drawing.Point(800, 460);
            this.tb_member_phonenum2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_member_phonenum2.MaxLength = 4;
            this.tb_member_phonenum2.Name = "tb_member_phonenum2";
            this.tb_member_phonenum2.Size = new System.Drawing.Size(70, 30);
            this.tb_member_phonenum2.TabIndex = 16;
            this.tb_member_phonenum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_member_phonenum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_num_KeyPress);
            // 
            // tb_member_phonenum3
            // 
            this.tb_member_phonenum3.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_member_phonenum3.Location = new System.Drawing.Point(911, 460);
            this.tb_member_phonenum3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_member_phonenum3.MaxLength = 4;
            this.tb_member_phonenum3.Name = "tb_member_phonenum3";
            this.tb_member_phonenum3.Size = new System.Drawing.Size(70, 30);
            this.tb_member_phonenum3.TabIndex = 17;
            this.tb_member_phonenum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_member_phonenum3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_num_KeyPress);
            // 
            // bar_1
            // 
            this.bar_1.AutoSize = true;
            this.bar_1.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bar_1.ForeColor = System.Drawing.Color.DimGray;
            this.bar_1.Location = new System.Drawing.Point(771, 464);
            this.bar_1.Name = "bar_1";
            this.bar_1.Size = new System.Drawing.Size(17, 23);
            this.bar_1.TabIndex = 13;
            this.bar_1.Text = "-";
            // 
            // bar_2
            // 
            this.bar_2.AutoSize = true;
            this.bar_2.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bar_2.ForeColor = System.Drawing.Color.DimGray;
            this.bar_2.Location = new System.Drawing.Point(882, 464);
            this.bar_2.Name = "bar_2";
            this.bar_2.Size = new System.Drawing.Size(17, 23);
            this.bar_2.TabIndex = 14;
            this.bar_2.Text = "-";
            // 
            // tb_member_phonenum1
            // 
            this.tb_member_phonenum1.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_member_phonenum1.Location = new System.Drawing.Point(689, 460);
            this.tb_member_phonenum1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_member_phonenum1.MaxLength = 3;
            this.tb_member_phonenum1.Name = "tb_member_phonenum1";
            this.tb_member_phonenum1.Size = new System.Drawing.Size(70, 30);
            this.tb_member_phonenum1.TabIndex = 15;
            this.tb_member_phonenum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_member_phonenum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_num_KeyPress);
            // 
            // tb_member_pwdend
            // 
            this.tb_member_pwdend.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_member_pwdend.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_member_pwdend.Location = new System.Drawing.Point(689, 260);
            this.tb_member_pwdend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_member_pwdend.MaxLength = 20;
            this.tb_member_pwdend.Name = "tb_member_pwdend";
            this.tb_member_pwdend.PasswordChar = '*';
            this.tb_member_pwdend.Size = new System.Drawing.Size(294, 30);
            this.tb_member_pwdend.TabIndex = 9;
            this.tb_member_pwdend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_member_pwdend_KeyDown);
            // 
            // la_member_pwdend
            // 
            this.la_member_pwdend.AutoSize = true;
            this.la_member_pwdend.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_member_pwdend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
            this.la_member_pwdend.Location = new System.Drawing.Point(545, 264);
            this.la_member_pwdend.Name = "la_member_pwdend";
            this.la_member_pwdend.Size = new System.Drawing.Size(120, 23);
            this.la_member_pwdend.TabIndex = 16;
            this.la_member_pwdend.Text = "비밀번호확인*";
            // 
            // tb_member_name
            // 
            this.tb_member_name.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_member_name.Location = new System.Drawing.Point(690, 310);
            this.tb_member_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_member_name.MaxLength = 5;
            this.tb_member_name.Name = "tb_member_name";
            this.tb_member_name.Size = new System.Drawing.Size(294, 30);
            this.tb_member_name.TabIndex = 10;
            // 
            // la_member_name
            // 
            this.la_member_name.AutoSize = true;
            this.la_member_name.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_member_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
            this.la_member_name.Location = new System.Drawing.Point(545, 314);
            this.la_member_name.Name = "la_member_name";
            this.la_member_name.Size = new System.Drawing.Size(98, 23);
            this.la_member_name.TabIndex = 18;
            this.la_member_name.Text = "성명(실명)*";
            // 
            // la_inco
            // 
            this.la_inco.AutoSize = true;
            this.la_inco.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_inco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
            this.la_inco.Location = new System.Drawing.Point(545, 564);
            this.la_inco.Name = "la_inco";
            this.la_inco.Size = new System.Drawing.Size(78, 23);
            this.la_inco.TabIndex = 20;
            this.la_inco.Text = "수신동의";
            // 
            // radio_member_email
            // 
            this.radio_member_email.AutoSize = true;
            this.radio_member_email.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radio_member_email.Location = new System.Drawing.Point(690, 562);
            this.radio_member_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio_member_email.Name = "radio_member_email";
            this.radio_member_email.Size = new System.Drawing.Size(82, 27);
            this.radio_member_email.TabIndex = 21;
            this.radio_member_email.Text = "이메일";
            this.radio_member_email.UseVisualStyleBackColor = true;
            this.radio_member_email.CheckedChanged += new System.EventHandler(this.radio_member_email_CheckedChanged);
            // 
            // radio_member_sms
            // 
            this.radio_member_sms.AutoSize = true;
            this.radio_member_sms.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radio_member_sms.Location = new System.Drawing.Point(797, 562);
            this.radio_member_sms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio_member_sms.Name = "radio_member_sms";
            this.radio_member_sms.Size = new System.Drawing.Size(65, 27);
            this.radio_member_sms.TabIndex = 22;
            this.radio_member_sms.Text = "SMS";
            this.radio_member_sms.UseVisualStyleBackColor = true;
            this.radio_member_sms.CheckedChanged += new System.EventHandler(this.radio_member_sms_CheckedChanged);
            // 
            // la_member_housenum
            // 
            this.la_member_housenum.AutoSize = true;
            this.la_member_housenum.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_member_housenum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
            this.la_member_housenum.Location = new System.Drawing.Point(545, 514);
            this.la_member_housenum.Name = "la_member_housenum";
            this.la_member_housenum.Size = new System.Drawing.Size(78, 23);
            this.la_member_housenum.TabIndex = 23;
            this.la_member_housenum.Text = "자택번호";
            // 
            // tb_member_housenum1
            // 
            this.tb_member_housenum1.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_member_housenum1.Location = new System.Drawing.Point(689, 510);
            this.tb_member_housenum1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_member_housenum1.MaxLength = 3;
            this.tb_member_housenum1.Name = "tb_member_housenum1";
            this.tb_member_housenum1.Size = new System.Drawing.Size(70, 30);
            this.tb_member_housenum1.TabIndex = 18;
            this.tb_member_housenum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_member_housenum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_num_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(882, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(771, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "-";
            // 
            // tb_member_housenum3
            // 
            this.tb_member_housenum3.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_member_housenum3.Location = new System.Drawing.Point(911, 510);
            this.tb_member_housenum3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_member_housenum3.MaxLength = 4;
            this.tb_member_housenum3.Name = "tb_member_housenum3";
            this.tb_member_housenum3.Size = new System.Drawing.Size(70, 30);
            this.tb_member_housenum3.TabIndex = 20;
            this.tb_member_housenum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_member_housenum3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_num_KeyPress);
            // 
            // tb_member_housenum2
            // 
            this.tb_member_housenum2.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_member_housenum2.Location = new System.Drawing.Point(800, 510);
            this.tb_member_housenum2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_member_housenum2.MaxLength = 4;
            this.tb_member_housenum2.Name = "tb_member_housenum2";
            this.tb_member_housenum2.Size = new System.Drawing.Size(70, 30);
            this.tb_member_housenum2.TabIndex = 19;
            this.tb_member_housenum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_member_housenum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_num_KeyPress);
            // 
            // mem_completion_btn
            // 
            this.mem_completion_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(125)))), ((int)(((byte)(179)))));
            this.mem_completion_btn.FlatAppearance.BorderSize = 0;
            this.mem_completion_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mem_completion_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mem_completion_btn.ForeColor = System.Drawing.Color.White;
            this.mem_completion_btn.Location = new System.Drawing.Point(713, 632);
            this.mem_completion_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mem_completion_btn.Name = "mem_completion_btn";
            this.mem_completion_btn.Size = new System.Drawing.Size(131, 34);
            this.mem_completion_btn.TabIndex = 24;
            this.mem_completion_btn.Text = "가입완료";
            this.mem_completion_btn.UseVisualStyleBackColor = false;
            this.mem_completion_btn.Click += new System.EventHandler(this.mem_completion_btn_Click);
            // 
            // mem_cancel_btn
            // 
            this.mem_cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(132)))), ((int)(((byte)(21)))));
            this.mem_cancel_btn.FlatAppearance.BorderSize = 0;
            this.mem_cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mem_cancel_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mem_cancel_btn.ForeColor = System.Drawing.Color.White;
            this.mem_cancel_btn.Location = new System.Drawing.Point(850, 632);
            this.mem_cancel_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mem_cancel_btn.Name = "mem_cancel_btn";
            this.mem_cancel_btn.Size = new System.Drawing.Size(131, 34);
            this.mem_cancel_btn.TabIndex = 25;
            this.mem_cancel_btn.Text = "가입취소";
            this.mem_cancel_btn.UseVisualStyleBackColor = false;
            this.mem_cancel_btn.Click += new System.EventHandler(this.mem_cancel_btn_Click);
            // 
            // pa_information
            // 
            this.pa_information.BackColor = System.Drawing.Color.White;
            this.pa_information.Controls.Add(this.information_false_btn);
            this.pa_information.Controls.Add(this.information_true_btn);
            this.pa_information.Controls.Add(this.ra_information_false);
            this.pa_information.Controls.Add(this.ra_information_true);
            this.pa_information.Controls.Add(this.textBox1);
            this.pa_information.Location = new System.Drawing.Point(12, 11);
            this.pa_information.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pa_information.Name = "pa_information";
            this.pa_information.Size = new System.Drawing.Size(1378, 768);
            this.pa_information.TabIndex = 1;
            // 
            // information_false_btn
            // 
            this.information_false_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(132)))), ((int)(((byte)(21)))));
            this.information_false_btn.FlatAppearance.BorderSize = 0;
            this.information_false_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.information_false_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.information_false_btn.ForeColor = System.Drawing.Color.White;
            this.information_false_btn.Location = new System.Drawing.Point(1062, 660);
            this.information_false_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.information_false_btn.Name = "information_false_btn";
            this.information_false_btn.Size = new System.Drawing.Size(131, 34);
            this.information_false_btn.TabIndex = 4;
            this.information_false_btn.Text = "취소";
            this.information_false_btn.UseVisualStyleBackColor = false;
            this.information_false_btn.Click += new System.EventHandler(this.information_false_btn_Click);
            // 
            // information_true_btn
            // 
            this.information_true_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(125)))), ((int)(((byte)(179)))));
            this.information_true_btn.FlatAppearance.BorderSize = 0;
            this.information_true_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.information_true_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.information_true_btn.ForeColor = System.Drawing.Color.White;
            this.information_true_btn.Location = new System.Drawing.Point(925, 660);
            this.information_true_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.information_true_btn.Name = "information_true_btn";
            this.information_true_btn.Size = new System.Drawing.Size(131, 34);
            this.information_true_btn.TabIndex = 3;
            this.information_true_btn.Text = "확인";
            this.information_true_btn.UseVisualStyleBackColor = false;
            this.information_true_btn.Click += new System.EventHandler(this.information_true_btn_Click);
            // 
            // ra_information_false
            // 
            this.ra_information_false.AutoSize = true;
            this.ra_information_false.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ra_information_false.Location = new System.Drawing.Point(1048, 621);
            this.ra_information_false.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ra_information_false.Name = "ra_information_false";
            this.ra_information_false.Size = new System.Drawing.Size(145, 27);
            this.ra_information_false.TabIndex = 2;
            this.ra_information_false.TabStop = true;
            this.ra_information_false.Text = "동의 하지 않음";
            this.ra_information_false.UseVisualStyleBackColor = true;
            this.ra_information_false.CheckedChanged += new System.EventHandler(this.ra_information_false_CheckedChanged);
            // 
            // ra_information_true
            // 
            this.ra_information_true.AutoSize = true;
            this.ra_information_true.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ra_information_true.Location = new System.Drawing.Point(938, 621);
            this.ra_information_true.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ra_information_true.Name = "ra_information_true";
            this.ra_information_true.Size = new System.Drawing.Size(88, 27);
            this.ra_information_true.TabIndex = 1;
            this.ra_information_true.TabStop = true;
            this.ra_information_true.Text = "동의 함";
            this.ra_information_true.UseVisualStyleBackColor = true;
            this.ra_information_true.CheckedChanged += new System.EventHandler(this.ra_information_true_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(192, 68);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1001, 539);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // pwd_view_btn
            // 
            this.pwd_view_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(125)))), ((int)(((byte)(179)))));
            this.pwd_view_btn.FlatAppearance.BorderSize = 0;
            this.pwd_view_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pwd_view_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwd_view_btn.ForeColor = System.Drawing.Color.White;
            this.pwd_view_btn.Location = new System.Drawing.Point(1000, 210);
            this.pwd_view_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pwd_view_btn.Name = "pwd_view_btn";
            this.pwd_view_btn.Size = new System.Drawing.Size(96, 32);
            this.pwd_view_btn.TabIndex = 8;
            this.pwd_view_btn.TabStop = false;
            this.pwd_view_btn.Text = "번호보기";
            this.pwd_view_btn.UseVisualStyleBackColor = false;
            this.pwd_view_btn.Click += new System.EventHandler(this.pwd_view_btn_Click);
            // 
            // id_overlap_btn
            // 
            this.id_overlap_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(125)))), ((int)(((byte)(179)))));
            this.id_overlap_btn.FlatAppearance.BorderSize = 0;
            this.id_overlap_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.id_overlap_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id_overlap_btn.ForeColor = System.Drawing.Color.White;
            this.id_overlap_btn.Location = new System.Drawing.Point(1000, 160);
            this.id_overlap_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.id_overlap_btn.Name = "id_overlap_btn";
            this.id_overlap_btn.Size = new System.Drawing.Size(96, 32);
            this.id_overlap_btn.TabIndex = 6;
            this.id_overlap_btn.Text = "중복확인";
            this.id_overlap_btn.UseVisualStyleBackColor = false;
            this.id_overlap_btn.Click += new System.EventHandler(this.id_overlap_btn_Click);
            // 
            // email_overlap_btn
            // 
            this.email_overlap_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(125)))), ((int)(((byte)(179)))));
            this.email_overlap_btn.FlatAppearance.BorderSize = 0;
            this.email_overlap_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.email_overlap_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.email_overlap_btn.ForeColor = System.Drawing.Color.White;
            this.email_overlap_btn.Location = new System.Drawing.Point(1000, 410);
            this.email_overlap_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.email_overlap_btn.Name = "email_overlap_btn";
            this.email_overlap_btn.Size = new System.Drawing.Size(96, 32);
            this.email_overlap_btn.TabIndex = 14;
            this.email_overlap_btn.Text = "중복확인";
            this.email_overlap_btn.UseVisualStyleBackColor = false;
            this.email_overlap_btn.Click += new System.EventHandler(this.email_overlap_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(865, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "* 필수입력항목";
            // 
            // id_la
            // 
            this.id_la.AutoSize = true;
            this.id_la.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id_la.ForeColor = System.Drawing.Color.Red;
            this.id_la.Location = new System.Drawing.Point(1105, 166);
            this.id_la.Name = "id_la";
            this.id_la.Size = new System.Drawing.Size(173, 23);
            this.id_la.TabIndex = 36;
            this.id_la.Text = "중복확인을 해주세요.";
            // 
            // email_la
            // 
            this.email_la.AutoSize = true;
            this.email_la.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.email_la.ForeColor = System.Drawing.Color.Red;
            this.email_la.Location = new System.Drawing.Point(1105, 414);
            this.email_la.Name = "email_la";
            this.email_la.Size = new System.Drawing.Size(173, 23);
            this.email_la.TabIndex = 37;
            this.email_la.Text = "중복확인을 해주세요.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(1007, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 23);
            this.label4.TabIndex = 38;
            this.label4.Text = "※ 미입력시 자동 수신거부 됩니다.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1105, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "8~20 글자의 영어와 숫자만 입력";
            // 
            // radio_member_false
            // 
            this.radio_member_false.AutoSize = true;
            this.radio_member_false.Checked = true;
            this.radio_member_false.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radio_member_false.Location = new System.Drawing.Point(890, 562);
            this.radio_member_false.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio_member_false.Name = "radio_member_false";
            this.radio_member_false.Size = new System.Drawing.Size(99, 27);
            this.radio_member_false.TabIndex = 23;
            this.radio_member_false.TabStop = true;
            this.radio_member_false.Text = "수신거부";
            this.radio_member_false.UseVisualStyleBackColor = true;
            this.radio_member_false.CheckedChanged += new System.EventHandler(this.radio_member_false_CheckedChanged);
            // 
            // la_pwdend_check
            // 
            this.la_pwdend_check.AutoSize = true;
            this.la_pwdend_check.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_pwdend_check.ForeColor = System.Drawing.Color.Red;
            this.la_pwdend_check.Location = new System.Drawing.Point(999, 264);
            this.la_pwdend_check.Name = "la_pwdend_check";
            this.la_pwdend_check.Size = new System.Drawing.Size(0, 23);
            this.la_pwdend_check.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(1105, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "※ 입력 후 ENTER";
            // 
            // tb_member_front
            // 
            this.tb_member_front.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_member_front.Location = new System.Drawing.Point(689, 360);
            this.tb_member_front.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_member_front.MaxLength = 6;
            this.tb_member_front.Name = "tb_member_front";
            this.tb_member_front.Size = new System.Drawing.Size(129, 30);
            this.tb_member_front.TabIndex = 11;
            this.tb_member_front.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_member_front.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_member_front_KeyPress);
            // 
            // la_member_front_end_sex
            // 
            this.la_member_front_end_sex.AutoSize = true;
            this.la_member_front_end_sex.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_member_front_end_sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
            this.la_member_front_end_sex.Location = new System.Drawing.Point(545, 364);
            this.la_member_front_end_sex.Name = "la_member_front_end_sex";
            this.la_member_front_end_sex.Size = new System.Drawing.Size(120, 23);
            this.la_member_front_end_sex.TabIndex = 8;
            this.la_member_front_end_sex.Text = "주민등록번호*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(825, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 23);
            this.label7.TabIndex = 43;
            this.label7.Text = "-";
            // 
            // tb_member_sex
            // 
            this.tb_member_sex.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_member_sex.Location = new System.Drawing.Point(849, 361);
            this.tb_member_sex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_member_sex.MaxLength = 1;
            this.tb_member_sex.Name = "tb_member_sex";
            this.tb_member_sex.Size = new System.Drawing.Size(26, 30);
            this.tb_member_sex.TabIndex = 12;
            this.tb_member_sex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_member_sex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_member_front_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(876, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 32);
            this.label8.TabIndex = 45;
            this.label8.Text = "* * * * * *";
            // 
            // mem_update_btn
            // 
            this.mem_update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(125)))), ((int)(((byte)(179)))));
            this.mem_update_btn.FlatAppearance.BorderSize = 0;
            this.mem_update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mem_update_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mem_update_btn.ForeColor = System.Drawing.Color.White;
            this.mem_update_btn.Location = new System.Drawing.Point(711, 632);
            this.mem_update_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mem_update_btn.Name = "mem_update_btn";
            this.mem_update_btn.Size = new System.Drawing.Size(131, 34);
            this.mem_update_btn.TabIndex = 46;
            this.mem_update_btn.Text = "회원수정";
            this.mem_update_btn.UseVisualStyleBackColor = false;
            this.mem_update_btn.Visible = false;
            this.mem_update_btn.Click += new System.EventHandler(this.mem_update_btn_Click);
            // 
            // mem_update_cancle_btn
            // 
            this.mem_update_cancle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(132)))), ((int)(((byte)(21)))));
            this.mem_update_cancle_btn.FlatAppearance.BorderSize = 0;
            this.mem_update_cancle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mem_update_cancle_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mem_update_cancle_btn.ForeColor = System.Drawing.Color.White;
            this.mem_update_cancle_btn.Location = new System.Drawing.Point(850, 632);
            this.mem_update_cancle_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mem_update_cancle_btn.Name = "mem_update_cancle_btn";
            this.mem_update_cancle_btn.Size = new System.Drawing.Size(131, 34);
            this.mem_update_cancle_btn.TabIndex = 47;
            this.mem_update_cancle_btn.Text = "돌아가기";
            this.mem_update_cancle_btn.UseVisualStyleBackColor = false;
            this.mem_update_cancle_btn.Visible = false;
            this.mem_update_cancle_btn.Click += new System.EventHandler(this.mem_update_cancle_btn_Click);
            // 
            // mem_delete_btn
            // 
            this.mem_delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mem_delete_btn.FlatAppearance.BorderSize = 0;
            this.mem_delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mem_delete_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mem_delete_btn.ForeColor = System.Drawing.Color.White;
            this.mem_delete_btn.Location = new System.Drawing.Point(1149, 632);
            this.mem_delete_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mem_delete_btn.Name = "mem_delete_btn";
            this.mem_delete_btn.Size = new System.Drawing.Size(131, 34);
            this.mem_delete_btn.TabIndex = 48;
            this.mem_delete_btn.Text = "회원탈퇴";
            this.mem_delete_btn.UseVisualStyleBackColor = false;
            this.mem_delete_btn.Visible = false;
            this.mem_delete_btn.Click += new System.EventHandler(this.mem_delete_btn_Click);
            // 
            // membership_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.pa_information);
            this.Controls.Add(this.la_pwdend_check);
            this.Controls.Add(this.tb_member_housenum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_member_housenum3);
            this.Controls.Add(this.tb_member_housenum2);
            this.Controls.Add(this.la_member_housenum);
            this.Controls.Add(this.radio_member_sms);
            this.Controls.Add(this.radio_member_email);
            this.Controls.Add(this.la_inco);
            this.Controls.Add(this.tb_member_name);
            this.Controls.Add(this.la_member_name);
            this.Controls.Add(this.tb_member_pwdend);
            this.Controls.Add(this.la_member_pwdend);
            this.Controls.Add(this.tb_member_phonenum1);
            this.Controls.Add(this.bar_2);
            this.Controls.Add(this.bar_1);
            this.Controls.Add(this.tb_member_phonenum3);
            this.Controls.Add(this.tb_member_phonenum2);
            this.Controls.Add(this.la_member_phonenum);
            this.Controls.Add(this.tb_member_front);
            this.Controls.Add(this.la_member_front_end_sex);
            this.Controls.Add(this.tb_member_email);
            this.Controls.Add(this.la_member_email);
            this.Controls.Add(this.tb_member_pwd);
            this.Controls.Add(this.la_member_pwd);
            this.Controls.Add(this.tb_member_id);
            this.Controls.Add(this.la_member_id);
            this.Controls.Add(this.logoimage);
            this.Controls.Add(this.email_overlap_btn);
            this.Controls.Add(this.email_la);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.id_la);
            this.Controls.Add(this.pwd_view_btn);
            this.Controls.Add(this.id_overlap_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radio_member_false);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_member_sex);
            this.Controls.Add(this.mem_delete_btn);
            this.Controls.Add(this.mem_completion_btn);
            this.Controls.Add(this.mem_cancel_btn);
            this.Controls.Add(this.mem_update_btn);
            this.Controls.Add(this.mem_update_cancle_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "membership_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.logoimage)).EndInit();
            this.pa_information.ResumeLayout(false);
            this.pa_information.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoimage;
        private System.Windows.Forms.Label la_member_id;
        private System.Windows.Forms.TextBox tb_member_id;
        private System.Windows.Forms.TextBox tb_member_pwd;
        private System.Windows.Forms.Label la_member_pwd;
        private System.Windows.Forms.TextBox tb_member_email;
        private System.Windows.Forms.Label la_member_email;
        private System.Windows.Forms.Label la_member_phonenum;
        private System.Windows.Forms.TextBox tb_member_phonenum2;
        private System.Windows.Forms.TextBox tb_member_phonenum3;
        private System.Windows.Forms.Label bar_1;
        private System.Windows.Forms.Label bar_2;
        private System.Windows.Forms.TextBox tb_member_phonenum1;
        private System.Windows.Forms.TextBox tb_member_pwdend;
        private System.Windows.Forms.Label la_member_pwdend;
        private System.Windows.Forms.TextBox tb_member_name;
        private System.Windows.Forms.Label la_member_name;
        private System.Windows.Forms.Label la_inco;
        private System.Windows.Forms.RadioButton radio_member_email;
        private System.Windows.Forms.RadioButton radio_member_sms;
        private System.Windows.Forms.Label la_member_housenum;
        private System.Windows.Forms.TextBox tb_member_housenum1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_member_housenum3;
        private System.Windows.Forms.TextBox tb_member_housenum2;
        private System.Windows.Forms.Button mem_completion_btn;
        private System.Windows.Forms.Button mem_cancel_btn;
        private System.Windows.Forms.Panel pa_information;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radio_information_true;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.RadioButton ra_information_true;
        private System.Windows.Forms.RadioButton ra_information_false;
        private System.Windows.Forms.Button information_true_btn;
        private System.Windows.Forms.Button information_false_btn;
        private System.Windows.Forms.Button pwd_view_btn;
        private System.Windows.Forms.Button id_overlap_btn;
        private System.Windows.Forms.Button email_overlap_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label id_la;
        private System.Windows.Forms.Label email_la;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radio_member_false;
        private System.Windows.Forms.Label la_pwdend_check;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_member_front;
        private System.Windows.Forms.Label la_member_front_end_sex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_member_sex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button mem_update_btn;
        private System.Windows.Forms.Button mem_update_cancle_btn;
        private System.Windows.Forms.Button mem_delete_btn;
    }
}