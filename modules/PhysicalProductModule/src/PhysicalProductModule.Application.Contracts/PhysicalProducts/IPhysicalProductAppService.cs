using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace PhysicalProductModule.PhysicalProducts;

/// <summary>
/// Defines the application service contract for managing physical products.
/// </summary>
public interface IPhysicalProductAppService : IApplicationService
{
    /// <summary>
    /// Creates a new physical product.
    /// </summary>
    /// <param name="input">The details of the physical product to create.</param>
    /// <returns>The created physical product details.</returns>
    Task<PhysicalProductDto> CreateAsync(CreateUpdatePhysicalProductDto input);

    /// <summary>
    /// Deletes a physical product by its ID.
    /// </summary>
    /// <param name="id">The ID of the physical product to delete.</param>
    Task DeleteAsync(int id);

    /// <summary>
    /// Retrieves a physical product by its ID.
    /// </summary>
    /// <param name="id">The ID of the physical product to retrieve.</param>
    /// <returns>The physical product details.</returns>
    Task<PhysicalProductDto> GetAsync(int id);

    /// <summary>
    /// Retrieves a paginated and sorted list of physical products.
    /// </summary>
    /// <param name="input">Pagination and sorting options.</param>
    /// <returns>A paginated list of physical products.</returns>
    Task<PagedResultDto<PhysicalProductDto>> GetListAsync(PagedAndSortedResultRequestDto input);

    /// <summary>
    /// Updates an existing physical product.
    /// </summary>
    /// <param name="id">The ID of the physical product to update.</param>
    /// <param name="input">The updated physical product details.</param>
    /// <returns>The updated physical product details.</returns>
    Task<PhysicalProductDto> UpdateAsync(int id, CreateUpdatePhysicalProductDto input);
}