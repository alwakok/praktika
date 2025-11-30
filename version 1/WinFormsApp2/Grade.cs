using System;
using WinFormsApp2;

public class Grade
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int SubjectId { get; set; }
    public int Mark { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }

    // Навигационные свойства - ОБЯЗАТЕЛЬНО добавьте это
    public virtual Student Student { get; set; }
    public virtual Subject Subject { get; set; }
}