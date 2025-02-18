using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Job
{
    public class CreateJobDto
    {
        public required string Title { get; set; }
        public required string Type { get; set; }
        public required string Description { get; set; }
        public required string Salary { get; set; }
        public int CompanyId { get; set; }
        
    }
}