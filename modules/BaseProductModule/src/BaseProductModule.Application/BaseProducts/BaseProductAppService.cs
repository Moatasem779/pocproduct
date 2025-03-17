﻿using BaseProductModule.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace BaseProductModule.BaseProducts;
public class BaseProductAppService : BaseProductModuleAppService, IBaseProductAppService 
{
    private readonly IRepository<BaseProduct, int> _repository;
    public BaseProductAppService(IRepository<BaseProduct, int> repository)
    {
        _repository = repository;
    }

    public async Task<BaseProductDto> CreateAsync(CreateUpdateBaseProductDto input)
    {
        var baseProduct = ObjectMapper.Map<CreateUpdateBaseProductDto, BaseProduct>(input);
        var result = await _repository.InsertAsync(baseProduct);
        return ObjectMapper.Map<BaseProduct, BaseProductDto>(result);
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(int id)
    {
        BaseProduct existBaseProduct = await CheckEntityIsFound(id);
        await _repository.DeleteAsync(existBaseProduct);
    }

    public async Task<BaseProductDto> GetAsync(int id)
    {
        BaseProduct? existBaseProduct = await CheckEntityIsFound(id);
        return ObjectMapper.Map<BaseProduct, BaseProductDto>(existBaseProduct);
    }

    public async Task<PagedResultDto<BaseProductDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        var result = await _repository.GetPagedListAsync(input.SkipCount , input.MaxResultCount , input.Sorting);

        var baseProductBaseDto = ObjectMapper.Map<List<BaseProduct>, List<BaseProductDto>>(result);

        return new PagedResultDto<BaseProductDto>
        {
            Items = baseProductBaseDto , 
            TotalCount = baseProductBaseDto.Count
        };

    }

    public async Task<BaseProductDto> UpdateAsync(int id, CreateUpdateBaseProductDto input)
    {
        BaseProduct? existBaseProduct = await CheckEntityIsFound(id);

        var updateBaseProduct = ObjectMapper.Map<CreateUpdateBaseProductDto, BaseProduct>(input, existBaseProduct);

        var result = await _repository.UpdateAsync(updateBaseProduct);

        return ObjectMapper.Map<BaseProduct, BaseProductDto>(updateBaseProduct);
        throw new NotImplementedException();   
    }

    private async Task<BaseProduct> CheckEntityIsFound(int id)
    {
        var existBaseProduct = await _repository.FirstOrDefaultAsync(x => x.Id == id);
        if (existBaseProduct == null)
            throw new EntityNotFoundException(typeof(BaseProduct));
        return existBaseProduct;
    }
}
