
using System.Data.Entity;

namespace UnitTestWithEffort
{
    public class FakeDbContext : IFakeContext
    {
        public FakeDbContext()
        {
            this.Companies = new FakeCompanySet();
            this.Contacts = new FakeContactSet();
        }

        public IDbSet<Company> Companies { get; private set; }

        public IDbSet<Contact> Contacts { get; private set; }

        public int SaveChanges()
        {
            return 0;
        }
    }
}
