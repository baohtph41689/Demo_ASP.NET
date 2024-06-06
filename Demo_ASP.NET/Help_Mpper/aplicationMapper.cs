using AutoMapper;
using Demo_ASP.NET.Models;
using Demo_ASP.NET.viewModel;
namespace Demo_ASP.NET.Help_Mpper
{
    public class aplicationMapper : Profile
    {
        public aplicationMapper()
        {
            CreateMap<product,viewProduct>().ReverseMap();
        }
    }
}
