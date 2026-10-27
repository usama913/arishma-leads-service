namespace Arishma.Leads.Application;
public interface ILeadRepository
{
    Task<IReadOnlyList<LeadDto>> ListAsync(CancellationToken ct = default);
}
