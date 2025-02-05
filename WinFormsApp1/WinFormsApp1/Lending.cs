using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Lending
    {
        public string Id { get; set; } = string.Empty;
        public string BookId { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public DateTime LendDate { get; set; }
        public Lending(string lendingId, string bookId, string userId, DateTime lendDate)
        {
            Id = lendingId;
            BookId = bookId;
            UserId = userId;
            LendDate = lendDate;
        }
        public Lending()
        {
        }
        public DateTime GetDueDate()
        {
            return LendDate.AddDays(30);
        }
    }
}
