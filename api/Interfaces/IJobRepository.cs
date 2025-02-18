using api.Dtos.Job;
using api.Models;
namespace api.Interfaces
{
    public interface IJobRepository
    {
        public Task<List<Job>> GetAll();
        public Task<Job> GetById(int Id);
        public Task<Job?> Create(CreateJobDto createJobDto);
 

    }
}