﻿using RepositoryPattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Application.Interfaces
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
    }
}
