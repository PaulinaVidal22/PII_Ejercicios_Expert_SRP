using System;
namespace SRP
{
public class Book
      {
      public string Title { get ; }
      public string Author { get ; }
      public string Code { get ;  }
      public string LibrarySector { get ; set; }
      public string LibraryShelve { get ; set; }

    public Book(String title, String author, String code)  //método constructor
      {
            this.Title = title;
            this.Author = author;
            this.Code = code;
      }
      }

        //la clase book tiene responsabilidades adicionales que no le corresponden al libro 
        // como sector y  shelve
        // lo cual hace que no sea un codigo reutilizable para otro contexto
}


