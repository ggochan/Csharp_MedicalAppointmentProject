namespace medical__appointment_project
{
    partial class reservation_up_de_form
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
            this.update_btn = new System.Windows.Forms.Button();
            this.la1 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.sel_listview = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sel_name = new System.Windows.Forms.TextBox();
            this.sel_phone1 = new System.Windows.Forms.TextBox();
            this.sel_front = new System.Windows.Forms.TextBox();
            this.sel_dep = new System.Windows.Forms.TextBox();
            this.sel_doc = new System.Windows.Forms.TextBox();
            this.sel_datetime = new System.Windows.Forms.TextBox();
            this.sel_phone2 = new System.Windows.Forms.TextBox();
            this.sel_phone3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sel_sex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(125)))), ((int)(((byte)(179)))));
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(554, 23);
            this.update_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(114, 54);
            this.update_btn.TabIndex = 54;
            this.update_btn.Text = "예약수정";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // la1
            // 
            this.la1.AutoSize = true;
            this.la1.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la1.Location = new System.Drawing.Point(58, 215);
            this.la1.Name = "la1";
            this.la1.Size = new System.Drawing.Size(50, 25);
            this.la1.TabIndex = 52;
            this.la1.Text = "성명";
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(132)))), ((int)(((byte)(21)))));
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(554, 85);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(114, 54);
            this.delete_btn.TabIndex = 55;
            this.delete_btn.Text = "예약취소";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // sel_listview
            // 
            this.sel_listview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sel_listview.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sel_listview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.sel_listview.Location = new System.Drawing.Point(201, 41);
            this.sel_listview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sel_listview.MultiSelect = false;
            this.sel_listview.Name = "sel_listview";
            this.sel_listview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sel_listview.Scrollable = false;
            this.sel_listview.Size = new System.Drawing.Size(308, 138);
            this.sel_listview.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.sel_listview.TabIndex = 56;
            this.sel_listview.UseCompatibleStateImageBehavior = false;
            this.sel_listview.View = System.Windows.Forms.View.Details;
            this.sel_listview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sel_listview_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(58, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "예약목록";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(58, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "핸드폰번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(58, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 59;
            this.label3.Text = "주민등록번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(58, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 60;
            this.label4.Text = "진료과";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(58, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 61;
            this.label5.Text = "의료진";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(58, 540);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 25);
            this.label6.TabIndex = 62;
            this.label6.Text = "진료날짜 및 시간";
            // 
            // sel_name
            // 
            this.sel_name.Enabled = false;
            this.sel_name.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sel_name.Location = new System.Drawing.Point(250, 212);
            this.sel_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sel_name.Name = "sel_name";
            this.sel_name.Size = new System.Drawing.Size(259, 30);
            this.sel_name.TabIndex = 63;
            this.sel_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sel_phone1
            // 
            this.sel_phone1.Enabled = false;
            this.sel_phone1.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sel_phone1.Location = new System.Drawing.Point(250, 277);
            this.sel_phone1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sel_phone1.Name = "sel_phone1";
            this.sel_phone1.Size = new System.Drawing.Size(68, 30);
            this.sel_phone1.TabIndex = 64;
            this.sel_phone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sel_front
            // 
            this.sel_front.Enabled = false;
            this.sel_front.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sel_front.Location = new System.Drawing.Point(250, 342);
            this.sel_front.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sel_front.Name = "sel_front";
            this.sel_front.Size = new System.Drawing.Size(112, 30);
            this.sel_front.TabIndex = 65;
            this.sel_front.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sel_dep
            // 
            this.sel_dep.Enabled = false;
            this.sel_dep.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sel_dep.Location = new System.Drawing.Point(250, 407);
            this.sel_dep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sel_dep.Name = "sel_dep";
            this.sel_dep.Size = new System.Drawing.Size(259, 30);
            this.sel_dep.TabIndex = 66;
            this.sel_dep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sel_doc
            // 
            this.sel_doc.Enabled = false;
            this.sel_doc.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sel_doc.Location = new System.Drawing.Point(250, 472);
            this.sel_doc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sel_doc.Name = "sel_doc";
            this.sel_doc.Size = new System.Drawing.Size(259, 30);
            this.sel_doc.TabIndex = 67;
            this.sel_doc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sel_datetime
            // 
            this.sel_datetime.Enabled = false;
            this.sel_datetime.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sel_datetime.Location = new System.Drawing.Point(250, 537);
            this.sel_datetime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sel_datetime.Name = "sel_datetime";
            this.sel_datetime.Size = new System.Drawing.Size(259, 30);
            this.sel_datetime.TabIndex = 68;
            this.sel_datetime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sel_phone2
            // 
            this.sel_phone2.Enabled = false;
            this.sel_phone2.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sel_phone2.Location = new System.Drawing.Point(345, 277);
            this.sel_phone2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sel_phone2.Name = "sel_phone2";
            this.sel_phone2.Size = new System.Drawing.Size(68, 30);
            this.sel_phone2.TabIndex = 69;
            this.sel_phone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sel_phone3
            // 
            this.sel_phone3.Enabled = false;
            this.sel_phone3.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sel_phone3.Location = new System.Drawing.Point(441, 277);
            this.sel_phone3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sel_phone3.Name = "sel_phone3";
            this.sel_phone3.Size = new System.Drawing.Size(68, 30);
            this.sel_phone3.TabIndex = 70;
            this.sel_phone3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(323, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 23);
            this.label7.TabIndex = 71;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(418, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 23);
            this.label8.TabIndex = 72;
            this.label8.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(427, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 23);
            this.label9.TabIndex = 75;
            this.label9.Text = "* * * * * *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(371, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 23);
            this.label10.TabIndex = 74;
            this.label10.Text = "-";
            // 
            // sel_sex
            // 
            this.sel_sex.Enabled = false;
            this.sel_sex.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sel_sex.Location = new System.Drawing.Point(397, 342);
            this.sel_sex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sel_sex.MaxLength = 1;
            this.sel_sex.Name = "sel_sex";
            this.sel_sex.Size = new System.Drawing.Size(26, 30);
            this.sel_sex.TabIndex = 73;
            this.sel_sex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reservation_up_de_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 644);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sel_sex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sel_phone3);
            this.Controls.Add(this.sel_phone2);
            this.Controls.Add(this.sel_datetime);
            this.Controls.Add(this.sel_doc);
            this.Controls.Add(this.sel_dep);
            this.Controls.Add(this.sel_front);
            this.Controls.Add(this.sel_phone1);
            this.Controls.Add(this.sel_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sel_listview);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.la1);
            this.Name = "reservation_up_de_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label la1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.ListView sel_listview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sel_name;
        private System.Windows.Forms.TextBox sel_phone1;
        private System.Windows.Forms.TextBox sel_front;
        private System.Windows.Forms.TextBox sel_dep;
        private System.Windows.Forms.TextBox sel_doc;
        private System.Windows.Forms.TextBox sel_datetime;
        private System.Windows.Forms.TextBox sel_phone2;
        private System.Windows.Forms.TextBox sel_phone3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox sel_sex;
    }
}