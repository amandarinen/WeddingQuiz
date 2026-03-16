namespace WeddingQuiz.Models
{
    public class QuizQuestion
    {
        public string Question { get; set; } = "";
        public List<string> Answers { get; set; } = new();
        public string CorrectAnswer { get; set; } = "";
    }

}
