using Domain.Entities.User;

namespace Domain.Contracts.User;

public class UserResponse
{
    public Guid id { get; set; }
    
    public string? Name { get; set; }
    
    public string? Salted { get; set; }

    public string? Hashed { get; set; }

    public string? Email { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? Field { get; set; }

    public UserRole? RoleId { get; set; }

    public Entities.Circle.Circle? CircleId { get; set; }
}

    

    

    
