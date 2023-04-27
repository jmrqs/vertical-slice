namespace PointOfSale.Web;

public class Query
{
    public Book GetBook() =>
        new()
        {
            Title = "C# in depth.",
            Author = new Author
            {
                Name = "Jon Skeet"
            }
        };
}

public class Book
{
    public string? Title { get; set; }

    public Author? Author { get; set; }
}

public class Author
{
    public string? Name { get; set; }
}
