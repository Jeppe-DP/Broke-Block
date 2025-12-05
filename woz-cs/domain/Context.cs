/* Context class to hold all context relevant to a session.
 */

namespace Domain
{

  public class Context
  {
    private Space current;
    Description descriptiontxt = new Description();
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
        description = descriptiontxt.GetDescription(current.GetName());
        Game.State = GameState.GameOver;

        current = Game.GetWorld().GetEntry();
      }
      else if (current.GetName().Equals ("forbedre veje"))
      {
        description = descriptiontxt.GetDescription(current.GetName());
        Game.State = GameState.Won;
      }
      else
      {
        description = "*" + current.Welcome ();
      }

      return description;
    }
  }
}
