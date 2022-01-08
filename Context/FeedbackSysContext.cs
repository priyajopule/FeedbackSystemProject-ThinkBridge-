using FeedbackSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace FeedbackSystem
{
    public class FeedbackSysContext : DbContext
    {
        public FeedbackSysContext(DbContextOptions options) : base(options) { }

        DbSet<Product> Products
        {
            get;
            set;
        }
        DbSet<Question> Questions
        {
            get;
            set;
        }
        DbSet<Survey> Surveys
        {
            get;
            set;
        }
        DbSet<Transaction> Transactions
        {
            get;
            set;
        }
    }
}