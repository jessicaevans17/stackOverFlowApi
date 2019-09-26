using System;
using System.Collections.Generic;

namespace stackOverFlowApi.Models
{
  public class Questions
  {
    public int Id { get; set; }
    public string QuestionTitle { get; set; }
    public string QuestionContent { get; set; }
    public int QuestionLike { get; set; }
    public int QuestionDislike { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;

    public List<Answers> Answer { get; set; } = new List<Answers>();

  }
}