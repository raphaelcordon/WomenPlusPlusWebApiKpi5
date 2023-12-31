using Domain.Entities.User;

namespace Domain.Contracts.User;

public class RoleRequest
{
    public string? RoleName { get; set; } 
    public UserPermission? PermissionId { get; set; }    
}