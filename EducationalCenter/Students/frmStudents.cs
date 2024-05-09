using EducationalCenterBusinessLayer;
using My_Student_Center.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace My_Student_Center.Students
{
    public partial class frmStudents : Form
    {
        private static DataTable _dt = clsStudents.GetAllStudents();

        //make Deleget And Event In Uc



        public frmStudents()
        {
            InitializeComponent();
           
        }

        private int _GetStuedentIDByDGV()
        {
            return (int)dgvStuedent.CurrentRow.Cells[0].Value;

        }

        private void frmStudents_Load(object sender, EventArgs e)
        {

            _dt = clsStudents.GetAllStudents();
            RefreshDataGridView();

        }
        public void RefreshDataGridView()
        {
            _dt = clsStudents.GetAllStudents();
            dgvStuedent.DataSource = _dt;
        }



        //search Operstions
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = "";

            // Map selected filter to the corresponding column name
            switch (cbFilter.Text)
            {
                case "رقم الشخص":
                    filterColumn = "personID";
                    break;
                case "الطالب":
                    filterColumn = "studentID";
                    break;
                case "الاسم":
                    filterColumn = "Name";
                    break;
                case "الصف":
                    filterColumn = "DegreeName";
                    break;
                case "الهاتف":
                    filterColumn = "Phone";
                    break;
                case "البريد الإلكتروني":
                    filterColumn = "Email";
                    break;
                case "العنوان":
                    filterColumn = "Address";
                    break;
                default:
                    break;
            }

            // If the search text is empty or invalid filter column selected, reset the filter and return
            if (string.IsNullOrWhiteSpace(txtSearch.Text) || filterColumn == "")
            {
                _dt.DefaultView.RowFilter = "";
                return;
            }

            // Apply filtering based on the selected column
            if (filterColumn == "personID" || filterColumn == "studentID")
            {
                // Allow only numbers if PersonID or studentID is selected
                if (!int.TryParse(txtSearch.Text.Trim(), out _))
                {
                    // Handle invalid input (optional)
                    txtSearch.Text = "";
                    return;
                }
                _dt.DefaultView.RowFilter = $"[{filterColumn}] = {txtSearch.Text.Trim()}";
            }
            else
            {
                _dt.DefaultView.RowFilter = $"[{filterColumn}] LIKE '{txtSearch.Text.Trim()}%'";
            }

        }

     

      







        //ToolStripMenuItem

        private void dgvStuedent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmShowStudenInfo frmShowStudenInfo = new frmShowStudenInfo(_GetStuedentIDByDGV());
            frmShowStudenInfo.ShowDialog();
        }

        private void DetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvStuedent.CurrentRow.Cells[1].Value;
            
            clsPeople p = clsPeople.Find(10);

            MessageBox.Show(p.Name);

            frmShowPersoneInfo frm = new frmShowPersoneInfo(PersonID);
            frm.ShowDialog();
        }

        private void تفاصيلالطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowStudenInfo frmShowStudenInfo = new frmShowStudenInfo(_GetStuedentIDByDGV());
            frmShowStudenInfo.ShowDialog();
        }

        private void اضافةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditStudent frm=new frmAddEditStudent();
            frm.ShowDialog();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditStudent frm= new frmAddEditStudent(_GetStuedentIDByDGV());
            frm.ShowDialog();
        }

        private void مسحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ask for confirmation before deleting
            DialogResult result = MessageBox.Show("Are you sure you want to delete the student with ID " + _GetStuedentIDByDGV() + "?", "Confirmation", MessageBoxButtons.YesNo);

            // Check the user's choice
            if (result == DialogResult.Yes)
            {
                // Attempt to delete the student
                if (clsStudents.DeleteStudents(_GetStuedentIDByDGV()))
                {
                    MessageBox.Show("Student deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to delete student.");
                }
            }


        }

        private void guna2CirclePictureBox7_Click(object sender, EventArgs e)
        {
            frmAddEditStudent AddEditStudent = new frmAddEditStudent();
            AddEditStudent.ShowDialog();
        }

        
    }
}
