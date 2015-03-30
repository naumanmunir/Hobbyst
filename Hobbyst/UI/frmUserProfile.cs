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
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace Hobbyst.UI
{
    public partial class frmUserProfile : Form
    {
        public frmUserProfile()
        {
            InitializeComponent();
        }

        private void frmUserProfile_Load(object sender, EventArgs e)
        {
            //Populate the combobox with states from DB
            populateStates();
        }

        //Continue Button
        private void btnContinue_Click_1(object sender, EventArgs e)
        {
            HUB hub = new HUB();
            var state = Convert.ToString(((DataRowView)cbStates.SelectedValue)["state"]);


            try
            {
                uploadpic(lblpath.Text);
                InsertUser(tbFname.Text, tbLname.Text, Convert.ToDateTime(tbDob.Text), tbPrimaryNum.Text, tbStreet.Text, tbCity.Text, Convert.ToString(state), tbZip.Text);
                hub.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message.ToString());
            }
        }


        private void uploadpic(string picturepath)
        {
            User u = new User();

            byte[] imageData = ReadFile(picturepath);
            u.profilePic(imageData);

             
        }

        //Open file in to a filestream and read data in a byte array.
        byte[] ReadFile(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes 
            //to read from file.
            //In this case we want to read entire file. 
            //So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);

            return data;
        }

        private void BrowsePicture()
        {
            OpenFileDialog dlg = new OpenFileDialog();

            //string picpath = lblpath.Text;

                dlg.Title = "Open Image";
                //dlg.Filter = "png files (*.png)|*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pbProfilePic.Image = Image.FromFile(dlg.FileName);
                    lblpath.Text = dlg.FileName;
                }
                dlg.Dispose();

        }

        #region Browse Button
        //Browse for Picture
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            BrowsePicture();
        }
        #endregion


        #region Insert New Users
        private void InsertUser(string Fname, string Lname,DateTime DoB, string PrimaryNum, string Street, string City, string State, string Zip)
        {
            User u = new User();

            
            u.newUserProfile(Fname, Lname, DoB, PrimaryNum, Street, City, State, Zip);

        }
        #endregion


        #region Populate States
        private void populateStates()
        {
            DataSet dspopulateStates;

            dspopulateStates = new User().populatestates();
            cbStates.DataSource = dspopulateStates.Tables[0].DefaultView;
            cbStates.DisplayMember = "state";

        }

        #endregion

        private void cbStates_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}
