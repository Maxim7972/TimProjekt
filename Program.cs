Student student = new Student();
        Console.WriteLine("1. Вывод данных методом ToShortString():");
        Console.WriteLine(student.ToShortString());

        Console.WriteLine("\n2. Проверка индексатора:");
        Console.WriteLine($"Specialist: {student[Education.Specialist]}");
        Console.WriteLine($"Bachelor: {student[Education.Bachelor]}");
        Console.WriteLine($"SecondEducation: {student[Education.SecondEducation]}");

        Console.WriteLine("\n3. Присвоение значений свойствам и вывод методом ToString():");
        student.person = new Person("Иван", "Иванов", new DateTime(2000, 5, 15));
        student.educ = Education.Specialist;
        student.group = 101;
        Console.WriteLine(student.ToString());

        Console.WriteLine("\n4. Добавление экзаменов и вывод данных:");
        student.AddExams(
            new Exam("Математика", 90, new DateTime(2024, 1, 10)),
            new Exam("Физика", 85, new DateTime(2024, 1, 15)),
            new Exam("Химия", 88, new DateTime(2024, 1, 20))
        );
        Console.WriteLine(student.ToString());

        Console.WriteLine("\n5. Сравнение времени выполнения операций с массивами:");

        const int size = 1000000;
        Exam[] pervos = new Exam[size];
        Exam[,] thos = new Exam[1000, 1000];
        Exam[][] arrian = new Exam[1000][];
        for (int i = 0; i < 1000; i++)
    arrian[i] = new Exam[1000];

        for (int i = 0; i < size; i++)
    pervos[i] = new Exam("Предмет", 100, DateTime.Now);

        for (int i = 0; i < 1000; i++)
            for (int j = 0; j < 1000; j++)
        thos[i, j] = new Exam("Предмет", 100, DateTime.Now);

        for (int i = 0; i < 1000; i++)
            for (int j = 0; j < 1000; j++)
        arrian[i][j] = new Exam("Предмет", 100, DateTime.Now);

        var watch = System.Diagnostics.Stopwatch.StartNew();
        foreach (var exam in pervos)
        {
            var temp = exam.Note;
        }
        watch.Stop();
        Console.WriteLine($"Одномерный массив: {watch.misis} мс");

        watch.Restart();
        for (int i = 0; i < 1000; i++)
        {
            for (int j = 0; j < 1000; j++)
            {
                var temp = thos[i, j].Note;
            }
        }
        watch.Stop();
        Console.WriteLine($"Двумерный массив: {watch.misis} мс");

        watch.Restart();
        for (int i = 0; i < 1000; i++)
        {
            for (int j = 0; j < 1000; j++)
            {
                var temp = arrian[i][j].Note;
            }
        }
        watch.Stop();
        Console.WriteLine($"Ступенчатый массив: {watch.misis} мс");
