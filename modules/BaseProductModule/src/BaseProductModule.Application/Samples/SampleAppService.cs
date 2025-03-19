//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Authorization;

//namespace BaseProductModule.Samples;

//public class SampleAppService : BaseProductModuleAppService, ISampleAppService
//{
//    public Task<SampleDto> GetAsync()
//    {
//        return Task.FromResult(
//            new SampleDto
//            {
//                Value = 42
//            }
//        );
//    }

//    [Authorize]
//    public Task<SampleDto> GetAuthorizedAsync()
//    {
//        return Task.FromResult(
//            new SampleDto
//            {
//                Value = 42
//            }
//        );
//    }
//}
