using StockFlow.Domain.Common;
using StockFlow.Domain.Enums;

namespace StockFlow.Domain.Entities;

public class StockMovement : BaseEntity
{
    public MovementType Type { get; set; }
    public int Quantity { get; set; }
    public int StockAfter { get; set; }
    public string? Reason { get; set; }

    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;

    public int UserId { get; set; }
    public User User { get; set; } = null!;
}
