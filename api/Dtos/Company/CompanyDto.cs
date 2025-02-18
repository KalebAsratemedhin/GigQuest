
using api.Dtos.Job;

namespace api.Dtos.Company
{
    public class CompanyDto
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ContactEmail { get; set; }
        public required string ContactPhone { get; set; }

        public List<JobDto> Jobs {get; set;}
    }
}