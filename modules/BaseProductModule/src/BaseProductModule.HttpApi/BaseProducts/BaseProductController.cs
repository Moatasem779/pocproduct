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
    public Task<BaseProductDto> CreateAsync(CreateUpdateBaseProductDto input)
    {
        throw new NotImplementedException();
    }

    [HttpDelete]

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
    [HttpGet("getbaseproduct/{id}")]

    public Task<BaseProductDto> GetAsync(int id)
    {
        throw new NotImplementedException();
    }
    [HttpGet]
    public Task<PagedResultDto<BaseProductDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        throw new NotImplementedException();
    }
    [HttpPatch("updatebaseproduct/{id}")]
    public Task<BaseProductDto> UpdateAsync(int id, CreateUpdateBaseProductDto input)
    {
        throw new NotImplementedException();
    }
}
