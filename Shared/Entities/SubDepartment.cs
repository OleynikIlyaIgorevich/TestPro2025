namespace Domain.Entities;

public class SubDepartment
{
    public int Id { get; set; }

    public int DepartmentId { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }

    public Department Department { get; set; }

    public List<Emploee> Emploees { get; set; }

    public SubDepartment() { }

    public SubDepartment(
        int id,
        int departmentId,
        string title,
        string description)
    {
        Id = id;
        DepartmentId = departmentId;
        Title = title;
        Description = description;
    }

    public SubDepartment(
        int departmentId,
        string title,
        string description)
    {
        DepartmentId = departmentId;
        Title = title;
        Description = description;
    }

    
}
