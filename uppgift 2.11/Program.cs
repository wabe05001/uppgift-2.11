using System;


namespace Uppgift_2_11_
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("hur långt hoppade alma?");
            string längdText = Console.ReadLine();
            double längd = double.Parse(längdText);
            double skillnad = 4.45 - längd;

            Console.WriteLine("Elin hoppade" + 4.45 + "meterhögre");


        }

    }
    


    

}