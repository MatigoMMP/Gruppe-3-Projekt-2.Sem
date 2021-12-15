using System;
using Microsoft.EntityFrameworkCore;
using festivalsql.Shared.Models;
using System.Linq;
using System.Collections.Generic;

namespace festivalsql.Client.Services
{
    public class JobService
    {
        private readonly FestivalContext _jobs = new();

        public IEnumerable<Job> GetAllJobs()
        {
            try
            {
                return _jobs.opgave.ToList();
            }
            catch { throw; }
        }

        public void AddJob(Job job)
        {
            try
            {
                _jobs.opgave.Add(job);
                _jobs.SaveChanges();
            }
            catch { throw; }
        }

        public void UpdateJob(Job job)
        {
            try
            {
                _jobs.Entry(job).State = EntityState.Modified;
                _jobs.SaveChanges();
            }
            catch { throw; }
        }

        public Job GetJobData(int id)
        {
            try
            {
                return _jobs.opgave
                    .First(job => job.opgave_id == id);
            }
            catch { throw; }
        }

        public void DeleteJob(int id)
        {
            try
            {
                var entity = _jobs.opgave.First(job => job.opgave_id == id);
                _jobs.opgave.Remove(entity);
                _jobs.SaveChanges();
            }
            catch { throw; }
        }
    }

    public class JobDetailService
    {
        private readonly FestivalContext _jobDetails = new();

        public IEnumerable<JobDetail> GetAllJobDetails()
        {
            try
            {
                return _jobDetails.opgavedetalje.ToList();
            }
            catch { throw; }
        }
    }

    public class PlaceService
    {
        private readonly FestivalContext _places = new();

        public IEnumerable<Place> GetAllPlaces()
        {
            try
            {
                return _places.placering.ToList();
            }
            catch { throw; }
        }
    }

    public class StatusService
    {
        private readonly FestivalContext _statuses = new();

        public IEnumerable<Status> GetAllStatuses()
        {
            try
            {
                return _statuses.status.ToList();
            }
            catch { throw; }
        }
    }
}
