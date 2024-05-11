using EducationalCenterBusinessLayer;
using Guna.UI2.WinForms;
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
    public partial class frmShowStudenInfo : Form
    {
        public frmShowStudenInfo(int StudenID)
        {
            InitializeComponent();
            FillUcStudenInfo(StudenID);
        }

        public  void  FillUcStudenInfo(int StudenID)
        {
            clsStudents stu = clsStudents.Find(StudenID);
            if (stu != null)
            {
                ucPersoneCard1.FillUCPersoenInfo(stu.PersonID);
                txtCreatedByUser.Text = stu.CreatedByUserID.ToString();
                txtStudentID.Text = stu.StudentID.ToString();
                cbGradeLevels.SelectedIndex = cbGradeLevels.FindString(stu.GradName);
            }
            else
            {
                MessageBox.Show("frmShowStudenInfo Is Null");
            }
           

           
        }
    }
}
