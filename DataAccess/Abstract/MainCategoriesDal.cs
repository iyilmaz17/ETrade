using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.DTOs;
using DataAccess.Concrete.EntityFramework;

namespace DataAccess.Abstract
{
    public interface MainCategoriesDal : IEntityRepository<MainCategory>
    {
    }
}
