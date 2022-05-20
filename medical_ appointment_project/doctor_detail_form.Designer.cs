namespace medical__appointment_project
{
    partial class doctor_detail_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctor_detail_form));
            this.detail_picture = new System.Windows.Forms.PictureBox();
            this.detail_logo = new System.Windows.Forms.PictureBox();
            this.la1 = new System.Windows.Forms.Label();
            this.la2 = new System.Windows.Forms.Label();
            this.la3 = new System.Windows.Forms.Label();
            this.la4 = new System.Windows.Forms.Label();
            this.detail_name = new System.Windows.Forms.Label();
            this.detail_dep = new System.Windows.Forms.Label();
            this.detail_phone = new System.Windows.Forms.Label();
            this.detail_email = new System.Windows.Forms.Label();
            this.la5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.detail_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // detail_picture
            // 
            this.detail_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detail_picture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("detail_picture.ErrorImage")));
            this.detail_picture.Image = ((System.Drawing.Image)(resources.GetObject("detail_picture.Image")));
            this.detail_picture.InitialImage = null;
            this.detail_picture.Location = new System.Drawing.Point(63, 112);
            this.detail_picture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.detail_picture.Name = "detail_picture";
            this.detail_picture.Size = new System.Drawing.Size(155, 213);
            this.detail_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.detail_picture.TabIndex = 0;
            this.detail_picture.TabStop = false;
            // 
            // detail_logo
            // 
            this.detail_logo.Image = ((System.Drawing.Image)(resources.GetObject("detail_logo.Image")));
            this.detail_logo.Location = new System.Drawing.Point(217, -1);
            this.detail_logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.detail_logo.Name = "detail_logo";
            this.detail_logo.Size = new System.Drawing.Size(247, 114);
            this.detail_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.detail_logo.TabIndex = 1;
            this.detail_logo.TabStop = false;
            // 
            // la1
            // 
            this.la1.AutoSize = true;
            this.la1.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la1.Location = new System.Drawing.Point(261, 134);
            this.la1.Name = "la1";
            this.la1.Size = new System.Drawing.Size(50, 25);
            this.la1.TabIndex = 29;
            this.la1.Text = "이름";
            // 
            // la2
            // 
            this.la2.AutoSize = true;
            this.la2.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la2.Location = new System.Drawing.Point(261, 184);
            this.la2.Name = "la2";
            this.la2.Size = new System.Drawing.Size(69, 25);
            this.la2.TabIndex = 30;
            this.la2.Text = "진료과";
            // 
            // la3
            // 
            this.la3.AutoSize = true;
            this.la3.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la3.Location = new System.Drawing.Point(261, 234);
            this.la3.Name = "la3";
            this.la3.Size = new System.Drawing.Size(44, 25);
            this.la3.TabIndex = 31;
            this.la3.Text = "P·H";
            // 
            // la4
            // 
            this.la4.AutoSize = true;
            this.la4.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la4.Location = new System.Drawing.Point(261, 284);
            this.la4.Name = "la4";
            this.la4.Size = new System.Drawing.Size(60, 25);
            this.la4.TabIndex = 32;
            this.la4.Text = "Email";
            // 
            // detail_name
            // 
            this.detail_name.AutoSize = true;
            this.detail_name.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.detail_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(113)))), ((int)(((byte)(156)))));
            this.detail_name.Location = new System.Drawing.Point(415, 134);
            this.detail_name.Name = "detail_name";
            this.detail_name.Size = new System.Drawing.Size(50, 25);
            this.detail_name.TabIndex = 33;
            this.detail_name.Text = "이름";
            // 
            // detail_dep
            // 
            this.detail_dep.AutoSize = true;
            this.detail_dep.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.detail_dep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(113)))), ((int)(((byte)(156)))));
            this.detail_dep.Location = new System.Drawing.Point(415, 184);
            this.detail_dep.Name = "detail_dep";
            this.detail_dep.Size = new System.Drawing.Size(69, 25);
            this.detail_dep.TabIndex = 34;
            this.detail_dep.Text = "진료과";
            // 
            // detail_phone
            // 
            this.detail_phone.AutoSize = true;
            this.detail_phone.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.detail_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(113)))), ((int)(((byte)(156)))));
            this.detail_phone.Location = new System.Drawing.Point(415, 234);
            this.detail_phone.Name = "detail_phone";
            this.detail_phone.Size = new System.Drawing.Size(31, 25);
            this.detail_phone.TabIndex = 35;
            this.detail_phone.Text = "폰";
            // 
            // detail_email
            // 
            this.detail_email.AutoSize = true;
            this.detail_email.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.detail_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(113)))), ((int)(((byte)(156)))));
            this.detail_email.Location = new System.Drawing.Point(415, 284);
            this.detail_email.Name = "detail_email";
            this.detail_email.Size = new System.Drawing.Size(69, 25);
            this.detail_email.TabIndex = 36;
            this.detail_email.Text = "이메일";
            // 
            // la5
            // 
            this.la5.AutoSize = true;
            this.la5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la5.Location = new System.Drawing.Point(58, 364);
            this.la5.Name = "la5";
            this.la5.Size = new System.Drawing.Size(206, 28);
            this.la5.TabIndex = 37;
            this.la5.Text = "학력사항 및 경력사항";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(58, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 38;
            this.label1.Text = "활동사항";
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(132)))), ((int)(((byte)(21)))));
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(540, 726);
            this.close_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(114, 47);
            this.close_btn.TabIndex = 51;
            this.close_btn.Text = "닫기";
            this.close_btn.UseVisualStyleBackColor = false;
           
            // 
            // doctor_detail_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 800);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.la5);
            this.Controls.Add(this.detail_email);
            this.Controls.Add(this.detail_phone);
            this.Controls.Add(this.detail_dep);
            this.Controls.Add(this.detail_name);
            this.Controls.Add(this.la4);
            this.Controls.Add(this.la3);
            this.Controls.Add(this.la2);
            this.Controls.Add(this.la1);
            this.Controls.Add(this.detail_logo);
            this.Controls.Add(this.detail_picture);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "doctor_detail_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.detail_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox detail_picture;
        private System.Windows.Forms.PictureBox detail_logo;
        private System.Windows.Forms.Label la1;
        private System.Windows.Forms.Label la2;
        private System.Windows.Forms.Label la3;
        private System.Windows.Forms.Label la4;
        private System.Windows.Forms.Label detail_name;
        private System.Windows.Forms.Label detail_dep;
        private System.Windows.Forms.Label detail_phone;
        private System.Windows.Forms.Label detail_email;
        private System.Windows.Forms.Label la5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close_btn;
    }
}