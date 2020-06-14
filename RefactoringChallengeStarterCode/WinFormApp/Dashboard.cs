using ConsoleApp;
using Dapper;
using DataAccessLibrary;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Dashboard : Form
    {
        BindingList<SystemUserModel> users = new BindingList<SystemUserModel>();

        public Dashboard()
        {
            InitializeComponent();

            userDisplayList.DataSource = users;
            userDisplayList.DisplayMember = "FullName";

            var records = DataAccess.GetUsers();

            users.Clear();
            records.ForEach(x => users.Add(x));
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            var p = new SystemUserModel()
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text
            };

            DataAccess.CreateUser(p);

            firstNameText.Text = "";
            lastNameText.Text = "";
            firstNameText.Focus();

            var records = DataAccess.GetUsers();
            users.Clear();
            records.ForEach(x => users.Add(x));

        }

        private void applyFilterButton_Click(object sender, EventArgs e)
        {
            var p = new 
            {
                Filter = filterUsersText.Text
            };

            var records = DataAccess.GetUsers(p);
            users.Clear();
            records.ForEach(x => users.Add(x));

        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConnectionFactory.CloseDbConnection();
        }
    }
}
