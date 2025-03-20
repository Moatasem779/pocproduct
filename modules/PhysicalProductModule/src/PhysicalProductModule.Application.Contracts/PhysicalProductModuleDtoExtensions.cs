using BaseProductModule.BaseProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;

namespace PhysicalProductModule;

public static class PhysicalProductModuleDtoExtensions
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        OneTimeRunner.Run(() =>
        {
            /* You can add extension properties to DTOs
             * defined in the depended modules.
             *
             * Example:
             *
             * ObjectExtensionManager.Instance
             *   .AddOrUpdateProperty<IdentityRoleDto, string>("Title");
             *
             * See the documentation for more:
             * https://docs.abp.io/en/abp/latest/Object-Extensions
             */

            ObjectExtensionManager.Instance.AddOrUpdateProperty<BaseProductDto, int>("Stock");
            ObjectExtensionManager.Instance.AddOrUpdateProperty<CreateUpdateBaseProductDto, int>("Stock");


        });
    

    }
}
