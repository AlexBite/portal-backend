using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Data;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
    }

    public DbSet<Question> Questions { get; set; }
}