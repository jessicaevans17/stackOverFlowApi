using stackOverFlowApi.Models;
using Microsoft.AspNetCore.Mvc;
using stackoverflowapi;
using System.Linq;
using System.Collections.Generic;

namespace stackOverFlowApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class QuestionsController : ControllerBase
  {
    private DatabaseContext context;

    public QuestionsController(DatabaseContext _context)
    {
      this.context = _context;
    }

    [HttpPost]
    public ActionResult<Questions> CreateQuestions([FromBody]Questions entry)
    {
      context.Questions.Add(entry);
      context.SaveChanges();
      return entry;
    }


    [HttpGet]
    public ActionResult<IEnumerable<Questions>> GetAllQuestions()
    {
      // 2. do the thing
      var Questions = context.Questions.OrderByDescending(question => question.DateCreated);

      // 3. return the thing
      return Questions.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult GetOneQuestion(int id)
    {
      // 2. Do the thing 
      var question = context.Questions.FirstOrDefault(q => q.Id == id);
      // 3. return the thing
      if (question == null)
      {
        return NotFound();
      }
      else
      {
        return Ok(question);
      }
    }
  }
}