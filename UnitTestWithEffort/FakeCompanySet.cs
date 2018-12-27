
using System.Linq;
using System.Data.Entity;

namespace UnitTestWithEffort
{
    public class FakeCompanySet : DbSet<Company>
    {
        public override Company Find(params object[] keyValues)
        {
            return this.SingleOrDefault(d => d.ID == (int)keyValues.Single());
        }
    }
}
