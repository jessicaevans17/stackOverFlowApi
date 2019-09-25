using stackOverFlowApi.Models;
using Microsoft.AspNetCore.Mvc;
using stackoverflowapi;

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
  }
}