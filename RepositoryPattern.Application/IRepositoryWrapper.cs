using RepositoryPattern.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Application
{
    public interface IRepositoryWrapper
    {
        IProductRepository Product { get; }
        void Save();
    }
}
