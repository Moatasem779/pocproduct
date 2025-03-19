using AutoMapper.Internal.Mappers;
using BaseProductModule.Entities;
using PhysicalProductModule.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace PhysicalProductModule.PhysicalProducts;
public class PhysicalProductAppService  : PhysicalProductModuleAppService , IPhysicalProductAppService
{
    private readonly IRepository<PhysicalProduct, int> _repository;
    public PhysicalProductAppService(IRepository<PhysicalProduct, int> repository)
    {
        _repository = repository;
    }

    public async Task<PhysicalProductDto> CreateAsync(CreateUpdatePhysicalProductDto input)
    {
        var physicalProduct = ObjectMapper.Map<CreateUpdatePhysicalProductDto, PhysicalProduct>(input);
        var result = await _repository.InsertAsync(physicalProduct);
        return ObjectMapper.Map<PhysicalProduct, PhysicalProductDto>(result);
        throw new NotImplementedException();
    }
    public async Task DeleteAsync(int id)
    {
        PhysicalProduct existBaseProduct = await CheckEntityIsFound(id);
        await _repository.DeleteAsync(existBaseProduct);
    }

    public async Task<PhysicalProductDto> GetAsync(int id)
    {
        PhysicalProduct? existBaseProduct = await CheckEntityIsFound(id);
        return ObjectMapper.Map<PhysicalProduct, PhysicalProductDto>(existBaseProduct);
    }

    public async Task<PagedResultDto<PhysicalProductDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        var result = await _repository.GetPagedListAsync(input.SkipCount, input.MaxResultCount, input.Sorting);

        var baseProductBaseDto = ObjectMapper.Map<List<PhysicalProduct>, List<PhysicalProductDto>>(result);

        return new PagedResultDto<PhysicalProductDto>
        {
            Items = baseProductBaseDto,
            TotalCount = baseProductBaseDto.Count
        };
    }
    public async Task<PhysicalProductDto> UpdateAsync(int id, CreateUpdatePhysicalProductDto input)
    {
        PhysicalProduct? existBaseProduct = await CheckEntityIsFound(id);

        var updateBaseProduct = ObjectMapper.Map<CreateUpdatePhysicalProductDto, PhysicalProduct>(input, existBaseProduct);

        var result = await _repository.UpdateAsync(updateBaseProduct);

        return ObjectMapper.Map<PhysicalProduct, PhysicalProductDto>(updateBaseProduct);
        throw new NotImplementedException();
    }

    private async Task<PhysicalProduct> CheckEntityIsFound(int id)
    {
        var existBaseProduct = await _repository.FirstOrDefaultAsync(x => x.Id == id);
        if (existBaseProduct == null)
            throw new EntityNotFoundException(typeof(PhysicalProduct));
        return existBaseProduct;
    }

}
