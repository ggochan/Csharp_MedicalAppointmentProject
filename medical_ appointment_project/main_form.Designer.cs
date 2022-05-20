namespace medical__appointment_project
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.logoimage = new System.Windows.Forms.PictureBox();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.pwd_textbox = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.membership_btn = new System.Windows.Forms.Button();
            this.pa_login = new System.Windows.Forms.Panel();
            this.pa_login_true = new System.Windows.Forms.Panel();
            this.member_up_de = new System.Windows.Forms.Button();
            this.select_btn = new System.Windows.Forms.Button();
            this.reservation_btn = new System.Windows.Forms.Button();
            this.la_login = new System.Windows.Forms.Label();
            this.la_login2 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.b_login_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoimage)).BeginInit();
            this.pa_login.SuspendLayout();
            this.pa_login_true.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoimage
            // 
            this.logoimage.BackColor = System.Drawing.Color.White;
            this.logoimage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoimage.BackgroundImage")));
            this.logoimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoimage.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoimage.InitialImage")));
            this.logoimage.Location = new System.Drawing.Point(246, 242);
            this.logoimage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoimage.Name = "logoimage";
            this.logoimage.Size = new System.Drawing.Size(450, 250);
            this.logoimage.TabIndex = 0;
            this.logoimage.TabStop = false;
            // 
            // id_textbox
            // 
            this.id_textbox.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id_textbox.Location = new System.Drawing.Point(54, 88);
            this.id_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(274, 30);
            this.id_textbox.TabIndex = 1;
            // 
            // pwd_textbox
            // 
            this.pwd_textbox.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwd_textbox.Location = new System.Drawing.Point(54, 128);
            this.pwd_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pwd_textbox.Name = "pwd_textbox";
            this.pwd_textbox.PasswordChar = '*';
            this.pwd_textbox.Size = new System.Drawing.Size(274, 30);
            this.pwd_textbox.TabIndex = 2;
            this.pwd_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pwd_textbox_KeyDown);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(125)))), ((int)(((byte)(179)))));
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(54, 168);
            this.login_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(134, 34);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "로그인";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // membership_btn
            // 
            this.membership_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(125)))), ((int)(((byte)(179)))));
            this.membership_btn.FlatAppearance.BorderSize = 0;
            this.membership_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.membership_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.membership_btn.ForeColor = System.Drawing.Color.White;
            this.membership_btn.Location = new System.Drawing.Point(194, 168);
            this.membership_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.membership_btn.Name = "membership_btn";
            this.membership_btn.Size = new System.Drawing.Size(134, 34);
            this.membership_btn.TabIndex = 5;
            this.membership_btn.Text = "회원가입";
            this.membership_btn.UseVisualStyleBackColor = false;
            this.membership_btn.Click += new System.EventHandler(this.membership_btn_Click);
            // 
            // pa_login
            // 
            this.pa_login.Controls.Add(this.b_login_btn);
            this.pa_login.Controls.Add(this.membership_btn);
            this.pa_login.Controls.Add(this.id_textbox);
            this.pa_login.Controls.Add(this.login_btn);
            this.pa_login.Controls.Add(this.pwd_textbox);
            this.pa_login.Location = new System.Drawing.Point(821, 218);
            this.pa_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pa_login.Name = "pa_login";
            this.pa_login.Size = new System.Drawing.Size(381, 250);
            this.pa_login.TabIndex = 6;
            // 
            // pa_login_true
            // 
            this.pa_login_true.BackColor = System.Drawing.Color.White;
            this.pa_login_true.Controls.Add(this.member_up_de);
            this.pa_login_true.Controls.Add(this.select_btn);
            this.pa_login_true.Controls.Add(this.reservation_btn);
            this.pa_login_true.Controls.Add(this.la_login);
            this.pa_login_true.Controls.Add(this.la_login2);
            this.pa_login_true.Controls.Add(this.logout_btn);
            this.pa_login_true.Location = new System.Drawing.Point(743, 236);
            this.pa_login_true.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pa_login_true.Name = "pa_login_true";
            this.pa_login_true.Size = new System.Drawing.Size(528, 250);
            this.pa_login_true.TabIndex = 5;
            // 
            // member_up_de
            // 
            this.member_up_de.BackColor = System.Drawing.Color.Gray;
            this.member_up_de.FlatAppearance.BorderSize = 0;
            this.member_up_de.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.member_up_de.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.member_up_de.ForeColor = System.Drawing.Color.White;
            this.member_up_de.Location = new System.Drawing.Point(334, 104);
            this.member_up_de.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.member_up_de.Name = "member_up_de";
            this.member_up_de.Size = new System.Drawing.Size(87, 32);
            this.member_up_de.TabIndex = 8;
            this.member_up_de.Text = "정보수정";
            this.member_up_de.UseVisualStyleBackColor = false;
            this.member_up_de.Click += new System.EventHandler(this.member_up_de_Click);
            // 
            // select_btn
            // 
            this.select_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(125)))), ((int)(((byte)(179)))));
            this.select_btn.FlatAppearance.BorderSize = 0;
            this.select_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_btn.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.select_btn.ForeColor = System.Drawing.Color.White;
            this.select_btn.Location = new System.Drawing.Point(219, 141);
            this.select_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(202, 98);
            this.select_btn.TabIndex = 7;
            this.select_btn.Text = "예약조회";
            this.select_btn.UseVisualStyleBackColor = false;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // reservation_btn
            // 
            this.reservation_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(132)))), ((int)(((byte)(21)))));
            this.reservation_btn.FlatAppearance.BorderSize = 0;
            this.reservation_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservation_btn.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reservation_btn.ForeColor = System.Drawing.Color.White;
            this.reservation_btn.Location = new System.Drawing.Point(13, 141);
            this.reservation_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reservation_btn.Name = "reservation_btn";
            this.reservation_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reservation_btn.Size = new System.Drawing.Size(202, 98);
            this.reservation_btn.TabIndex = 6;
            this.reservation_btn.Text = "진료예약";
            this.reservation_btn.UseVisualStyleBackColor = false;
            this.reservation_btn.Click += new System.EventHandler(this.reservation_btn_Click);
            // 
            // la_login
            // 
            this.la_login.AutoSize = true;
            this.la_login.BackColor = System.Drawing.Color.Transparent;
            this.la_login.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
            this.la_login.Location = new System.Drawing.Point(10, 70);
            this.la_login.Name = "la_login";
            this.la_login.Size = new System.Drawing.Size(89, 32);
            this.la_login.TabIndex = 0;
            this.la_login.Text = "000 님";
            // 
            // la_login2
            // 
            this.la_login2.AutoSize = true;
            this.la_login2.BackColor = System.Drawing.Color.Transparent;
            this.la_login2.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_login2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
            this.la_login2.Location = new System.Drawing.Point(130, 110);
            this.la_login2.Name = "la_login2";
            this.la_login2.Size = new System.Drawing.Size(209, 23);
            this.la_login2.TabIndex = 1;
            this.la_login2.Text = "방문해 주셔서 감사합니다";
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Gray;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(334, 70);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(87, 32);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.Text = "로그아웃";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // b_login_btn
            // 
            this.b_login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(132)))), ((int)(((byte)(21)))));
            this.b_login_btn.FlatAppearance.BorderSize = 0;
            this.b_login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_login_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.b_login_btn.ForeColor = System.Drawing.Color.White;
            this.b_login_btn.Location = new System.Drawing.Point(54, 207);
            this.b_login_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b_login_btn.Name = "b_login_btn";
            this.b_login_btn.Size = new System.Drawing.Size(274, 34);
            this.b_login_btn.TabIndex = 6;
            this.b_login_btn.Text = "비 로그인 접수하기";
            this.b_login_btn.UseVisualStyleBackColor = false;
            this.b_login_btn.Click += new System.EventHandler(this.b_login_btn_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1403, 800);
            this.Controls.Add(this.pa_login);
            this.Controls.Add(this.logoimage);
            this.Controls.Add(this.pa_login_true);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoimage)).EndInit();
            this.pa_login.ResumeLayout(false);
            this.pa_login.PerformLayout();
            this.pa_login_true.ResumeLayout(false);
            this.pa_login_true.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoimage;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.TextBox pwd_textbox;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button membership_btn;
        private System.Windows.Forms.Label la_login;
        private System.Windows.Forms.Label la_login2;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button reservation_btn;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Panel pa_login_true;
        private System.Windows.Forms.Panel pa_login;
        private System.Windows.Forms.Button member_up_de;
        private System.Windows.Forms.Button b_login_btn;
    }
}

