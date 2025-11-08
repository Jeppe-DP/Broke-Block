/* Command for transitioning between spaces
 */

class CommandGo : BaseCommand, ICommand {
  public CommandGo () {
    description = "Follow an exit";
  }
  
  public void Execute (Context context, string command, string[] parameters) {
    if (parameters.Length == 0) {
      Console.WriteLine("I don't seem to know where that is 🤔");
      return;
    }
    string destination = string.Join(" ", parameters);
    context.Transition(parameters[0]);
  }
}
