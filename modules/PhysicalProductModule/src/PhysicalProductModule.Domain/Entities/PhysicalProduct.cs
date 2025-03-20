using BaseProductModule.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;

namespace PhysicalProductModule.Entities;
public class PhysicalProduct : BaseProduct , IHasExtraProperties
{
    public int Stock {  get; set; }

    public ExtraPropertyDictionary ExtraProperties { get; set; }
}
