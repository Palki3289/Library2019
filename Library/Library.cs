using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
   public class Library
    {
        private Dictionary<string, int> libraryDictionary = new Dictionary<string, int>();
        // create dictionary for bookname and username for issued book <string, string> calling it as issue dctionary
        private Dictionary<string, string> issuedBooks = new Dictionary<string, string>();
        // create dictionary for book name and  user name for hold book calling it as hold dictionary
        private Dictionary<string, string> holdBooks = new Dictionary<string, string>();


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
            libraryDictionary.Add("Sita", 2);
            libraryDictionary.Add("Increase Productivity", 4);
            libraryDictionary.Add("C sharp", 5);
            libraryDictionary.Add("JavaBook", 1);// test with book
        }

        public bool Issue(string bookName, string userName) // add username parameter
        {
            if (libraryDictionary.ContainsKey(bookName))
            {
                if (libraryDictionary[bookName] > 0)
                {
                    libraryDictionary[bookName] = libraryDictionary[bookName] - 1;
                    // add entry to dictionary issue dictioary
                    issuedBooks.Add(bookName, userName);
                    return true;
                }
                else
                // else block that means book count is 0
                // add this bookname and user name mapping to hold dictionary
                holdBooks.Add(bookName, userName);
            }
            return false;
        }

        public bool Return(string bookName, string userName) // add paramter username
        {
            if (libraryDictionary.ContainsKey(bookName))
            {
                // remove user1 person entry from issue dictionary
                issuedBooks.Remove(bookName);
                // check if hold dictionary contains entry for thod book (user2 is in hold dictionary)
                if (holdBooks.ContainsKey(bookName))
                {
                   string holdPerson = holdBooks[bookName];
                    // remove bookname/user2 entry from hold dictonary
                    holdBooks.Remove(bookName);
                    // add entry to issue dictionary
                    issuedBooks.Add(bookName, holdPerson);
                    return true;
                }

                else
               
                libraryDictionary[bookName] = libraryDictionary[bookName] + 1; // do this only if there is no hold
                return false;

            }
            else
            {
                libraryDictionary.Add(bookName, 1);
                return false;
            }
            
        }
        public void DisplayBooks()
        {
            foreach (var bookName in libraryDictionary.Keys)
            {
                if(libraryDictionary[bookName] > 0)
                Console.WriteLine(bookName);
            }
        }

        // books issued to a user// this method takes username as input and and return the book name from teh 
        // issues dictionary
        public void TestIssuedBooks()
        {
            foreach (var item in issuedBooks.Keys)
            {
                Console.WriteLine(item + "and" + issuedBooks[item]);
            }
        }
    }
}

