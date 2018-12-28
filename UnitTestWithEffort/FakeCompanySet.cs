
using System.Linq;
using System.Data.Entity;

namespace UnitTestWithEffort
{
    public class FakeCompanySet : FakeDbSet<Company>
    {
        public override Company Find(params object[] keyValues)
        {
            return this.SingleOrDefault(d => d.Id == (int)keyValues.Single());
        }
    }
}
