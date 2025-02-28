using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system_project
{
    internal class Librarian :User
    {
        public Librarian(string name )
        {
            Name = name;
        }
        public int EmployeeNumber { get; set; }
        
        public void AddBook(Book newBook , Library library)
        {
            library.Add(newBook);

        }

        public void RemoveBook(Book removedBook , Library library)
        {
            library.Remove(removedBook);

        }

    }
}
