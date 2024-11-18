class Person
{
    string name;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
            if(name==null)
            {
                throw new Exception("Имя не может быть пустым");
            }
        }
    }
    string fam;
    public string Fam
    {
        get
        {
            return fam;
        }
        set
        {
            fam = value;
            if(fam==null)
            {
                throw new Exception("Фамилия не может быть пустой");
            }
        }
    }
    
    DateTime birth;
    public DateTime Birth
    {
        get
        {
            return birth;
        }
        set
        {
            birth = value;
            if (birth.Year<1900)
            {
                throw new Exception("Недопустимый год");
            }
        }
    }
    public Person(string name, string fam,DateTime birth)
    {
        this.name = name;
        this.fam = fam;
        this.birth = birth;
    }
    public Person()
    {
        name = "Andrey";
        fam = "Petrov";
        birth = new DateTime(1995, 12, 17);
    }
    public override  string ToString()
    {
        return $"Имя:{name},фамилия:{fam},дата рождения:{birth}";
    }
    public virtual string ToShortString()
    {
        return $"Имя:{name},фамилия:{fam}";
    }
}
