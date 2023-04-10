using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCartDal : EfEntityRepositoryBase<Cart, ETradeContext>, ICartDal
    {
        public List<CartSummary> GetCartSummary(int UserId)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var result = from c in context.Carts
                             join p in context.Products
                             on c.ProductId equals p.Id
                             where c.UserId == UserId
                             select new CartSummary
                             {
                                 CartCode = c.CartCode,
                                 Amount = c.Amount,
                                 ProductName = p.ProductName,
                                 Status = c.Status,
                             };
                return result.ToList();
            }
        }
    }
}
