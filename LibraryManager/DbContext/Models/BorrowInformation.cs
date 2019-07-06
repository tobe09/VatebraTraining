using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManager.DbContext.Models
{
    public class BorrowInformation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int BorrowInformationId { get; set; }
        public int BorrowerId { get; set; }
        public int BookId { get; set; }

        public Borrower Borrower { get; set; }
        public Book Book { get; set; }
    }
}