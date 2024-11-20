
class Student
{
    Person person { get; set; }
    Education educ { get; set; }
    int group { get; set; }
    Exam[] exams { get; set; }
    public Student(Person person,Education educ,int group )
    {
        this.person = person;
        this.educ = educ;
        this.group = group;
    }
    public Student()
    {
        this.person = new Person("Alex", "Inavov", new DateTime(1987, 12, 4));
        this.educ = Education.Bachelor;
        this.group = 323;
        this.exams = new Exam[0];
    }

    public double average
    {
        get 
        { 
            return exams.Length > 0 ? exams.Average(e => e.Note) : 0; 
        }
    }
    public bool this[Education educ]
    {
        get 
        {

            return this.educ == educ; ;
            
        }
       
    }
    public void AddExams(params Exam[] newExams)
    {
        exams = exams.Concat(newExams).ToArray();
    }
    public override string ToString()
    {
        string examsInfo = exams.Length > 0 ? string.Join(", ", exams.Select(e => e.ToString())) : "Экзаменов нет";
        return $"{person}, Образование: {educ}, Группа: {group}, Экзамены: {examsInfo}";
    }
    public virtual string ToShortString()
    {
        return $"{person}, Образование: {educ}, Группа: {group}, Средний балл: {average}";
    }

}