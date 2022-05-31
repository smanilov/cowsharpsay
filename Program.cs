using System;

namespace cowsay
{
    class Program
    {
        static void Main(string[] args)
        {
            string say = Console.ReadLine();

            string line1;
            string line2;
            if (say.Length <= 38)
            {
                line1 = say.PadRight(8);
                line2 = "".PadRight(38);
            } else
            {
                line1 = say.Substring(0, 38);
                line2 = say.Substring(38);
                line2 = line2.PadRight(38);
            }

            Console.WriteLine(" ________________________________________");
            Console.WriteLine("/ " + line1 + " \\");
            Console.WriteLine("\\ " + line2 + " /");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("        \\   ^__^");
            Console.WriteLine("         \\  (oo)\\_______");
            Console.WriteLine("            (__)\\       )\\/\\");
            Console.WriteLine("                ||----w |");
            Console.WriteLine("                ||     ||");
        }
    }
}