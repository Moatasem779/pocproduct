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

    public async Task<PhysicalProductDto> CreateAsync(CreateUpdatePhysicalProductDto input)
    {
        var physicalProduct = ObjectMapper.Map<CreateUpdatePhysicalProductDto, PhysicalProduct>(input);
        var result = await _repository.InsertAsync(physicalProduct);
        return ObjectMapper.Map<BaseProduct, PhysicalProductDto>(result);
    }
    public async Task DeleteAsync(int id)
    {
        BaseProduct existBaseProduct = await CheckEntityIsFound(id);
        await _repository.DeleteAsync(existBaseProduct);
    }

    public async Task<PhysicalProductDto> GetAsync(int id)
    {
        BaseProduct? existBaseProduct = await CheckEntityIsFound(id);
        return ObjectMapper.Map<BaseProduct, PhysicalProductDto>(existBaseProduct);
    }

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
    public async Task<PhysicalProductDto> UpdateAsync(int id, CreateUpdatePhysicalProductDto input)
    {
        BaseProduct? existBaseProduct = await CheckEntityIsFound(id);

        var updateBaseProduct = ObjectMapper.Map<CreateUpdatePhysicalProductDto, BaseProduct>(input, existBaseProduct);

        var result = await _repository.UpdateAsync(updateBaseProduct);

        return ObjectMapper.Map<BaseProduct, PhysicalProductDto>(updateBaseProduct);
    }

  
    private async Task<BaseProduct> CheckEntityIsFound(int id)
    {
        var existBaseProduct = await _repository.FirstOrDefaultAsync(x => x.Id == id);
        if (existBaseProduct == null)
            throw new EntityNotFoundException(typeof(PhysicalProduct));
        return existBaseProduct;
    }
}
