using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Infrastructure.Persistence.Contexts
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
