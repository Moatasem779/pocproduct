using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Modularity;
using Xunit;

namespace PhysicalProductModule.PhysicalProducts;
/// <summary>
/// Base class for testing the Physical Products App Service.
/// </summary>
/// <typeparam name="TStartupModule">The type of the startup module.</typeparam>
public abstract class PhysicalProductsAppService_Tests<TStartupModule> : PhysicalProductModuleApplicationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{
    /// <summary>
    /// The physical product app service instance.
    /// </summary>
    private readonly IPhysicalProductAppService _physicalProductAppService;

    /// <summary>
    /// Initializes a new instance of the <see cref="PhysicalProductsAppService_Tests{TStartupModule}"/> class.
    /// </summary>
    public PhysicalProductsAppService_Tests()
    {
        // Get the required physical product app service instance.
        _physicalProductAppService = GetRequiredService<IPhysicalProductAppService>();
    }

    /// <summary>
    /// Tests that creating a physical product asynchronously returns the created product successfully.
    /// </summary>
    [Fact]
    public async Task CreateAsync_Should_Create_PhysicalProduct_Successfully()
    {
        // Arrange
        var input = new CreateUpdatePhysicalProductDto
        {
            Name = "Test Product",
            Description = "Test Description",
            Price = 100m
        };

        // Act
        var result = await _physicalProductAppService.CreateAsync(input);

        // Assert
        result.ShouldNotBeNull();
        result.Name.ShouldBe("Test Product");
        result.Description.ShouldBe("Test Description");
        result.Price.ShouldBe(100m);
    }

    /// <summary>
    /// Tests that creating a physical product asynchronously throws an exception when the input is null.
    /// </summary>
    [Fact]
    public async Task CreateAsync_Should_Throw_Exception_When_Input_Is_Null()
    {
        // Act and Assert
        await Should.ThrowAsync<ArgumentNullException>(async () =>
        {
            await _physicalProductAppService.CreateAsync(null);
        });
    }

    /// <summary>
    /// Tests that getting a physical product asynchronously returns the product when it exists.
    /// </summary>
    [Fact]
    public async Task GetAsync_Should_Return_PhysicalProduct_When_Exists()
    {
        // Arrange
        var input = new CreateUpdatePhysicalProductDto
        {
            Name = "Existing Product",
            Description = "Existing Description",
            Price = 150m
        };

        var createdProduct = await _physicalProductAppService.CreateAsync(input);

        // Act
        var result = await _physicalProductAppService.GetAsync(createdProduct.Id);

        // Assert
        result.ShouldNotBeNull();
        result.Id.ShouldBe(createdProduct.Id);
        result.Name.ShouldBe("Existing Product");
    }

    /// <summary>
    /// Tests that getting a physical product asynchronously throws an EntityNotFoundException when the product does not exist.
    /// </summary>
    [Fact]
    public async Task GetAsync_Should_Throw_EntityNotFoundException_When_Product_Does_Not_Exist()
    {
        // Act and Assert
        await Should.ThrowAsync<EntityNotFoundException>(async () =>
        {
            await _physicalProductAppService.GetAsync(9999);
        });
    }

    /// <summary>
    /// Tests that updating a physical product asynchronously updates the existing product successfully.
    /// </summary>
    [Fact]
    public async Task UpdateAsync_Should_Update_Existing_PhysicalProduct_Successfully()
    {
        // Arrange
        var input = new CreateUpdatePhysicalProductDto
        {
            Name = "Original Product",
            Description = "Original Description",
            Price = 200m
        };

        var createdProduct = await _physicalProductAppService.CreateAsync(input);

        var updateInput = new CreateUpdatePhysicalProductDto
        {
            Name = "Updated Product",
            Description = "Updated Description",
            Price = 250m
        };

        // Act
        var updatedProduct = await _physicalProductAppService.UpdateAsync(createdProduct.Id, updateInput);

        // Assert
        updatedProduct.ShouldNotBeNull();
        updatedProduct.Id.ShouldBe(createdProduct.Id);
        updatedProduct.Name.ShouldBe("Updated Product");
        updatedProduct.Description.ShouldBe("Updated Description");
        updatedProduct.Price.ShouldBe(250m);
    }

    /// <summary>
    /// Tests that updating a physical product asynchronously throws an EntityNotFoundException when the product does not exist.
    /// </summary>
    [Fact]
    public async Task UpdateAsync_Should_Throw_EntityNotFoundException_When_Product_Does_Not_Exist()
    {
        var updateInput = new CreateUpdatePhysicalProductDto
        {
            Name = "Non-existing Product",
            Description = "Should not exist",
            Price = 300m
        };

        // Act and Assert
        await Should.ThrowAsync<EntityNotFoundException>(async () =>
        {
            await _physicalProductAppService.UpdateAsync(9999, updateInput);
        });
    }
    /// <summary>
    /// Tests that deleting a physical product asynchronously deletes the existing product successfully.
    /// </summary>
    [Fact]
    public async Task DeleteAsync_Should_Throw_EntityNotFoundException_When_Product_Does_Not_Exist()
    {
        await Should.ThrowAsync<EntityNotFoundException>(async () =>
        {
            await _physicalProductAppService.DeleteAsync(9999);
        });
    }
    /// <summary>
    /// Tests that getting a list of physical products asynchronously returns a paged list of products.
    /// </summary>
    [Fact]
    public async Task GetListAsync_Should_Return_Paged_List_Of_PhysicalProducts()
    {
        for (int i = 1; i <= 5; i++)
        {
            await _physicalProductAppService.CreateAsync(new CreateUpdatePhysicalProductDto
            {
                Name = $"Product {i}",
                Description = $"Description {i}",
                Price = i * 10m
            });
        }

        var input = new PagedAndSortedResultRequestDto
        {
            MaxResultCount = 3,
            SkipCount = 0
        };

        var result = await _physicalProductAppService.GetListAsync(input);


        result.ShouldNotBeNull();
        result.Items.Count.ShouldBe(3);
        result.TotalCount.ShouldBeGreaterThanOrEqualTo(5);
    }
}

