using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _ProductDal;

        public ProductManager(IProductDal ProductDal)
        {
            _ProductDal = ProductDal;
        }

        public void TAdd(Product entity)
        {
            _ProductDal.Add(entity);
        }

        public void TDelete(Product entity)
        {
            _ProductDal.Delete(entity);
        }

        public Product TGetByID(int id)
        {
            return _ProductDal.GetByID(id);
        }

        public List<Product> TGetListAll()
        {
            return _ProductDal.GetListAll();
        }

        public List<Product> TGetProductsWithCategories()
        {
            return _ProductDal.GetProductsWithCategories();
        }

        public void TUpdate(Product entity)
        {
            _ProductDal.Update(entity);
        }
    }
}