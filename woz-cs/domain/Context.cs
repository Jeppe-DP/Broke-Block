/* Context class to hold all context relevant to a session.
 */

public class Context
{
  private Space current;

  public Context (Space node)
  {
    current = node;
  }
  
  public Space GetCurrent()
  {
    return current;
  }
  
  public string Transition (string direction)
  {
    Space from = current;
    current = current.FollowEdge(direction);

    string description = "";

    if (current.GetName().Equals ("start"))
    {
      description = from.GetDescription();
      Game.State = GameState.GameOver;
    }
    else if (current.GetName().Equals ("forbedre veje"))
    {
      description = current.GetDescription();
      Game.State = GameState.Won;
    } else if (from.GetName().Equals("by") && current.GetName().Equals("byg hus"))
    {
      if (!Inventory.Contains ("hammer"))
      {
        description = "Du glemte at samle hammeren op!";
        Game.State = GameState.GameOver;
        current = Game.GetWorld().GetEntry();
      } else
      {
        description = current.Welcome ();
      }
    } else
    {
      description = current.Welcome ();
    }

    return description;
  }
}
