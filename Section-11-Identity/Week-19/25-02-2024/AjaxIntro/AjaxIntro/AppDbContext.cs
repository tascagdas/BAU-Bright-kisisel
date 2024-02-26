using AjaxIntro.Models;
using Microsoft.EntityFrameworkCore;

namespace AjaxIntro;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
    {
        
    }

    public DbSet<Student> Students { get; set; }
}