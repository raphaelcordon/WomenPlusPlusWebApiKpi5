using Postgrest.Attributes;

namespace Domain.Entities.Kpi;

[Table("Comment")]
public class KpiComment : BaseEntity
{
    [Column("KpiId")]
    public Kpi? KpiId { get; set; }
 
    [Column("UserId")]
    public User.User? UserId { get; set; }
    
    [Column("CommentText")]
    public string? CommentText { get; set; }
    
    [Column("CommentDate")]
    public DateTime? CommentDate { get; set; }
}