﻿namespace My_Student_Center.Students
{
    partial class frmShowStudenInfo
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ucPersoneCard1 = new My_Student_Center.People.user_control.ucPersoneCard();
            this.cbGradeLevels = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreatedByUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStudentID = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbIsActive = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.White;
            this.guna2GroupBox1.BorderRadius = 3;
            this.guna2GroupBox1.BorderThickness = 0;
            this.guna2GroupBox1.Controls.Add(this.cbGradeLevels);
            this.guna2GroupBox1.Controls.Add(this.pictureBox2);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.txtCreatedByUser);
            this.guna2GroupBox1.Controls.Add(this.txtStudentID);
            this.guna2GroupBox1.Controls.Add(this.pbIsActive);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.pictureBox1);
            this.guna2GroupBox1.Controls.Add(this.label22);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(18, 396);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(861, 149);
            this.guna2GroupBox1.TabIndex = 181;
            this.guna2GroupBox1.Text = "Student Information";
            // 
            // ucPersoneCard1
            // 
            this.ucPersoneCard1.BackColor = System.Drawing.Color.White;
            this.ucPersoneCard1.Location = new System.Drawing.Point(18, 2);
            this.ucPersoneCard1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucPersoneCard1.Name = "ucPersoneCard1";
            this.ucPersoneCard1.Size = new System.Drawing.Size(903, 371);
            this.ucPersoneCard1.TabIndex = 0;
            // 
            // cbGradeLevels
            // 
            this.cbGradeLevels.BackColor = System.Drawing.Color.Transparent;
            this.cbGradeLevels.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(37)))), ((int)(((byte)(193)))));
            this.cbGradeLevels.BorderRadius = 9;
            this.cbGradeLevels.BorderThickness = 2;
            this.cbGradeLevels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGradeLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGradeLevels.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbGradeLevels.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbGradeLevels.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbGradeLevels.ForeColor = System.Drawing.Color.Black;
            this.cbGradeLevels.ItemHeight = 30;
            this.cbGradeLevels.Location = new System.Drawing.Point(6, 41);
            this.cbGradeLevels.Name = "cbGradeLevels";
            this.cbGradeLevels.Size = new System.Drawing.Size(255, 36);
            this.cbGradeLevels.TabIndex = 222;
            this.cbGradeLevels.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(278, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 221;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 220;
            this.label3.Text = "الصف";
            // 
            // txtCreatedByUser
            // 
            this.txtCreatedByUser.BackColor = System.Drawing.Color.White;
            this.txtCreatedByUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(37)))), ((int)(((byte)(193)))));
            this.txtCreatedByUser.BorderRadius = 9;
            this.txtCreatedByUser.BorderThickness = 2;
            this.txtCreatedByUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreatedByUser.DefaultText = "";
            this.txtCreatedByUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCreatedByUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCreatedByUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreatedByUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreatedByUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.txtCreatedByUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtCreatedByUser.ForeColor = System.Drawing.Color.Black;
            this.txtCreatedByUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.txtCreatedByUser.Location = new System.Drawing.Point(422, 90);
            this.txtCreatedByUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCreatedByUser.Name = "txtCreatedByUser";
            this.txtCreatedByUser.PasswordChar = '\0';
            this.txtCreatedByUser.PlaceholderText = "";
            this.txtCreatedByUser.SelectedText = "";
            this.txtCreatedByUser.Size = new System.Drawing.Size(288, 33);
            this.txtCreatedByUser.TabIndex = 219;
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.White;
            this.txtStudentID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(37)))), ((int)(((byte)(193)))));
            this.txtStudentID.BorderRadius = 9;
            this.txtStudentID.BorderThickness = 2;
            this.txtStudentID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentID.DefaultText = "";
            this.txtStudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.txtStudentID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtStudentID.ForeColor = System.Drawing.Color.Black;
            this.txtStudentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.txtStudentID.Location = new System.Drawing.Point(422, 44);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.PasswordChar = '\0';
            this.txtStudentID.PlaceholderText = "";
            this.txtStudentID.SelectedText = "";
            this.txtStudentID.Size = new System.Drawing.Size(288, 33);
            this.txtStudentID.TabIndex = 218;
            this.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbIsActive
            // 
            this.pbIsActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.pbIsActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbIsActive.Location = new System.Drawing.Point(716, 97);
            this.pbIsActive.Name = "pbIsActive";
            this.pbIsActive.Size = new System.Drawing.Size(31, 26);
            this.pbIsActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIsActive.TabIndex = 217;
            this.pbIsActive.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(749, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 216;
            this.label4.Text = ":اسم المستخدم";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(716, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 215;
            this.pictureBox1.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(768, 44);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 21);
            this.label22.TabIndex = 214;
            this.label22.Text = ":رقم الطالب";
            // 
            // frmShowStudenInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 567);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.ucPersoneCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmShowStudenInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowStudenInfo";
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private People.user_control.ucPersoneCard ucPersoneCard1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbGradeLevels;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtCreatedByUser;
        private Guna.UI2.WinForms.Guna2TextBox txtStudentID;
        private System.Windows.Forms.PictureBox pbIsActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label22;
    }
}