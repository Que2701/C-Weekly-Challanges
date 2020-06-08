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
        private List<UserModel> userModels = new List<UserModel>();
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

        public object this[string propertyVale]
        {
            set
            {
                userModels.FirstOrDefault(u => u.GetType().Name == propertyVale);
            }
        }
    }
}
