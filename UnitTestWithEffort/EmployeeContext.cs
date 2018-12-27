using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace UnitTestWithEffort
{
    public class EmployeeContext : DbContext, IFakeContext
    {
        public IDbSet<Company> Companies { get; set; }
        public IDbSet<Contact> Contacts { get; set; }
    }
}




