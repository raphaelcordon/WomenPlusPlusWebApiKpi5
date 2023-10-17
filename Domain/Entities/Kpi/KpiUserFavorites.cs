using Postgrest.Attributes;

namespace Domain.Entities.Kpi;

[Table("KpiUserFavorites")]
public class KpiUserFavorites : BaseEntity
{
    [Column("UserId")]
    public User.User? UserId { get; set; }
    
    [Column("KpiId")]
    public Kpi? KpiId { get; set; }
}