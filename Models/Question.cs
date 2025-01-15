namespace ActivityBuilder.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
