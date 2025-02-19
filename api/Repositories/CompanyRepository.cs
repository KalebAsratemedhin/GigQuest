using api.Data;
using api.Dtos.Company;
using api.Interfaces;
using api.Mappers;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ApplicationDBContext _context;
        public CompanyRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<Company> Create(CreateCompanyDto createCompanyDto)
        {
            var newCompany = createCompanyDto.ToModel();
            await _context.Companies.AddAsync(newCompany);
            await _context.SaveChangesAsync();
            return newCompany;
        }

        public async Task<List<Company>> GetAll()
        {
            return await _context.Companies.Include(company => company.Jobs).ToListAsync();
        }

        public async Task<Company?> GetById(int Id)
        {
            return await _context.Companies.Include(company => company.Jobs).FirstOrDefaultAsync(company => company.Id == Id);

        }
    }
}