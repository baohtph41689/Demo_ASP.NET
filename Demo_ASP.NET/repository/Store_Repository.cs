using AutoMapper;
using Demo_ASP.NET.Models;
using Demo_ASP.NET.viewModel;
using Microsoft.EntityFrameworkCore;

namespace Demo_ASP.NET.repository
{
    public class Store_Repository : IstoreRepository
    {
        // luu tru 1 instance cua storecontext, mot lop dbcontex tuong tac vs csdl
        private readonly storeContext _context; 
        // luu tru 1 instance cua imapper  map giua model va view model
        private readonly IMapper _mapper;

        public Store_Repository(storeContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }
        public Task<viewProduct> AddPro(product model)
        {
            throw new NotImplementedException();
        }

        public Task DeletePro(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<viewProduct>> GetAll()
        {
           //var listPro = await _context.Products.ToListAsync();
            var listPro =   _context.Products.Select( pro => new viewProduct { 
                  Name =   pro.Name,
                Description = pro.Description,
                  Price = pro.Price,
                  CategoryId = pro.CategoryId
            }).ToList();
            // Ánh xạ các đối tượng Product thành viewProduct
            var viewProducts = _mapper.Map<List<viewProduct>>(listPro);
            return viewProducts;
        }

        public Task<viewProduct> GetPro(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePro(int id, viewProduct model)
        {
            throw new NotImplementedException();
        }
    }
}
