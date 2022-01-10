using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Adres : Mesto, IExecutable
    {
        private string street;
        private int home;

        public Adres() { }

        public Adres(string _obl, string _city, int _age, string _street, int _home) : base(_obl, _city, _age)
        {
            obl = _obl;
            city = _city;
            age = _age;
            street = _street;
            home = _home;
        }

        public string getStreet()
        {
            return street;
        }

        public int getHome()
        {
            return home;
        }

        public void setStreet(string _street)
        {
            street = _street;
        }

        public void setHome(int _home)
        {
            home = _home;
        }

         /*public void show()
        {
            Console.WriteLine($"Проживание: {obl} область, город {city}, {street} улица, дом {home}, Возраст: {age}");
        }

        public void init()
        {
            Console.Write("Область? ");
            obl = Console.ReadLine();
            Console.Write("Город? ");
            city = Console.ReadLine();
            Console.Write("Возраст? ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Улица? ");
            street = Console.ReadLine();
            Console.Write("Номер дома? ");
            home = int.Parse(Console.ReadLine());
        }*/
        override public void show()
        {
            Console.WriteLine($"Проживание: {obl} область, город {city}, {street} улица, дом {home}, Возраст: {age}");
        }

        override public void init()
        {
            Console.Write("Область? ");
            obl = Console.ReadLine();
            Console.Write("Город? ");
            city = Console.ReadLine();
            Console.Write("Возраст? ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Улица? ");
            street = Console.ReadLine();
            Console.Write("Номер дома? ");
            home = int.Parse(Console.ReadLine());
        }


        ~Adres() { }
    }
}
