using Business.Concrete;
using DataAccess.Concrete.EntityFramework;






//CategoryTest();


//ProductTest();




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