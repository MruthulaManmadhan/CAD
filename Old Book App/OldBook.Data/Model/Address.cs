using System;
using System.Collections.Generic;
using System.Text;

namespace OldBook.Data.Model
{
    public class Address
    {
        public int Id { get; set; }
        public string HouseName { get; set; }
        public string LandMark { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public double Phone { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }

        //Navigation Property
        public User User { get; set; }
        public int UserId { get; set; }

    }
}
