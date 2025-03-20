using BaseProductModule.BaseProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;

namespace PhysicalProductModule.PhysicalProducts;
public class PhysicalProductDto : BaseProductDto , IHasExtraProperties
{
    public int Stock {  get; set; }
    public ExtraPropertyDictionary ExtraProperties { get; set; }


}
