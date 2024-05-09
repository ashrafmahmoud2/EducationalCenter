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

namespace My_Student_Center.Students
{
    public partial class frmAddEditStudent : Form
    {
        public frmAddEditStudent()
        {
            InitializeComponent();
        }
        public frmAddEditStudent(int StuedenID)
        {
            InitializeComponent();
        }
        private void frmAddEditStudent_Load(object sender, EventArgs e)
        {
            _FillGraduationDegrees();
        }

        private void _FillGraduationDegrees()
        {
            cbGradeLevels.Items.Clear();
            DataTable countriesDataTable = clsGraduationDegrees.GetAllGraduationDegrees();

            foreach (DataRow row in countriesDataTable.Rows)
            {
                cbGradeLevels.Items.Add(row["DegreeName"]);
            }


        }


     

        
    }
}
