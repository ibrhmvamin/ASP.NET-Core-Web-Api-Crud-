using System.Text.Json.Serialization;

namespace ASP.NET_Core_Web_Api_Crud_Operations_Homework8.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime? OrderDate { get; set; } = DateTime.Now;
        public int ProductId { get; set; }
        [JsonIgnore]
        public virtual Product? Product { get; set; }
        public int CustomerId { get; set; }
        [JsonIgnore]
        public virtual Customer? Customer { get; set; }
    }
}
