namespace ActivityBuilder.DTOs
{
    public class CreateQuestionDTO
    {
        public string Text { get; set; }
        public List<CreateAnswerDTO> Answers { get; set; }
    }
}
