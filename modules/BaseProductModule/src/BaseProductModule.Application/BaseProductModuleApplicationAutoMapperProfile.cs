using AutoMapper;
using BaseProductModule.BaseProducts;
using BaseProductModule.Entities;

namespace BaseProductModule;

public class BaseProductModuleApplicationAutoMapperProfile : Profile
{
    public BaseProductModuleApplicationAutoMapperProfile()
    {

        CreateMap<CreateUpdateBaseProductDto, BaseProductDto>()
             .ForMember(dest => dest.LastModificationTime, opt => opt.Ignore())
             .ForMember(dest => dest.LastModifierId, opt => opt.Ignore())
            .ForMember(dest => dest.CreationTime, opt => opt.Ignore())
            .ForMember(dest => dest.CreatorId, opt => opt.Ignore())
            .ForMember(dest => dest.Id, opt => opt.Ignore()).ReverseMap();
        CreateMap<CreateUpdateBaseProductDto, BaseProduct>()
            .ForMember(dest => dest.IsDeleted, opt => opt.Ignore())
            .ForMember(dest => dest.DeleterId, opt => opt.Ignore())
            .ForMember(dest => dest.DeletionTime, opt => opt.Ignore())
             .ForMember(dest => dest.LastModificationTime, opt => opt.Ignore())
            .ForMember(dest => dest.CreationTime, opt => opt.Ignore())
            .ForMember(dest => dest.CreatorId, opt => opt.Ignore())
            .ForMember(dest => dest.LastModifierId, opt => opt.Ignore())
            .ForMember(dest => dest.Discriminator, opt => opt.Ignore())
            .ForMember(dest => dest.Id, opt => opt.Ignore()).ReverseMap();
        CreateMap<BaseProduct, BaseProductDto>()
            .MapExtraProperties().ReverseMap() ;
    }
}
