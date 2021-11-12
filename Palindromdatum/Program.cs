using System;

namespace Palindromdatum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in ett datum, börja med de två sissta siffrorna i året, skriv sedan månaden och sist dagen: ");

            string Datum = Console.ReadLine();
            int compare=String.Compare(Datum, ReverseDatum(Datum));

            if (String.Equals(Datum,ReverseDatum(Datum)))
            {
                Console.WriteLine("Datumet " + Datum + " är ett palindrom!");
            }
            else
            {
                Console.WriteLine("Datumet " + Datum + " är inte ett palindrom!");
            }

        }
        public static string ReverseDatum(string Datum)
        {
            char[] array = Datum.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
