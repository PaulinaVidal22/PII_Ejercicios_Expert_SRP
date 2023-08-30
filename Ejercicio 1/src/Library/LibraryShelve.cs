using System.Collections.Generic;

namespace SRP
{
    public class LibraryShelve
{
    public List<Book> ListOfBooks {get; set;}
    public int ShelveNumber {get; set;}

    public LibraryShelve (int shelveNumber)
    {
        this.ShelveNumber = shelveNumber;
        this.ListOfBooks = new List <Book>();
    }

    public void AddBooks(Book book)
    {
        ListOfBooks.Add(book);
    }

}
}



