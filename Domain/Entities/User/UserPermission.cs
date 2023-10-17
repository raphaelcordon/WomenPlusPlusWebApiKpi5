using Postgrest.Attributes;

namespace Domain.Entities.User;

[Table("Permission")]
public class UserPermission : BaseEntity
{
    [Column("PermissionName")]
    public string? PermissionName { get; set; }    
}