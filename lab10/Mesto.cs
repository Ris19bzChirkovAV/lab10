using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Mesto : IExecutable, ICloneable
    {
        protected string obl;
        protected string city;
        protected int age;

        public Mesto() { }
        public Mesto (string _obl, string _city, int _age)
        {
            obl = _obl;
            city = _city;
            age = _age;
        }

        public void setObl(string _obl)
        {
            obl = _obl;
        }

        public void setCity(string _city)
        {
            city = _city;
        }

        public string getObl()
        {
            return obl;
        }

        public string getCity()
        {
            return city;
        }

        virtual public int getAge()
        {
            return age;
        }

        public void setAge(int _age)
        {
            age = _age;
        }

        /*public void init()
        {
            Console.Write("Область? ");
            obl = Console.ReadLine();
            Console.Write("Город? ");
            city = Console.ReadLine();
            Console.Write("Возраст? ");
            age = int.Parse(Console.ReadLine());
        }

        public void show()
        {
            Console.WriteLine($"{obl} область, город {city}, Возраст: {age}");
        }*/

        virtual public void init()
        {
            Console.Write("Область? ");
            obl = Console.ReadLine();
            Console.Write("Город? ");
            city = Console.ReadLine();
            Console.Write("Возраст? ");
            age = int.Parse(Console.ReadLine());
        }

        virtual public void show()
        {
            Console.WriteLine($"{obl} область, город {city}, Возраст: {age}");
        }

        public Mesto copy()
        {
            return (Mesto)this.MemberwiseClone();
        }

        public object Clone()
        {
            return new Mesto("CLON" + this.obl, this.city, this.age);
        }

        ~Mesto() { }
    }
}
