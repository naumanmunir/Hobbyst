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
    public partial class HUB : Form
    {
        public HUB()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateHobby_Click(object sender, EventArgs e)
        {
            CreateHobby cH = new CreateHobby();

            cH.Show();
        }

        private void btnBrowseHobbys_Click(object sender, EventArgs e)
        {
            FindHobbyst fh = new FindHobbyst();

            fh.Show();
        }
    }
}
