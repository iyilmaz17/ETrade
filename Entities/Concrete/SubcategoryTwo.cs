using Core.Entities;

namespace Entities.Concrete
{
    public class SubcategoryTwo : IEntity
    {
        public int Id { get; set; }
        public int ParentCategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
