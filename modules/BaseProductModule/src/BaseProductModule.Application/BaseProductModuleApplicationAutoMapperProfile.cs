using AutoMapper;
using BaseProductModule.BaseProducts;
using BaseProductModule.Entities;

namespace BaseProductModule;

/// <summary>
/// AutoMapper profile for mapping between BaseProduct-related DTOs and entities.
/// </summary>
public class BaseProductModuleApplicationAutoMapperProfile : Profile
{
    /// <summary>
    /// Constructor of the <see cref="BaseProductModuleApplicationAutoMapperProfile"/> class.
    /// Defines mapping configurations for BaseProduct entities and DTOs.
    /// </summary>
    public BaseProductModuleApplicationAutoMapperProfile()
    {
        /// <summary>
        /// Maps <see cref="CreateUpdateBaseProductDto"/> to <see cref="BaseProductDto"/>.
        /// Ignores audit properties and identity fields.
        /// </summary>
        CreateMap<CreateUpdateBaseProductDto, BaseProductDto>()
             .ForMember(dest => dest.LastModificationTime, opt => opt.Ignore())
             .ForMember(dest => dest.LastModifierId, opt => opt.Ignore())
             .ForMember(dest => dest.CreationTime, opt => opt.Ignore())
             .ForMember(dest => dest.CreatorId, opt => opt.Ignore())
             .ForMember(dest => dest.Id, opt => opt.Ignore())
             
             .ReverseMap();

        /// <summary>
        /// Maps <see cref="CreateUpdateBaseProductDto"/> to <see cref="BaseProduct"/>.
        /// Ignores soft-delete and audit properties.
        /// </summary>
        CreateMap<CreateUpdateBaseProductDto, BaseProduct>()
            .ForMember(dest => dest.IsDeleted, opt => opt.Ignore())
            .ForMember(dest => dest.DeleterId, opt => opt.Ignore())
            .ForMember(dest => dest.DeletionTime, opt => opt.Ignore())
            .ForMember(dest => dest.LastModificationTime, opt => opt.Ignore())
            .ForMember(dest => dest.CreationTime, opt => opt.Ignore())
            .ForMember(dest => dest.CreatorId, opt => opt.Ignore())
            .ForMember(dest => dest.LastModifierId, opt => opt.Ignore())
            .ForMember(dest => dest.Discriminator, opt => opt.Ignore())
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .MapExtraProperties()
            .ReverseMap();

        /// <summary>
        /// Maps <see cref="BaseProduct"/> to <see cref="BaseProductDto"/>.
        /// Includes extra property mappings.
        /// </summary>
        CreateMap<BaseProduct, BaseProductDto>()
            .MapExtraProperties()
            .ReverseMap();
    }
}

