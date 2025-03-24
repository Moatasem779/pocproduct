using AutoMapper;
using BaseProductModule.BaseProducts;
using BaseProductModule.Entities;
using PhysicalProductModule.Entities;
using PhysicalProductModule.PhysicalProducts;

namespace PhysicalProductModule;

/// <summary>
/// AutoMapper profile for mapping between PhysicalProduct-related DTOs and entities.
/// </summary>
public class PhysicalProductModuleApplicationAutoMapperProfile : Profile
{
    /// <summary>
    /// Constructor of the <see cref="PhysicalProductModuleApplicationAutoMapperProfile"/> class.
    /// Defines mapping configurations for PhysicalProduct entities and DTOs.
    /// </summary>
    public PhysicalProductModuleApplicationAutoMapperProfile()
    {
        /// <summary>
        /// Maps <see cref="CreateUpdatePhysicalProductDto"/> to <see cref="PhysicalProductDto"/>.
        /// Ignores audit properties and identity fields.
        /// </summary>
        CreateMap<CreateUpdatePhysicalProductDto, PhysicalProductDto>()
            .ForMember(dest => dest.LastModificationTime, opt => opt.Ignore())
            .ForMember(dest => dest.LastModifierId, opt => opt.Ignore())
            .ForMember(dest => dest.CreationTime, opt => opt.Ignore())
            .ForMember(dest => dest.CreatorId, opt => opt.Ignore())
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ReverseMap();

        /// <summary>
        /// Maps <see cref="CreateUpdatePhysicalProductDto"/> to <see cref="PhysicalProduct"/>.
        /// Ignores soft-delete and audit properties.
        /// </summary>
        CreateMap<CreateUpdatePhysicalProductDto, PhysicalProduct>()
            .ForMember(dest => dest.IsDeleted, opt => opt.Ignore())
            .ForMember(dest => dest.DeleterId, opt => opt.Ignore())
            .ForMember(dest => dest.DeletionTime, opt => opt.Ignore())
            .ForMember(dest => dest.LastModificationTime, opt => opt.Ignore())
            .ForMember(dest => dest.CreationTime, opt => opt.Ignore())
            .ForMember(dest => dest.CreatorId, opt => opt.Ignore())
            .ForMember(dest => dest.LastModifierId, opt => opt.Ignore())
            .ForMember(dest => dest.Discriminator, opt => opt.Ignore())
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ReverseMap();

        /// <summary>
        /// Maps <see cref="PhysicalProduct"/> to <see cref="PhysicalProductDto"/>.
        /// </summary>
        CreateMap<PhysicalProduct, PhysicalProductDto>()
            .ReverseMap();

        /// <summary>
        /// Maps <see cref="BaseProductDto"/> to <see cref="PhysicalProductDto"/>.
        /// </summary>
        CreateMap<BaseProductDto, PhysicalProductDto>()
            .ReverseMap();        
        ///
        CreateMap<BaseProduct, PhysicalProductDto>()
            .ReverseMap();

    }
}

