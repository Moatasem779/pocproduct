using ProductPOCModule.Samples;
using Xunit;

namespace ProductPOCModule.EntityFrameworkCore.Applications;

[Collection(ProductPOCModuleTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ProductPOCModuleEntityFrameworkCoreTestModule>
{

}
