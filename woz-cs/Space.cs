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
    if(location == "start")
    {
      description = "Du er borgermester for den afrikanske landsby, Broke-Block. Landsbyens har været hårdt ramt af tørke, hungersnød og naturkatastrofer. Byens huse er utætte og ødelagte, de har brug for en kærlig hånd. Vil du vælge at blive i byen for at snakke med borgerne? Eller vil du vandre ud i vildnis for at finde byggemateriale?";
    }

    else if(location == "by")
    {
      description = "Du vælger at blive i landsbyen. På vej hen til rådhuset går du forbi en lokal nabolag. Husene har stærkt brug for hjælp, da byggningerne er forfalden. En lokal beboer, Kofi går op til dig med to forskellige ting. Vil du vælge om feje støv og sten væk fra vejene? Eller modtag hammer, søm og træ til at bygge?";
    }

    else if(location == "vildnis")
    {
      description = "Efter du har examineret husene i landsbyen, indser du hvor vigtigt det er at reparere borgernes huse. Så du samler et mindre hold og kører ud i vildmarken for at finde træ og andre potentielle byggematerialer. Efter i har samlet træ og sten i noget tid, spørger din cheufeur om i skal vende tilbage til landsbyen eller samle mere materiale. Vil du vandre længere væk og samle mere materiale eller vil du vende tilbage til byen?";
    }

    else if(location == "byg hus")
    {
      description = "Tilbage ved husene møder du Aziz og Kofi, de hjælper dig med at reparere husene.Efterfølgende kommer du i snak med Aziz, so fortæller stolt at han er sygeplejerske hos det lokale hospital. Aziz fortæller sørgmodigt, at hospitalet har stærkt behov for ressourcer. Heldigvis har du fået medicin fra en af nabolandene. Vil du give medicinen et hospitalet, eller beholde medicinen for dig selv indtil videre?";
    }

    else if (location=="feje")
    {
      description = "Du går i gang med at rydde op i byen da det er vigtigt at holde sine omgivelser rene. Da du fejer kraftigt op af en hytte, bryder hele hytten sammen og kvaser dig";
    }

    else if (location == "mere tid i vildnis")
    {
      description = "Da vi allerede er ude i ørkenen, kunne man vel ligeså godt fortsætte med at lede efter mere træ og metal. Efter at have fortsat ud i ørkenen i nogle timer er det tid til at vende om, men vi er nu så langt ude som vi nogensinde har været. Din chauffør prøver forgæves at navigere tilbage til Broke Block. Ingen hører nogensinde fra holdet der samlede materialer i vildnisset igen";
    }

    else if(location == "ressourcer til hospital")
    {
      description = "Som borgermester, kontakter du andre nærliggende byer for at købe og forhandle om ressourcer til hospitalet. Efter hårde, men succesfulde forhandlinger vender du tilbage til hospitalet med medicin og diverse ting. Tag medicin og ressourcer, og sælg det videre eller giv Aziz og hospitalet ressourcerne";
    }

    else if (location == "sælg medicin")
    {
      description = "Du får et godt tilbud fra en nærliggende bande som er interesseret i medicinen du har modtaget. De tilbyder flere penge, end du nogensinde har haft og truer dig endda hvis du ikke sælger det til dem. Du giver ind for fristelsen og sælger medicinen videre.Et par uger efter er der et stort udbrud af ebola i Broke-Block. Det nye hospital har ingen antibiotika og dermed dør 80% af indbyggerne. Inklusiv dig";
    }

    else if (location == "byg skole")
    {
      description = "Du vælger at bygge en skole, da beboerne har brug for en uddannelse. Det er vigtigt, at beboerne får en uddannelse, da det kan hjælpe med at få Broke-Block ud af fattigdom. Dog har beboerne brug for mere mad, da de lever i sult. Der er nogle bønder i Broke-Block, der spørger dig, om du vil hjælpe dem med at forbedre markerne og plante afgrøder. Vil du samarbejde med bønderne eller lade dem styre det selv?";
    }

    else if (location == "byg bar")
    {
      description = "Du valgte at bygge en bar, denne bar har det hele. Menn hvis du gennemtænker det igen, en bar i broken-block..? Er det optimalt? Der er mangel på sanitet, derfor opstår der alkoholforgiftning og alle de stakkels beboere er døde, inklusiv dig";
    }

    else if (location == "samarbejde med bønder")
    {
      description = "Du vælger at samarbejde med de lokale bønder. Du hjælper bønderne med at plante og opsætte afgrøder lokalt. Planterne vokser, og der er nu flere råvarer, der kan bruges til mad til borgerne. De seneste par dage har det regnet uafbrudt. Du står ude på markerne for at hjælpe bønderne, når du lægger mærke til, at den lokale flod er begyndt at stige. Vil du bygge en dæmning for at stoppe oversvømmelserne? Eller vælger du at ignorere floden?";
    }

    else if (location == "forsæt uden samarbejde")
    {
      description = "Rationerne bliver mindre og mindre, da der ikke er nok råvarer. Beboerne af Broke-Block ender med at ikke have nok mad. Nogle af beboerne vælger derfor at forlade Broke-Block, mens de resterende dør af sult.";
    }

    else if (location == "byg dæmninger")
    {
      description = "Du har bygget de mobile dæmninger, og vandet er stoppet med at stige. Landsbyen og markerne bliver ikke oversvømmet. Afgrøderne på marken vokser bedre nu, hvor byen har rigeligt adgang til vand, og der er nu overskud af råvarer. Vil du sælge de overskydende råvarer til nabolande?";
    }

    else if (location == "ignorere floden")
    {
      description = "Du har ignoreret den stigende vandstand i floden, som går over sine bredder. Landsbyen bliver oversvømmet. Huse, bygninger og afgrøder bliver ødelagt.";
    }

    else if (location == "sælge råvarer")
    {
      description = "Andre lande rundt omkring er villige til at handle med Broke-Block. Dog er der problemer med at transportere varer frem og tilbage. Broke-Blocks veje er meget dårlige, og de store lastbiler kan ikke køre på de små grusveje. Vil du bruge penge på at bygge nye veje eller beholde pengene selv?";
    }

    else if (location == "behold råvarer")
    {
      description = "Du vælger at lade være med at samarbejde med andre lande. Broke-Blocks økonomi vokser aldrig og befolkningen vil dermed forblive i fattigdom.";
    }

    else if (location == "forbedre veje")
    {
      description = "Broke-Block har bedre veje nu og lastbilerne kan transportere varer frem og tilbage. Broke-Block sælger mange varer til nabolandene og økonomien vokser. Tillykke!Broke-Block er nu kommet ud af fattigdom. Beboerne er glade og kan nu leve i et velfungerende samfund.";
    }

    else if (location == "behold veje")
    {
      description = "Du vælger at beholde pengene for dig selv. Beboerne i Broke-Block bliver sure, da de stadigvæk lever i fattigdom. Beboerne stopper med at arbejde i protest og Broke-Block forbliver i fattigdom";
    }
    else
    {
      description = "tom";
    }
    return description;
  }
  public void Welcome () {
  //tilføjet mellemrum
    Console.Clear();
    Console.WriteLine();
  //oversat
    Console.WriteLine("Du er nu ved "+name);
    Console.WriteLine();

    Console.WriteLine(GetDescription());
    HashSet<string> exits = edges.Keys.ToHashSet();
    Console.WriteLine();
    Console.WriteLine("Nuværende udgange er:");
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
