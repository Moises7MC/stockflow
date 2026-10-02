using StockFlow.Domain.Common;
using StockFlow.Domain.Enums;

namespace StockFlow.Domain.Entities;

public class User : BaseEntity
{
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public UserRole Role { get; set; } = UserRole.User;

    public ICollection<StockMovement> StockMovements { get; set; } = [];
}
