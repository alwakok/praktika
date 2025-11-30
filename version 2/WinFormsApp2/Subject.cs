using System.Collections.Generic;

public class Subject
{
    public int Id { get; set; }
    public string Name { get; set; }

    // Навигационное свойство
    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
}