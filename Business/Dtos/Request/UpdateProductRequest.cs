namespace Business.Dtos.Request;

public class UpdateProductRequest
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; } 
    public short UnitsInStock { get; set; }
    public string QuantityPerUnit { get; set; }
  
}