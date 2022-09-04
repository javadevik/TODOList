using Microsoft.EntityFrameworkCore;
using TODOList.Models;

namespace TODOList.Data;

public class ApplicationContext : DbContext
{
    public ApplicationContext()
    {
        Database.EnsureCreated();
    }

    public DbSet<ToDo> ToDos { get; set; } = null!;
}