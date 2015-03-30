using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hobbyst.BL;

namespace Hobbyst.UI
{
    public partial class FrmNewUser : Form
    {

        
        private EventDrivenID eventdrivenid;
        public FrmNewUser(EventDrivenID eventdrivenid)
        {
            InitializeComponent();
            this.eventdrivenid = eventdrivenid;
            eventdrivenid.UpdateIDEvent += this.UserID; //whatever method you want to fire upon invocation of the event
        }

        public FrmNewUser()
        {
            InitializeComponent();
        }

        public void UserID()
        {
            ////int id = UserID;
            //string randnum;
            //Random ran = new Random();
            //randnum = Convert.ToString(ran.Next(100000, 999999));

            //lblID.Text = randnum;
        }


        private void btnContinue_Click(object sender, EventArgs e)
        {
            
            try
            {
                AddUser(tbUserName.Text, tbPass.Text, tbRPass.Text, tbEmail.Text);
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message.ToString());
            }
        }

        private void AddUser(string UserName, string Password, string repeatPass, string Email)
        {
            //To BL
            User u = new User();
            Hobbys hby = new Hobbys();
            frmUserProfile fUP = new frmUserProfile();

            if (UserName == "" || Password == "" || repeatPass == "" || Email == "")
            {
                MessageBox.Show("Please fill the form");

            }
            else
            {
                if (Password == repeatPass)
                {
                    u.InsertUser(UserName, Password, Email);
                    this.Hide();
                    fUP.Show();
                }
                else
                {
                    MessageBox.Show("Password must be same");
                }
            }
                
        }

        
        //public string lbText
        //{
        //    set { this.label1.Text = value; }
        //    get { return this.label1.Text; }
        //}
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Form2 fm = new Form2();
        //    fm.Show(this);
        //}

        private void FrmNewUser_Load(object sender, EventArgs e)
        {

        }
    }
}
