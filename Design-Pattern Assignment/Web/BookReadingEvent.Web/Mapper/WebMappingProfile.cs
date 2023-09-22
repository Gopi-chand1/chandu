using AutoMapper;
using BookReadingEvent.ProductDomain.AppServices.DTOs;
using BookReadingEvent.Web.Models;

namespace BookReadingEvent.Web.Mapper
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile() : base("WebMappingProfile")
        {
            CreateMap<ProductViewModel, ProductDTO>().ReverseMap();
            CreateMap<CreateEventDTO, Event>();
            CreateMap<Comment, CommentDTO>();
            CreateMap<CommentDTO, Comment>();
        }
    }
}
