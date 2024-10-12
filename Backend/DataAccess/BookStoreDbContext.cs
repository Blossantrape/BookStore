using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class BookStoreDbContext : DbContext
{
    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
    {
    }
    
    public DbSet<BookEntity> Books { get; set; }
}