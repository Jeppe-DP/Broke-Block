/* Command for transitioning between spaces
 */

class CommandGo : BaseCommand, ICommand {
  public CommandGo () {
    description = "Follow an exit";
  }
  
  public string Execute (Context context, string command, string[] parameters) {
    if (parameters.Length == 0) {
      return "I don't seem to know where that is 🤔";
    }
    context.Transition(parameters[0]);

    GameState newState = context.State;

    if (newState == GameOver || newState == Won)
    {
      return context.GetCurrent().GetDescription();
    }
    else
    {
      return context.GetCurrent().Welcome();
    }
  }
}
