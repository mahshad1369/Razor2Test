namespace Razor2Test.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string? QuestionText { get; set; }
        public DateTime CreationDate { get; set; } 


        public Question()
        {
            CreationDate = DateTime.Now;
        }
    }
}
