using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace PhysicalProductModule.PhysicalProducts;
public interface IPhysicalProductAppService : IApplicationService
{
    Task<PhysicalProductDto> CreateAsync(CreateUpdatePhysicalProductDto input);

    Task DeleteAsync(int id);
    Task<PhysicalProductDto> GetAsync(int id);

    Task<PagedResultDto<PhysicalProductDto>> GetListAsync(PagedAndSortedResultRequestDto input);
    Task<PhysicalProductDto> UpdateAsync(int id, CreateUpdatePhysicalProductDto input);
}
