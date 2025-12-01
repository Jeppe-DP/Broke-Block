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

    if (badChoices.Contains(current.GetName()))
    {
      description = current.GetDescription();
      Game.State = GameState.GameOver;

      current = Game.GetWorld().GetEntry();
    }
    else if (current.GetName().Equals ("forbedre veje"))
    {
      description = current.GetDescription();
      Game.State = GameState.Won;
    } else if (from.GetName().Equals("by") && current.GetName().Equals("byg hus"))
    {
      if (!Inventory.Contains (new string[] { "hammer", "træ", "søm" }))
      {
        description = "Du havde ikke de fornødne materialer til at reparere husene!";
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
