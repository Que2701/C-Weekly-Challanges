using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleLibrary
{
    public class PeopleList
    {
        #region Fields
        private static volatile PeopleList instance = null;
        private static object syncRoot = new object();
        #endregion

        #region Constructor
        /// <summary>
        /// Private constructor
        /// </summary>
        private PeopleList() { }
        #endregion

        #region Properties
        public static PeopleList Instance { get { if (instance == null) { lock (syncRoot) { if (instance == null) { instance = new PeopleList(); } } } return instance; } }

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
