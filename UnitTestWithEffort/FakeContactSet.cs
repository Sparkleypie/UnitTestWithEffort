using System.Linq;

namespace UnitTestWithEffort
{
    public class FakeContactSet : FakeDbSet<Contact>
    {
        public override Contact Find(params object[] keyValues)
        {
            return this.SingleOrDefault(e => e.ContactID == (int)keyValues.Single());
        }
    }
}
