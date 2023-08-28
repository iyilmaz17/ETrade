using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, ETradeContext>, ICategoryDal
    {
        //public List<MainCategoryDto> GetMainCategory(string categoryName)
        //{
        //    using (var context = new ETradeContext())
        //    {
        //        var result = from category in context.Categories
        //                     where (category.CategoryName1 == categoryName)
        //                     select new MainCategoryDto { CategoryaName = category.CategoryName2 };
        //        return result.ToList();

        //    }
        //}
    }
}
