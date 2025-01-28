namespace Domain.Entities;

public class Emploee
{
    public int Id { get; set; }

    public int CabinetId { get; set; }
    public int SubDepartmentId { get; set; }
    public int PositionId { get; set; }

    public bool IsLeader { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }

    public DateTime BirthAt { get; set; }
    public string WorkingPhone { get; set; }
    public string PersonelPhone { get; set; }
    public string WorkingEmail { get; set; }
    public string PersonelEmail { get; set; }

    public string? Description { get; set; }

    public Cabinet Cabinet { get; set; }
    public SubDepartment SubDepartment { get; set; }
    public Position Position { get; set; }

    public List<Comment> Comments { get; set; }

    public Emploee() { }

    public Emploee(
       int id,
       int cabinetId,
       int subDepartmentId,
       int positionId,
       bool isLeader,
       string name,
       string password,
       string lastName,
       string firstName,
       string middleName,
       DateTime birthAt,
       string workingPhone,
       string personelPhone,
       string workingEmail,
       string personelEmail,
       string description)
    {
        Id = id;
        CabinetId = cabinetId;
        SubDepartmentId = subDepartmentId;
        PositionId = positionId;
        IsLeader = isLeader;
        Name = name;
        Password = password;
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
        BirthAt = birthAt;
        WorkingPhone = workingPhone;
        PersonelPhone = personelPhone;
        WorkingEmail = workingEmail;
        Description = description;
    }

    public Emploee(
        int cabinetId,
        int subDepartmentId,
        int positionId,
        bool isLeader,
        string name,
        string password,
        string lastName,
        string firstName,
        string middleName,
        DateTime birthAt,
        string workingPhone,
        string personelPhone,
        string workingEmail,
        string personelEmail,
        string description)
    {
        CabinetId = cabinetId;
        SubDepartmentId = subDepartmentId;
        PositionId = positionId;
        IsLeader = isLeader;
        Name = name;
        Password = password;
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
        BirthAt = birthAt;
        WorkingPhone = workingPhone;
        PersonelPhone = personelPhone;
        WorkingEmail = workingEmail;
        Description = description;
    }

}
