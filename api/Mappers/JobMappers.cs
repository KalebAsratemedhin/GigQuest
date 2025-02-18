using api.Dtos.Job;
using api.Models;

namespace api.Mappers
{
    public static class JobMappers
    {
        public static JobDto ToDto(this Job job)
        {
            return new JobDto{
                Id = job.Id,
                Title = job.Title,
                Type = job.Type,
                Description = job.Description,
                Salary = job.Salary,
                CompanyId = job.CompanyId
            };
        }

        public static Job ToModel(this CreateJobDto jobDto)
        {
            return new Job{
                Title = jobDto.Title,
                Type = jobDto.Type,
                Description = jobDto.Description,
                Salary = jobDto.Salary,
                CompanyId = jobDto.CompanyId
            };
        }
    }
}