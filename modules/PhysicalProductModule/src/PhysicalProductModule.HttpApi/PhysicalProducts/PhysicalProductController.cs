using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
namespace PhysicalProductModule.PhysicalProducts;
[Area(PhysicalProductModuleRemoteServiceConsts.ModuleName)]
[RemoteService(Name = PhysicalProductModuleRemoteServiceConsts.RemoteServiceName)]
[Route("api/PhysicalProductModule/sample")]
public class PhysicalProductController : PhysicalProductModuleController
{
    private readonly IPhysicalProductAppService _physicalProductAppService;

    public PhysicalProductController(IPhysicalProductAppService physicalProductAppService)
    {
        _physicalProductAppService = physicalProductAppService;
    }

    [HttpPost("createphysicalproduct")]
    public async Task<IActionResult> CreateAsync(CreateUpdatePhysicalProductDto input)
    {
        var result = await _physicalProductAppService.CreateAsync(input);

        return result == null ? BadRequest() : Ok(result);
    }
    [HttpGet("deletephysicalproduct/{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
       await _physicalProductAppService.DeleteAsync(id);

       return Ok();
    }
    [HttpGet("getphysicalproduct/{id}")]
    public async Task<IActionResult> GetAsync(int id)
    {
        var result = await _physicalProductAppService.GetAsync(id);

        return result == null ? BadRequest() : NoContent();
    }
    [HttpGet("getallphysicalproduct")]
    public async Task<IActionResult> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        var result = await _physicalProductAppService.GetListAsync(input);

        return result.TotalCount == 0 ? BadRequest() : Ok(result);  
    }
    [HttpGet("updatephysicalproduct/{id}")]
    public async  Task<IActionResult> UpdateAsync(int id, CreateUpdatePhysicalProductDto input)
    {
        var result = await _physicalProductAppService.UpdateAsync(id , input);

        return result == null ? BadRequest() : NoContent();
    }
}
