/* Space class for modeling spaces (rooms, caves, ...)*/

// This class represents a place in your game, like a room or area.
public class Space : Node
{
  // Text for the two choices the player can make
  public string Choice1Text = "";
  public string Choice2Text = "";

  // Where each choice will take the player
  public string Choice1NextRoom = "";
  public string Choice2NextRoom = "";

  // Constructor: called when we create a new space
  public Space(string name) : base(name)
  {
  }

public string GetDescription()
{
  string description = "";
  string location = name;

  switch(location){
    case("start"):
      Choice1Text = "Bliv i byen";
      Choice1NextRoom = "by";                  // ✅ matches startRoom.AddEdge("by", by)
      Choice2Text = "Gå ud i vildnisset";
      Choice2NextRoom = "vildnis";             // ✅ matches startRoom.AddEdge("vildnis", vildnisByggematerialer)
      description = "Du er borgermester for den afrikanske landsby, Broke-Block.\n"
      +"Landsbyens har været hårdt ramt af tørke, hungersnød og naturkatastrofer. \n"
      +"Byens huse er utætte og ødelagte, de har brug for en kærlig hånd.\n"
      +"Vil du vælge at blive i byen for at snakke med borgerne?\n"
      +"Eller vil du vandre ud i vildnis for at finde byggemateriale?";
      break;

    case("by"):
      Choice1Text = "Feje vejene";
      Choice1NextRoom = "feje";               // ✅ matches by.AddEdge("feje", feje)
      Choice2Text = "Byg huse i Broke Block";
      Choice2NextRoom = "byg hus";            // ✅ matches by.AddEdge("byg hus", bygHus)
      description = "Du vælger at blive i landsbyen.\n"
      +"På vej hen til rådhuset går du forbi en lokal nabolag.\n"
      +"Husene har stærkt brug for hjælp, da byggningerne er forfalden.\n"
      +"En lokal beboer, Kofi går op til dig med to forskellige ting.\n"
      +"Vil du vælge om feje støv og sten væk fra vejene? Eller modtag hammer, søm og træ til at bygge?";
      break;

    case("vildnis"):
      Choice1Text = "Udforske vildnis efter mere materiale";
      Choice1NextRoom = "mere tid i vildnis";  // ✅ matches vildnisByggematerialer.AddEdge("mere tid i vildnis", mereTidIVildnis)
      Choice2Text = "Vend tilbage til Broke Block";
      Choice2NextRoom = "byg hus";             // ✅ matches vildnisByggematerialer.AddEdge("byg hus", bygHus)
      description = "Efter du har examineret husene i landsbyen, indser du hvor vigtigt det er at reparere borgernes huse.\n"
      +"Så du samler et mindre hold og kører ud i vildmarken for at finde træ og andre potentielle byggematerialer.\n"
      +"Efter i har samlet træ og sten i noget tid, spørger din chauffør om i skal vende tilbage til landsbyen eller samle mere materiale.\n"
      +"Vil du vandre længere væk og samle mere materiale eller vil du vende tilbage til byen?";
      break;

    case("byg hus"):
      Choice1Text = "Behold medicinen for dig selv";
      Choice1NextRoom = "sælg medicin";           // ✅ matches bygHus.AddEdge("sælg medicin", sælgMedicin)
      Choice2Text = "Giv ressourcerne til hospitalet og de lokale i nød.";
      Choice2NextRoom = "ressourcer til hospital"; // ✅ matches bygHus.AddEdge("ressourcer til hospital", hospital)
      description = "Tilbage ved husene møder du Aziz og Kofi, de hjælper dig med at reparere husene.\n"
      +"Efterfølgende kommer du i snak med Aziz, som fortæller stolt at han er sygeplejerske hos det lokale hospital.\n"
      +"Aziz fortæller sørgmodigt, at hospitalet har stærkt behov for ressourcer.\n"
      +"Heldigvis har du fået medicin fra en af nabolandene.\n"
      +"Vil du give medicinen til hospitalet, eller beholde medicinen for dig selv indtil videre?";
      break;

    case("feje"):
      description = "Du går i gang med at rydde op i byen da det er vigtigt at holde sine omgivelser rene.\n"
      +"Da du fejer kraftigt op af en hytte, bryder hele hytten sammen og kvaser dig";
      break;

    case("mere tid i vildnis"):
      description = "Da vi allerede er ude i ørkenen, kunne man vel ligeså godt fortsætte med at lede efter mere træ og metal.\n"
      +"Efter at have fortsat ud i ørkenen i nogle timer er det tid til at vende om, men vi er nu så langt ude som vi nogensinde har været. \n"
      +"Din chauffør prøver forgæves at navigere tilbage til Broke Block.\n"
      +"Ingen hører nogensinde fra holdet der samlede materialer i vildnisset igen";
      break;

    case("ressourcer til hospital"):
      Choice1Text = "Sælg medicin på det sorte marked";
      Choice1NextRoom = "sælg medicin";          // ✅ matches hospital.AddEdge(...)
      Choice2Text = "Ressourcer til hospital";
      Choice2NextRoom = "byg skole";            // ✅ matches hospital.AddEdge(...)
      description = "Som borgermester, kontakter du andre nærliggende byer for at købe og forhandle om ressourcer til hospitalet.\n"
      +"Efter hårde, men succesfulde forhandlinger vender du tilbage til hospitalet med medicin og diverse ting.\n"
      +"Tag medicin og ressourcer, og sælg det videre eller giv Aziz og hospitalet ressourcerne.";
      break;

    case("sælg medicin"):
      description = "Du får et godt tilbud fra en nærliggende bande som er interesseret i medicinen du har modtaget.\n"
      +"De tilbyder flere penge, end du nogensinde har haft og truer dig endda hvis du ikke sælger det til dem.\n"
      +"Du giver ind for fristelsen og sælger medicinen videre.\n"
      +"Et par uger efter er der et stort udbrud af ebola i Broke-Block.\n"
      +"Det nye hospital har ingen antibiotika og dermed dør 80% af indbyggerne. Inklusiv dig";
      break;

    case("byg skole"):
      Choice1Text = "Samarbejde med de lokale bønder";
      Choice1NextRoom = "samarbejde med bønder";    // ✅ matches skole.AddEdge(...)
      Choice2Text = "Forsæt uden samarbejde med bønderne.";
      Choice2NextRoom = "fortsæt uden samarbejde"; // ✅ matches skole.AddEdge(...)
      description = "Du vælger at bygge en skole, da beboerne har brug for en uddannelse.\n"
      +"Vil du samarbejde med bønderne eller lade dem styre det selv?";
      break;

    case("samarbejde med bønder"):
      Choice1Text = "Byg dæmning";
      Choice1NextRoom = "byg dæmninger";             // ✅ matches samarbejdeMedBønder.AddEdge(...)
      Choice2Text = "Ignorere floden";
      Choice2NextRoom = "ignorere floden";          // ✅ matches samarbejdeMedBønder.AddEdge(...)
      description = "Du vælger at samarbejde med de lokale bønder. Du hjælper bønderne med at plante og opsætte afgrøder lokalt.";
      break;

    case("fortsæt uden samarbejde"):
      description = "Rationerne bliver mindre og mindre, da der ikke er nok råvarer.\n"
      +"Beboerne af Broke-Block ender med at ikke have nok mad.\n"
      +"Nogle af beboerne vælger derfor at forlade Broke-Block, mens de resterende dør af sult.";
      break;

    case("byg dæmninger"):
      Choice1Text = "Behold råvarer";
      Choice1NextRoom = "behold råvarer";            // ✅ matches bygDæmninger.AddEdge(...)
      Choice2Text = "Sælge råvarer";
      Choice2NextRoom = "sælge råvarer";            // ✅ matches bygDæmninger.AddEdge(...)
      description = "Du har bygget de mobile dæmninger, og vandet er stoppet med at stige.";
      break;

    case("ignorere floden"):
      description = "Du har ignoreret den stigende vandstand i floden, som går over sine bredder.\n"
      +"Landsbyen bliver oversvømmet.\n"
      +"Huse, bygninger og afgrøder bliver ødelagt.";
      break;

    case("sælge råvarer"):
      Choice1Text = "Forbedre veje";
      Choice1NextRoom = "forbedre veje";            // ✅ matches sælgeRåvarer.AddEdge(...)
      Choice2Text = "Behold veje";
      Choice2NextRoom = "behold veje";              // ✅ matches sælgeRåvarer.AddEdge(...)
      description = "Andre lande rundt omkring er villige til at handle med Broke-Block.\n"
      +"Vil du bruge penge på at bygge nye veje eller beholde pengene selv?";
      break;

    case("behold råvarer"):
      description = "Du vælger at lade være med at samarbejde med andre lande.\n"
      +"Broke-Blocks økonomi vokser aldrig og befolkningen vil dermed forblive i fattigdom.";
      break;

    case("forbedre veje"):
      description = "🎉🎉 Broke-Block har bedre veje nu og lastbilerne kan transportere varer frem og tilbage.\n"
      +"Beboerne er glade og kan nu leve i et velfungerende samfund.";
      break;

    case("behold veje"):
      description = "Du vælger at beholde pengene for dig selv.\n"
      +"Beboerne i Broke-Block bliver sure, da de stadigvæk lever i fattigdom.";
      break;

    default:
      description = "tom";
      break;
  }

  return description;
}

// This method shows the space, the choices, and the possible exits
public string Welcome()
{
  string result = $"Du er nu ved {name}\n\n";
  result += GetDescription();
  result += $"\n\n1) {Choice1Text}";
  result += $"\n2) {Choice2Text}";

  return result;
}

// Move to another space using the edges dictionary from Node
public override Space FollowEdge(string direction)
{
  // Always cast to Space because edges might be Node
  return (Space)base.FollowEdge(direction);
}
}
