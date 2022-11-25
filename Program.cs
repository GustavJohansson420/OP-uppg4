class Program
{
    static void Main()
    {
        Console.WriteLine("Skriv hur många elever som ska ha styrka 1:");
        int s1elever = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Skriv hur många elever som ska ha styrka 2:");
        int s2elever = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Skriv hur många elever som ska ha styrka 3:");
        int s3elever = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Skriv hur många elever som ska ha styrka 4:");
        int s4elever = Convert.ToInt32(Console.ReadLine());
        int s1ep = s1elever*1;
        int s2ep = s1elever*2;
        int s3ep = s1elever*3;
        int s4ep = s1elever*4;
        Console.WriteLine("");
        Console.WriteLine("Ena lagets uppbyggnad bör se ut såhär:");


        if (s1elever % 2 == 0 && s2elever % 2 == 0 && s3elever % 2 == 0 && s4elever % 2 == 0)
        {
            Console.Write(s1elever/2);
            Console.Write(s2elever/2);
            Console.Write(s3elever/2);
            Console.WriteLine(s4elever/2);
        }
        else if (s1ep == s4ep && s2ep == s3ep)
        {
            Console.Write(s1elever);
            Console.Write(s2elever);
            Console.Write("0");
            Console.WriteLine("0");
            Console.WriteLine("eller");
            Console.Write("0");
            Console.Write("0");
            Console.Write(s3elever);
            Console.WriteLine(s4elever);
            Console.WriteLine("eller");
            Console.Write(s1elever);
            Console.Write("0");
            Console.Write(s3elever);
            Console.WriteLine("0");
            Console.WriteLine("eller");
            Console.Write("0");
            Console.Write(s2elever);
            Console.Write("0");
            Console.WriteLine(s4elever);
        }
        else if (s1ep == s3ep && s2ep == s4ep)
        {
            Console.Write(s1elever);
            Console.Write(s2elever);
            Console.Write("0");
            Console.WriteLine("0");
            Console.WriteLine("eller");
            Console.Write("0");
            Console.Write("0");
            Console.Write(s3elever);
            Console.WriteLine(s4elever);
            Console.WriteLine("eller");
            Console.Write(s1elever);
            Console.Write("0");
            Console.Write("0");
            Console.WriteLine(s4elever);
            Console.WriteLine("eller");
            Console.Write("0");
            Console.Write(s2elever);
            Console.Write(s3elever);
            Console.WriteLine("0");
        }
        else if (s1ep == s2ep && s3ep == s4ep)
        {
            Console.Write(s1elever);
            Console.Write("0");
            Console.Write(s3elever);
            Console.WriteLine("0");
            Console.WriteLine("eller");
            Console.Write(s1elever);
            Console.Write("0");
            Console.Write("0");
            Console.WriteLine(s4elever);
            Console.WriteLine("eller");
            Console.Write(s1elever);
            Console.Write("0");
            Console.Write(s3elever);
            Console.WriteLine("0");
            Console.WriteLine("eller");
            Console.Write("0");
            Console.Write(s2elever);
            Console.Write(s3elever);
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine("Jag vet inte vad jag har skapat lol");
        }

    }
}
