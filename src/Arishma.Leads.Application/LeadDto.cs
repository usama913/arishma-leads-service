namespace Arishma.Leads.Application;
public record LeadDto(Guid Id, string Name);
public record ServiceInfoDto(string Service, string Subdomain, string Status, string DatabaseProvider);
