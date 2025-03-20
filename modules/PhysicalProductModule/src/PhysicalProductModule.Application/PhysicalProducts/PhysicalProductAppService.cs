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

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IBaseProductAppService))]

public class PhysicalProductAppService  : PhysicalProductModuleAppService , IBaseProductAppService
{
    private readonly IRepository<PhysicalProduct, int> _repository;
    public PhysicalProductAppService(IRepository<PhysicalProduct, int> repository)
    {
        _repository = repository;
    }

    //public async Task<PhysicalProductDto> CreateAsync(CreateUpdatePhysicalProductDto input)
    //{
      
    //}

    public async Task<BaseProductDto> CreateAsync(CreateUpdateBaseProductDto input)
    {   var physicalProduct = ObjectMapper.Map<CreateUpdateBaseProductDto, PhysicalProduct>(input);
        var result = await _repository.InsertAsync(physicalProduct);
        return ObjectMapper.Map<PhysicalProduct, BaseProductDto>(result);
    }

    public async Task DeleteAsync(int id)
    {
        PhysicalProduct existBaseProduct = await CheckEntityIsFound(id);
        await _repository.DeleteAsync(existBaseProduct);
    }

    //public async Task<PhysicalProductDto> GetAsync(int id)
    //{
    //    PhysicalProduct? existBaseProduct = await CheckEntityIsFound(id);
    //    return ObjectMapper.Map<PhysicalProduct, PhysicalProductDto>(existBaseProduct);
    //}

    //public async Task<PagedResultDto<PhysicalProductDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    //{
    //    var result = await _repository.GetPagedListAsync(input.SkipCount, input.MaxResultCount, input.Sorting);

    //    var baseProductBaseDto = ObjectMapper.Map<List<PhysicalProduct>, List<PhysicalProductDto>>(result);

    //    return new PagedResultDto<PhysicalProductDto>
    //    {
    //        Items = baseProductBaseDto,
    //        TotalCount = baseProductBaseDto.Count
    //    };
    //}
    //public async Task<PhysicalProductDto> UpdateAsync(int id, CreateUpdatePhysicalProductDto input)
    //{
    //    PhysicalProduct? existBaseProduct = await CheckEntityIsFound(id);

    //    var updateBaseProduct = ObjectMapper.Map<CreateUpdatePhysicalProductDto, PhysicalProduct>(input, existBaseProduct);

    //    var result = await _repository.UpdateAsync(updateBaseProduct);

    //    return ObjectMapper.Map<PhysicalProduct, PhysicalProductDto>(updateBaseProduct);
    //    throw new NotImplementedException();
    //}

    public async Task<BaseProductDto> UpdateAsync(int id, CreateUpdateBaseProductDto input)
    {
        PhysicalProduct? existBaseProduct = await CheckEntityIsFound(id);

        var updateBaseProduct = ObjectMapper.Map<CreateUpdateBaseProductDto, PhysicalProduct>(input, existBaseProduct);

        var result = await _repository.UpdateAsync(updateBaseProduct);

        return ObjectMapper.Map<PhysicalProduct, BaseProductDto>(updateBaseProduct);
    }

    private async Task<PhysicalProduct> CheckEntityIsFound(int id)
    {
        var existBaseProduct = await _repository.FirstOrDefaultAsync(x => x.Id == id);
        if (existBaseProduct == null)
            throw new EntityNotFoundException(typeof(PhysicalProduct));
        return existBaseProduct;
    }

    public async Task<BaseProductDto> GetAsync(int id)
    {
        PhysicalProduct? existBaseProduct = await CheckEntityIsFound(id);
        return ObjectMapper.Map<PhysicalProduct, BaseProductDto>(existBaseProduct);
    }

    public async Task<PagedResultDto<BaseProductDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        var result = await _repository.GetPagedListAsync(input.SkipCount, input.MaxResultCount, input.Sorting);

        var baseProductBaseDto = ObjectMapper.Map<List<PhysicalProduct>, List<PhysicalProductDto>>(result);

        return new PagedResultDto<BaseProductDto>
        {
            Items = baseProductBaseDto,
            TotalCount = baseProductBaseDto.Count
        };
    }
}
