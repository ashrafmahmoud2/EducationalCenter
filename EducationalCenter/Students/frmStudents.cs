using EducationalCenterBusiness;
using EducationalCenterBusinessLayer;
using My_Student_Center.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Student_Center.Students
{
    public partial class frmStudents : Form
    {
        //Add Student

        //Geral Filter
        //Persone +Filter
        //Persone Filter + student

        //add Persoe
        //ucFilter
        //uc perseonCard
        //uc persoenWithFilete
        //






        public frmStudents()
        {
            InitializeComponent();
            dgvStuedent.DataSource = clsStudents.GetAllStudents();
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            dgvStuedent.DataSource = clsStudents.GetAllStudents();

        }

        private void guna2CirclePictureBox7_Click(object sender, EventArgs e)
        {
            frmAddEditStudent frm=new frmAddEditStudent();
            frm.ShowDialog();
        }
    }
}
