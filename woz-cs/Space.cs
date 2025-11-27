/* Space class for modeling spaces (rooms, caves, ...)*/

public class Space : Node {

  public bool HasWon = false;

  public Space (String name) : base(name)
  {
  }

  public string GetDescription()
  {
    string description = "";
    string location = name;

    switch(location){
      case("start"):
        description = "Du er borgermester for den afrikanske landsby, Broke-Block.\n"
        +"Landsbyens har været hårdt ramt af tørke, hungersnød og naturkatastrofer. \n"
        +"Byens huse er utætte og ødelagte, de har brug for en kærlig hånd.\n"
        +"Vil du vælge at blive i byen for at snakke med borgerne?\n"
        +"Eller vil du vandre ud i vildnis for at finde byggemateriale?";
        break;

      case("by"):
        description = "Du vælger at blive i landsbyen.\n"
        +"På vej hen til rådhuset går du forbi en lokal nabolag.\n"
        +"Husene har stærkt brug for hjælp, da byggningerne er forfalden.\n"
        +"En lokal beboer, Kofi går op til dig med to forskellige ting.\n"
        +"Vil du vælge om feje støv og sten væk fra vejene? Eller modtag hammer, søm og træ til at bygge?";
        break;

      case("vildnis"):
        description = "Efter du har examineret husene i landsbyen, indser du hvor vigtigt det er at reparere borgernes huse.\n"
        +"Så du samler et mindre hold og kører ud i vildmarken for at finde træ og andre potentielle byggematerialer.\n"
        +"Efter i har samlet træ og sten i noget tid, spørger din cheufeur om i skal vende tilbage til landsbyen eller samle mere materiale.\n"
        +"Vil du vandre længere væk og samle mere materiale eller vil du vende tilbage til byen?";
        break;

      case("byg hus"):
        description = "Tilbage ved husene møder du Aziz og Kofi, de hjælper dig med at reparere husene.\n"
        +"Efterfølgende kommer du i snak med Aziz, som fortæller stolt at han er sygeplejerske hos det lokale hospital.\n"
        +"Aziz fortæller sørgmodigt, at hospitalet har stærkt behov for ressourcer.\n"
        +"Heldigvis har du fået medicin fra en af nabolandene.\n "
        +"Vil du give medicinen et hospitalet, eller beholde medicinen for dig selv indtil videre?";
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
        description = "Som borgermester, kontakter du andre nærliggende byer for at købe og forhandle om ressourcer til hospitalet.\n"
        +"Efter hårde, men succesfulde forhandlinger vender du tilbage til hospitalet med medicin og diverse ting.\n"
        +"Tag medicin og ressourcer, og sælg det videre eller giv Aziz og hospitalet ressourcerne\n"
        +"\n"
        +"🏥 FACTA: SUNDHED = MASSER AF JOBS & EN SUPERPRODUKTIV BEFOLKNING\n"
        +"💼 Sundhed = Jobmaskine. Universel sundhedsdækning skaber en hel industri af jobs: Læger, sygeplejersker, portører, rengøring, admin - det er et kæmpe job-sikkerhedsnet!\n"
        +"💪 Rask befolkning = Mere værdiskabelse. Når folk ikke er syge, møder de op på arbejde, er mere effektive og bidrage mere til samfundet. Det er den ultimative win-win.\n"
        +"Kort sagt: Investering i sundhed er en dobbelt gevinst: Den skaber jobs NU og sikrer en produktiv befolkning som kan skabe endnu flere jobs i fremtiden";
        break;

      case("sælg medicin"):
        description = "Du får et godt tilbud fra en nærliggende bande som er interesseret i medicinen du har modtaget.\n"
        +"De tilbyder flere penge, end du nogensinde har haft og truer dig endda hvis du ikke sælger det til dem.\n"
        +"Du giver ind for fristelsen og sælger medicinen videre.\n"
        +"Et par uger efter er der et stort udbrud af ebola i Broke-Block.\n"
        +"Det nye hospital har ingen antibiotika og dermed dør 80% af indbyggerne. Inklusiv dig";
        break;

      case("byg skole"):
        description = "Du vælger at bygge en skole, da beboerne har brug for en uddannelse. \n"
        +"Det er vigtigt, at beboerne får en uddannelse, da det kan hjælpe med at få Broke-Block ud af fattigdom.\n"
        +"Dog har beboerne brug for mere mad, da de lever i sult. \n"
        +"Der er nogle bønder i Broke-Block, der spørger dig, om du vil hjælpe dem med at forbedre markerne og plante afgrøder.\n"
        +"Vil du samarbejde med bønderne eller lade dem styre det selv?\n"
        +"\n"
        +"📚 FACTA: UDDANNELSE = DIN PERSONLIGE PENGEMASKINE\n"
        +"🎓 Flere år på skolebænken = flere penge i lommen. Global statistik viser det klart og tydeligt: For hvert ekstra år du uddanner dig, stiger din timeløn med hele 9%. Det er ren matematik!\n"
        +"💼 Uddannelse + Arbejde = Fattigdom på flugt. Sammensat skaber de den ultimative one-two punch mod fattigdom. Det er de vigtigste våben i kampen.\n"
        +"Kort sagt: At investere i uddannelse er som at opgradere sin karakter i et spil – jo højere level, jo bedre loot (løn) får du. Det er den sikreste vej til en federe indtægt.";
        break;

      case("byg bar"):
        description = "Du valgte at bygge en bar, denne bar har det hele.\n"
        +"Menn hvis du gennemtænker det igen, en bar i broken-block..? Er det optimalt?\n"
        +"Der er mangel på sanitet, derfor opstår der alkoholforgiftning og alle de stakkels beboere er døde, inklusiv dig";
        break;

      case("samarbejde med bønder"):
        description = "Du vælger at samarbejde med de lokale bønder. Du hjælper bønderne med at plante og opsætte afgrøder lokalt.\n"
        +"Planterne vokser, og der er nu flere råvarer, der kan bruges til mad til borgerne.\n"
        +"De seneste par dage har det regnet uafbrudt.\n"
        +"Du står ude på markerne for at hjælpe bønderne, når du lægger mærke til, at den lokale flod er begyndt at stige.\n"
        +"Vil du bygge en dæmning for at stoppe oversvømmelserne? Eller vælger du at ignorere floden?\n"
        //tilføjet fakta boks til quizzen
        +"\n"
        +"💼 FACTA: ARBEJDE = LANDETS SUPERHELTE-KRÆFTER.\n"
        +"🚀 Arbejde får økonomien til at EKSPLODERE (på en god måde)! Når folk bliver bedre til deres jobs, bliver hele landet rigere. Det er som et hold der leveller op - alle bliver stærkere.\n"
        +"⚡ Effektivitet = den hemmelige sauce! Jo bedre vi bliver, jo flere fede jobs opstår. Og de kedelige, uproduktive jobs? Dem sparker vi ud - de er ikke worth it længere.\n"
        +"Kort sagt: Arbejde er ikke bare et job - det er landet træningsprogram. Bedre arbejde = stærkere økonomi = alle vinder.";
        break;

      case("forsæt uden samarbejde"):
        description = "Rationerne bliver mindre og mindre, da der ikke er nok råvarer.\n"
        +"Beboerne af Broke-Block ender med at ikke have nok mad.\n"
        +"Nogle af beboerne vælger derfor at forlade Broke-Block, mens de resterende dør af sult.";
        break;

      case("byg dæmninger"):
        description = "Du har bygget de mobile dæmninger, og vandet er stoppet med at stige.\n"
        +"Landsbyen og markerne bliver ikke oversvømmet.\n"
        +"Afgrøderne på marken vokser bedre nu, hvor byen har rigeligt adgang til vand, og der er nu overskud af råvarer.\n"
        +"Vil du sælge de overskydende råvarer til nabolande?\n"
        +"\n"
        +"🌍 FACTA: KLIMAÆNDRINGER = DEN STØRSTE PARTYCRASHER I VERDENSHISTORIEN\n"
        +"💸 Fattigdom? Sværere nu. Klimaet gør det SVÆRERE at blive rig. Det er som at prøve at lave en gruppeopgave, hvor opgaven hele tiden bliver slettet af en mystisk kraft lige inden afleveringen.\n"
        +"🏙️ Byer skal være katastrofe-klare. Fremtiden handler ikke om at bygge de flotteste byer, men om at bygge de SEJESTE byer - dem der kan tåle en oversvømmelse eller en storm uden at gå i stykker. Tænk på det som at lave en systembackup af hele samfundet.\n"
        +"Kort sagt: Hvis din by kan overleve en apokalypse, kan den også hjælpe med at bekæmpe fattigdom. Det handler om at være smartere end vejret.";

        break;

      case("ignorere floden"):
        description = "Du har ignoreret den stigende vandstand i floden, som går over sine bredder.\n"
        +"Landsbyen bliver oversvømmet.\n"
        +"Huse, bygninger og afgrøder bliver ødelagt.";
        break;

      case("sælge råvarer"):
        description = "Andre lande rundt omkring er villige til at handle med Broke-Block.\n"
        +"Dog er der problemer med at transportere varer frem og tilbage.\n"
        +"Broke-Blocks veje er meget dårlige, og de store lastbiler kan ikke køre på de små grusveje.\n"
        +"Vil du bruge penge på at bygge nye veje eller beholde pengene selv?\n"
        +"\n"
        +"💸 FACTA: SÅDAN BLIVER HANDEL TIL FLERE PENGE I LOMMERNE\n"
        +"🛒 Handel = Flere Jobs & Færre Fattige: Når lande handler, skal der laves flere ting. Flere ting = flere jobs. Flere jobs = færre som skal tigge om at låne en tier.\n"
        +"📈 Det Giver Vækst (og Mere Vækst): Hvert år kan handel booste landets økonomi med 1-1,5%. Det lyder måske lidt, men...\n"
        +"💰 Resultatet Efter 10 År? Ka-ching! Et helt årti med den her superkraft betyder, at den gennemsnitlige persons indkomst er steget med 10-20%. Så er der pludselig råd til både kantinen og en streamingtjeneste.\n"
        +"kort sagt: Mere handel = mere vækst = flere penge til dig. Det er ren win-win.";
        break;

      case("behold råvarer"):
        description = "Du vælger at lade være med at samarbejde med andre lande.\n"
        +"Broke-Blocks økonomi vokser aldrig og befolkningen vil dermed forblive i fattigdom.";
        break;

      case("forbedre veje"):
        description = "🎉🎉 Broke-Block har bedre veje nu og lastbilerne kan transportere varer frem og tilbage.\n"
        +"Broke-Block sælger mange varer til nabolandene og økonomien vokser.\n"
        +"Tillykke!Broke-Block er nu kommet ud af fattigdom.\n"
        +"Beboerne er glade og kan nu leve i et velfungerende samfund.\n"
        // FAKTA DEL (Den del, der muligvis forsvandt)
        + "\n" // Tilføjer en tom linje for at adskille vindertekst og fakta
        + "💰 Handel = Penge: God infrastruktur (veje, havne, internet) er din gratisbillet til at handle memes, ressourcepakker og alt andet med hele verden. Mere handel = færre fattigdomme.\n"
        + "🚗 Pendling = Job: En god vej betyder, at du faktisk kan komme til dit drømme-job i den der store, fjerne by, i stedet for at sidde fast i ingenting. Det kalder vi en karriere-vej (undskyld).\n"
        + "Kort sagt: Ingen gode veje = ingen penge. Det er simpelt matematik, folkens";
        HasWon = true; // markerer "win"
        break;

      case("behold veje"):
        description = "Du vælger at beholde pengene for dig selv.\n"
        +"Beboerne i Broke-Block bliver sure, da de stadigvæk lever i fattigdom.\n"
        +"Beboerne stopper med at arbejde i protest og Broke-Block forbliver i fattigdom";
        break;

      default:
      description = "tom";
      break;
    }
   return description;
  }

  public void Welcome () {
    Console.Clear();
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
 //followedge så spillet ikke slutter efter et dårlig valg
    Space next = (Space)base.FollowEdge(direction);
    //liste over de rum som afslutter spillet
    string[] badChocies  = {
      "mere tid i vildnis",
      "feje",
      "sælg medicin",
      "byg bar",
      "ignorere floden",
      "forsæt uden samarbejde",
      "behold råvarer",
      "behold veje"
    };

    if (badChocies.Contains(next.name))
    {
      GameOverScreen gameOver = new GameOverScreen();
      gameOver.Show();

      return GameLauncher.GetWorld().GetEntry();//sendes tilbage til start
    }
    return next;

  //  return (Space) (base.FollowEdge(direction));
  }

}
