using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProiectHHoratiu.Data;
using ProiectHHoratiu.Models;

namespace ProiectHHoratiu.Pages.Contacts
{
    public class IndexModel : PageModel
    {
        private readonly ProiectHHoratiu.Data.ProiectHHoratiuContext _context;

        public IndexModel(ProiectHHoratiu.Data.ProiectHHoratiuContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; }

        public async Task OnGetAsync()
        {
            Person = await _context.Person.ToListAsync();
        }
    }
}
