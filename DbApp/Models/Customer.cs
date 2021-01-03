using System;
using System.Collections.Generic;

#nullable disable

namespace DbApp.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
