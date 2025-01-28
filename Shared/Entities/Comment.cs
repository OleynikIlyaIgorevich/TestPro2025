namespace Domain.Entities;

public class Comment
{
    public int Id { get; set; }

    public int DocumentId { get; set; }
    public int EmploeeId { get; set; }

    public string Text { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }

    public Document Document { get; set; }
    public Emploee Emploee { get; set; }

    public Comment() { }

    public Comment(
        int id,
        int documentId,
        int emloeeId,
        string text,
        DateTime dateCreated)
    {
        Id = id;
        DocumentId = documentId;
        EmploeeId = emloeeId;
        Text = text;
        DateCreated = dateCreated;
    }

    public Comment(
        int documentId,
        int emloeeId,
        string text,
        DateTime dateCreated)
    {
        DocumentId = documentId;
        EmploeeId = emloeeId;
        Text = text;
        DateCreated = dateCreated;
    }
}
