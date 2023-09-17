using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<MainCategory>> GetAll();
        IDataResult<MainCategory> GetById(int categoryId);
        IResult Add(MainCategory category);


        // Category2
        IDataResult<List<SubcategoryOne>> GetAllSubcategoryOne();
        IDataResult<List<SubcategoryOne>> GetByParentCategoryIdSubcategoryOne(int parentCategoryId);
        // Category2
        IDataResult<List<SubcategoryTwo>> GetAllSubcategoryTwo();
        IDataResult<List<SubcategoryTwo>> GetByParentCategoryIdSubcategoryTwo(int parentCategoryId);

    }
}