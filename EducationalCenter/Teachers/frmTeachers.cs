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

namespace My_Student_Center.Teachers
{
    public partial class frmTeachers : Form
    {
        //stop in make teacher ui;


        //code gen
        //InAll: GetFistColunID();
        //stroed prosuers:
        //Data :
        // business: Make test fun otomatic by GetFistColun();,//Add to Exsist And make the start from one fun;



        //Students
        //code:Make Combo Level shows the studen Level
        //Add Age in Get All,records num,erro provider,libtitel Updatas


        //vido
        //deleget - event 

        public frmTeachers()
        {
            InitializeComponent();
            dgvTeachers.DataSource=clsTeachers.GetAllTeachers();
        }
    }
}
