namespace lab3.Models;

public class QuizModel
{
    private readonly List<string> operations = new(){ "+", "-"};
    private readonly Random random = new();

    private int x;
    private int y;
    private string operation = null!;
    private int RightAnswer { get; set; }
    public string Question = null!;
    public List<string> Results { get; set; } = new();

    public int AnswersCount;
    public int RightAnswersCount;


    public void SetRandomValues()
    {
        
        x = random.Next(0, 15);
        y = random.Next(0, 15);
        operation = operations[random.Next(0, 2)];
        RightAnswer = operation switch
        {
            "+" => x + y,
            "-" => x - y,
            _ => RightAnswer
        };
 
        Question = $"{x} {operation} {y} = ";
    }

    public void UppdateResults(int answer)
    {
        AnswersCount++;
        if(answer == RightAnswer)
        {
            RightAnswersCount++;
        }
        Results.Add($"{Question} {answer}");
    }
}