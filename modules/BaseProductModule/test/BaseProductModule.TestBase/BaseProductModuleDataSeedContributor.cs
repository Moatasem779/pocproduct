using BaseProductModule.Entities;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;
using Volo.Abp.MultiTenancy;

namespace BaseProductModule;

public class BaseProductModuleDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly IGuidGenerator _guidGenerator;
    private readonly ICurrentTenant _currentTenant;
    private readonly IRepository<BaseProduct, int> _productRepostory;


    public BaseProductModuleDataSeedContributor(
        IGuidGenerator guidGenerator, ICurrentTenant currentTenant, IRepository<BaseProduct, int> productRepostory)
    {
        _guidGenerator = guidGenerator;
        _currentTenant = currentTenant;
        _productRepostory = productRepostory;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        /* Instead of returning the Task.CompletedTask, you can insert your test data
         * at this point!
         */
        if(! await _productRepostory.AnyAsync())
        {
            var products = new List<BaseProduct>{
                new BaseProduct { Name = "Laptop", Description = "High-end gaming laptop", Price = 1500.99m ,   ExtraProperties = new ExtraPropertyDictionary
                                {
                                    ["Brand"] = "ASUS"
                                }},
                new BaseProduct { Name = "Smartphone", Description = "Latest smartphone with AI features", Price = 999.99m ,   ExtraProperties =new ExtraPropertyDictionary
                                {
                                    ["Brand"] = "DELL"
                                } },
                new BaseProduct { Name = "Tablet", Description = "Lightweight tablet for work and play", Price = 499.49m  ,   ExtraProperties =new ExtraPropertyDictionary
                                {
                                    ["Brand"] = "HP"
                                }},

            };
            await _productRepostory.InsertManyAsync(products);
        }
    }
}
