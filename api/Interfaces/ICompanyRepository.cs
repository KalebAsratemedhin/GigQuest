using api.Dtos.Company;
using api.Models;

namespace api.Interfaces
{
    public interface ICompanyRepository
    {
        public Task<List<Company>> GetAll();
        public Task<Company> GetById(int Id);
        public Task<Company?> Create(CreateCompanyDto createCompanyDto);
 
    }
}