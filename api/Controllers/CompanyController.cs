using api.Dtos.Company;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/companies")]
    [ApiController]
     
    public class CompanyController: ControllerBase
    {
        private readonly ICompanyRepository  _companyRepo;

        public CompanyController(ICompanyRepository companyRepo)
        {
            _companyRepo = companyRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Companies = await _companyRepo.GetAll();
            var CompaniesDto = Companies.Select(company => company.ToCompanyDto());

            return Ok(CompaniesDto);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var company = await _companyRepo.GetById(id);

            if(company == null)
            {
                return NotFound();
            }

            return Ok(company.ToCompanyDto());

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCompanyDto createCompanyDto)
        {
            var company = await _companyRepo.Create(createCompanyDto);

            return CreatedAtAction(nameof(GetById), new {Id = company.Id}, company.ToCompanyDto());

        }
    }

}
