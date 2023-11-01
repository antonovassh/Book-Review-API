using AutoMapper;
using BookReviewAPI.Dto;
using BookRewiewAPI.Models;

namespace BookReviewAPI.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Book, BookDto>()
                .ReverseMap();
            CreateMap <Category, CategoryDto>()
                .ReverseMap();
            CreateMap<Country, CountryDto>()
                .ReverseMap() ;
        }
    }
}
