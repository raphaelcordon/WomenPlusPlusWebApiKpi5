using Postgrest.Attributes;

namespace Domain.Entities.Kpi;

[Table("SystemMetrics")]
public class KpiSystemMetrics : BaseEntity
{
    [Column("MetricName")]
    public string? MetricName { get; set; }
    
    [Column("Value")]
    public float? Value { get; set; }
    
    [Column("Timestamp")]
    public DateTime? Timestamp { get; set; }
}