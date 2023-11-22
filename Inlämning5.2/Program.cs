using System;
namespace inlämning5.__1
{
    class Progam
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många tal vill du skriva in");
            int gånger = int.Parse(Console.ReadLine());
            int[] tal = new int[gånger];
            Console.WriteLine("Skriv in dina " + gånger + " heltal");
            for (int i = 0; i < gånger; i++)
            {
                tal[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0;i<gånger; i++)
            {
                Console.WriteLine("Tal"+(i+1)+": " + tal[i]);
            }

        }
    }
}
