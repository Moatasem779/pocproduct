using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace BaseProductModule.BaseProducts;
/// <summary>
/// Data transfer object for creating or updating a base product.
/// </summary>
public class CreateUpdateBaseProductDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
}