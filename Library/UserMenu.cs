using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class UserMenu
    {
        Library lib = new Library();
        public void Options()
        {
            
            while (true)
                {
                    Console.WriteLine("0. Exit");
                    Console.WriteLine("1. Issue Book");
                    Console.WriteLine("2. Return Book");
                    Console.WriteLine("3. BookList");
                    Console.WriteLine("4. check issued books Scenario");
                Console.Write("Select an option: ");
                    var option = Console.ReadLine();
                    switch (option)
                    {
                        case "0":
                            Console.WriteLine("Thank you for visiting the Library!");
                        Console.WriteLine("Press enter to exit");
                        var userInput = Console.ReadLine();
                        return; 
                        case "1":
                        Console.WriteLine("What is your name:");
                        var name = Console.ReadLine();
                        User user1 = new User(name);
                        Console.Write("Which book you want to issue: ");
                        var bookIssue = Console.ReadLine();
                        bool result = lib.Issue(bookIssue,name);
                            if (result == true)
                              Console.WriteLine("Book is available to issue");
                           else
                             Console.WriteLine("Book is not available to issue, User is added to waitlist");
                        break;
                    case "2":
                        Console.WriteLine("What is your name:");
                        var uname = Console.ReadLine();
                        User user2 = new User(uname);
                        Console.Write("Which book you want to return: ");
                        var bookReturn = Console.ReadLine();
                        bool result1 = lib.Return(bookReturn,uname);
                        if (result1 == true)
                            Console.WriteLine("Book is returned and issued to the person was in waiting list");
                        else
                            Console.WriteLine("Book is returned");
                        break;
                    case "3":
                        Console.WriteLine("See the books present in Library which are avaialable");
                       Console.WriteLine("********************");
                       lib.DisplayBooks();
                        break;
                    /*case "4":
                       /* User a = new User("Palki");
                        User b = new User("Sudi");
                        // print user 1 wants to issue which book ?
                        Console.WriteLine("Palki wants to issue which book");
                        // user 1 wants to issue JavaBook
                        Console.WriteLine("Palki wants to issue JavaBook");
                        // isssue ("bookname", userA.name)
                        lib.Issue("JavaBook","Palki");
                        // print which book user 2 wants to issue.
                        Console.WriteLine("Sudi wants to issue which book");
                        // you as user 2 enter javabook
                        Console.WriteLine("Sudi wants to issue JavaBook");
                        // issue (bookname, user2.name)
                        lib.Issue("JavaBook", "Sudi");
                        // print user 1 wants to return which book ?
                        Console.WriteLine("Palki wants to return which Book");
                        // user 1 enter the javabook
                        Console.WriteLine("Palki wants to return JavaBook");
                        // call return (javabook, user1.nama)
                        lib.Return("JavaBook", "Palki");
                        // book returned successfully and issues user 2.
                        Console.WriteLine("JavaBook returned succesfully and issued to Sudi");
                        lib.TestIssuedBooks();
                        
                        break;*/
                    case "4":
                        Console.WriteLine("See the books present issued to peoplein Library");
                        Console.WriteLine("********************");
                        lib.TestIssuedBooks();
                        break;
                    default:
                        break;
                }
               
                }
        }
    }
}
