using Postgrest.Attributes;

namespace Domain.Entities.Kpi;

[Table("KpiValidation")]
public class KpiValidation : BaseEntity
{
    [Column("KpiId")]
    public Kpi? KpiId { get; set; }
    
    [Column("Rule")]
    public string? Rule { get; set; }
}