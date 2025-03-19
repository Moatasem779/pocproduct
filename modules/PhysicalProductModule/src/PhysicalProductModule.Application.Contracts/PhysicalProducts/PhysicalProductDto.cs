using BaseProductModule.BaseProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalProductModule.PhysicalProducts;
/// <summary>
/// Data transfer object (DTO) for physical products.
/// Inherits properties from <see cref="BaseProductDto"/>.
/// </summary>
public class PhysicalProductDto : BaseProductDto
{
    public int Stock {  get; set; }
}
