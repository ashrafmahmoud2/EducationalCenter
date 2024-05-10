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

namespace My_Student_Center.Genral.user_control
{
    public partial class ucFilter : UserControl
    {
        private clsStudents _selectedStudent;
        private clsPeople _selectedPeople;

        private int _selectedStudentID;
        private int _selectedPeopleID;

        public ucFilter()
        {
            InitializeComponent();
        }

        private enum enmode { Person , Student, Teacher, Class, User }
        enmode mode;

         

        public void ShowAddPerson(bool Visible )
        {
            btnAdd.Visible = Visible;
        }

        public void ShowSearchPerson(bool Visible )
        {
            btnFind.Visible = Visible;
        }

        public void EnablePermission(bool enabled )
        {
            btnFind.Enabled = enabled;
            btnAdd.Enabled = enabled;
            txtSearch.Enabled= enabled;
        }


        public void FillTxtSearchcbFindBy(string TxtSearch,string cbFind)
        {
            txtSearch.Text = TxtSearch;
            cbFindBy.Text = cbFind;
            gbFilter.Enabled = false;
        }



       

        public clsStudents SelectedStudentInfo => _selectedStudent;

        public int SelectedStudentID => _selectedStudentID;

        public void _SearchForPeople()
        {
            cbFindBy.Text = "PersonID";
          //  cbFindBy.Text = "Pesone Name";

        }
        public void _SearchForStudent()
        {
            cbFindBy.Text = "PersonID";
           // cbFindBy.Text = "Pesone Name";
            cbFindBy.Text = "StudentID";

        }
        public void _SearchForTeacher()
        {
            cbFindBy.Text = "PersonID";
            cbFindBy.Text = "Pesone Name";
            cbFindBy.Text = "TeacherID";

        }
        public void _SearchForClass()
        {
            cbFindBy.Text = "ClassID";
            cbFindBy.Enabled = false;

        }
        public void _SearchForUser()
        {
            cbFindBy.Text = "PersonID";
            cbFindBy.Text = "Pesone Name";
            cbFindBy.Enabled = false;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPersone frm=new frmAddEditPersone();
            frm.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            switch (mode)
            {
                case enmode.Person:
                    if (cbFindBy.Text == "PersonID" && int.TryParse(txtSearch.Text, out int personId) && 
                        clsPeople.DoesPeopleExist(personId))
                    {
                        _selectedPeople = clsPeople.Find(personId);
                        _selectedPeopleID = _selectedPeople.PersonID;
                    }
                    break;

                case enmode.Student:
                    if (cbFindBy.Text == "PersonID" &&
                        int.TryParse(txtSearch.Text, out int studentId) && clsPeople.DoesPeopleExist(studentId))
                    {
                        _selectedPeople = clsPeople.Find(studentId);
                        _selectedPeopleID = _selectedPeople.PersonID;

                        if (cbFindBy.Text == "StudentID" && clsStudents.DoesStudentsExist(studentId))
                        {
                            _selectedStudent = clsStudents.Find(studentId);
                            _selectedStudentID = _selectedStudent.StudentID;
                        }
                    }
                    break;

            }




        }
    }
}
