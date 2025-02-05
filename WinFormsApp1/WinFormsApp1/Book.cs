using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public string Id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public Book(string id, string title, string author, string genre, string isbn)
        {
            Id = id;
            Title = title;
            Author = author;
            Genre = genre;
            ISBN = isbn;
        }
    }
}
