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

namespace My_Student_Center.People
{
    public partial class frmAddEditPersone : Form
    {
        public delegate void DataBackEventHandler(object sender, int PeronseiD);
        public event DataBackEventHandler DataBack;

       
     
        enum enMode { Add = 0, Update = 1 }

        private enMode mode = enMode.Add;
        private int _PersonID;
        private clsPeople _Person;

        public frmAddEditPersone()
        {
            InitializeComponent();
         mode=   enMode.Add;
            _LoadData();
        }

        public frmAddEditPersone(int PersoneID)
        {
            InitializeComponent();
            mode = enMode.Update;
            _PersonID = PersoneID;
            _Person = clsPeople.Find(PersoneID);
            _LoadData();
        }

        private void _LoadData()
        {
            if (mode == enMode.Add)
            {
              //  _SavePerson();
                lblTitle.Text = "Add New Person";
            }
            else
            {
                _LoadDataInForm();
                lblTitle.Text = "Update Person";
            }
        }

        private void _GetDataFromForm()
        {
            _Person = (mode == enMode.Add) ? new clsPeople() : clsPeople.Find(_PersonID);
            _Person.Name = $"{txtFirstName.Text} {txtSecondName.Text} {txtThirdName.Text} {txtLastName.Text}";
            _Person.Gender = rbMale.Checked;
            _Person.Phone = txtPhone.Text;
            _Person.Email = txtEmail.Text;
            _Person.Address = txtAddress.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
        }


        private void _LoadDataInForm()
        {
            _Person = clsPeople.Find(_PersonID);
            if (_Person != null)
            {
                string[] names = _Person.Name.Split(' ');
                txtFirstName.Text = names[0];
                if (names.Length >= 2)
                {
                    txtSecondName.Text = names[1];
                    if (names.Length >= 3)
                    {
                        txtThirdName.Text = names[2];
                        if (names.Length >= 4)
                        {
                            txtLastName.Text = names[3];
                        }
                    }
                }
                rbMale.Checked = _Person.Gender;
                rbFemale.Checked = !_Person.Gender;
                txtPhone.Text = _Person.Phone;
                txtEmail.Text = _Person.Email;
                txtAddress.Text = _Person.Address;
                dtpDateOfBirth.Value = _Person.DateOfBirth;
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            _GetDataFromForm();

            if (mode == enMode.Update)
            {
                _Person.Mode = clsPeople.enMode.Update;
                if (_Person.Save())
                {
                    DataBack?.Invoke(this, _Person.PersonID);
                    MessageBox.Show("Update Successful");
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }
            }
            else
            {
               // _Person.Mode = clsPeople.enMode.AddNew;

                if (_Person.Save())
                {
                    DataBack?.Invoke(this, _Person.PersonID);
                    MessageBox.Show($"Person Added, Person ID: {_Person.PersonID}");
                }
                else
                {
                    MessageBox.Show("Add Failed");
                }
            }



        }



    }
}
