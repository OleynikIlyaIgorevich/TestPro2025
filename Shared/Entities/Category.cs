namespace Domain.Entities;

public class Category
{
    public int Id { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }

    public List<Document> Documents { get; set; }

    public Category() { }

    public Category(
        int id,
        string title,
        string description)
    {
        Id = id;
        Title = title;
        Description = description;
    }

    public Category(
        string title,
        string description)
    {
        Title = title;
        Description = description;
    }
}
