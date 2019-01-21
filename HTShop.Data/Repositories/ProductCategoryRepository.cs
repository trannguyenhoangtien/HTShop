﻿using HTShop.Data.Infrastructure;
using HTShop.Model.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HTShop.Data.Repositories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        
        public ProductCategoryRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}