using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ExpenseTracker.Data
{
    public class ExpenseDbContext : DbContext
    {
        public ExpenseDbContext(DbContextOptions<ExpenseDbContext> options) : base(options) { }

        public DbSet<Expense> Expenses { get; set; }
    }
}
