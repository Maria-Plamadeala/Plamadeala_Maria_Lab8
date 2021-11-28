﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Plamadeala_Maria_Lab8.Data;
using Plamadeala_Maria_Lab8.Models;

namespace Plamadeala_Maria_Lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Plamadeala_Maria_Lab8.Data.Plamadeala_Maria_Lab8Context _context;

        public IndexModel(Plamadeala_Maria_Lab8.Data.Plamadeala_Maria_Lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
