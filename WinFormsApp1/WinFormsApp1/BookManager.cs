using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json.Bson;

namespace Library
{
    public class BookManager
    {
        private const string FilePath = "books.json";
        public List<Book> Books { get; set; } = new();
        public BookManager()
        {
            LoadBooks();
        }
        public void LoadBooks()
        {
            Books = JsonSerializer.Deserialize<List<Book>>(File.ReadAllText(FilePath)) ?? new List<Book>();
        }
        public void SaveBooks()
        {
            File.WriteAllText(FilePath, JsonSerializer.Serialize(Books, new JsonSerializerOptions { WriteIndented = true }));
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
            SaveBooks();
        }
        public void RemoveBook(Book book)
        {
            for(int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Id == book.Id)
                {
                    Books.RemoveAt(i);
                    break;
                }
            }
            SaveBooks();
        }
        public Book? GetBookById(string id)
        {
            return Books.Find(b => b.Id == id);
        }
    }
}
