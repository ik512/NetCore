﻿using System.Collections.Generic;
using WebStore.Domain.Entities;
using WebStore.Domain.Filters;

namespace WebStore.Infrastructure.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Brand> GetBrands();
        IEnumerable<Product> GetProducts(ProductFilter filter);
    }

}
