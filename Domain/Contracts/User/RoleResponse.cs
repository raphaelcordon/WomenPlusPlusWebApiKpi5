using Domain.Entities.User;

namespace Domain.Contracts.User;

public class RoleResponse
{
    public Guid id { get; set; }
    public string? RoleName { get; set; } 
    public UserPermission? PermissionId { get; set; }    
}