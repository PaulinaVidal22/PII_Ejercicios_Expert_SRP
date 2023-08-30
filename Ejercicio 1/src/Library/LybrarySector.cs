using System.Collections.Generic;

namespace SRP
{
    public class LibrarySector
{
    public List<LibraryShelve> ListOfShelf {get;set; }
    public string librarySector {get; set;}

    public LibrarySector (string librarySector)
    {
        this.librarySector = librarySector ;
        this.ListOfShelf = new List<LibraryShelve>();
    }

    public void AddShelve (LibraryShelve shelve)
    {
        ListOfShelf.Add(shelve);
    }

}
}


