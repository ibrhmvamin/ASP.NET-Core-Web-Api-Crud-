using System.Text.Json.Serialization;

namespace ASP.NET_Core_Web_Api_Crud_Operations_Homework8.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        [JsonIgnore]
        public virtual ICollection<Order>? Orders { get; set; }

    }
}
