﻿using EducationalCenterBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Student_Center.People.user_control
{
    public partial class ucPersoneCard : UserControl
    {
        int _PersoneID;
        public ucPersoneCard()
        {
            InitializeComponent();
        }

        public void FillUCPersoenInfo(int PerosnID)
        {
            _PersoneID = PerosnID;
            clsPeople Person = clsPeople.Find(PerosnID);

            if (Person != null)
            {
                string[] nameParts = Person.Name.Split(' ');

                txtFirstName.Text = (nameParts.Length >= 1) ? nameParts[0] : "--";
                txtSecondName.Text = (nameParts.Length >= 2) ? nameParts[1] : "--";
                txtThirdName.Text = (nameParts.Length >= 3) ? nameParts[2] : "--";
                txtLastName.Text = (nameParts.Length >= 4) ? nameParts[3] : "--";


                lblPersonID.Text = Person.PersonID.ToString();
                rbMale.Checked = Person.Gender; 
                txtAddress.Text = Person.Address;
                txtEmail.Text = Person.Email;
                txtPhone.Text = Person.Phone;
                dtpDateOfBirth.Value = Person.DateOfBirth;
            }
        }



        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            frmAddEditPersone frrm=new frmAddEditPersone(_PersoneID);
            frrm.ShowDialog();
        }
    }
}
