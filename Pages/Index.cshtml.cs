using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;


namespace ToDoList.Pages
{
    public class IndexModel : PageModel
    {
        /*private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
       

        public void OnGet()
        {
            
        }
    }*/
        private readonly ToDoList.Data.ApplicationDbContext _context;

        public IndexModel(ToDoList.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ToDoModel> ToDoModel { get; set; }

        public async Task OnGetAsync()
        {
            ToDoModel = await _context.ToDo.ToListAsync();
        }
    }
}
