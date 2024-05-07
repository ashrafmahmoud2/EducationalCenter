namespace My_Student_Center.People.user_control
{
    partial class ucPersoneCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucFilter1 = new My_Student_Center.Genral.user_control.ucFilter();
            this.ucPersoneCard1 = new My_Student_Center.People.user_control.ucPersoneCard();
            this.SuspendLayout();
            // 
            // ucFilter1
            // 
            this.ucFilter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucFilter1.Location = new System.Drawing.Point(0, 0);
            this.ucFilter1.Name = "ucFilter1";
            this.ucFilter1.Size = new System.Drawing.Size(1035, 125);
            this.ucFilter1.TabIndex = 2;
            // 
            // ucPersoneCard1
            // 
            this.ucPersoneCard1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPersoneCard1.Location = new System.Drawing.Point(0, 140);
            this.ucPersoneCard1.Name = "ucPersoneCard1";
            this.ucPersoneCard1.Size = new System.Drawing.Size(1035, 342);
            this.ucPersoneCard1.TabIndex = 1;
            this.ucPersoneCard1.Load += new System.EventHandler(this.ucPersoneCard1_Load);
            // 
            // ucPersoneCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucFilter1);
            this.Controls.Add(this.ucPersoneCard1);
            this.Name = "ucPersoneCardWithFilter";
            this.Size = new System.Drawing.Size(1035, 482);
            this.ResumeLayout(false);

        }

        #endregion
        private ucPersoneCard ucPersoneCard1;
        private Genral.user_control.ucFilter ucFilter1;
    }
}
