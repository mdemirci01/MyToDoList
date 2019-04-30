using Microsoft.EntityFrameworkCore;
using MyToDoList.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoList.Api.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }

        public virtual DbSet<TodoItem> TodoItems { get; set; }
    }
}
