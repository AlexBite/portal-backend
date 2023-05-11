using Core.Data;
using Core.DTO;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Core.Controllers;

[ApiController]
[Route("api/questions")]
public class QuestionsController : ControllerBase
{
    private readonly ApiDbContext _dbContext;

    public QuestionsController(ApiDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Question>>> GetQuestions()
    {
        return await _dbContext.Questions.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<IEnumerable<Question>>> AddQuestion(CreateQuestion question)
    {
        await _dbContext.Questions.AddAsync(new Question()
        {
            Content = question.Content
        });
        await _dbContext.SaveChangesAsync();

        return Ok();
    }
}