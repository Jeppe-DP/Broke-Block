/* Space class for modeling spaces (rooms, caves, ...)
 */
class Space : Node {

  public Space (String name) : base(name)
  {
  }

  public string GetDescription()
  {
    string description = "";
    string location = name;
    if(location == "by")
    {
      description = "Du er borgermester for den afrikanske landsby, Broke-Block. Landsbyens har været hårdt ramt af tørke, hungersnød og naturkatastrofer. Byens huse er utætte og ødelagte, de har brug for en kærlig hånd. Vil du vælge at blive i byen for at snakke med borgerne? Eller vil du vandre ud i vildnis for at finde byggemateriale?";
    }

    if(location == "forfaldenby")
    {
      description = "Du vælger at blive i landsbyen. På vej hen til rådhuset går du forbi en lokal nabolag. Husene har stærkt brug for hjælp, da byggningerne er forfalden. En lokal beboer, Kofi går op til dig med to forskellige ting. Vil du vælge om feje støv og sten væk fra vejene? Eller modtag hammer, søm og træ til at bygge?";
    }

    if(location == "bygmateriale")
    {
      description = "Efter du har examineret husene i landsbyen, indser du hvor vigtigt det er at reparere borgernes huse. Så du samler et mindre hold og kører ud i vildmarken for at finde træ og andre potentielle byggematerialer. Efter i har samlet træ og sten i noget tid, spørger din cheufeur om i skal vende tilbage til landsbyen eller samle mere materiale. Vil du vandre længere væk og samle mere materiale eller vil du vende tilbage til byen?";
    }

    if(location == "landsbyaziz")
    {
      description = "Du har valgt at returnere tilbage til landsbyen. Tilbage ved husene møder du Aziz og Kofi, de hjælper dig med at reparere husene. Efterfølgende kommer du i snak med Aziz, som fortæller stolt at han er sygeplejerske hos det lokale hospital. Aziz fortæller sørgmodigt, at hospitalet har stærkt behov for ressourcer. Ignore Aziz anmodning for hjælp eller hjælpe Jørgen med at skaffe ressourcer til hospitalet.";
    }

    if(location == "hospital")
    {
      description = "Som borgermester, kontakter du andre nærlæggende byer og anstandser for at købe og forhandle om ressourcer til hospitalet. Efter hårde, men successfulde forhandlinger vender du tilbage til hospitalet med medicin og diverse ting. Tag medicin og ressourcer, og sælg det videre eller giv Aziz og hospitalet ressourcerne.";
    }
    else
    {
      description = "tom";
    }
    return description;
  }
  public void Welcome () {
    Console.WriteLine("You are now at "+name);
    Console.WriteLine(GetDescription());
    HashSet<string> exits = edges.Keys.ToHashSet();
    Console.WriteLine("Current exits are:");
    foreach (String exit in exits)
    {
      Console.WriteLine(" - "+exit);
    }
  }

  public void Goodbye () {
  }

  public override Space FollowEdge (string direction)
  {
    return (Space) (base.FollowEdge(direction));
  }
}
