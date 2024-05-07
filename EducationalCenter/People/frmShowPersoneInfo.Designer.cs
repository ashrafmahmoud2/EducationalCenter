namespace My_Student_Center.People
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
            this.guna2CirclePictureBox7 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // ucPersoneCard1
            // 
            this.ucPersoneCard1.Location = new System.Drawing.Point(-4, -7);
            this.ucPersoneCard1.Name = "ucPersoneCard1";
            this.ucPersoneCard1.Size = new System.Drawing.Size(1011, 319);
            this.ucPersoneCard1.TabIndex = 0;
            // 
            // guna2CirclePictureBox7
            // 
            this.guna2CirclePictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox7.Image = global::My_Student_Center.Properties.Resources.close;
            this.guna2CirclePictureBox7.ImageRotate = 0F;
            this.guna2CirclePictureBox7.Location = new System.Drawing.Point(952, -7);
            this.guna2CirclePictureBox7.Name = "guna2CirclePictureBox7";
            this.guna2CirclePictureBox7.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox7.Size = new System.Drawing.Size(64, 55);
            this.guna2CirclePictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox7.TabIndex = 211;
            this.guna2CirclePictureBox7.TabStop = false;
            this.guna2CirclePictureBox7.UseTransparentBackground = true;
            // 
            // frmShowPersoneInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 310);
            this.Controls.Add(this.guna2CirclePictureBox7);
            this.Controls.Add(this.ucPersoneCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowPersoneInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowPersoneInfo";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private user_control.ucPersoneCard ucPersoneCard1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox7;
    }
}