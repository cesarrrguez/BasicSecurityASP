using BasicSecurityASP.Models;

namespace BasicSecurityASP.Services;

public interface IProductService
{
    Task<List<Product>> GetAllAsync();
}
