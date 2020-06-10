using System;
using System.Collections.Generic;
using System.Text;

namespace OldBook.Data.Model
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public DateTime DateOfOrder { get; set; }
        public string Status { get; set; }
        public List<Book> Books { get; set; }
        public List<Address> Addresses { get; set; }

        //Navigation Property
        public int UserId { get; set; }
        public User User { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}
