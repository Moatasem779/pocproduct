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
/// <summary>
/// Base class for testing the BaseProductsAppService.
/// </summary>
/// <typeparam name="TStartupModule">The type of the startup module.</typeparam>
public abstract class BaseProductsAppService_Tests<TStartupModule> : BaseProductModuleApplicationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{
    /// <summary>
    /// The instance of the IBaseProductAppService.
    /// </summary>
    private readonly IBaseProductAppService _baseProductAppService;

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseProductsAppService_Tests{TStartupModule}"/> class.
    /// </summary>
    public BaseProductsAppService_Tests()
    {
        // Get the instance of the IBaseProductAppService from the service provider.
        _baseProductAppService = GetRequiredService<IBaseProductAppService>();
    }

    /// <summary>
    /// Tests that the GetListAsync method returns a list of base products with the correct count.
    /// </summary>
    [Fact]
    public async Task GetListBaseProduct_Count()
    {
        
        var request = new PagedAndSortedResultRequestDto
        {
            MaxResultCount = 1000,
            SkipCount = 0,
            Sorting = "Id" 
        };

        
        var result = await _baseProductAppService.GetListAsync(request);

       
        Assert.Equal(3, result.TotalCount);
    }

    /// <summary>
    /// Tests that the GetListAsync method returns a list of base products with at least zero items.
    /// </summary>
    [Fact]
    public async Task GetListBaseProduct_Should_Return_At_Least_Zero()
    {
        
        var request = new PagedAndSortedResultRequestDto
        {
            MaxResultCount = 1000,
            SkipCount = 0,
            Sorting = "Id"
        };

        
        var result = await _baseProductAppService.GetListAsync(request);

       
        Assert.NotNull(result);
        Assert.True(result.TotalCount >= 0);
    }

    /// <summary>
    /// Tests that the CreateAsync method creates a new base product successfully.
    /// </summary>
    [Fact]
    public async Task CreateBaseProduct_Should_Create_Successfully()
    {
        
        var input = new CreateUpdateBaseProductDto
        {
            Name = "Test Product",
            Description = "Test Description",
            Price = 199.99m , 
            ExtraProperties = new ExtraPropertyDictionary
            {
                ["stock"] = "120"
            }
        };
        var createdProduct = await _baseProductAppService.CreateAsync(input);
        Assert.NotNull(createdProduct);
        Assert.Equal(input.Name, createdProduct.Name);
        Assert.Equal(input.Description, createdProduct.Description);
        Assert.Equal(input.Price, createdProduct.Price);
    }

    /// <summary>
    /// Tests that the GetAsync method returns the correct base product by id.
    /// </summary>
    [Fact]
    public async Task GetBaseProductById_Should_Return_Correct_Product()
    {
        
        var createdProduct = await _baseProductAppService.CreateAsync(new CreateUpdateBaseProductDto
        {
            Name = "Sample Product",
            Description = "Sample Description",
            Price = 99.99m ,
            ExtraProperties = new ExtraPropertyDictionary
            {
                ["stock"] = "120"
            }
        });

        
        var retrievedProduct = await _baseProductAppService.GetAsync(createdProduct.Id);

       
        Assert.NotNull(retrievedProduct);
        Assert.Equal(createdProduct.Id, retrievedProduct.Id);
    }

    /// <summary>
    /// Tests that the UpdateAsync method updates a base product successfully.
    /// </summary>
    [Fact]
    public async Task UpdateBaseProduct_Should_Update_Successfully()
    {
        var existingProduct = await _baseProductAppService.CreateAsync(new CreateUpdateBaseProductDto
        {
            Name = "Old Product",
            Description = "Old Description",
            Price = 199.99m,
            ExtraProperties = new ExtraPropertyDictionary
            {
                ["stock"] = "120"
            }
        });

        var input = new CreateUpdateBaseProductDto
        {
            Name = "Updated Product",
            Description = "Updated Description",
            Price = 299.99m ,
            ExtraProperties = new ExtraPropertyDictionary
            {
                ["stock"] = "120"
            }
        };

       
        var updatedProduct = await _baseProductAppService.UpdateAsync(existingProduct.Id, input);

     
        Assert.NotNull(updatedProduct);
        Assert.Equal("Updated Product", updatedProduct.Name);
    }
}
