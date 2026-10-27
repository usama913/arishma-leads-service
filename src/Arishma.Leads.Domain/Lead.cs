namespace Arishma.Leads.Domain;
public class Lead
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string Company { get; set; } = "";
    public string? ContactName { get; set; }
    public string? Email { get; set; }
    public string? Source { get; set; }
    public int Score { get; set; }
}
