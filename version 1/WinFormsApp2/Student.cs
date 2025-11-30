using System.Collections.Generic;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Class { get; set; }
    public DateTime BirthDate { get; set; }

    public string FullName => $"{LastName} {FirstName}";

    // Навигационное свойство
    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
}