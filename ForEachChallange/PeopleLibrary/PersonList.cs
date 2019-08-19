using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleLibrary
{
    public class PersonList
    {
        #region Fields
        private static volatile PersonList instance = null;
        private static object syncRoot = new object();
        #endregion

        #region Constructor
        /// <summary>
        /// Private constructor
        /// </summary>
        private PersonList() { }
        #endregion

        #region Properties
        public static PersonList Instance { get { if (instance == null) { lock (syncRoot) { if (instance == null) { instance = new PersonList(); } } } return instance; } }

        public List<string> PeoplesList { get; set; } = new List<string>()
        {
            "John",
            "Marry",
            "Sue",
            "Greg",
            "Yolanda",
            "Jose",
            "Bill"
        };
        #endregion
    }
}
