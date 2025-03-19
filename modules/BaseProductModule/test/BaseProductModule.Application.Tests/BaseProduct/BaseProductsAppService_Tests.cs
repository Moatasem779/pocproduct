using BaseProductModule.BaseProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Modularity;
using Xunit;

namespace BaseProductModule.BaseProduct;

public class BaseProductsAppService_Tests<TStartupModule> : BaseProductModuleApplicationTestBase<TStartupModule>
        where TStartupModule : IAbpModule

{

    private readonly IBaseProductAppService _baseProductAppService;

    public BaseProductsAppService_Tests()
    {
        _baseProductAppService = GetRequiredService<IBaseProductAppService>();
    }


    [Fact]
    public async Task GetListOfBaseProductCount()
    {
        var result =await _baseProductAppService.GetListAsync(new PagedAndSortedResultRequestDto
        {
            MaxResultCount = 1000,
            SkipCount = 0,
            Sorting="Id"

        });
        Assert.Equal(3, result.TotalCount);

    }

}
