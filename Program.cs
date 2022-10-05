using System;

namespace ColoredLyrics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Play with Fire", 
                                Console.ForegroundColor);
            

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("by Sam Tinnesz\n", 
                                Console.ForegroundColor); 
            
            Console.ForegroundColor = ConsoleColor.Blue; 
            Console.WriteLine(@"Insane, inside
The danger gets me high
Can't help myself
Got secrets I can't tell
I love the smell of gasoline
I light the match to taste the heat
I've always liked to play with fire
Play with fire
I've always liked to play with fire
I ride (I ride) the edge (the edge)
My speed goes in the red
Hot blood (hot blood), these veins (these veins)
My pleasure is their pain
I love to watch the castles burn
These golden ashes turn to dirt (hmm, hmm)
I've always liked to play with fire
Play with fire
Play with fire
Fire, fire
I've always liked to play with fire
Oh, watching as the flames get higher
Oh, I've always liked to play with (mmm)
Rite of passage, classic havoc
Match in the gas tank, ooh, that's wretched
Unstoppable, legendary animal (mmm)
Digital justice, now you're gonna know us
Hail to the king and queen of the ruckus
Yacht Money wired, no denying
I've always liked to play with fire
Play with fire
(I've always liked to play with fire)
Play with fire
(I've always liked to play with fire)
Fire, fire
(I've always liked to play with fire)
Always liked to play with fire
(I've always liked to play with)", 
                Console.ForegroundColor);
            Console.ResetColor();
            Console.ReadKey(); 
        }
    }
}
