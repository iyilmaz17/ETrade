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
        public List<CustomerProductDto> GetAllCustomerProduct()
        {
            using (ETradeContext context = new ETradeContext())
                    {
                var result = from p in context.Products
                             join i in context.ProductImages
                             on p.Id equals i.ProductId
                             where i.HomeImage == true 
                             select new CustomerProductDto
                             {
                                 Id = p.Id,
                                 Barcode = p.Barcode,
                                 AddedDate = p.AddedDate,
                                 Brand = p.Brand,
                                 CategoryId1 = p.CategoryId1,
                                 CategoryId2 = p.CategoryId2,
                                 CategoryId3 = p.CategoryId3,
                                 Description = p.Description,
                                 ProductCode = p.ProductCode,
                                 ProductName = p.ProductName,
                                 Status = p.Status,
                                 Stock = p.Stock,
                                 TaxRate = p.TaxRate,
                                 UnitPrice = p.UnitPrice,
                                 ImagePath = i.ImagePath
                             };
                return result.ToList();
                           }
        }
        public List<CustomerProductDto> GetByCatgeoryIdCustomerProduct(int categoryId)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var result = from p in context.Products
                             join i in context.ProductImages
                             on p.Id equals i.ProductId
                             where i.HomeImage == true && p.CategoryId1 == categoryId
                             select new CustomerProductDto
                             {
                                 Id = p.Id,
                                 Barcode = p.Barcode,
                                 AddedDate = p.AddedDate,
                                 Brand = p.Brand,
                                 CategoryId1 = p.CategoryId1,
                                 CategoryId2 = p.CategoryId2,
                                 CategoryId3 = p.CategoryId3,
                                 Description = p.Description,
                                 ProductCode = p.ProductCode,
                                 ProductName = p.ProductName,
                                 Status = p.Status,
                                 Stock = p.Stock,
                                 TaxRate = p.TaxRate,
                                 UnitPrice = p.UnitPrice,
                                 ImagePath = i.ImagePath
                             };
                return result.ToList();
            }
        }

        //public List<ProductDetailDto> getProductsDetailDtos()
        //{
        //    using (ETradeContext context = new ETradeContext())
        //    {
        //        var result = from p in context.Products
        //                     join c in context.Categories
        //                         on p.CategoryId equals c.Id
        //                     select new ProductDetailDto
        //                     {
        //                         ProductName = p.ProductName,
        //                         ProductId = p.Id,
        //                         CategoryName = c.CategoryName3 
        //                     };
        //        return result.ToList();
        //    }
        //}

    }
}
