namespace p1
{
    partial class Eform
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
            this.lbl_pname = new System.Windows.Forms.Label();
            this.lbl_teamlead = new System.Windows.Forms.Label();
            this.lbl_task = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_estdtime = new System.Windows.Forms.DateTimePicker();
            this.rtd_desc = new System.Windows.Forms.RichTextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.LL_logout = new System.Windows.Forms.LinkLabel();
            this.pn2 = new System.Windows.Forms.Panel();
            this.pn1 = new System.Windows.Forms.Panel();
            this.dtp_startdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pn2.SuspendLayout();
            this.pn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_pname
            // 
            this.lbl_pname.AutoSize = true;
            this.lbl_pname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pname.Location = new System.Drawing.Point(26, 13);
            this.lbl_pname.Name = "lbl_pname";
            this.lbl_pname.Size = new System.Drawing.Size(66, 24);
            this.lbl_pname.TabIndex = 0;
            this.lbl_pname.Text = "label1";
            // 
            // lbl_teamlead
            // 
            this.lbl_teamlead.AutoSize = true;
            this.lbl_teamlead.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_teamlead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teamlead.Location = new System.Drawing.Point(26, 44);
            this.lbl_teamlead.Name = "lbl_teamlead";
            this.lbl_teamlead.Size = new System.Drawing.Size(51, 20);
            this.lbl_teamlead.TabIndex = 1;
            this.lbl_teamlead.Text = "label1";
            // 
            // lbl_task
            // 
            this.lbl_task.AutoSize = true;
            this.lbl_task.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_task.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_task.Location = new System.Drawing.Point(26, 71);
            this.lbl_task.Name = "lbl_task";
            this.lbl_task.Size = new System.Drawing.Size(51, 20);
            this.lbl_task.TabIndex = 2;
            this.lbl_task.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "End Date:";
            // 
            // dtp_estdtime
            // 
            this.dtp_estdtime.Enabled = false;
            this.dtp_estdtime.Location = new System.Drawing.Point(3, 23);
            this.dtp_estdtime.Name = "dtp_estdtime";
            this.dtp_estdtime.Size = new System.Drawing.Size(200, 20);
            this.dtp_estdtime.TabIndex = 6;
            // 
            // rtd_desc
            // 
            this.rtd_desc.Location = new System.Drawing.Point(26, 201);
            this.rtd_desc.Name = "rtd_desc";
            this.rtd_desc.Size = new System.Drawing.Size(200, 124);
            this.rtd_desc.TabIndex = 7;
            this.rtd_desc.Text = "";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(26, 359);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // LL_logout
            // 
            this.LL_logout.AutoSize = true;
            this.LL_logout.Location = new System.Drawing.Point(459, 13);
            this.LL_logout.Name = "LL_logout";
            this.LL_logout.Size = new System.Drawing.Size(40, 13);
            this.LL_logout.TabIndex = 9;
            this.LL_logout.TabStop = true;
            this.LL_logout.Text = "Logout";
            this.LL_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_logout_LinkClicked);
            // 
            // pn2
            // 
            this.pn2.Controls.Add(this.dtp_estdtime);
            this.pn2.Controls.Add(this.label4);
            this.pn2.Location = new System.Drawing.Point(249, 118);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(221, 57);
            this.pn2.TabIndex = 10;
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.dtp_startdate);
            this.pn1.Controls.Add(this.label5);
            this.pn1.Location = new System.Drawing.Point(26, 118);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(221, 57);
            this.pn1.TabIndex = 11;
            // 
            // dtp_startdate
            // 
            this.dtp_startdate.Enabled = false;
            this.dtp_startdate.Location = new System.Drawing.Point(7, 23);
            this.dtp_startdate.Name = "dtp_startdate";
            this.dtp_startdate.Size = new System.Drawing.Size(200, 20);
            this.dtp_startdate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Task Description:";
            // 
            // Eform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.LL_logout);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.rtd_desc);
            this.Controls.Add(this.lbl_task);
            this.Controls.Add(this.lbl_teamlead);
            this.Controls.Add(this.lbl_pname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Eform";
            this.Text = "Employee Task Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Eform_FormClosed);
            this.Load += new System.EventHandler(this.Eform_Load);
            this.pn2.ResumeLayout(false);
            this.pn2.PerformLayout();
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pname;
        private System.Windows.Forms.Label lbl_teamlead;
        private System.Windows.Forms.Label lbl_task;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_estdtime;
        private System.Windows.Forms.RichTextBox rtd_desc;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.LinkLabel LL_logout;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.DateTimePicker dtp_startdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}