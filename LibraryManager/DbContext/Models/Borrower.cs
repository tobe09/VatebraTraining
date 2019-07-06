using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManager.DbContext.Models
{
    public class Borrower
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BorrowerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        [ForeignKey("BorrowerId")]
        public ICollection <BorrowInformation> BorrowInformation { get; set; }
    }
}
