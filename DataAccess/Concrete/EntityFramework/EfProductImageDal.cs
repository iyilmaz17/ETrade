using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductImageDal : EfEntityRepositoryBase<ProductImage, ETradeContext>, IProductImageDal
    {
        public ProductImage GetByDistinctProductId(int productId)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var result = (from i in context.ProductImages where i.ProductId == productId
                              select i).FirstOrDefault();
                return result;
            }
        }


    }
}
