namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создать два объекта типа Person с проверкой и совпад.
            Person person1 = new Person("Anrey", "Petrov", new DateTime(2000, 5, 15));
            Person person2 = new Person("Anrey", "Petrov", new DateTime(2000, 5, 15));

            Console.WriteLine($"Ссылки равны: {ReferenceEquals(person1, person2)}");
            Console.WriteLine($"Объекты равны: {person1 == person2}");
            Console.WriteLine($"Хэш-код person1: {person1.GetHashCode()}");
            Console.WriteLine($"Хэш-код person2: {person2.GetHashCode()}");

            // 2. Создать объект типа Student добавить элементы и тд. вывод 
            Student student = new Student(person1, Education.Bachelor, 102);
            student.AddExams(new Exam("Математика", 5, new DateTime(2023, 6, 1)), new Exam("Физика", 4, new DateTime(2023, 6, 2)));
            student.Exams.Add(new Test("Информатика", true));
            Console.WriteLine("\nДанные студента:");
            Console.WriteLine(student.ToString());

            // 3. Вывести значение типа Person для Student
            Console.WriteLine("\nСвойство Person объекта Student:");
            Console.WriteLine(student.Person);

            // 4. Создал полную копию объекта Student с DeepCopy() 
            Student studentCopy = (Student)student.DeepCopy();
            student.GroupNumber = 200; // Изменяем исходный объект
            student.Name = "Alex"; // Изменяем имя
            Console.WriteLine("\nИсходный объект Student после изменений:");
            Console.WriteLine(student);
            Console.WriteLine("\nКопия объекта Student:");
            Console.WriteLine(studentCopy);

            // 5. Проверка исключения некорректной группк
            try
            {
                student.GroupNumber = 50; // Некорректное значение
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"\nИсключение: {ex.Message}");
            }

            // 6. Список по всем элементам 
            Console.WriteLine("\nСписок всех зачетов и экзаменов:");
            foreach (object item in student.Exams)
            {
                Console.WriteLine(item);
            }

            // 7. Список экзаменов с оценкой выше 3
            Console.WriteLine("\nСписок экзаменов с оценкой выше 3:");
            foreach (Exam exam in student.Perebor(3))
            {
                Console.WriteLine(exam);
            }
        }
    }
}

