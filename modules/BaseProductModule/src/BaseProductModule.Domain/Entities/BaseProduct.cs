using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.Domain.Entities.Auditing;

namespace BaseProductModule.Entities;
/// <summary>
/// Represents the base product entity with full auditing features.
/// </summary>
public class BaseProduct : FullAuditedEntity<int> , IHasExtraProperties
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Discriminator { get; set; } = string.Empty;
    public ExtraPropertyDictionary ExtraProperties { get; set; }

}
