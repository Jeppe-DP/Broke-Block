/* Context class to hold all context relevant to a session.
 */

public class Context
{
  private Space current;

  //liste over de rum som afslutter spillet
  private string[] badChoices  = {
      "mere tid i vildnis",
      "feje",
      "sælg medicin",
      "byg bar",
      "ignorere floden",
      "forsæt uden samarbejde",
      "behold råvarer",
      "behold veje"
    };

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

    if (!current.CheckItems())
    {
      description = current.Message;
      current = from;
    }
    else if (badChoices.Contains(current.GetName()))
    {
      description = current.GetDescription();
      Game.State = GameState.GameOver;

      current = Game.GetWorld().GetEntry();
    }
    else if (current.GetName().Equals ("forbedre veje"))
    {
      description = current.GetDescription();
      Game.State = GameState.Won;
    }
    else
    {
      description = "*" + current.Welcome ();
    }

    return description;
  }
}
