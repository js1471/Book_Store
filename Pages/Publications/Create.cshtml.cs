using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Book_Store.Data;
using Book_Store.Models;

namespace Book_Store.Pages.Publications
{
    public class CreateModel : PageModel
    {
        private readonly Book_Store.Data.Book_StoreContext _context;

        public CreateModel(Book_Store.Data.Book_StoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BookId"] = new SelectList(_context.Book, "Id", "Tittle");
        ViewData["PublisherId"] = new SelectList(_context.Set<Publisher>(), "Id", "Publisher_Name");
            return Page();
        }

        [BindProperty]
        public Publication Publication { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publication.Add(Publication);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
