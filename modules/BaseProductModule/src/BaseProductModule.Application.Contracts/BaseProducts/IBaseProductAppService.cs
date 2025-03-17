using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace BaseProductModule.BaseProducts;
public interface IBaseProductAppService : IApplicationService 
{
    Task<BaseProductDto> CreateAsync(CreateUpdateBaseProductDto input);

    Task DeleteAsync(int id);
    Task<BaseProductDto> GetAsync(int id);

    Task<PagedResultDto<BaseProductDto>> GetListAsync(PagedAndSortedResultRequestDto input);
    Task<BaseProductDto> UpdateAsync(int id, CreateUpdateBaseProductDto input);

}
