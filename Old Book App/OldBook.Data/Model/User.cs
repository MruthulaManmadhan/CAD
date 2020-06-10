using System;
using System.Collections.Generic;
using System.Text;

namespace OldBook.Data.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public List<Address> Addresses { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
        public List<Cart> Carts { get; set; }
        //Navigation Property
        public List<Book> Books { get; set; }
        public Book Book { get; set; }
        
    }
}
