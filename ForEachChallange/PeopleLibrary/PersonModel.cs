using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleLibrary
{
    public class PersonModel
    {
        #region Fields
        private static volatile PersonModel instance = null;
        private static object syncRoot = new object();
        #endregion

        #region Constructor
        /// <summary>
        /// Private constructor
        /// </summary>
        private PersonModel() { }
        #endregion

        #region Properties
        public static PersonModel Instance { get { if (instance == null) { lock (syncRoot) { if (instance == null) { instance = new PersonModel(); } } } return instance; } }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public List<PersonModel> Peoples { get; set; } = new List<PersonModel>();
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
                Peoples.Add(new PersonModel() { FirstName = "Tim", LastName = "Corey" });
                Peoples.Add(new PersonModel() { FirstName = "Bill", LastName = "McCoy" });
                Peoples.Add(new PersonModel() { FirstName = "Marry", LastName = "Jones" });
                Peoples.Add(new PersonModel() { FirstName = "Sue", LastName = "Smith" });

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
