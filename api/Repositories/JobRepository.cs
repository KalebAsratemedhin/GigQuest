using api.Data;
using api.Dtos.Job;
using api.Interfaces;
using api.Mappers;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class JobRepository : IJobRepository
    {
        private readonly ApplicationDBContext _context;
        public JobRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<Job> Create(CreateJobDto createJobDto)
        {
            var newJob = createJobDto.ToModel();
            
            await _context.Jobs.AddAsync(newJob);
            await _context.SaveChangesAsync();

            System.Console.WriteLine(newJob + "new job");
            return newJob;
        }

        public async Task<List<Job>> GetAll()
        {
            return await _context.Jobs.Include(job => job.Company).ToListAsync();
        }

        public async Task<Job?> GetById(int Id)
        {
            return await _context.Jobs.Include(job => job.Company).FirstOrDefaultAsync(job => job.Id == Id);

        }
    }
}