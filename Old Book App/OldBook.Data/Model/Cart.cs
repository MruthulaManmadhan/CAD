using System;
using System.Collections.Generic;
using System.Text;

namespace OldBook.Data.Model
{
    public class Cart
    {
        public int Id { get; set; }
        public int TotalPrice { get; set; }
        public string Status { get; set; }
        public List<Book> Books { get; set; }

        //Navigation Property
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
