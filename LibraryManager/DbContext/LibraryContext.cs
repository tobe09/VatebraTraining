using LibraryManager.DbContext.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.DbContext
{
    public class LibraryContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options): base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Borrower> Borrowers { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Catalogue> Catalogues { get; set; }
        public virtual DbSet<BorrowInformation> BorrowInformation { get; set; }
    }
}