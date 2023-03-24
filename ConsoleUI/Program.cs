using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

ProductManager productManager = new ProductManager( new EfProductDal());
foreach (var pro in productManager.GetByUnitPrice(10,20000))
{
    Console.WriteLine(pro.ProductName +" ----- "+pro.UnitPrice);
}
