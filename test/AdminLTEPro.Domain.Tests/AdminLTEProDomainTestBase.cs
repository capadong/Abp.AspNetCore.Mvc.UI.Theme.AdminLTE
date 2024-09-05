using Volo.Abp.Modularity;

namespace AdminLTEPro;

/* Inherit from this class for your domain layer tests. */
public abstract class AdminLTEProDomainTestBase<TStartupModule> : AdminLTEProTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
