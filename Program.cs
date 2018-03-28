using System;
using CastleGrimtol.Project;

namespace CastleGrimtol.Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            game.Setup();
Console.Clear();
            System.Console.WriteLine($@"
                      /~~~~~~~~~~~~~~~~~~~~~/
                     / Surviving Vanuatu!  /
                    /~~~~~~~~~~~~~~~~~~~~~/ 
            A text-based game...y'know.... for Kids!

            Welcome to Surviving Vanuatu!

In the South Pacific North of New Caledonia Southeast of the Solomon Islands and due west of Fiji lies the resort island of Vanuatu. A typical island resort with many fine hotels belies the sordid and sinister recent history of this Paradise in the Pacific!

In 1953 a raging typhoon capsized a Spanish cargo ship, the SS Cargador de Mar, laden with mostly refugee supply containers.   About 80 miles NW of Vanuatu, the ship sank in only 300 feet of water, coming to rest on top of an uncharted atoll.  The overloaded ship wasted no time in diving for the bottom, coming to rest on her bow and stern over a coral colony chasm.  On striking the atoll, the keel snapped and the ship's cargo in the main hold was discharged into the relatively stormy sea.

Among the cargo, smuggled from Spain destined for a secret black market sale, were a few articles of technology, technology the likes of which had not been invented... yet--or on earth...
            ");
            Console.WriteLine("<N>ext");
           string userInput = Console.ReadLine().ToLower();
           if (userInput[0] == 'n') 
           {
               Console.Clear();
Console.WriteLine($@"
Apparently, the secret is out that these items even exist, and there have been a dozen attempts at salvage since the 50's. None of the diving personnel were ever seen or recovered from these attempts at retrieving the tech gold.

You are a salvage and treasure diver, contracted to a joint Vanuatu-ese and American corporation.  You have been made aware of the technically sophisticated devices that were smuggled aboard Cargador de Mar--made aware of their special capabilities. Among the items is a piece of red cloth about two feet square and feels fluid--like mercury--when you try to hold it, but if you pinch a corner of it--it forms a cylinder with a VERY sharp tip and what appears to be a handle on the other end. There are raised buttons on it as well, but their purpose is unknown.  Slapping the back of the grip returns the cloth to its mercurial consistency.  There were several other items, but their descriptions, use, and purposes are currently a mystery.");


           }
           System.Console.WriteLine("<N>ext");
           userInput = Console.ReadLine();
           if (userInput[0] == 'n')
           {
               Console.Clear();
               System.Console.WriteLine($@"
These items are believed to have fallen into the chasm where the Cargador de Mar is resting over precariously.  No one has dived the chasm yet, but a U.S. survey ship has loaded a camera and sonar module into the chasm, and there are four inter-connected coral caves.  The atoll with the chasm in the middle appears to be a tall, narrow structure, compared to the other atoll islands in the region.

Mission: After you are kitted out, conduct the dive from the survey/research vessel anchored over the position of the SS Cargador de Mar and recover the items. Don't get killed, disappear, or otherwise not be seen again.                
               ");

               // Show Help Screen <N>ext
               // Then display 1st room, inside while loop with list of commands drawn, including quit...TODO work on this.
           }
        }
    }
}
