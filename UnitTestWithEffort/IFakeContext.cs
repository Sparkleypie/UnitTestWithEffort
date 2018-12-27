using System.Data.Entity;

namespace UnitTestWithEffort
{
    interface IFakeContext
    {
        DbSet<Company> Companies { get; set; }
        DbSet<Contact> Contacts { get; set; }
        int SaveChanges();
    }
}
