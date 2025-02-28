using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system_project
{
    public class Program
    {
        private static string name;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the library system");

            Library library = new Library();

            Console.WriteLine("Are you librarian or regular user (L/R)");

            char userType = Console.ReadLine().ToUpper()[0];
            
            
                if (userType == 'L')
                {
                    Console.WriteLine("Entre your name ");
                    string librarianName = Console.ReadLine();

                    Librarian L1 = new Librarian(librarianName);
                    Console.WriteLine($"Welcome {L1.Name}");
                while (true)
                {



                    Console.WriteLine("Please choose to Add book (A) / Remove book (R) / Display book (D)");

                    char choice = Console.ReadLine().ToUpper()[0];
                    switch (choice)
                    {
                        case 'A':
                            Console.WriteLine("Entre book details ");
                            string bookName = Console.ReadLine();
                            string bookAuthor = Console.ReadLine();
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book()
                            {

                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear,

                            };
                            L1.AddBook(book, library);

                            break;

                        case 'R':
                            Console.WriteLine("Entre book details ");
                            bookName = Console.ReadLine();
                            bookAuthor = Console.ReadLine();
                            bookYear = Convert.ToInt32(Console.ReadLine());
                            book = new Book()
                            {

                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear,

                            };
                            L1.RemoveBook(book, library);
                            break;

                        case 'D':
                            Console.WriteLine("The book list");
                            L1.DisplayBooks(library);
                            break;


                        default:
                            Environment.Exit(0);
                            break;
                    }
                }

                }
                else if (userType == 'R')
                {
                    Console.WriteLine("Welcome user , Entre your name ");
                    string userName = Console.ReadLine();

                LibraryUser U1 = new LibraryUser(name);
                    Console.WriteLine($"Welcome {U1.Name}");
                while (true)
                {

                    Console.WriteLine("Please choose to  Display book (D) /  borrow book(B)");

                    char choice = Console.ReadLine().ToUpper()[0];
                    switch (choice)
                    {
                        case 'D':
                            Console.WriteLine("The book list");
                            U1.DisplayBooks(library);
                            break;

                        case 'B':
                            Console.WriteLine("Entre book details to Borrow ");
                            string bookName = Console.ReadLine();
                            string bookAuthor = Console.ReadLine();
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book()
                            {

                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear,

                            };
                            U1.BorrowBook(book, library);

                            break;

                     

                        default:
                           Environment.Exit(0);
                            break;
                    }
                }



                }
                else
                {
                    Console.WriteLine("Please entre correct value (L/R)");
                }
            
           

        }
    }
}
