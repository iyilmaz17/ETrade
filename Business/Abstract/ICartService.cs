using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICartService
    {
        IResult Add(Cart cart);
        IDataResult<List<Cart>> GetAll();
        IDataResult<List<CartSummary>> GetSummary(int userId);

    }
}
