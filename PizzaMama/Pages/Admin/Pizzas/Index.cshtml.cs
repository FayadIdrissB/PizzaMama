using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaMama.Data;
using PizzaMama.Models;

namespace PizzaMama.Pages.Admin.Pizzas
{
    public class IndexModel : PageModel
    {
        private readonly PizzaMama.Data.DataContext _context;

        public IndexModel(PizzaMama.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizza { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Pizzas != null)
            {
                Pizza = await _context.Pizzas.ToListAsync();
            }
        }
    }
}
