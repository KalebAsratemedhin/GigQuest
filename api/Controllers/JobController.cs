using api.Dtos.Job;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/jobs")]
    [ApiController]
    public class JobController: ControllerBase
    {
        private readonly IJobRepository  _jobRepo;

        public JobController(IJobRepository jobRepo)
        {
            _jobRepo = jobRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var jobs = await _jobRepo.GetAll();
            var jobsDto = jobs.Select(job => job.ToJobDto());

            return Ok(jobsDto);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var job = await _jobRepo.GetById(id);

            if(job == null)
            {
                return NotFound();
            }

            return Ok(job.ToJobDto());

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateJobDto createJobDto)
        {
            var job = await _jobRepo.Create(createJobDto);

            return CreatedAtAction(nameof(GetById), new {Id = job.Id}, job.ToJobDto());

        }
    }

}
