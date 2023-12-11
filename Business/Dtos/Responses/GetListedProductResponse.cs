using Core.DataAccess.Paging;

namespace Business.Dtos.Responses;


        public class GetListedProductResponse
        {
            public int Id { get; set; }
            public string ProductName { get; set; }
            public string CategoryName { get; set; }
            public decimal UnitPrice { get; set; }
            public short UnitsInStock { get; set; }
            public string QuantityPerUnit { get; set; }
        }
    