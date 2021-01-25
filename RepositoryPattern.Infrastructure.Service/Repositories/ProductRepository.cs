using RepositoryPattern.Application.Interfaces;
using RepositoryPattern.Domain.Entities;
using RepositoryPattern.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Infrastructure.Service.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
