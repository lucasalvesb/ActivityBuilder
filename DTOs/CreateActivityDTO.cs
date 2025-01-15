﻿namespace ActivityBuilder.DTOs
{
    public class CreateActivityDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public List<CreateQuestionDTO> Questions { get; set; }
    }
}
