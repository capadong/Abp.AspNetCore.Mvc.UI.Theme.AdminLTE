using AdminLTEPro.Samples;
using Xunit;

namespace AdminLTEPro.EntityFrameworkCore.Domains;

[Collection(AdminLTEProTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AdminLTEProEntityFrameworkCoreTestModule>
{

}
