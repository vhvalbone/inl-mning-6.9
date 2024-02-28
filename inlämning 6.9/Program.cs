using System;

public class Program
{
    public static void Main()
    {
        bool fortsatt = true;
        while (fortsatt)
        {
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Är n ett primtal?");
            Console.WriteLine("2. Antalet primtal mindre än n");
            Console.WriteLine("3. Avsluta programmet");

            int val;
            if (!int.TryParse(Console.ReadLine(), out val))
            {
                Console.WriteLine("Felaktigt val. Vänligen ange ett nummer.");
                continue;
            }

            switch (val)
            {
                case 1:
                    Console.WriteLine("Ange ett heltal:");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    if (ArPrimtal(n1))
                    {
                        Console.WriteLine(n1 + " är ett primtal.");
                    }
                    else
                    {
                        Console.WriteLine(n1 + " är inte ett primtal.");
                    }
                    break;

                case 2:
                    Console.WriteLine("Ange ett heltal:");
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    int antalPrimtal = AntalPrimtalMindreAn(n2);
                    Console.WriteLine("Antalet primtal mindre än " + n2 + " är: " + antalPrimtal);
                    break;

                case 3:
                    Console.WriteLine("Avslutar programmet.");
                    fortsatt = false;
                    break;

                default:
                    Console.WriteLine("Felaktigt val. Vänligen välj ett giltigt alternativ.");
                    break;
            }

            Console.WriteLine(); 
        }
    }

    public static bool ArPrimtal(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static int AntalPrimtalMindreAn(int n)
    {
        int antalPrimtal = 0;
        for (int i = 2; i < n; i++)
        {
            if (ArPrimtal(i))
            {
                antalPrimtal++;
            }
        }
        return antalPrimtal;
    }
}

