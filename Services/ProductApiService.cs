using System.Net.Http.Json;          // Extensiones para trabajar con JSON en HttpClient
using InventoryWeb.Models;           // Modelos/DTOs que usará este servicio

namespace InventoryWeb.Services;

// Servicio para consumir la API de productos
public class ProductApiService
{
    private readonly HttpClient _httpClient; // Cliente HTTP inyectado para hacer llamadas a la API

    public ProductApiService(HttpClient httpClient)
    {
        _httpClient = httpClient; // Se recibe vía inyección de dependencias
    }

    // Obtener lista de productos desde la API
    public async Task<List<ProductDto>> GetProductsAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<ProductDto>>("api/products")
               ?? new List<ProductDto>(); // Si la respuesta es null, devuelve lista vacía
    }

    // Obtener un producto por su ID
    public async Task<ProductDto?> GetProductByIdAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<ProductDto>($"api/products/{id}");
    }

    // Crear un nuevo producto (POST)
    public async Task<HttpResponseMessage> CreateProductAsync(CreateProductDto product)
    {
        return await _httpClient.PostAsJsonAsync("api/products", product);
    }

    // Actualizar un producto existente (PUT)
    public async Task<HttpResponseMessage> UpdateProductAsync(int id, UpdateProductDto product)
    {
        return await _httpClient.PutAsJsonAsync($"api/products/{id}", product);
    }

    // Eliminar un producto por ID (DELETE)
    public async Task<HttpResponseMessage> DeleteProductAsync(int id)
    {
        return await _httpClient.DeleteAsync($"api/products/{id}");
    }
}
