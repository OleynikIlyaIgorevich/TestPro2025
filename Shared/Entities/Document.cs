namespace Domain.Entities;

public class Document
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public string Title { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }

    public Category Category { get; set; }

    public List<Comment> Comments { get; set; }

    public Document() { }

    public Document(
        int id,
        int categoryId,
        string title,
        DateTime dateCreated)
    {
        Id = id;
        CategoryId = categoryId;
        Title = title;
        DateCreated = dateCreated;
    }

    public Document(
        int categoryId,
        string title,
        DateTime dateCreated)
    {
        CategoryId = categoryId;
        Title = title;
        DateCreated = dateCreated;
    }
}
