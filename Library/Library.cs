using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Library
    {
        Dictionary<string, int> LibraryDictionary = new Dictionary<string, int>();


        /// <summary>
        /// whether book is checkedout or not
        /// </summary>
        public bool CheckedOut { get; set; }

        /// <summary>
        /// defines the count of particular book
        /// </summary>
        public int Count { get; set; }

        public Library()
        {
            Initialize();
        }

        private void Initialize()
        {
            LibraryDictionary.Add("Sita", 2);
            LibraryDictionary.Add("Increase Productivity", 4);
            LibraryDictionary.Add("C sharp", 5);
            LibraryDictionary.Add("Head First Java", 1);
        }

        public bool Issue(string bookName)
        {
            if (LibraryDictionary.ContainsKey(bookName) && LibraryDictionary[bookName] > 0)
            {
                LibraryDictionary[bookName] = LibraryDictionary[bookName] - 1 ;
                return true;
            }
            return false;
        }
    }
}

