using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hobbyst.DL;
using System.Data;
using System.IO;
using System.Drawing.Imaging;

namespace Hobbyst.BL
{
    class User
    {
        //USER LOGIN
        public void ValidateUsers(string username, string pwd)
        {

            new GetData().GetUserData(username, pwd);
        }

        //CREATING NEW USER
        public void InsertUser(string UserName, string Password, string Email)
        {
            //To DL
            AddUser au = new AddUser();
            au.InsertUser (UserName, Password, Email);

        }

        //CREATING A NEW PROFILE FOR NEW USER
        public void newUserProfile(string Fname, string Lname, DateTime DoB, string PrimaryNum, string Street, string City, string State, string Zip)
        {
            UserProfile up = new UserProfile();

            up.NewUserProfile(Fname, Lname, DoB, PrimaryNum, Street, City, State, Zip);

        }

        //UPLOAD USER PIC
        public void profilePic(object picpath)
        {
            UserProfile up = new UserProfile();

            up.uploadProfilePic(picpath);

        }

        public void CreateHobbies(string Title, string Description, float Price)
        {
            Hobbies h = new Hobbies();

            h.CreateHobbies(Title, Description, Price);

        }

        public DataSet SearchHobbies(string Title, Decimal Price, int Zip)
        {
            DataSet ds = new DataSet();
            ds = new Hobbies().SearchHobbies(Title, Price, Zip);
            return ds;
        }


        //POPULATING STATES
        public DataSet populatestates()
        {
            DataSet ds = new DataSet();

            ds = new UserProfile().populateStates();

            return ds;
        }
    }
}
