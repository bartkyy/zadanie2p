using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        zad2();
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
    }

    static void zad2()
    {
        Console.WriteLine("napisz zdanie");
        string zdanie = Console.ReadLine();
        int ilosc = 0;

        foreach (char c in zdanie)
        {
            if (c == 'b' | c == 'B')
                ilosc++;

        }
        if (ilosc == 1)
        {
            Console.WriteLine($"Zdanie ma {ilosc} litere b");
        }
        else if (ilosc == 0)
        {
            Console.WriteLine("Zdanie nie posiada liter b");
        }
        else if (ilosc <= 4)
        {
            Console.WriteLine($"Zdanie ma {ilosc} litery b");
        }
        else
        {
            Console.WriteLine($"Zdanie ma {ilosc} liter b");
        }
    }
}