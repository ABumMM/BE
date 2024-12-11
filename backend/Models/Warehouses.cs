namespace backend.Models
{
    public class Warehouses
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public virtual ICollection<WarehouseProducts> WarehouseProducts { get; set; } = new List<WarehouseProducts>();

    }
}
