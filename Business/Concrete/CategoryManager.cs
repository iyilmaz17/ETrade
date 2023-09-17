using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly MainCategoriesDal _mainCategoriesDal;
        private readonly SubcategoriesOneDal _subcategoriesOneDal;
        private readonly SubcategoriesTwoDal _subcategoriesTwoDal;

        public CategoryManager(MainCategoriesDal mainCategoriesDal, SubcategoriesOneDal subcategoriesOneDal, SubcategoriesTwoDal subcategoriesTwoDal)
        {
            _mainCategoriesDal = mainCategoriesDal;
            _subcategoriesOneDal = subcategoriesOneDal;
            _subcategoriesTwoDal = subcategoriesTwoDal;
        }

        public IDataResult<List<MainCategory>> GetAll()
        {
            return new SuccessDataResult<List<MainCategory>>(_mainCategoriesDal.GetAll());
        }

        public IDataResult<MainCategory> GetById(int categoryId)
        {
            return new SuccessDataResult<MainCategory>(_mainCategoriesDal.Get(c => c.Id == categoryId));
        }
        [ValidationAspect(typeof(CategoryValidator))]
        public IResult Add(MainCategory category)
        {
            _mainCategoriesDal.Add(category);
            return new SuccessResult("Kategori eklendi");
        }

        // Category2
        public IDataResult<List<SubcategoryOne>> GetAllSubcategoryOne()
        {
            return new SuccessDataResult<List<SubcategoryOne>>(_subcategoriesOneDal.GetAll());
        }


        public IDataResult<List<SubcategoryOne>> GetByParentCategoryIdSubcategoryOne(int parentCategoryId)
        {
            return new SuccessDataResult<List<SubcategoryOne>>(_subcategoriesOneDal.GetAll(c=>c.ParentCategoryId == parentCategoryId));
        }

        public IDataResult<List<SubcategoryTwo>> GetAllSubcategoryTwo()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SubcategoryTwo>> GetByParentCategoryIdSubcategoryTwo(int parentCategoryId)
        {
            throw new NotImplementedException();
        }
    }
}
