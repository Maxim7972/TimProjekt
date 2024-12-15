

public class Exam : IDateAndCopy
{
    public string Name { get; set; }      
    public int Note { get; set; }        
    public DateTime Date { get; set; }   

    
    public Exam(string name, int note, DateTime examDate)
    {
        this.Name = name;
        this.Note = note;
        this.Date = examDate;
    }

   
    public Exam() { }

    // Реализация метода Copy()
    public object Copy()
    {
        return new Exam(this.Name, this.Note, this.Date);
    }

    public override string ToString()
    {
        return $"Предмет: {Name}, Оценка: {Note}, Дата экзамена: {Date.ToShortDateString()}";
    }
}




