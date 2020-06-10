using ConsoleApp;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            var records = ConnectionFactory.GetConnection()
            .Query<SystemUserModel>("spSystemUser_Get", commandType: CommandType.StoredProcedure).ToList();

            users.Clear();
            records.ForEach(x => users.Add(x));
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            var p = new
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text
            };

            ConnectionFactory.GetConnection()
                .Execute("dbo.spSystemUser_Create", p, commandType: CommandType.StoredProcedure);

            firstNameText.Text = "";
            lastNameText.Text = "";
            firstNameText.Focus();

            var records = ConnectionFactory.GetConnection()
            .Query<SystemUserModel>("spSystemUser_Get", commandType: CommandType.StoredProcedure).ToList();

            users.Clear();
            records.ForEach(x => users.Add(x));

        }

        private void applyFilterButton_Click(object sender, EventArgs e)
        {
            var p = new
            {
                Filter = filterUsersText.Text
            };

            var records = ConnectionFactory.GetConnection()
                .Query<SystemUserModel>("spSystemUser_GetFiltered", p, commandType: CommandType.StoredProcedure).ToList();

            users.Clear();
            records.ForEach(x => users.Add(x));

        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConnectionFactory.CloseDbConnection();
        }
    }
}
