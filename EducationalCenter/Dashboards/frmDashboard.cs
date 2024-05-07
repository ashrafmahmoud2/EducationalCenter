using EducationalCenterBusiness;
using EducationalCenterBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Student_Center.Dashboards
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            guna2DataGridView1.DataSource = clsPerson.All();

            lblStudents.Text = clsStudents.GetAllStudents().Rows.Count.ToString();
            //lblTeachers.Text = clsTeacher.All().Rows.Count.ToString();
            //lblClasses.Text = clsClass.All().Rows.Count.ToString();
            //lblGroups.Text = clsGroup.All().Rows.Count.ToString();
            //lblUsers.Text = clsUser.All().Columns.Count.ToString();
            //MessageBox.Show(clsUser.All().Rows.Count.ToString());
            //lblSubjects.Text = clsSubject.All().Rows.Count.ToString();


        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
