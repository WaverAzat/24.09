using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework
{
    public enum weekend
    {
        monday = 1,
        tuesday = 2,
        wednesday = 3,
        thursday = 4,
        friday = 5,
        saturday = 6,
        sunday = 7
    }
    class Program
    {
        static int[] Bubble(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.Вася и форточка");
            Console.WriteLine("Введите размер форточки a(длину) в см");
            string a = Console.ReadLine();
            int a1 = Convert.ToInt32(a);
            Console.WriteLine("Введите размер форточки b(ширину) в см");
            string b = Console.ReadLine();
            int b1 = Convert.ToInt32(b);
            Console.WriteLine("Введите диаметр головы в см");
            string d = Console.ReadLine();
            int d1 = Convert.ToInt32(d);
            int gipotinuza = Convert.ToInt32(Math.Sqrt((a1 * a1) + (b1 * b1)));
            int d2 = d1 + 2;
            if (gipotinuza >= d2)
            {
                Console.WriteLine("Вася сможет высунуть голову");
            }
            else
            {
                Console.WriteLine("Вася не сможет высунуть голову");
            }
            Console.ReadKey();
            Console.WriteLine("Задание 2.Таблица умножения");
            Console.WriteLine("Введите число 1<= n <=9");
            string n = Console.ReadLine();
            int n1 = Convert.ToInt32(n);
            int tab1 = n1 * 1;
            int tab2 = n1 * 2;
            int tab3 = n1 * 3;
            int tab4 = n1 * 4;
            int tab5 = n1 * 5;
            int tab6 = n1 * 6;
            int tab7 = n1 * 7;
            int tab8 = n1 * 8;
            int tab9 = n1 * 9;
            int tab10 = n1 * 10;
            Console.WriteLine($"{tab1}\n{tab2}\n{tab3}\n{tab4}\n{tab5}\n{tab6}\n{tab7}\n{tab8}\n{tab9}\n{tab10}");
            Console.ReadKey();
            Console.WriteLine("Задание 3.Прием числа и вывод");
            Console.WriteLine("Введите число");
            string ch = Console.ReadLine();
            int ch1 = Convert.ToInt32(ch);
            if (ch1 % 15 == 0)
            {
                Console.WriteLine("БэнгБум");
            }
            else if (ch1 % 3 == 0)
            {
                Console.WriteLine("Бэнг");
            }
            else if (ch1 % 5 == 0)
            {
                Console.WriteLine("Бум");
            }
            else
            {
                Console.WriteLine("Мимо");
            }
            Console.ReadKey();
            Console.WriteLine("Задание 4.Проверка строки на регистр");
            Console.WriteLine("Введите выражение");
            string stroka = Console.ReadLine();
            stroka = stroka.Replace(" ", string.Empty);//ищет в строке пробел и удаляет ее через метод Empty
            int count = 0;
            foreach (char l in stroka)//перебор в l из stroka
            {
                if (char.IsUpper(l))// если прописное
                {
                    count += 1;
                }
            }
            string stroka1 = count == stroka.Length ? "True" : "False";// ? тернарные операции (+:-)
            Console.WriteLine(stroka1);
            Console.ReadKey();
            Console.WriteLine("Задание 5.Овца");
            Console.WriteLine("Введите кол-во");
            int counttt = int.Parse(Console.ReadLine());
            for (int sheep = 1; sheep <= counttt; sheep += 1)//([инициализация счетчика]; [условие цикла]; [изменение счётчика])
            {
                Console.Write(sheep + " овца ... ");
            }
            Console.ReadKey();
            Console.WriteLine("Задание 8.Сумка");
            int countigr = 0;
            string[] bag = { "helicopter", "carwow", "barbie doll", "vinks","hello kitty"};
            foreach (string toy in bag)// из bag перебираем в toy
            {
                if (toy == "barbie doll" || toy == "hello kitty")// || или
                {
                    countigr += 1;
                }
            }
            Console.WriteLine( " кол-во кукол в сумке"  + countigr);
            Console.ReadKey();
            Console.WriteLine("Задание 9.Дни недели");
            Console.WriteLine("Введите номер дня в неделе");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine((weekend)day);
            Console.ReadKey();
            Console.WriteLine("Задание 10.Сортировка массива");
            Console.WriteLine("Введите числа через пробел");
            int[] arr = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            Console.WriteLine("{0}", string.Join("", Bubble(arr)));
            Console.ReadKey();
            Console.WriteLine("Задание 11.Правильная последовательность");
            Console.WriteLine("Введите 10 рандомных чисел");
            byte[] massiv = Console.ReadLine().Split(' ').Select(s => byte.Parse(s)).ToArray();
            for (int i = 1; i < massiv.Length; i++)
            {
                if (massiv[i] <= massiv[i - 1])
                {
                    Console.WriteLine(massiv[i]);
                    break;
                }
            }
            Console.ReadKey();
















        }

    }
}
