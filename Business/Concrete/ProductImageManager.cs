using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class ProductImageManager : IProductImageService
    {
        private readonly IProductImageDal _productImage;
        private readonly IFileHelper _fileHelper;
        public ProductImageManager(IProductImageDal productImage, IFileHelper fileHelper)
        {
            _productImage = productImage;
            _fileHelper = fileHelper;
        }
        public IResult Add(IFormFile file, ProductImage productImage,int productId)
        {
            IResult result = BusinessRules.Run(CheckIfProductImageLimit(productImage.ProductId));
            if (result != null)
            {
                return result;
            }
            productImage.ImagePath = _fileHelper.Upload(file, PathConstants.ImagesPath);
            productImage.UploadDate = DateTime.Now; ;
            _productImage.Add(productImage);
            return new SuccessResult(Messages.ProductImagesAdded);

        }

        public IResult Delete(ProductImage productImage)
        {
            _fileHelper.Delete(PathConstants.ImagesPath + productImage.ImagePath);
            _productImage.Delete(productImage);
            return new SuccessResult(Messages.ProductImagesDeleted);
        }

        public IResult Update(IFormFile file, ProductImage productImage)
        {
            productImage.ImagePath = _fileHelper.Update(file, PathConstants.ImagesPath + productImage.ImagePath,
                PathConstants.ImagesPath);
            _productImage.Update(productImage);
            return new SuccessResult(Messages.ProductImagesUpdated);
        }

        public IDataResult<List<ProductImage>> GetAll()
        {
            return new SuccessDataResult<List<ProductImage>>(_productImage.GetAll());
        }

        public IDataResult<List<ProductImage>> GetByProductId(int productId)
        {
            var result = BusinessRules.Run(CheckIfProductImageLimit(productId));
            if (result!=null)
            {
                return new ErrorDataResult<List<ProductImage>>(GetDefaultProductImage(productId).Data);
            }
            return new SuccessDataResult<List<ProductImage>>(_productImage.GetAll(p => p.ProductId == productId));
        }
        public IDataResult<ProductImage> GetByDistinctProductId(int productId)
        {
            var result = (_productImage.GetByDistinctProductId(productId));
            
            return new SuccessDataResult<ProductImage>(result);
        }

        public IDataResult<ProductImage> GetById(int imageId)
        {
            return new SuccessDataResult<ProductImage>(_productImage.Get(x => x.Id == imageId));
        }

        private IResult CheckIfProductImageLimit(int productId)
        {
            var result = _productImage.GetAll(p => p.ProductId == productId).Count;
            if (result > 4)
            {
                return new ErrorResult(Messages.ProductImagesNotAdded);
            }

            return new SuccessResult();
        }
        private IResult CheckProductImage(int productId)
        {
            var result = _productImage.GetAll(p => p.ProductId == productId).Count;
            if (result > 0)
            {
                return new SuccessResult();
            }

            return new ErrorResult();
        }

        private IDataResult<List<ProductImage>> GetDefaultProductImage(int productId)
        {
            List<ProductImage> productImage = new List<ProductImage>();
            productImage.Add(new ProductImage
            {
                Id = productId,
                UploadDate = DateTime.Now,
                ImagePath = "DefaultImage.jpg"
            });

            return new SuccessDataResult<List<ProductImage>>(productImage);
        }
    }
}
