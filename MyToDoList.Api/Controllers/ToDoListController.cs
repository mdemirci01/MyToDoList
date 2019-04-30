using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyToDoList.Api.Data;
using MyToDoList.Api.Model;

namespace MyToDoList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAll")]
    public class ToDoListController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        public ToDoListController(ApplicationDbContext context)
        {
            this.db = context;
        }
        public IList<TodoItem> Get()
        {
            return db.TodoItems.ToList();
        }
        [HttpGet("{id}")]
        public TodoItem Get(int id)
        {
            return db.TodoItems.FirstOrDefault(f => f.Id == id);
        }
    }
}