using AutoMapper.Internal.Mappers;
using BaseProductModule.BaseProducts;
using BaseProductModule.Entities;
using PhysicalProductModule.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace PhysicalProductModule.PhysicalProducts;

public class PhysicalProductAppService  : PhysicalProductModuleAppService , IPhysicalProductAppService
{
    private readonly IRepository<BaseProduct, int> _repository;
    public PhysicalProductAppService(IRepository<BaseProduct, int> repository) 
    {
        _repository = repository;
    }
    /// <inheritdoc/>
    public async Task<PhysicalProductDto> CreateAsync(CreateUpdatePhysicalProductDto input)
    {
        var physicalProduct = ObjectMapper.Map<CreateUpdatePhysicalProductDto, PhysicalProduct>(input);
        physicalProduct.Discriminator = typeof(PhysicalProduct).Name;
        var result = await _repository.InsertAsync(physicalProduct);
        return ObjectMapper.Map<BaseProduct, PhysicalProductDto>(result);
    }
    /// <inheritdoc/>
    public async Task DeleteAsync(int id)
    {
        BaseProduct existBaseProduct = await CheckEntityIsFound(id);
        await _repository.DeleteAsync(existBaseProduct);
    }
    /// <inheritdoc/>
    public async Task<PhysicalProductDto> GetAsync(int id)
    {
        BaseProduct? existBaseProduct = await CheckEntityIsFound(id);
        return ObjectMapper.Map<BaseProduct, PhysicalProductDto>(existBaseProduct);
    }
    /// <inheritdoc/>
    public async Task<PagedResultDto<PhysicalProductDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        var result = await _repository.GetPagedListAsync(input.SkipCount, input.MaxResultCount, input.Sorting);

        var baseProductBaseDto = ObjectMapper.Map<List<BaseProduct>, List<PhysicalProductDto>>(result);

        return new PagedResultDto<PhysicalProductDto>
        {
            Items = baseProductBaseDto,
            TotalCount = baseProductBaseDto.Count
        };
    }
    /// <inheritdoc/>
    public async Task<PhysicalProductDto> UpdateAsync(int id, CreateUpdatePhysicalProductDto input)
    {
        BaseProduct? existBaseProduct = await CheckEntityIsFound(id);

        var updateBaseProduct = ObjectMapper.Map<CreateUpdatePhysicalProductDto, BaseProduct>(input, existBaseProduct);

        var result = await _repository.UpdateAsync(updateBaseProduct);

        return ObjectMapper.Map<BaseProduct, PhysicalProductDto>(updateBaseProduct);
    }
    /// <summary>
    /// Ensures that a <see cref="BaseProduct"/> entity with the given ID exists in the repository.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="EntityNotFoundException"></exception>
    private async Task<BaseProduct> CheckEntityIsFound(int id)
    {
        var existingBaseProduct = await _repository.FirstOrDefaultAsync(x => x.Id == id);
        if (existingBaseProduct == null)
            throw new EntityNotFoundException(typeof(BaseProduct), id);
        return existingBaseProduct;
    }
}
