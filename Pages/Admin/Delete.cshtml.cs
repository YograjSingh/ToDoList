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
    public class DeleteModel : PageModel
    {
        private readonly ToDoList.Data.ApplicationDbContext _context;

        public DeleteModel(ToDoList.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ToDoModel ToDoModel { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ToDoModel = await _context.ToDo.FirstOrDefaultAsync(m => m.Title == id);

            if (ToDoModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ToDoModel = await _context.ToDo.FindAsync(id);

            if (ToDoModel != null)
            {
                _context.ToDo.Remove(ToDoModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
