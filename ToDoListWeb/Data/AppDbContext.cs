using Microsoft.EntityFrameworkCore;
using ToDoListWeb.Models;

namespace ToDoListWeb.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Todo> Todos { get; set; }
    }
}
