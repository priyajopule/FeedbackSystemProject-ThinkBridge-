using FeedbackSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FeedbackSystem
{
    public class FeedbackSysContext : DbContext
    {
        internal IEnumerable<object> login;

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

        DbSet<User> Users
        {
            get;
            set;
        }
    }
}