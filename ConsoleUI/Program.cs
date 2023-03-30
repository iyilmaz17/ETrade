using Business.Concrete;
using DataAccess.Concrete.EntityFramework;



ProductDetailDtoTest();


//CategoryTest();


//ProductTest();


void ProductDetailDtoTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
    var result = productManager.GetProductDetail();

    if (result.IsSuccess == true)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + " ----- " + product.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }



    
}

//void CategoryTest()
//{
//    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

//    foreach (var category in categoryManager.GetAll())
//    {
//        Console.WriteLine(category.CategoryName1);
//    }
//}

//void ProductTest()
//{
//    ProductManager productManager = new ProductManager(new EfProductDal());
//    foreach (var pro in productManager.GetByUnitPrice(10, 20000).Data)
//    {
//        Console.WriteLine(pro.ProductName + " ----- " + pro.UnitPrice);
//    }
//}