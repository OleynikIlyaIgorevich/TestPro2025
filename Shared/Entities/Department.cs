namespace Domain.Entities;

public class Department
{
    public int Id { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }

    public List<SubDepartment> SubDepartments { get; set; }

    public Department()
    {
        
    }

    public Department(
        int id,
       string title,
       string description)
    {
        Id = id;
        Title = title;
        Description = description;
    }

    public Department(
        string title,
        string description)
    {
        Title = title;
        Description = description;
    }

}
