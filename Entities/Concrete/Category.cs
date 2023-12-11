using Core.Entities;

namespace Entities.Concrete;

public class Category:Entity<int>
{
    public int  Id { get; set; }
    public string Name { get; set; }
    public List<Product> Products { get; set; }
}