﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookTableRazor.Modals;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookTableRazor.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly AplicationDbContext _db;

        public IndexModel(AplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Book> Books { get; set; }
        public async Task OnGet()
        {
            Books = await _db.Books.ToListAsync();
        }
    }
}