using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleLibrary
{
    public class People
    {
        #region Fields
        private static volatile People instance = null;
        private static object syncRoot = new object();
        #endregion

        #region Constructor
        /// <summary>
        /// Private constructor
        /// </summary>
        private People() { }
        #endregion

        #region Properties
        public static People Instance { get { if (instance == null) { lock (syncRoot) { if (instance == null) { instance = new People(); } } } return instance; } }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public List<People> Peoples { get; set; } = new List<People>();
        #endregion

        #region Methods
        /// <summary>
        /// Add the people properties to people list
        /// </summary>
        /// <returns></returns>
        public bool PopulatePeopleList()
        {
            try
            {
                Peoples.Add(new People() { FirstName = "Tim", LastName = "Corey" });
                Peoples.Add(new People() { FirstName = "Bill", LastName = "McCoy" });
                Peoples.Add(new People() { FirstName = "Marry", LastName = "Jones" });
                Peoples.Add(new People() { FirstName = "Sue", LastName = "Smith" });

                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message); return false;
            }
        }
        #endregion
    }
}
