using System;
using System.Collections.Generic;
using System.Text;

namespace OldBook.Data.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Edition { get; set; }
        public int Price { get; set; }
        public string Status { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
        public List<Cart> Carts { get; set; }

        //Navigation Property
        public List<User> Authors { get; set; }
        public User User { get; set; }

    }
}
