/* Command registry
 */

public class Registry {
  Context context;
  ICommand fallback;
  Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>();
  
  public Registry (Context context, ICommand fallback) {
    this.context = context;
    this.fallback = fallback;
  }
  
  public void Register (string name, ICommand command) {
    commands.Add(name, command);
  }
  
  public string Dispatch (string line) {
    string[] elements = line.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries);
    string command = elements[0];
    string[] parameters = GetParameters(elements);

    return (commands.ContainsKey(command) ? GetCommand(command) : fallback).Execute(context, command, parameters);
  }
  
  // ✅ NEW DISPATCH — REQUIRED FOR CHOICES (1 or 2)
  public string Dispatch(string command, string[] parameters)
  {
    if (commands.ContainsKey(command))
      return commands[command].Execute(context, command, parameters);

    return fallback.Execute(context, command, parameters);
  }

  public ICommand GetCommand (string commandName) {
    return commands[commandName];
  }
  
  public string[] GetCommandNames () {
    return commands.Keys.ToArray();
  }
  
  // helpers
  
  private string[] GetParameters (string[] input) {
    string[] output = new string[input.Length-1];
    for (int i=0 ; i<output.Length ; i++) {
      output[i] = input[i+1];
    }
    return output;
  }
}

