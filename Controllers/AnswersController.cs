using stackOverFlowApi.Models;
using Microsoft.AspNetCore.Mvc;
using stackoverflowapi;

namespace stackOverFlowApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnswersController : ControllerBase
  {
    private DatabaseContext context;

    public AnswersController(DatabaseContext _context)
    {
      this.context = _context;
    }


    [HttpPost]
    public ActionResult<Answers> CreateAnswers([FromBody]Answers entry)
    {
      context.Answers.Add(entry);
      context.SaveChanges();
      return entry;
    }
  }
}
