namespace Core.Models;

public class Book
{
    public const int MaxTitleLength = 100;

    private Book(Guid id, string title, string description, decimal price)
    {
        Id = id;
        Title = title;
        Description = description;
        Price = price;
    }
    
    public Guid Id { get; }

    public string Title { get; } = string.Empty;
    
    public string Description { get; } = string.Empty;
    
    public decimal Price { get; }

    public static (Book book, string Error) Create(Guid id, string title, string description, decimal price)
    {
        var error = string.Empty;

        if (string.IsNullOrEmpty(title) || title.Length > MaxTitleLength)
        {
            error = "Title must be between 1 and 100 characters";
        }
        
        var book = new Book(id, title, description, price);

        return (book, error);
    }
}