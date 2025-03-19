using BaseProductModule.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalProductModule.Entities;
public class PhysicalProduct : BaseProduct
{
    public int Stock {  get; set; }
}
