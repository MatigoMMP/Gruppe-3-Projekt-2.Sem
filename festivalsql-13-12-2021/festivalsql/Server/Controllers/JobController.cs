using System;
using System.Linq;
using System.Collections.Generic;
using festivalsql.Shared.Models;
using festivalsql.Client.Services;
using Microsoft.AspNetCore.Mvc;

namespace festivalsql.Server.Controllers
{
    public class JobController : Controller
    {
        private readonly JobService _jobService = new();

        [Route("api/job")]
        [HttpGet]
        public IEnumerable<Job> GetJobs()
        {
            return _jobService.GetAllJobs();
        }

        [Route("api/job/detail/{id}")]
        [HttpGet("detail/{id}")]
        public Job GetJobData(int id)
        {
            return _jobService.GetJobData(id);
        }

        [Route("api/job/create")]
        [HttpPost]
        public void Post([FromBody] Job job)
        {
            if (ModelState.IsValid)
            {
                _jobService.AddJob(job);
            }
        }

        [Route("api/job/edit")]
        [HttpPut("edit")]
        public void Put([FromBody] Job job)
        {
            if (ModelState.IsValid)
            {
                _jobService.UpdateJob(job);
            }
        }

        [Route("api/job/delete{id}")]
        [HttpDelete("delete({id}")]
        public void DeleteJob(int id)
        {
            _jobService.DeleteJob(id);
        }
    }
}
