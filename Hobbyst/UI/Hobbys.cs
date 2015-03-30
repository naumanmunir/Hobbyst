using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hobbyst.UI
{
    public partial class Hobbys : Form
    {
        public Hobbys()
        {
            InitializeComponent();
        }

        private void btnCreateHobby_Click(object sender, EventArgs e)
        {
            CreateHobby chby = new CreateHobby();
            chby.Show();
        }

        private void btnFindHobbyst_Click(object sender, EventArgs e)
        {
            FindHobbyst fhby = new FindHobbyst();
            fhby.Show();
        }
    }
}
