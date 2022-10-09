namespace WindowsFormsApplication2
{
    partial class message_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtto = new System.Windows.Forms.TextBox();
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.txtsubj = new System.Windows.Forms.TextBox();
            this.Settings = new System.Windows.Forms.GroupBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtadmin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtport = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkssl = new System.Windows.Forms.CheckBox();
            this.txtsmtp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Btnsend = new System.Windows.Forms.Button();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Marker", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Marker", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Subject:";
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(89, 117);
            this.txtmessage.Multiline = true;
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtmessage.Size = new System.Drawing.Size(368, 160);
            this.txtmessage.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Marker", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "From:";
            // 
            // txtto
            // 
            this.txtto.Location = new System.Drawing.Point(83, 32);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(326, 20);
            this.txtto.TabIndex = 0;
            // 
            // txtfrom
            // 
            this.txtfrom.Location = new System.Drawing.Point(83, 58);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(326, 20);
            this.txtfrom.TabIndex = 1;
            // 
            // txtsubj
            // 
            this.txtsubj.Location = new System.Drawing.Point(83, 84);
            this.txtsubj.Name = "txtsubj";
            this.txtsubj.Size = new System.Drawing.Size(326, 20);
            this.txtsubj.TabIndex = 2;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.Btnsend);
            this.Settings.Controls.Add(this.txtsmtp);
            this.Settings.Controls.Add(this.label8);
            this.Settings.Controls.Add(this.chkssl);
            this.Settings.Controls.Add(this.txtport);
            this.Settings.Controls.Add(this.label7);
            this.Settings.Controls.Add(this.txtpassword);
            this.Settings.Controls.Add(this.txtadmin);
            this.Settings.Controls.Add(this.label5);
            this.Settings.Controls.Add(this.label6);
            this.Settings.Location = new System.Drawing.Point(57, 283);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(423, 124);
            this.Settings.TabIndex = 3;
            this.Settings.TabStop = false;
            this.Settings.Text = "groupBox1";
            this.Settings.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(77, 51);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(165, 20);
            this.txtpassword.TabIndex = 2;
            // 
            // txtadmin
            // 
            this.txtadmin.Location = new System.Drawing.Point(76, 25);
            this.txtadmin.Name = "txtadmin";
            this.txtadmin.Size = new System.Drawing.Size(165, 20);
            this.txtadmin.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Marker", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Marker", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Admin";
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(76, 77);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(121, 20);
            this.txtport.TabIndex = 3;
            this.txtport.Text = "587";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Marker", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Port:";
            // 
            // chkssl
            // 
            this.chkssl.AutoSize = true;
            this.chkssl.Location = new System.Drawing.Point(282, 28);
            this.chkssl.Name = "chkssl";
            this.chkssl.Size = new System.Drawing.Size(46, 17);
            this.chkssl.TabIndex = 1;
            this.chkssl.Text = "SSL";
            this.chkssl.UseVisualStyleBackColor = true;
            // 
            // txtsmtp
            // 
            this.txtsmtp.Location = new System.Drawing.Point(282, 56);
            this.txtsmtp.Name = "txtsmtp";
            this.txtsmtp.Size = new System.Drawing.Size(119, 20);
            this.txtsmtp.TabIndex = 4;
            this.txtsmtp.Text = "gmail.com";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Marker", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(248, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Smtp:";
            // 
            // Btnsend
            // 
            this.Btnsend.Location = new System.Drawing.Point(251, 82);
            this.Btnsend.Name = "Btnsend";
            this.Btnsend.Size = new System.Drawing.Size(78, 20);
            this.Btnsend.TabIndex = 5;
            this.Btnsend.Text = "Send";
            this.Btnsend.UseVisualStyleBackColor = true;
            this.Btnsend.Click += new System.EventHandler(this.button1_Click);
            // 
            // message_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 403);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.txtsubj);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "message_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "message_form";
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.TextBox txtsubj;
        private System.Windows.Forms.GroupBox Settings;
        private System.Windows.Forms.Button Btnsend;
        private System.Windows.Forms.TextBox txtsmtp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkssl;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtadmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}