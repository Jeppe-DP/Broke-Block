/* Command for exiting program
 */

namespace Domain
{

  class CommandExit : BaseCommand, ICommand {

    public CommandExit ()
    {
      description = "Afslut spillet";
    }

    public string Execute (Context context, string command, string[] parameters) {
      Game.State = GameState.Done;
      return "*Spillet er slut.";
    }
  }
}
