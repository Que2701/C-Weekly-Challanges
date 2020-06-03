using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileChallengeApp.Models;

namespace ModelsLibrary
{
    public class UserModelHelper
    {
        public static UserModel CreateUserModel(string firstName, string lastName, int age, bool isAlive)
        {
            var userModel = new UserModel()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                IsAlive = isAlive
            };

            return userModel;
        }
    }
}
