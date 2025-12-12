//UserInterface til at display title screen gennem Game.cs
using Domain;

namespace Presentation
{
    public class UIManager
    {

        public void Clear()
        {
            Console.Clear();
        }

    // Print text centered horizontally

        public void WriteCentered (string text){
            int left = (Console.WindowWidth - text.Length) / 2;
            //Adding new spaces to simulate centered.

            Console.WriteLine(new string(' ', Math.Max(left,0)) + text);
        }

        //Print ASCII style title.

        public void WriteTitle (string[] ascii)
        {
            Clear();

            foreach(string line in ascii){

                WriteCentered(line);
            }
            Console.WriteLine();
        }

        //print room descriptions.
        public void PrintDescription (string description)
        {
            Console.ResetColor();
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine(description);
            Console.WriteLine("");//empty
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
        }

        public void PrintChoices(Space room)
        {
            List<string> exitNames = room.GetExitNames();

            Console.WriteLine("Valgmuligheder:");

            if (exitNames.Count >= 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1: " + exitNames[0]);
            }

            if (exitNames.Count >= 2)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("2: " + exitNames[1]);
            }

            Console.ResetColor();
        }
    }
}
