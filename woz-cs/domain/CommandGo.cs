/* Command for transitioning between spaces
 */

namespace Domain
{

  class CommandGo : BaseCommand, ICommand
  {
    public CommandGo ()
    {
      description = "Vælg mulighed";
    }

    public string Execute (Context context, string command, string[] parameters)
    {
      try
      {
        return context.Transition(parameters[0]);
      }
      catch
      {
        return "vælg en korrekt lokation 😊";
      }
    }
  }
}
