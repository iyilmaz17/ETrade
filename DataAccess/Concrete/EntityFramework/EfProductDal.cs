using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ETradeContext>, IProductDal
    {
        public List<ProductDetailDto> getProductsDetailDtos()
        {
            using (ETradeContext context = new ETradeContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                                 on p.CategoryId equals c.Id
                             select new ProductDetailDto
                             {
                                 ProductName = p.ProductName,
                                 ProductId = p.Id,
                                 CategoryName = c.CategoryName1
                             };
                return result.ToList();
            }
        }
    }
}
