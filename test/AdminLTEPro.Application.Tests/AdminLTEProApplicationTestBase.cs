using Volo.Abp.Modularity;

namespace AdminLTEPro;

public abstract class AdminLTEProApplicationTestBase<TStartupModule> : AdminLTEProTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
