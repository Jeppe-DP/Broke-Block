//class for the quiz in the game
using Domain;

namespace Presentation
{
    public class Quiz
    {
        private List<Question> questions = new List<Question>();

        public Quiz()
        {
            questions.Add(new Question(
                "Hvorfor er arbejde vigtigt for afskaffelse af fattigdom?",
                new string[]{
                    "Ved at øge den økonomiske vækst og effektivitet hvilket skaber flere produktive jobs og fjerner uproduktive arbejde.",
                    "Ved at alle får lov at arbejde præcis 2 timer om ugen i fællesskabshaven",
                    "Ved at omfordele rigdom gennem progressiv beskatning og investere i velfærdstilbud.",
                    "Fordi hvis man bare manifesterer nok så falder pengene ned fra himlen bro"
                },
                1 // svarmulighed 1 er korrekt
            ));

            questions.Add(new Question(
                "Hvordan kan uddannelse hjælpe med afskaffelse af fattigdom?",
                new string[]{
                    "Ved at alle skal læse 50 bøger om ugen i fællesskabsbiblioteket.",
                    "Ved at forhøje lønnen markant for hvert ekstra uddannelsesår hvilket direkte øger folks indkomst.",
                    "Ved at skabe mere lighed gennem bedre adgang til uddannelse for alle samfundslag.",
                    "Fordi hvis man bare snakker med en vis sten får man alle svarene til eksamen lowkey."
                },
                3 // svarmulighed 3 er korrekt
            ));

            questions.Add(new Question(
                "Hvordan kan sundhedsdækning bekæmpe fattigdom?",
                new string[]{
                    "Fordi hvis man bare spiser en magisk pille bliver man rig og uovervindelig, on god.",
                    "Ved at alle får en gratis energidrik og en bandage om ugen.",
                    "Ved at reducere ulighed i adgangen til livsvigtig lægehjælp.",
                    "Ved at sikre en rask befolkning der kan arbejde og bidrage mere produktivt til samfundet"
                },
                4 // svarmulighed 4 er korrekt
            ));

            questions.Add(new Question(
                "Hvilken strategisk handling er essentiel for at beskytte befolkningen og forhindre naturkatastrofer i at forværre den økonomiske situation?",
                new string[]{
                    "At byerne skal være i stand til at klare naturkatastrofer for at beskytte mod klimaændringernes indvirkning",
                    "At alle bygninger skal males i lyse glade farver for at forbedre humøret.",
                    "Fordi hvis man bare bygger byen i form af en stjerne bliver den immun mod oversvømmelser, fr.",
                    "At prioritere økonomisk vækst gennem industrialisering uden miljømæssige hensyn."
                },
                1
            ));

            questions.Add(new Question(
                "Hvor mange procent stiger et lands indkomst typisk med efter et årti, som et resultat af øget global handel?",
                new string[]{
                    "50 til 75 procent.",
                    "100 procent, fordi al handel fører til uendelig rigdom for alle, og vi skal bare printe flere penge.",
                    "10 til 20 procent.",
                    "2 til 5 procent"
                },
                3
            ));

            questions.Add(new Question(
                "Ifølge simpel matematik, folkens, hvad er infrastrukturs to største magter til at bekæmpe fattigdom?",
                new string[]{
                    "Infrastruktur får alle priser på fødevarer til at falde til nul da det eliminerer alle transportomkostninger.",
                    "Den primære effekt er at reducere antallet af biler i byerne da det motiverer folk til at gå og dermed forbedrer folkesundheden.",
                    "Den gør handel med nabolande og globale markeder mulig samtidig med at den styrker transporten så befolkningen lettere kan nå arbejdspladser i større byer.",
                    "Den sikrer at bønder kan sælge deres råvarer direkte til rumvæsener via højhastigheds-veje hvilket garanterer astronomisk profit."
                },
                3
            ));
        }

        public void Start()
        {
            Console.Clear();
            Console.WriteLine("Nu kommer den endelige quiz!");
            int score = 0;

            foreach (Question q in questions)
            {
                Console.WriteLine("\n" + q.Text);

                // Vis svarmuligheder
                for (int i = 0; i < q.Answers.Length; i++)
                {
                    Console.WriteLine("{0}) {1}", i + 1, q.Answers[i]);
                }

                // køre indtil brugeren indtaster det rigtig tal
                int input;
                while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > q.Answers.Length)
                {
                    Console.Write("Ugyldigt svar - prøv med tal fra 1-4: ");
                }

                // Tjek korrekt svar
                if (input == q.CorrectAnswer)
                {
                    Console.WriteLine("✔ Korrekt!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine("❌ Forkert!\n");
                }
            }

            // Afslut quiz
            Console.WriteLine($"🎯 DIN SCORE: Du fik {score} ud af {questions.Count} rigtige!");
            Console.WriteLine("Tak for at spille! Tryk ENTER for at afslutte.");
            Console.ReadLine();
        }
    }
}
