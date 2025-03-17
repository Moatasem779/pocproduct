using ProductPOCModule.Samples;
using Xunit;

namespace ProductPOCModule.EntityFrameworkCore.Domains;

[Collection(ProductPOCModuleTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ProductPOCModuleEntityFrameworkCoreTestModule>
{

}
