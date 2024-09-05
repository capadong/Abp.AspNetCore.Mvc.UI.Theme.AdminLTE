using AdminLTEPro.Samples;
using Xunit;

namespace AdminLTEPro.EntityFrameworkCore.Applications;

[Collection(AdminLTEProTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AdminLTEProEntityFrameworkCoreTestModule>
{

}
