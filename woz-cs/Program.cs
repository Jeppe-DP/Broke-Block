/* Class that starts the program
 */

public class Program
{
  public static void Main(string[] args)
  {
    Game game = new Game ();
    Shell shell = new Shell (game);

    shell.Run ();
  }
}
