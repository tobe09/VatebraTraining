using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManager.DbContext.Models
{
    public class Catalogue
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CatalogueId { get; set; }

        [DisplayName("Book Name")]
        public string BookName { get; set; }

        [DisplayName("Number Of Books")]
        public int NumberOfBooks
        {
            get
            {
                return Books.Count;
            }
        }

        [ForeignKey("CatalogueId")]
        public ICollection<Book> Books { get; set; } 
    }
}
