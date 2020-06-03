using ModelsLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TextFileChallengeApp.Models;

namespace TextFileChallengeApp
{
    public enum File
    {
        FirstName,
        LastName,
        Age,
        IsAlive
    }
    public partial class TextFileChallenge : Form
    {
        private string stadardDataSet = @"Files\StandardDataSet.csv";
        private string advancedDataSet = @"Files\AdvancedDataSet.csv";
        public TextFileChallenge()
        {
            InitializeComponent();
        }

        private void TextFileChallenge_Load(object sender, EventArgs e)
        {
            try
            {
                ReadStandardCSVFile().ForEach(u =>
                {
                    usersListBox.Items.Add(Display.UserInformation(u));
                });
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        /// <summary>
        /// Read a CSV file
        /// </summary>
        /// <returns></returns>
        private List<UserModel> ReadStandardCSVFile()
        {
            var userModels = new List<UserModel>();

            using (StreamReader streamReader = new StreamReader(advancedDataSet))
            {
                var line = default(string);
                var headerLine = streamReader.ReadLine();
                while ((line = streamReader.ReadLine()) != null)
                {
                    var lineSplit = line.Split(',');
                    userModels.Add(new UserModel()
                    {
                        FirstName = lineSplit[(int)File.FirstName],
                        LastName = lineSplit[(int)File.LastName],
                        Age = Int32.Parse(lineSplit[(int)File.Age]),
                        IsAlive = Int32.Parse(lineSplit[(int)File.IsAlive]) == 0 ? true : false
                    });
                }
            }

            return userModels;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            var userModel = UserModelHelper.CreateUserModel(firstNameTextbox.Text, lastNameTextbox.Text, (int)ageNumbericUpDown.Value, isAliveCheckbox.Checked);
            usersListBox.Items.Add(Display.UserInformation(userModel));
        }

        private void saveListButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter streamWriter = new StreamWriter(advancedDataSet, true))
            {
                // Dean,Flynn,31,0
                streamWriter.WriteLine($"{firstNameTextbox.Text},{lastNameTextbox.Text},{(int)ageNumbericUpDown.Value},{Convert.ToInt32(isAliveCheckbox.Checked)}");
            }
        }
    }
}
