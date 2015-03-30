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
    public partial class FindHobbyst : Form
    {
        
        public FindHobbyst()
        {
            InitializeComponent();
        }

        public void FindHobbyst_Load(object sender, EventArgs e)
        {
            var distance = new Dictionary<string, string>();
            distance["10"] = "0 - 5 miles";
            distance["20"] = "5 - 10 miles";
            distance["30"] = "10 - 20 miles";
            distance["40"] = "20 - 30 miles";
            cbDistance.DataSource = new BindingSource(distance, null);
            cbDistance.DisplayMember = "Value";
            cbDistance.ValueMember = "Key";
            this.cbDistance.DropDownStyle = ComboBoxStyle.DropDownList;
        }

         

        private void btnHire_Click(object sender, EventArgs e)
        {
            //search(tbsearch.Text);
            Results();
        }

        //public void search(string Title, string Price)
        //{
        //    User u = new User();

        //    u.SearchHobbies(Title, Price);
        //}

        private void Results()
        {

            PopulateGrid(new User().SearchHobbies(tbsearch.Text, Convert.ToDecimal(tbPrice.Text), Convert.ToInt32(tbZip.Text)));

        }

        private void PopulateGrid(DataSet ds)
        {
            dgsearch.DataSource = null;
            dgsearch.DataSource = ds.Tables[0];

        }

        public virtual void cbDistance_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
