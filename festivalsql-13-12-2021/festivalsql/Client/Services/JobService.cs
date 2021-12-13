using System;
using Microsoft.EntityFrameworkCore;
using festivalsql.Shared.Models;
using System.Linq;
using System.Collections.Generic;

namespace festivalsql.Client.Services
{
    public class JobService
    {
        FestivalContext jc = new FestivalContext();

        public IEnumerable<Job> GetAllJobs()
        {
            try
            {
                return jc.opgave.ToList();
            }
            catch { throw; }
        }

        public void AddJob(Job job)
        {
            try
            {
                jc.opgave.Add(job);
                jc.SaveChanges();
            }
            catch { throw; }
        }

        public void UpdateJob(Job job)
        {
            try
            {
                jc.Entry(job).State = EntityState.Modified;
                jc.SaveChanges();
            }
            catch { throw; }
        }

        public Job GetJobData(int id)
        {
            try
            {
                return jc.opgave.First(job => job.opgave_id == id);
            }
            catch { throw; }
        }

        public void DeleteJob(int id)
        {
            try
            {
                var entity = jc.opgave.First(job => job.opgave_id == id);
                jc.opgave.Remove(entity);
                jc.SaveChanges();
            }
            catch { throw; }
        }
    }
}
