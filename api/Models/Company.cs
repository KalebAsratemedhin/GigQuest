using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Company
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ContactEmail { get; set; }
        public required string ContactPhone { get; set; }

        public List<Job> Jobs { get; set; } = new List<Job>();

    }
}