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

namespace My_Student_Center.People.user_control
{
    public partial class ucPersoneCardWithFilter : UserControl
    {

        //stop in make _IsOldStudent;

        //sea khaled code

        //code gen
        //stroed prosuers:fix add ,add NVARCHAR(255) to prammters,
        //Data Layer: command.Parameters.AddWithValue("@PersonID", PersonID)
        //vs: mathod get the first Colum ID;



        //Students
        //code:don't make to setudent in same persoenID,text in combo Grad
        //Add Age in Get All,records num,erro provider,libtitel Updatas


        //vido
        //deleget - event 



        public event Action<int> OnPerosnSelected;
        protected virtual void PeroneSelected(int PersoenID)
        {
            Action<int> handler= OnPerosnSelected;
            if (handler != null)
            {
                handler(PersoenID);
            }
        }


        public ucPersoneCardWithFilter()
        {
            InitializeComponent();
        }

        private void ucPersoneCard1_Load(object sender, EventArgs e)
        {
            cbFindBy.SelectedIndex = 0;
        }


        private bool _ShowAddPerone = true;
        public bool ShowAddPerone
        {
            get { return _ShowAddPerone; }
            set
            {
                _ShowAddPerone = value;
                btnAdd.Visible = _ShowAddPerone;
            }
        }


        private bool _FilterEnable = true;
        public bool FilterEnable
        {
            get { return _FilterEnable; }
            set
            {
                _FilterEnable = value;
                btnFind.Visible=_FilterEnable;
            }
        }

        private bool _EnabledGb = true;
        public bool EnabledGb
        {
            get { return _EnabledGb; }
            set
            {
                _EnabledGb = value;
                gbFilter.Enabled = _EnabledGb;
            }
        }


        private int _PersoenID;
        public int PeronsonID
        {
            get { return _PersoenID; }
        }

        public int GetPersoenID()
        {
            return int.Parse(txtSearch.Text);
        }


        public void LodePerosoneInfo(int PersoneID)
        {
           // cbFindBy.SelectedIndex = 1;
            txtSearch.Text = PersoneID.ToString();
            ucPersoneCard1.FillUCPersoenInfo(PersoneID);   
            _FindNow();

        }
        private void _FindNow()
        {

           switch(cbFindBy.Text)
            {
                case "PersoneID":
                    if (int.TryParse(txtSearch.Text, out int PersoneID))
                    {
                        ucPersoneCard1.FillUCPersoenInfo(PersoneID);
                        _PersoenID = PersoneID;
                       
                        
                        
                    }
                    else
                    {
                        // Handle invalid input (e.g., show a message to the user)
                    }
                    break;

            }
            if(OnPerosnSelected != null && cbFindBy.Enabled)
            {
                OnPerosnSelected(ucPersoneCard1.PerosneID);
            }
        }

 
        private void btnFind_Click(object sender, EventArgs e)
        {
            _FindNow();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _FindNow();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmAddEditPersone frm=new frmAddEditPersone();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }
        private void DataBackEvent(object sender,int PerosneID)
        {
            txtSearch.Text = PerosneID.ToString();
            ucPersoneCard1.FillUCPersoenInfo(PerosneID);
        }
    }
}
