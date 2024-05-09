using EducationalCenterBusinessLayer;
using My_Student_Center.Class;
using My_Student_Center.Dashboards;
using My_Student_Center.Groups;
using My_Student_Center.MoreInfo;
using My_Student_Center.Payment;
using My_Student_Center.Students;
using My_Student_Center.Subjects;
using My_Student_Center.Teachers;
using My_Student_Center.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Student_Center
{
    //colores 19; 15; 64         236; 240; 241     
    public partial class frmHome : Form
    {

        //fix Conaction with app Confic , clsLogHandler ,
        //review the code of back end;

        private Form currentChildForm;
        private Form _frmLoginForm;

        public frmHome()
        {
            InitializeComponent();
        }

        public void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.Controls.Add(childForm);
            guna2CustomGradientPanel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            if (childForm.Tag != null)
            {
                //lblTitleChildForm.Text = childForm.Tag.ToString();
            }
            else
            {
                // lblTitleChildForm.Text = childForm.Text;
            }

            //  RefreshUserInfo(this, clsGlobal.CurrentUser.UserID);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          //add test fun to code gen
          //put in git

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDashboard());
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmStudents());


        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTeachers());

        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSubjects());

        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmClass());

        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmGroups());

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPayment());

        }

        private void btnMoreInfo_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmMoreInfo());
        }

        private void btnUsers_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmUsers());

        }
    }
}
