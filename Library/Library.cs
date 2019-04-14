using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Library
    {
        Dictionary<string, int> LibraryDictionary = new Dictionary<string, int>();
        // create dictionary for bookname and username for issued book <string, string> calling it as issue dctionary
        Dictionary<string, string> IssuedBooks = new Dictionary<string, string>();
        // create dictionary for book name and  user name for hold book calling it as hold dictionary
        Dictionary<string, string> HoldBooks = new Dictionary<string, string>();


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
            LibraryDictionary.Add("JavaBook", 1);// test with book
        }

        public bool Issue(string bookName, string userName) // add username parameter
        {
            if (LibraryDictionary.ContainsKey(bookName))
            {
                if (LibraryDictionary[bookName] > 0)
                {
                    LibraryDictionary[bookName] = LibraryDictionary[bookName] - 1;
                    // add entry to dictionary issue dictioary
                    IssuedBooks.Add(bookName, userName);
                    return true;
                }
                else
                // else block that means book count is 0
                // add this bookname and user name mapping to hold dictionary
                HoldBooks.Add(bookName, userName);
            }
            return false;
        }

        public bool Return(string bookName, string userName) // add paramter username
        {
            if (LibraryDictionary.ContainsKey(bookName))
            {
                // remove user1 person entry from issue dictionary
                IssuedBooks.Remove(bookName);
                // check if hold dictionary contains entry for thod book (user2 is in hold dictionary)
                if (HoldBooks.ContainsKey(bookName))
                {
                   string Holdperson = HoldBooks[bookName];
                    // remove bookname/user2 entry from hold dictonary
                    HoldBooks.Remove(bookName);
                    // add entry to issue dictionary
                    IssuedBooks.Add(bookName, Holdperson);
                    return true;
                }

                else
               
                LibraryDictionary[bookName] = LibraryDictionary[bookName] + 1; // do this only if there is no hold
                return false;

            }
            else
            {
                LibraryDictionary.Add(bookName, 1);
                return false;
            }
            
        }
        public void DisplayBooks()
        {
            foreach (var bookName in LibraryDictionary.Keys)
            {
                if(LibraryDictionary[bookName] > 0)
                Console.WriteLine(bookName);
            }
        }

        // books issued to a user// this method takes username as input and and return the book name from teh 
        // issues dictionary
        public void TestIssuedBooks()
        {
            foreach (var item in IssuedBooks.Keys)
            {
                Console.WriteLine(item + "and" + IssuedBooks[item]);
            }
        }
    }
}

