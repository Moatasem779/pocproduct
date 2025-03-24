using BaseProductModule.BaseProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;

namespace PhysicalProductModule.PhysicalProducts;
/// <summary>
/// Data transfer object (DTO) for physical products.
/// Inherits properties from <see cref="BaseProductDto"/>.
/// </summary>
public class PhysicalProductDto : BaseProductDto , IHasExtraProperties
{
    public ExtraPropertyDictionary ExtraProperties { get; set; }


}
