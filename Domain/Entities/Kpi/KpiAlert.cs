using Postgrest.Attributes;

namespace Domain.Entities.Kpi;

[Table("Alert")]
public class KpiAlert : BaseEntity
{
    [Column("KpiId")]
    public Kpi? KpiId { get; set; }
    
    [Column("TresholdValue")]
    public float? TresholdValue { get; set; }
    
    [Column("AlertType")]
    public string? AlertType { get; set; }
}