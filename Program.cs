using System.Drawing;
using System.Security.Principal;


A a = new(10);
MyTime tim = new();

char vvod;
do
{
    Console.Clear();
    Console.WriteLine("1.Task 1\n2.Task 2\n3.Task 3\nESC. Exit");
    vvod = Console.ReadKey().KeyChar;
    switch (vvod)
    {
        case '1':
            {
                Console.Clear();
                char vvod2;
                do
                {
                    Console.Clear();
                    Console.WriteLine("1.Четные\n2.Нечетные\n3.Простые\n4.Фибоначчи\n");
                    vvod2 = Console.ReadKey().KeyChar;
                    switch (vvod2)
                    {
                        case '1':
                            {
                                Console.Clear();
                                A.Operation Op = new A.Operation(a.Print);
                                Op += a.Четные;
                                Op();
                                Console.ReadLine();
                                break;
                            }
                        case '2':
                            {
                                Console.Clear();
                                A.Operation Op = new A.Operation(a.Print);
                                Op += a.Нечетные;
                                Op();
                                Console.ReadLine();
                                break;
                            }
                        case '3':
                            {
                                Console.Clear();
                                A.Operation Op = new A.Operation(a.Print);
                                Op += a.Простые;
                                Op();
                                Console.ReadLine();
                                break;
                            }
                        case '4':
                            {
                                Console.Clear();
                                A.Operation Op = new A.Operation(a.Print);
                                Op += a.Фибоначчи;
                                Op();
                                Console.ReadLine();
                                break;
                            }
                    }
                } while (vvod2 != 27);

                break;
            }
        case '2':
            {
                Console.Clear();
                char vvod2;
                do
                {
                    Console.Clear();
                    Console.WriteLine("1.Время\n2.Дата\n3.Треугольник\n4.Квадрат\n");
                    vvod2 = Console.ReadKey().KeyChar;
                    switch (vvod2)
                    {
                        case '1':
                            {
                                Console.Clear();
                                void Op(Action op) => op();
                                Op(tim.PrintTime);
                                Console.ReadLine();
                                break;
                            }
                        case '2':
                            {
                                Console.Clear();
                                void Op(Action op) => op();
                                Op(tim.PrintDate);
                                Op(tim.PrintDay);
                                Console.ReadLine();
                                break;
                            }
                        case '3':
                            {
                                MyShape shape = new();
                                Console.Clear();
                                Func<double, double, double> f1 = shape.Треугольник;
                                Console.WriteLine("Площать треугольника 5х5 = " + f1(5, 5));
                                Console.ReadLine();
                                break;
                            }
                        case '4':
                            {
                                MyShape shape = new();
                                Console.Clear();
                                Func<double, double> f1 = shape.Квадрат;
                                Console.WriteLine("Площать квадрата (5) = " + f1(5));
                                Console.ReadLine();
                                break;
                            }
                    }
                } while (vvod2 != 27);

                break;
            }
        case '3':
            {
                Console.Clear();

                break;
            }
    }
} while (vvod != 27);


class MyTime
{
    public void PrintTime()
    {
        Console.WriteLine("TimeNow: " + DateTime.Now.ToString("HH:mm:ss"));
    }
    public void PrintDate()
    {
        Console.WriteLine("DateNow: " + DateTime.Now.ToString("dd MMMM yyyy"));
    }
    public void PrintDay()
    {
        Console.WriteLine("Day: " + DateTime.Now.DayOfWeek);
    }
}
class MyShape
{
    public double Треугольник(double x, double y) { return (x * y) / 2; }
    public double Квадрат(double x) { return x * x; }
}

class A
{
    public delegate void Operation();
    int[] mas;
    public A(int size = 5)
    {
        Random rand = new();
        mas = new int[size];
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = rand.Next(1, 26);
        }
    }
    public void Четные()
    {
        Console.WriteLine("Четные");
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] % 2 == 0)
                Console.Write(mas[i] + " ");
        }
        Console.WriteLine();
    }
    public void Нечетные()
    {
        Console.WriteLine("Нечетные");
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] % 2 != 0)
                Console.Write(mas[i] + " ");
        }
        Console.WriteLine();
    }
    public void Простые()
    {
        Console.WriteLine("Простые");
        for (int i = 0; i < mas.Length; i++)
        {
            bool f = true;
            for (int u = 2; u <= mas[i] / 2; u++)
            {
                if (mas[i] % u == 0)
                {
                    f = false;
                    break;
                }
            }
            if (f && mas[i] != 1)
                Console.Write(mas[i] + " ");
        }
        Console.WriteLine();
    }
    public void Фибоначчи()
    {
        Console.WriteLine("Фибоначчи");
        for (int i = 0; i <= mas.Length; i++)
        {
            if (i < 2)
                Console.Write(mas[i] + " ");
            else
                Console.Write((mas[i - 1] + mas[i - 2]) + " ");
        }
        Console.WriteLine();
    }
    public void Print()
    {
        Console.WriteLine("Массив");
        for (int i = 0; i < mas.Length; i++)
        {
            Console.Write(mas[i] + " ");
        }
        Console.WriteLine();
    }

}