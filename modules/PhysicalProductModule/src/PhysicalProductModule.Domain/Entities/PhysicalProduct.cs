using BaseProductModule.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalProductModule.Entities;
/// <summary>
/// Represents a physical product entity.
/// Inherits properties from <see cref="BaseProduct"/>.
/// </summary>
public class PhysicalProduct : BaseProduct
{
    public int Stock {  get; set; }
}
