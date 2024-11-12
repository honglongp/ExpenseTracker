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
    public class DetailsModel : PageModel
    {
        private readonly ExpenseTracker.Data.ExpenseDbContext _context;

        public DetailsModel(ExpenseTracker.Data.ExpenseDbContext context)
        {
            _context = context;
        }

        public Expense Expense { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _context.Expenses.FirstOrDefaultAsync(m => m.Id == id);
            if (expense == null)
            {
                return NotFound();
            }
            else
            {
                Expense = expense;
            }
            return Page();
        }
    }
}
