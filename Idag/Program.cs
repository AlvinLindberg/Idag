using System;
using System.Collections.Generic;

namespace Idag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> elever = new Dictionary<string, int>();

            //bool kor = true;

            //while (kor)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("===== STUDENTBETYG =====");
            //    Console.WriteLine("1. Lägg till elev och betyg");
            //    Console.WriteLine("2. Uppdatera befintligt betyg");
            //    Console.WriteLine("3. Visa alla elever och betyg");
            //    Console.WriteLine("4. Visa medelbetyg");
            //    Console.WriteLine("5. Avsluta");
            //    Console.Write("Välj ett alternativ: ");

            //    int val = Convert.ToInt32(Console.ReadLine());

            //    if (val == 1)
            //    {
            //        Console.Write("Skriv elevens namn: ");
            //        string namn = Console.ReadLine();

            //        if (elever.ContainsKey(namn))
            //        {
            //            Console.WriteLine("Eleven finns redan.");
            //        }
            //        else
            //        {
            //            Console.Write("Skriv elevens betyg: ");
            //            int betyg = Convert.ToInt32(Console.ReadLine());

            //            elever.Add(namn, betyg);

            //            Console.WriteLine("Eleven har lagts till!");
            //        }
            //    }
            //    else if (val == 2)
            //    {
            //        Console.Write("Skriv elevens namn: ");
            //        string namn = Console.ReadLine();

            //        if (elever.ContainsKey(namn))
            //        {
            //            Console.Write("Skriv det nya betyget: ");
            //            int betyg = Convert.ToInt32(Console.ReadLine());

            //            elever[namn] = betyg;

            //            Console.WriteLine("Betyget har uppdaterats!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Eleven finns inte.");
            //        }
            //    }
            //    else if (val == 3)
            //    {
            //        if (elever.Count == 0)
            //        {
            //            Console.WriteLine("Det finns inga elever.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("===== ALLA ELEVER =====");

            //            foreach (var elev in elever)
            //            {
            //                Console.WriteLine(elev.Key + " - " + elev.Value);
            //            }
            //        }
            //    }
            //    else if (val == 4)
            //    {
            //        if (elever.Count == 0)
            //        {
            //            Console.WriteLine("Det finns inga betyg att räkna på.");
            //        }
            //        else
            //        {
            //            int summa = 0;

            //            foreach (var elev in elever)
            //            {
            //                summa += elev.Value;
            //            }

            //            double medel = (double)summa / elever.Count;

            //            Console.WriteLine("Medelbetyget är: " + medel);
            //        }
            //    }
            //    else if (val == 5)
            //    {
            //        kor = false;
            //        Console.WriteLine("Programmet avslutas.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ogiltigt val.");
            //    }
            //}

            // The following commented code was preserved from the original file:
            ////
            //// Console.WriteLine("Hur många tal vill du lagra ?");
            ////
            //// int antal= Convert.ToInt32(Console.ReadLine());
            ////
            //// int[] tal = new int[antal];
            ////
            //// for (int i = 0; i < tal.Length; i++)
            //// {
            ////     Console.WriteLine("Skriv ett tal:");
            ////     tal[i] = Convert.ToInt32(Console.ReadLine());
            //// }
            ////
            //// int summa = 0;
            ////
            //// for (int i = 0; i < tal.Length; i++)
            //// {
            ////     Console.WriteLine(tal[i]);
            ////     summa += tal[i];
            //// }
            ////
            //// Console.WriteLine("Summan är: " + summa);
            ////
            //// double medelvärde = (double)summa / tal.Length;
            ////
            //// Console.WriteLine("Medelvärdet är: " + medelvärde);
        }
    }
}



