using BaseProductModule.BaseProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalProductModule.PhysicalProducts;
public class PhysicalProductDto : BaseProductDto
{
    public int Stock {  get; set; }
}
