
public enum Education
{
    Specialist,
    Bachelor,
    SecondEducation
}

public class Exam
{
    public string Name { get; set; }      // Название предмета
    public int Note { get; set; }          // Оценка
    public DateTime Date { get; set; }  // Дата экзамена

    // параметрами
    public Exam(string name, int note, DateTime examDate)
    {
        this.Subject = name;
        this.Note = note;
        this.Date = examDate;
    }

    // по умолчанию
    public Exam()
    {

    }


    public override string ToString()
    {
        return $"Предмет: {Name}, Оценка: {Note}, Дата экзамена: {Date.ToShortDateString()}";
    }
}


