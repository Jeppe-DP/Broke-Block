//Question klasse - indeholder vores spm og deres svar muligheder
public class Question
{
    public string Text;
    public string [] Answers; //svarmuligheder som et array af strenge
    public int CorrectAnswer;

    public Question(string text, string []answers, int CorrectAnswer)

    {
        Text = text;
        Answers = answers;
       this.CorrectAnswer = CorrectAnswer;
    }
}
