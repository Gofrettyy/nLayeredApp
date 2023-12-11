using Core.Entities;

namespace Entities.Concrete;

public class Product:Entity<int>//Guid dememizin sebebi 1)Veri güvenliği için 2)Microservice mimarileride bestpractice olarak guid kullanırız.
{
   
    public int? CategoryId { get; set; }
    public string ProductName { get; set; }
    public decimal? UnitPrice { get; set; } 
    public short? UnitsInStock { get; set; }
    public string? QuantityPerUnit { get; set; }
    public Category Category { get; set; }
}