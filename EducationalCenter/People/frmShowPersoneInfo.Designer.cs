﻿namespace My_Student_Center.People
{
    partial class frmShowPersoneInfo
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
            this.ucPersoneCard1 = new My_Student_Center.People.user_control.ucPersoneCard();
            this.SuspendLayout();
            // 
            // ucPersoneCard1
            // 
            this.ucPersoneCard1.BackColor = System.Drawing.Color.White;
            this.ucPersoneCard1.Location = new System.Drawing.Point(30, 0);
            this.ucPersoneCard1.Name = "ucPersoneCard1";
            this.ucPersoneCard1.Size = new System.Drawing.Size(856, 381);
            this.ucPersoneCard1.TabIndex = 0;
            // 
            // frmShowPersoneInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 367);
            this.Controls.Add(this.ucPersoneCard1);
            this.Name = "frmShowPersoneInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowPersoneInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private user_control.ucPersoneCard ucPersoneCard1;
    }
}