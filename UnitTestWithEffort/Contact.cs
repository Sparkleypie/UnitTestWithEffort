using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnitTestWithEffort
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }

        [ForeignKey("Company")]
        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
    }
}
