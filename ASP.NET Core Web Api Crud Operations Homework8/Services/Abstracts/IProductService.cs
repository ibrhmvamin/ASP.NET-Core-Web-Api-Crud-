using ASP.NET_Core_Web_Api_Crud_Operations_Homework8.Entities;

namespace ASP.NET_Core_Web_Api_Crud_Operations_Homework8.Services.Abstracts
{
    public interface IProductService
    {
        Task<List<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task UpdateAsync(Product? product);
        Task AddAsync(Product? product);
        Task DeleteAsync(int id);
    }
}
