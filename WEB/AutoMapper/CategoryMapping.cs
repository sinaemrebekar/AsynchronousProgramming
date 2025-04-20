using AutoMapper;
using Core.Entities.Concrete;
using WEB.ExtensionsMethods;
using WEB.Models.CategoryViewModels;

namespace WEB.AutoMapper
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<GetCategoryVM, Category>().ReverseMap()
                .ForMember(desc => desc.UpdatedDate, 
                           source => source.MapFrom
                           (
                               x => x.UpdatedDate.HasValue ? x.UpdatedDate.ToString() : " - ")
                           )
                .ForMember(desc => desc.Status, 
                           source => source.MapFrom
                           (
                               x => x.Status.GetDisplayName())
                           );

            CreateMap<CreateCategoryVM, Category>().ReverseMap();
            CreateMap<UpdateCategoryVM, Category>().ReverseMap();
        }
    }
}
