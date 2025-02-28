using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system_project
{
    internal class Library
    {
        private Book[] books = new Book[100];
        private int currentBookCount = 0;
        private Book[] Borrowedbooks = new Book[50];
        private int borrowedBooks = 0;
        
        public void Display()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }

        }

        public void Add(Book book)
        {
            if (currentBookCount < books.Length)
            {
                books[currentBookCount] = book;
                currentBookCount++;
                Console.WriteLine("Book added succesfully");
            }
            else
            {
                Console.WriteLine("Library is full to add new book ");
            }

        }

        public void Remove(Book book )
        {
            int index = Array.IndexOf(books, book);
            books[index] = null;
            currentBookCount--;
            Console.WriteLine("Book removed succesfully");

        }

        public void Borrrow(Book book)
        {
            if (borrowedBooks < Borrowedbooks.Length)
            {
                books[currentBookCount] = book;
                borrowedBooks++;
                Console.WriteLine("Book borrowed succesfully");
            }
            else
            {
                Console.WriteLine("Library is empty to borrow book ");
            }
        }
    }
}
