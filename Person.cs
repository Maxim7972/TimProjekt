using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Person:IDateAndCopy
    {
        protected string name;
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
        protected string fam;
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

        public DateTime Date { get; set; }
        
        public Person(string name, string fam, DateTime Date)
        {
            this.name = name;
            this.fam = fam;
            this.Date = Date;
        }
        public Person()
        {
            name = "Andrey";
            fam = "Petrov";
            Date = new DateTime(1995, 12, 17);
        }
        public override string ToString()
        {
            return $"Имя:{name},фамилия:{fam},дата рождения:{Date}";
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
            return name == p.name && fam == p.fam && Date == p.Date&&fam==p.fam;
        }
        public override int GetHashCode()
        {
            int hash = 23;
            hash = hash * 31 + name.GetHashCode();
            hash = hash * 31 + fam.GetHashCode();
            hash = hash * 31 + Date.GetHashCode();
            return hash;
        }
        public object DeepCopy()
        {
            return new Person();
        }
    }
}
