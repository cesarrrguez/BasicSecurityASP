using BasicSecurityASP.Models;
using System.Text.Json;

namespace BasicSecurityASP.Services;

public class ProductService : IProductService
{
    private readonly string _path = Path.Combine(Directory.GetCurrentDirectory(), "products.json");

    public async Task<List<Product>> GetAllAsync()
    {
        var content = await File.ReadAllTextAsync(_path);
        var products = JsonSerializer.Deserialize<List<Product>>(content) ?? new List<Product>();
        return products;
    }
}
