using System;

namespace the_thing_namer_3000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of thing are we talking about?");
            // Describing the kind of thing we are talking about
            string a = Console.ReadLine(); 
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            /* Adjective describing the thing */
            string b = Console.ReadLine();
            string c = "of Doom";
            string d = "3000";
            Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");

            // Aside from comments, what is one other thing you could do to make
            // this code more understandable
            // Answer: More descriptive naming of variables
        }
    }
}
