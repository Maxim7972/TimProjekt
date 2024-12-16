public class Test
{
    public string Testop { get; set; } //Название предмета
    public bool Teststat { get; set; }      // Сдан зачет 


    public Test(string testop, bool teststat)
    {
        this.Testop = testop;
        this.Teststat = teststat;
    }

    public Test()
    {
        this.Testop = "Тест по умолчанию";
        this.Teststat = false;
    }

    public override string ToString()
    {
        return $"Описание: {Testop}, Пройден: {Teststat}";
    }
}
