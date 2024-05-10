using EducationalCenterBusinessLayer;
using My_Student_Center.Genral.user_control;
using My_Student_Center.People.user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace My_Student_Center.Students
{
    public partial class frmAddEditStudent : Form
    {

        enum enMode { Add = 0, Update = 1 }

        private enMode mode = enMode.Add;
        private int _StudentID;
        private clsStudents _Student;


        public frmAddEditStudent()
        {
            InitializeComponent();
            mode =enMode.Add;
            _LoadData();
        }
        public frmAddEditStudent(int StuedenID)
        {
            InitializeComponent();
            mode=enMode.Update;
            _StudentID = StuedenID;
            _LoadData();
        }

        private void _LoadData()
        {
            if (mode == enMode.Add)
            {
                //  _SaveStudent();
                txtStudentID.Text = "--";
               // txtStudentID.Enabled=false;
                lblTitle.Text = "Add New Student";
            }
            else
            {
                ucPersoneCardWithFilter1.EnabledGb=false;
                _LoadDataInForm();
                lblTitle.Text = "Update Student";
            }
        }

        private void _GetDataFromForm()
        {
           

            _Student =new clsStudents();
            _Student.PersonID = ucPersoneCardWithFilter1.GetPersoenID();
            _Student.CreatedByUserID = 4;
            _Student.GradID=cbGradeLevels.SelectedIndex+1;

        }


        private void _LoadDataInForm()
        {
             _Student=clsStudents.Find(_StudentID);
            //if (_Student.GradID  > 0)
            //{
                ucPersoneCardWithFilter1.LodePerosoneInfo(_Student.PersonID);
                txtStudentID.Text = _Student.StudentID.ToString();
                txtCreatedByUser.Text= _Student.CreatedByUserID.ToString();
            cbGradeLevels.SelectedIndex = cbGradeLevels.FindString(_Student.GradName.Trim());
               

            // }
            // MessageBox.Show("Student Not Found");
        }

        private bool _IsOldStudent()
        {
             return mode == enMode.Add &
               clsStudents.DoesStudentExist(ucPersoneCardWithFilter1.GetPersoenID())
               
           
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
            cbGradeLevels.SelectedIndex = 0;



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //stop in make _IsOldStudent;
            if (!_IsOldStudent())
            {
                btnSave.Enabled = false;
                return;  
            }

            _GetDataFromForm();

            if (mode == enMode.Update)
            {

                _Student.Mode = clsStudents.enMode.Update;
                _Student.StudentID = _StudentID;
             //   _Student.Mode = clsStudents.enMode.Update;
                if (_Student.Save())
                {
                    MessageBox.Show("Update Successful");
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }
            }
            else
            {
                // _Student.Mode = clsPeople.enMode.AddNew;

                if (_Student.Save())
                {
                    MessageBox.Show($"Student Added, Student ID: {_Student.StudentID}");
                    mode=enMode.Update;
                    lblTitle.Text = "Update Student";
                }
                else
                {
                    MessageBox.Show("Add Failed");
                }
            }



        }
    }
}
