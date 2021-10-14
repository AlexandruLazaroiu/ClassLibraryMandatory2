using System;

namespace ClassLibraryMandatory2
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int PageNumber { get; set; }

        public Book(string isbn, string title, string author, int pageNumber)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            PageNumber = pageNumber;
        }
    }
}
