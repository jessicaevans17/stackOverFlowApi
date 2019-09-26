using System;

namespace stackOverFlowApi.Models
{
  public class Questions
  {
    public int Id { get; set; }
    public string Question { get; set; }
    public int QuestionLike { get; set; }
    public int QuestionDislike { get; set; }
    public DateTime DateCreated { get; set; }

  }
}