using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Book_Store.Data;
using Book_Store.Models;

namespace Book_Store.Pages.Publications
{
    public class IndexModel : PageModel
    {
        private readonly Book_Store.Data.Book_StoreContext _context;

        public IndexModel(Book_Store.Data.Book_StoreContext context)
        {
            _context = context;
        }

        public IList<Publication> Publication { get;set; }

        public async Task OnGetAsync()
        {
            Publication = await _context.Publication
                .Include(p => p.Book)
                .Include(p => p.Publisher).ToListAsync();
        }
    }
}
