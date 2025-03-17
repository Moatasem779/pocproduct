using Xunit;

namespace ProductPOCModule.EntityFrameworkCore;

[CollectionDefinition(ProductPOCModuleTestConsts.CollectionDefinitionName)]
public class ProductPOCModuleEntityFrameworkCoreCollection : ICollectionFixture<ProductPOCModuleEntityFrameworkCoreFixture>
{

}
