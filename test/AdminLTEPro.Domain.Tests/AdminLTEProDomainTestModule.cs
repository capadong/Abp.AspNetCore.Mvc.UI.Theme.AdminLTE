using Volo.Abp.Modularity;

namespace AdminLTEPro;

[DependsOn(
    typeof(AdminLTEProDomainModule),
    typeof(AdminLTEProTestBaseModule)
)]
public class AdminLTEProDomainTestModule : AbpModule
{

}
