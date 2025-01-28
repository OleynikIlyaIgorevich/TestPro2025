namespace Domain.Entities;

public class Position
{
    public int Id { get; set; }

    public string Title { get; set; }
    public string? Description { get; set; }

    public List<Emploee> Workers { get; set; }

    public Position() { }

    public Position(
        int id,
        string title,
        string description)
    {
        Id = id;
        Title = title;
        Description = description;
    }

    public Position(
        string title,
        string description)
    {
        Title = title;
        Description = description;
    }
}
