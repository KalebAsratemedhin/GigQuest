using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Company;
using api.Models;

namespace api.Mappers
{
    public static class CompanyMappers
    {
        public static CompanyDto ToDto(this Company company)
        {
            return new CompanyDto{
                Id = company.Id,
                Name = company.Name,
                Description = company.Description,
                ContactEmail = company.ContactEmail,
                ContactPhone = company.ContactPhone
            };
        }


        public static Company ToModel(this CreateCompanyDto companyDto)
        {
            return new Company{
                Name = companyDto.Name,
                Description = companyDto.Description,
                ContactEmail = companyDto.ContactEmail,
                ContactPhone = companyDto.ContactPhone
            };
        }
    }
}