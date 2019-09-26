using System;

namespace stackOverFlowApi.Models
{
  public class Answers
  {
    public int Id { get; set; }
    public string Answer { get; set; }
    public int AnswerLike { get; set; }
    public int AnswerDislike { get; set; }

    // public int UnicornId{get;set;}
    public int QuestionsId { get; set; }

    // public ModelName Unicorn{get;set;}
    public Questions Questions { get; set; }

  }
}




