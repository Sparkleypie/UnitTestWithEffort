using System.Data.Entity;

namespace UnitTestWithEffort
{
    public interface IFakeContext
    {
        IDbSet<Company> Companies { get; set; }
        IDbSet<Contact> Contacts { get; set; }
        int SaveChanges();
    }
}
