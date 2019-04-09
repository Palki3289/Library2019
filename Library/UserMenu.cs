using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class UserMenu
    {
        public void Options()
        {
            
            while (true)
                {
                    Console.WriteLine("0. Exit");
                    Console.WriteLine("1. Issue Book");
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
                            Library lib = new Library();
                        Console.Write("Which book you want to issue: ");
                        var book = Console.ReadLine();
                        bool result = lib.Issue(book);
                            if (result == true)
                              Console.WriteLine("Book is available to issue");
                            else
                              Console.WriteLine("Book is not available to issue, Please try after some days");
                             break;
                       default:
                             break;
                    }
               
                }
        }
    }
}
