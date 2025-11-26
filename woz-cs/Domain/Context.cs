/* Context class to hold all context relevant to a session.
 */

public class Context
{
  public GameState State { get; set; }
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
    State = GameState.Running;
  }
  
  public Space GetCurrent()
  {
    return current;
  }
  
  public string Transition (string direction)
  {
    Space next = current.FollowEdge(direction);

    if (badChoices.Contains (next.GetName ()))
    {
      string description = next.GetDescription();
      current = Game.GetWorld().GetEntry();

      State = GameState.GameOver;

      return description;
    }
    else if (next.GetName ().Equals ("forbedre veje"))
    {
      string description = next.GetDescription();
      current = next;

      State = GameState.Won;

      return description;
    }
    else
    {
      current = next;
      return current.Welcome();
    }
  }
}
