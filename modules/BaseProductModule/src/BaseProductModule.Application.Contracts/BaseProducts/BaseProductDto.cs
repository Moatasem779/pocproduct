﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Data;

namespace BaseProductModule.BaseProducts;
/// <summary>
/// Data transfer object (DTO) for base products, including audit information.
/// </summary>
public class BaseProductDto : AuditedEntityDto<int> , IHasExtraProperties
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }

    public ExtraPropertyDictionary ExtraProperties { get; set; }
}
