namespace Razor2Test.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }= DateTime.Now;
        public int ProductId { get; set; }
    }
}
