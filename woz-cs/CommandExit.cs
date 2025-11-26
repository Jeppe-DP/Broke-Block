/* Command for exiting program
 */

class CommandExit : BaseCommand, ICommand {
  public string Execute (Context context, string command, string[] parameters) {
    context.State == Done;
    return "Spillet er slut";
  }
}
