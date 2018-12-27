using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UnitTestWithEffort
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Promo { get; set; }
        public virtual List<Contact> Contacts { get; set; }
    }
}
