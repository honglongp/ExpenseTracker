using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Data;
using ExpenseTracker.Models;

namespace ExpenseTracker.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ExpenseTracker.Data.ExpenseDbContext _context;

        public IndexModel(ExpenseTracker.Data.ExpenseDbContext context)
        {
            _context = context;
        }

        public IList<Expense> Expense { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Expense = await _context.Expenses.ToListAsync();
        }
    }
}
