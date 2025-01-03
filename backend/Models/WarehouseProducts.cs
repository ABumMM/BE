﻿namespace backend.Models
{
    public class WarehouseProducts
    {
        public Guid Id { get; set; }
        public Guid WarehouseId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; } = 0;
        public virtual Warehouses Warehouse { get; set; } = null!;
        public virtual Products Product { get; set; } = null!;
    }
}
