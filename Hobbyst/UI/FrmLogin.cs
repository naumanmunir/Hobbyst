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
using Hobbyst.DL;

namespace Hobbyst.UI
{
    
    public partial class FrmLogin : Form
    {
        
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //validate user 
            
            try
            {
                login();
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message.ToString());
            }
        }

        private void login()
        {

            User u = new User();
            HUB hub = new HUB();


            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Invalid login");
            }
            else
            {
                new User().ValidateUsers(tbUsername.Text, tbPassword.Text);
                
                //u.ValidateUsers(username, password);
                this.Hide();
                hub.Show();
            }

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            FrmNewUser fnu = new FrmNewUser();
            this.Hide();
            fnu.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        private void frmUserProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserProfile up = new frmUserProfile();
            

            up.Show();
        }

        private void frmHUBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HUB hub = new HUB();

            hub.Show();
        }

        private void frmNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmNewUser fnu = new FrmNewUser();

            //fnu.Show();
        }
    }
}
