using ASP.NET_Core_Web_Api_Crud_Operations_Homework8.Entities;

namespace ASP.NET_Core_Web_Api_Crud_Operations_Homework8.Repositories.Abstracts
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllAsync();
        Task<Order> GetByIdAsync(int id);
        Task UpdateAsync(Order? order);
        Task AddAsync(Order? order);
        Task DeleteAsync(int id);
    }
}
