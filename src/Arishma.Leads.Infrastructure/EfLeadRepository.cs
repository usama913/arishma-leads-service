using Arishma.Leads.Application;
namespace Arishma.Leads.Infrastructure;
public class EfLeadRepository : ILeadRepository
{
    private readonly AppDbContext _db;
    public EfLeadRepository(AppDbContext db) => _db = db;
    // Phase 0: scaffold returns no rows and never requires a live DB for /health.
    // Phase 1: replace with a real query over _db.Leads.
    public Task<IReadOnlyList<LeadDto>> ListAsync(CancellationToken ct = default)
        => Task.FromResult<IReadOnlyList<LeadDto>>(Array.Empty<LeadDto>());
}
