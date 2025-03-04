namespace api.Models
{
    public class Job
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Type { get; set; }
        public required string Description { get; set; }
        public required string Salary { get; set; }

        public int CompanyId { get; set; }
        
        public Company? Company { get; set; }
  
    }
}