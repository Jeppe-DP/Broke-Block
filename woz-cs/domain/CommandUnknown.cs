/* Fallback for when a command is not implemented
 */

namespace Domain
{

  class CommandUnknown : BaseCommand, ICommand {
    public string Execute (Context context, string command, string[] parameters) {
      return "Jeg forstår ikke" + command + "' 😕";
    }
  }
}
