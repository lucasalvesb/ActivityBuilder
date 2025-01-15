namespace ActivityBuilder.DTOs
{
   public class ActivityDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<QuestionDTO> Questions { get; set; }
    }
}
