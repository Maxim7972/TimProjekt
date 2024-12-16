using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public enum Education
    {
        Bachelor,
        Specialist,
        SecondEducation
    }
    public enum Education
    {
        Bachelor,
        Specialist,
        SecondEducation
    }
    public class Student : Person, IDateAndCopy,IEnumerable
    {
        private Education education;
        private int groupNumber;
        private ArrayList tests;
        private ArrayList exams;

        public Student(Person person, Education education, int groupNumber)
            : base(person.Name, person.Fam, person.Date)
        {
            this.education = education;
            this.groupNumber = groupNumber;
            tests = new ArrayList();
            exams = new ArrayList();
        }

        public Student() : this(new Person(), Education.Bachelor, 101) { }

        public Person Person
        {
            get => new Person(Name, Fam, Date);
            set
            {
                Name = value.Name;
                Fam = value.Fam;
                Date = value.Date;
            }
        }

        public double AverageGrade
        {
            get
            {
                if (exams.Count == 0) return 0;
                double sum = 0;
                foreach (Exam exam in exams)
                {
                    sum += exam.Note;
                }
                return sum / exams.Count;
            }
        }

        public ArrayList Exams
        {
            get => exams;
            set => exams = value;
        }

        public void AddExams(params Exam[] newExams)
        {
            exams.AddRange(newExams);
        }

        public override string ToString()
        {
            string result = $"Человек: {Name} {Fam}, Дата: {Date}, Образование: {education}, Группа: {groupNumber}\nЭкзамены:\n";
            foreach (Exam exam in exams)
            {
                result += $"{exam.Name} - {exam.Note} ({exam.Date})\n";
            }
            result += "Тесты:\n";
            foreach (Test test in tests)
            {
                result += $"{test.Testop} - {test.Teststat}\n";
            }
            return result;
        }

        public override string ToShortString()
        {
            return $"Человек: {Name} {Fam}, Дата: {Date}, Образование: {education}, Группа: {groupNumber}, Средний балл: {AverageGrade}";
        }

        public  object DeepCopy()
        {
            Student copy = new Student(new Person(Name, Fam, Date), education, groupNumber)
            {
                exams = (ArrayList)exams.Clone(),
                tests = (ArrayList)tests.Clone()
            };
            return copy;
        }

        public int GroupNumber
        {
            get => groupNumber;
            set
            {
                if (value <= 100 || value > 599)
                    throw new ArgumentOutOfRangeException("GroupNumber", "Номер группы должен быть в пределах 101-599");
                groupNumber = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in tests)
            {
                yield return item;
            }
            foreach (var item in exams)
            {
                yield return item;
            }
        }

        public IEnumerable ExamsWithGradeAbove(int grade)
        {
            foreach (Exam exam in exams)
            {
                if (exam.Note > grade)
                {
                    yield return exam;
                }
            }
        }
    }
}
