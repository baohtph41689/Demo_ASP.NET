using Demo_ASP.NET.Models;
using Demo_ASP.NET.viewModel;

namespace Demo_ASP.NET.repository
{
    public interface IstoreRepository
    {
        public Task<List<viewProduct>> GetAll();
        public Task<viewProduct> GetPro(int id);

        public Task<viewProduct> AddPro(product model);

        public Task UpdatePro(int id, viewProduct model);

        public Task DeletePro(int id);
    }
}
