
using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            
            LibraryShelve shelve7 =  new LibraryShelve (7);
            LibraryShelve shelve3 =  new LibraryShelve (3);

            LibrarySector sectorA = new LibrarySector("A");
            LibrarySector sectorB = new LibrarySector("B");

            shelve7.AddBooks(book1);
            shelve3.AddBooks(book2);
            
            sectorA.AddShelve(shelve7);
            sectorB.AddShelve(shelve3);

            Console.WriteLine($"sector {sectorA} contains {string.Join(",",sectorA.ListOfShelf)}");
            Console.WriteLine($"sector {sectorB} contains {string.Join(",",sectorB.ListOfShelf)}");

            Console.WriteLine($"shelve {shelve7} contains {string.Join(",",shelve7.ListOfBooks)}");
            Console.WriteLine($"shelve {shelve3} contains {string.Join(",",shelve3.ListOfBooks)}");

            // corregir join, usar for par imprimir

        }
    }
}