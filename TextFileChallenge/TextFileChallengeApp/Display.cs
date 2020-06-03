using TextFileChallengeApp.Models;

namespace TextFileChallengeApp
{
    public static class Display
    {
        #region Methods
        public static string UserInformation(UserModel user)
        {
            string aliveStatus = "is dead";
            if (user.IsAlive)
                aliveStatus = "is alive";

            return $"{user.FirstName} {user.LastName} is {user.Age} and {aliveStatus}";
        }
        #endregion
    }
}
