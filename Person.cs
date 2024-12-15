using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Person
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
                if (name == null)
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
                if (fam == null)
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
                if (birth.Year < 1900)
                {
                    throw new Exception("Недопустимый год");
                }
            }
        }
        public Person(string name, string fam, DateTime birth)
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
        public override string ToString()
        {
            return $"Имя:{name},фамилия:{fam},дата рождения:{birth}";
        }
        public virtual string ToShortString()
        {
            return $"Имя:{name},фамилия:{fam}";
        }
        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Person p1, Person p2)
        {
            return !p1.Equals(p2);
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || (obj is not Person)) return false;
            Person p = (Person)obj;
            return name == p.name && fam == p.fam && birth == p.birth;
        }
        public override int GetHashCode()
        {
            int hash = 23;
            hash = hash * 31 + name.GetHashCode();
            hash = hash * 31 + fam.GetHashCode();
            hash = hash * 31 + birth.GetHashCode();
            return hash;
        }
        public object DeepCopy()
        {
            return new Person();
        }
    }
}
