using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly ToDoList.Data.ApplicationDbContext _context;

        public IndexModel(ToDoList.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ToDoModel> ToDoModel { get;set; }

        public async Task OnGetAsync()
        {
            ToDoModel = await _context.ToDo.ToListAsync();
        }
    }
}
