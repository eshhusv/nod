using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Введите третье число: ");
        int c = int.Parse(Console.ReadLine());

        Thread.CurrentThread.Name = "main";
        GCD();
        Thread mythread = new Thread(GCD);
        mythread.Name = "back";
        mythread.Start();

        void GCD()
        {
            Random r = new Random();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(Thread.CurrentThread.Name + " начал работу");
        https://skysmart.ru/articles/mathematic/naibolshij-obshchij-delitel
            Console.WriteLine(Thread.CurrentThread.Name + " закончил работу");
            sw.Stop();
        }
    }
}