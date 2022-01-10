using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab10
{
    class Program: IComparable
    {
        public class sortByObl: IComparer
        {
            int IComparer.Compare(object ob1, Object ob2)
            {
                Mesto m1 = (Mesto)ob1;
                Mesto a1 = (Mesto)ob2;
                return String.Compare(m1.getObl(), a1.getObl());
            }
        }
        static void init(IExecutable exec)
        {
            exec.init();
        }

        static void show(IExecutable exec)
        {
            exec.show();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Создание объектов разных классов:\n");
            Mesto m1 = new Mesto("Московская", "Москва", 25);
            m1.show();
            Adres a1 = new Adres("Пермская", "Пермь", 24, "Танкистов", 15);
            Adres a2 = new Adres("Московская", "Москва", 25, "Солдатова", 4);
            Adres a3 = new Adres("Кировская", "Глазов", 17, "9 Мая", 25);
            Adres a4 = new Adres("Пермь", "Пермь", 12, "Кочегаров", 26);
            Adres a5 = new Adres("Уфимская", "Уфа", 30, "Советская", 151);
            a1.show();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Создание массива объектов и просмотр:\n");
            Adres[] arr = new Adres[5];
            arr[0] = a1; arr[1] = a2; arr[2] = a3; arr[3] = a4; arr[4] = a5;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].show();
            }
            Console.ReadLine();
            Console.Clear();
            int j = 0;
            int count = 0;
            Console.WriteLine("Запрос количества граждан старше:");
            string buf = Console.ReadLine();
            foreach(Adres item in arr)
            {
                if (item is Adres)
                {
                    if (arr[j].getAge() > int.Parse(buf))
                    {
                        count++;
                    }
                }
                j++;
            }
            
            Console.WriteLine($"Граждан старше {int.Parse(buf)}: {count}");
            count = 0;
            j = 0;
            Console.WriteLine("Запрос проживающих в городе?");
            buf = Console.ReadLine();
            foreach (Adres item in arr)
            {
               if (arr[j] as Mesto != null)
                {
                    if (arr[j].getCity() == buf)
                        count++;
                }
                j++;
            }
            j = 0;
            Console.WriteLine($"Проживают в городе {buf}: {count}");
            Console.ReadLine();
            Console.WriteLine("Запрос всех улиц");
            foreach (Adres item in arr)
            {
                if (item is Adres)
                {
                    Console.WriteLine(arr[j].getStreet());
                }
                j++;
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Создание массива разных классов:\n");
            IExecutable[] arr1 = new IExecutable[3];
            for (int i = 0; i < 3; i++)
            {
                if (i % 2 == 0)
                    arr1[i] = new Mesto();
                else
                    arr1[i] = new Adres();
                init(arr1[i]);
            }

            for (int i = 0; i < 3; i++)
            {
                show(arr1[i]);
            }
            Console.WriteLine("\nСортировка массива по области методом Sort класса Array:");
            Console.ReadLine();
            Array.Sort(arr1, new sortByObl());
            for (int i = 0; i < 3; i++)
            {
                show(arr1[i]);
            }
            Console.ReadLine();
            Console.WriteLine("Поверхностное копирование объектов:\n");
            Mesto[] arr2 = new Mesto[2];
            arr2[0] = new Mesto("Пермская", "Краснокамск", 15);
            arr2[1] = new Mesto("Сврдловская", "Первоуральск", 21);
            arr2[0].copy();
            arr2[0].show();
            Console.ReadLine();
            Console.WriteLine("Клонирование объекта: \n");
            arr2[0] = (Mesto)arr2[1].Clone();
            arr2[0].show();
            Console.ReadLine();


        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
