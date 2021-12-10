using System;
using System.Linq;
using System.Collections.Generic;
using festivalsql.Server.Data;
using festivalsql.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace festivalsql.Server.Controllers
{
    public class JobController : Controller
    {
        private JobDbOperations DbOperations = new JobDbOperations();

        [Route("api/job")]
        [HttpGet]
        public IEnumerable<Job> GetJobs()
        {
            return DbOperations.GetAllJobs();
        }

        [Route("api/job/detail/{id}")]
        [HttpGet("detail/{id}")]
        public Job GetJobData(int id)
        {
            return DbOperations.GetJobData(id);
        }

        [Route("api/job/create")]
        [HttpPost]
        public void Post([FromBody] Job job)
        {
            if (ModelState.IsValid)
            {
                DbOperations.AddJob(job);
            }
        }

        [Route("api/job/edit")]
        [HttpPut("edit")]
        public void Put([FromBody] Job job)
        {
            if (ModelState.IsValid)
            {
                DbOperations.UpdateJob(job);
            }
        }

        [Route("api/job/delete{id}")]
        [HttpDelete("delete({id}")]
        public void DeleteJob(int id)
        {
            DbOperations.DeleteJob(id);
        }
    }
}
