using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;

namespace Library
{
    public class LendingManager
    {
        private const string FilePath = "lendings.json";
        public List<Lending> Lendings = new();
        public LendingManager()
        {
            LoadLendings();
        }
        public void LoadLendings()
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Close();
                Lendings = new List<Lending>();
            }
            else
            {
                string json = File.ReadAllText(FilePath);
                if (string.IsNullOrWhiteSpace(json))
                {
                    Lendings = new List<Lending>();
                }
                else
                {
                    Lendings = JsonSerializer.Deserialize<List<Lending>>(json) ?? new List<Lending>();
                }
            }
        }
        public void SaveLendings()
        {
            File.WriteAllText(FilePath, JsonSerializer.Serialize(Lendings, new JsonSerializerOptions { WriteIndented = true }));
        }
        public void LendBook(string bookId, string userId)
        {
            Lendings.Add(new Lending(Guid.NewGuid().ToString(), bookId, userId, DateTime.Now));
            SaveLendings();
        }
        public void ReturnBook(string bookId)
        {
            for (int i = 0; i < Lendings.Count; i++)
            {
                if (Lendings[i].BookId == bookId)
                {
                    Lendings.RemoveAt(i);
                    break;
                }
            }
            SaveLendings();
        }
        public List<Lending> GetLendingsByUserId(string userId)
        {
            return Lendings.FindAll(l => l.UserId == userId);
        }
        public Lending? GetLendingByBookId(string bookId)
        {
            return Lendings.Find(l => l.BookId == bookId);
        }
        public Lending? GetLendingByIds(string bookId, string userId)
        {
            return Lendings.Find(l => l.BookId == bookId && l.UserId == userId);
        }
        public Lending? GetLendingById(string id)
        {
            return Lendings.Find(l => l.Id == id);
        }
        public void RemoveLending(string id)
        {
            for (int i = 0; i < Lendings.Count; i++)
            {
                if (Lendings[i].Id == id)
                {
                    Lendings.RemoveAt(i);
                    break;
                }
            }
            SaveLendings();
        }
    }
}
