using AutoMapper;
using BaseProductModule.BaseProducts;
using BaseProductModule.Entities;
using PhysicalProductModule.Entities;
using PhysicalProductModule.PhysicalProducts;

namespace PhysicalProductModule;

public class PhysicalProductModuleApplicationAutoMapperProfile : Profile
{
    public PhysicalProductModuleApplicationAutoMapperProfile()
    {
        CreateMap<CreateUpdatePhysicalProductDto, PhysicalProductDto>()
         .ForMember(dest => dest.LastModificationTime, opt => opt.Ignore())
         .ForMember(dest => dest.LastModifierId, opt => opt.Ignore())
        .ForMember(dest => dest.CreationTime, opt => opt.Ignore())
        .ForMember(dest => dest.CreatorId, opt => opt.Ignore())
        .ForMember(dest => dest.Id, opt => opt.Ignore()).ReverseMap();
        CreateMap<CreateUpdatePhysicalProductDto, PhysicalProduct>()
            .ForMember(dest => dest.IsDeleted, opt => opt.Ignore())
            .ForMember(dest => dest.DeleterId, opt => opt.Ignore())
            .ForMember(dest => dest.DeletionTime, opt => opt.Ignore())
             .ForMember(dest => dest.LastModificationTime, opt => opt.Ignore())
            .ForMember(dest => dest.CreationTime, opt => opt.Ignore())
            .ForMember(dest => dest.CreatorId, opt => opt.Ignore())
            .ForMember(dest => dest.LastModifierId, opt => opt.Ignore())
            .ForMember(dest => dest.Id, opt => opt.Ignore()).ReverseMap();
        CreateMap<PhysicalProduct, PhysicalProductDto>().ReverseMap();


        CreateMap<BaseProductDto, PhysicalProductDto>()
            .MapExtraProperties().ReverseMap();

        CreateMap<CreateUpdateBaseProductDto, PhysicalProduct>()
            .MapExtraProperties().ReverseMap();
    }
}
