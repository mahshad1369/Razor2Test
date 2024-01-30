using System.Xml.Linq;

namespace Razor2Test.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? PhotoPath { get; set; }

        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public List<Comment>? Comments { get; set; }
        public List<Question>? Questions { get; set; }
        public DateTime CreationDate { get; set; } 

        public Product()
        {
            CreationDate = DateTime.Now;
        }

    }

}
