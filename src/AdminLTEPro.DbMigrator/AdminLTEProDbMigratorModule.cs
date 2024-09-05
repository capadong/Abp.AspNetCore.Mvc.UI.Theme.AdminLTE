using AdminLTEPro.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AdminLTEPro.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AdminLTEProEntityFrameworkCoreModule),
    typeof(AdminLTEProApplicationContractsModule)
    )]
public class AdminLTEProDbMigratorModule : AbpModule
{
}
