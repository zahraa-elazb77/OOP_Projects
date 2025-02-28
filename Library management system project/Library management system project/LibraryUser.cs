using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system_project
{
    internal class LibraryUser : User
    {
        public LibraryUser(String name)
        {
            Name = name;
        }
        public LibrayCard Card { get; set; }

      

        public void BorrowBook (Book book , Library library)
        {
            library.Borrrow(book);
        }
    }
}
