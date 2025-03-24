using BaseProductModule.BaseProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Xunit;

namespace BaseProductModule.BaseProduct;
 public abstract class BaseProductsAppService_Tests<TStartupModule> : BaseProductModuleApplicationTestBase<TStartupModule>
        where TStartupModule : IAbpModule

{

    private readonly IBaseProductAppService _baseProductAppService;

    public BaseProductsAppService_Tests()
    {
        _baseProductAppService = GetRequiredService<IBaseProductAppService>();
    }


    [Fact]
    public async Task GetListBaseProduct_Count()
    {
        var result =await _baseProductAppService.GetListAsync(new PagedAndSortedResultRequestDto
        {
            MaxResultCount = 1000,
            SkipCount = 0,
            Sorting="Id"

        });
        Assert.Equal(3, result.TotalCount);

    }
    [Fact]
    public async Task CreateBaseProduct_Should_Create_Successfully()
    {
        var input = new CreateUpdateBaseProductDto
        {
            Name = "Test Product",
            Description = "Test Description",
            Price = 199.99m
        };

        var createdProduct = await _baseProductAppService.CreateAsync(input);

        Assert.NotNull(createdProduct);
        Assert.Equal(input.Name, createdProduct.Name);
        Assert.Equal(input.Description, createdProduct.Description);
        Assert.Equal(input.Price, createdProduct.Price);

    }

    [Fact]
    public async Task UpdateBaseProduct_Should_Update_Successfully()
    {
        var input = new CreateUpdateBaseProductDto
        {
            Name = "Updated Product",
            Description = "Updated Description",
            Price = 299.99m
        };

        var existingProduct = await _baseProductAppService.CreateAsync(new CreateUpdateBaseProductDto
        {
            Name = "Old Product",
            Description = "Old Description",
            Price = 199.99m,
        });

        var updatedProduct = await _baseProductAppService.UpdateAsync(existingProduct.Id, input);

        Assert.NotNull(updatedProduct);
        Assert.Equal("Updated Product", updatedProduct.Name);
        Assert.Equal("Updated Description", updatedProduct.Description);
        Assert.Equal(299.99m, updatedProduct.Price);
     
    }

}
