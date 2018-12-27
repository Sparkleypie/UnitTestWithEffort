using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestWithEffort
{
    public class FakeContactSet : DbSet<Contact>
    {
        public override Contact Find(params object[] keyValues)
        {
            return this.SingleOrDefault(e => e.ContactID == (int)keyValues.Single());
        }
    }
}
