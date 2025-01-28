namespace Domain.Entities;

public class Cabinet
{
    public int Id { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }

    public List<Emploee> Emploees { get; set; }

    public Cabinet() { }

    public Cabinet(
        int id,
        string title,
        string description)
    {
        Id = id;
        Title = title;
        Description = description;
    }


    public Cabinet(
        string title,
        string description)
    {
        Title = title;
        Description = description;
    }
    
}
