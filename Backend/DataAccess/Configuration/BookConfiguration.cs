using Core.Models;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration;

public class BookConfiguration : IEntityTypeConfiguration<BookEntity>
{
    public void Configure(EntityTypeBuilder<BookEntity> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.Property(b => b.Title)
            .HasMaxLength(Book.MaxTitleLength)
            .IsRequired();
        
        builder.Property(b => b.Description)
            .IsRequired();
        
        builder.Property(b => b.Price)
            .IsRequired();
    }
}