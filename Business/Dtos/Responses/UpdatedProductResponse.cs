namespace Business.Dtos.Responses;

public class UpdatedProductResponse
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; } 
    public short UnitsInStock { get; set; }
    public string QuantityPerUnit { get; set; }
    public DateTime UpdatedDate { get; set; }
}