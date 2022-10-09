using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    partial class japorm
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.database_UserDataSet = new WindowsFormsApplication2.database_UserDataSet();
            this.uSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERTableAdapter = new WindowsFormsApplication2.database_UserDataSetTableAdapters.USERTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication2.database_UserDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btntransactions = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.logopnl = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.pnltite = new System.Windows.Forms.Panel();
            this.lbltite = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnldesktop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.database_UserDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.logopnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnltite.SuspendLayout();
            this.SuspendLayout();
            // 
            // database_UserDataSet
            // 
            this.database_UserDataSet.DataSetName = "database_UserDataSet";
            this.database_UserDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERBindingSource
            // 
            this.uSERBindingSource.DataMember = "USER";
            this.uSERBindingSource.DataSource = this.database_UserDataSet;
            // 
            // uSERTableAdapter
            // 
            this.uSERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication2.database_UserDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERTableAdapter = this.uSERTableAdapter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btntransactions);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.logopnl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 577);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = global::WindowsFormsApplication2.Properties.Resources.ezgif4;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 517);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(205, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btntransactions
            // 
            this.btntransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntransactions.FlatAppearance.BorderSize = 0;
            this.btntransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntransactions.ForeColor = System.Drawing.Color.Gainsboro;
            this.btntransactions.Image = global::WindowsFormsApplication2.Properties.Resources.ssd;
            this.btntransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntransactions.Location = new System.Drawing.Point(0, 403);
            this.btntransactions.Name = "btntransactions";
            this.btntransactions.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btntransactions.Size = new System.Drawing.Size(205, 60);
            this.btntransactions.TabIndex = 6;
            this.btntransactions.Text = "Transactions";
            this.btntransactions.UseVisualStyleBackColor = true;
            this.btntransactions.Click += new System.EventHandler(this.btntransactions_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Gainsboro;
            this.button5.Image = global::WindowsFormsApplication2.Properties.Resources.tumblr_n8irx1cqgv1rat0tqo1_500__1_;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 343);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(205, 60);
            this.button5.TabIndex = 5;
            this.button5.Text = "Dashboard";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.Image = global::WindowsFormsApplication2.Properties.Resources.Hnet_com_image__6_;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 283);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(205, 60);
            this.button4.TabIndex = 4;
            this.button4.Text = "Report";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Image = global::WindowsFormsApplication2.Properties.Resources.Hnet_com_image__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 223);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(205, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "Books";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Image = global::WindowsFormsApplication2.Properties.Resources.Hnet_com_image__4_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 163);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(205, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "Users";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // logopnl
            // 
            this.logopnl.BackColor = System.Drawing.Color.Black;
            this.logopnl.Controls.Add(this.pictureBox1);
            this.logopnl.Controls.Add(this.lbldate);
            this.logopnl.Controls.Add(this.lbltime);
            this.logopnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.logopnl.Location = new System.Drawing.Point(0, 0);
            this.logopnl.Name = "logopnl";
            this.logopnl.Size = new System.Drawing.Size(205, 163);
            this.logopnl.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.ezgif_com_gif_maker;
            this.pictureBox1.Location = new System.Drawing.Point(69, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 77);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbldate.Location = new System.Drawing.Point(26, 142);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(30, 13);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "Date";
            // 
            // lbltime
            // 
            this.lbltime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltime.AutoSize = true;
            this.lbltime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbltime.Location = new System.Drawing.Point(66, 117);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(33, 13);
            this.lbltime.TabIndex = 2;
            this.lbltime.Text = "TIME";
            // 
            // pnltite
            // 
            this.pnltite.BackColor = System.Drawing.Color.DarkCyan;
            this.pnltite.Controls.Add(this.lbltite);
            this.pnltite.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltite.Location = new System.Drawing.Point(205, 0);
            this.pnltite.Name = "pnltite";
            this.pnltite.Size = new System.Drawing.Size(707, 81);
            this.pnltite.TabIndex = 1;
            // 
            // lbltite
            // 
            this.lbltite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltite.AutoSize = true;
            this.lbltite.Font = new System.Drawing.Font("Adobe Hebrew", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltite.ForeColor = System.Drawing.Color.White;
            this.lbltite.Location = new System.Drawing.Point(284, 24);
            this.lbltite.Name = "lbltite";
            this.lbltite.Size = new System.Drawing.Size(144, 26);
            this.lbltite.TabIndex = 0;
            this.lbltite.Text = "DASHBOARD";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnldesktop
            // 
            this.pnldesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldesktop.Location = new System.Drawing.Point(205, 81);
            this.pnldesktop.Name = "pnldesktop";
            this.pnldesktop.Size = new System.Drawing.Size(707, 496);
            this.pnldesktop.TabIndex = 2;
            this.pnldesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnldesktop_Paint);
            // 
            // japorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(912, 577);
            this.Controls.Add(this.pnldesktop);
            this.Controls.Add(this.pnltite);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Gold;
            this.Name = "japorm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.japorm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.database_UserDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.logopnl.ResumeLayout(false);
            this.logopnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnltite.ResumeLayout(false);
            this.pnltite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private database_UserDataSet database_UserDataSet;
        private System.Windows.Forms.BindingSource uSERBindingSource;
        private database_UserDataSetTableAdapters.USERTableAdapter uSERTableAdapter;
        private database_UserDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private PaintEventHandler panel1_Paint;
        private Panel pnltite;
        private Label lbltite;
        private Panel logopnl;
        private Button button5;
        private Label lbldate;
        private Label lbltime;
        private PictureBox pictureBox1;
        private Timer timer1;
        private Panel pnldesktop;
        private Button btntransactions;
        private Button button1;

        public EventHandler Form3_Load { get; private set; }
    }
}