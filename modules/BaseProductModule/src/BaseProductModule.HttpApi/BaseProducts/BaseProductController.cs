using BaseProductModule.Samples;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace BaseProductModule.BaseProducts;

[Area(BaseProductModuleRemoteServiceConsts.ModuleName)]
[RemoteService(Name = BaseProductModuleRemoteServiceConsts.RemoteServiceName)]
[Route("api/BaseProductModule/baseproduct")]
public class BaseProductController : BaseProductModuleController, IBaseProductAppService
{
    private readonly IBaseProductAppService _baseproductAppService;

    public BaseProductController(IBaseProductAppService baseproductAppService)
    {
        _baseproductAppService = baseproductAppService;
    }

    [HttpPost]
    public async Task<BaseProductDto> CreateAsync(CreateUpdateBaseProductDto input)
    {
       return await _baseproductAppService.CreateAsync(input);
    }

    [HttpDelete("deletebaseproducts/{id}")]

    public Task DeleteAsync(int id)
    {
        return _baseproductAppService.DeleteAsync(id);
    }
    [HttpGet("getbaseproduct/{id}")]

    public Task<BaseProductDto> GetAsync(int id)
    {
        return _baseproductAppService.GetAsync(id);
    }
    [HttpGet("getbaseproducts")]
    public Task<PagedResultDto<BaseProductDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        return _baseproductAppService.GetListAsync(input);
    }
    [HttpPatch("updatebaseproduct/{id}")]
    public Task<BaseProductDto> UpdateAsync(int id, CreateUpdateBaseProductDto input)
    {
        return _baseproductAppService.UpdateAsync(id, input);
    }
}
