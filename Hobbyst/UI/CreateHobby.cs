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
    public partial class CreateHobby : Form
    {
        public CreateHobby()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                createHobbies(tbTitle.Text, rtbDscrption.Text, float.Parse(tbPrice.Text));
                MessageBox.Show("You created a new hobby!");
            }
            catch(Exception er)
            {
                MessageBox.Show("Unable to create a new hobby \n:( \nPlease check all fields");
            }
        }

        private void createHobbies(string Title, string Description, float Price)
        {
            User u = new User();

            u.CreateHobbies(Title, Description, Price);
        }
    }
}
