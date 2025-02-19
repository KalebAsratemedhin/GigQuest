
using api.Dtos.Company;

namespace api.Dtos.Job
{
    public class BasicJobDto
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Type { get; set; }
        public required string Description { get; set; }
        public required string Salary { get; set; }

    }
}