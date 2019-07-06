using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManager.DbContext.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        public string ISBN { get; set; }
        public BookStatus BookStatus { get; set; }
        public int CatalogueId { get; set; }

        public Catalogue Catalogue { get; set; }

        [ForeignKey("BookId")]
        public ICollection<BorrowInformation> BorrowInformation { get; set; }
    }

    public enum BookStatus
    {
        [Description("Borrowed")]
        Borrowed,
        [Description("Available")]
        Available
    }
}