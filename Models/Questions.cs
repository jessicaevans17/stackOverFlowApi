using System;

namespace stackOverFlowApi.Models
{
  public class Questions
  {
    public int Id { get; set; }
    public string Question { get; set; }
    public int QuestionUpVote { get; set; }
    public int QuestionDownVote { get; set; }

  }
}