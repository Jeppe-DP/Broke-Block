/* Class that starts the program
 */

using Presentation;
using Domain;

public class Program
{
  public static void Main(string[] args)
  {
    Game game = new Game ();
    Shell shell = new Shell (game);

    shell.Run ();
  }
}
