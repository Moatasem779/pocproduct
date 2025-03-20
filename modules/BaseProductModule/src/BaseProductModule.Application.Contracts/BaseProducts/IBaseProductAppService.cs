using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace BaseProductModule.BaseProducts;
/// <summary>
/// Defines the application service contract for managing base products.
/// </summary>
public interface IBaseProductAppService : IApplicationService
{
    /// <summary>
    /// Creates a new base product.
    /// </summary>
    /// <param name="input">The details of the product to create.</param>
    /// <returns>The created product details.</returns>
    Task<BaseProductDto> CreateAsync(CreateUpdateBaseProductDto input);

    /// <summary>
    /// Deletes a base product by its ID.
    /// </summary>
    /// <param name="id">The ID of the product to delete.</param>
    Task DeleteAsync(int id);

    /// <summary>
    /// Retrieves a base product by its ID.
    /// </summary>
    /// <param name="id">The ID of the product to retrieve.</param>
    /// <returns>The product details.</returns>
    Task<BaseProductDto> GetAsync(int id);

    /// <summary>
    /// Retrieves a paginated and sorted list of base products.
    /// </summary>
    /// <param name="input">Pagination and sorting options.</param>
    /// <returns>A paginated list of base products.</returns>
    Task<PagedResultDto<BaseProductDto>> GetListAsync(PagedAndSortedResultRequestDto input);

    /// <summary>
    /// Updates an existing base product.
    /// </summary>
    /// <param name="id">The ID of the product to update.</param>
    /// <param name="input">The updated product details.</param>
    /// <returns>The updated product details.</returns>
    Task<BaseProductDto> UpdateAsync(int id, CreateUpdateBaseProductDto input);
}