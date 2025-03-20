﻿using BaseProductModule.BaseProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;

namespace PhysicalProductModule.PhysicalProducts;
/// <summary>
/// Data transfer object (DTO) for creating or updating a physical product.
/// Inherits properties from <see cref="CreateUpdateBaseProductDto"/>.
/// </summary>
public class CreateUpdatePhysicalProductDto : CreateUpdateBaseProductDto
{
}
