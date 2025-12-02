/* Context class to hold all context relevant to a session.
 */

public class Context
{
  public Space Current { get; set; }

  public World World { get; } // Referer til "world" så spilleren kan komme over til sit næste choice.


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

  public Context (Space startroom, World world)
  {
    Current = startroom;
    World = world;
  }

  public Space GetCurrent() //tilføjet efter at choice blev tilføjet i space.cs
  {
    return Current;
  }
  
  public string Transition (string direction)
  {
    Space next = Current.FollowEdge(direction);

    if (badChoices.Contains (next.GetName ()))
    {
      string description = next.GetDescription();
      Current = Game.GetWorld().GetEntry();

      Game.State = GameState.GameOver;

      return description;
    }
    else if (next.GetName ().Equals ("forbedre veje"))
    {
      string description = next.GetDescription();
      Current = next;

      Game.State = GameState.Won;

      return description;
    }
    else
    {
      Current = next;
      return Current.Welcome();
    }
  }
}
