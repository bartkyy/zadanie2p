class Program
{
    static void Main(string[] args)
    {
        zad1();
    }

    static void zad1()
    {
        Console.WriteLine("hello, world");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        int j = 0;
        while (j < 10)
        {
            Console.WriteLine(j);
            j++;
        }


        Console.WriteLine("napisz zdanie");
        string zdanie = Console.ReadLine();
        int ilosc = 0;
        foreach (char c in zdanie)
        {
            ilosc++;
        }
        Console.WriteLine($"Zdania ma {ilosc} liter");
    }
}