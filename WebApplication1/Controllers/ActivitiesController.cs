using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using WebApplication1.Respository;

namespace WebApplication1.Controllers
{
    public class ActivitiesController : ApiController
    {
        GitHubActivitiesRepository repository;

        public ActivitiesController()
        {
            repository = new GitHubActivitiesRepository();
        }

        public IEnumerable<GitHubActivity> GetAllActivities()
        {
            return repository.GetAllActivities();
        }

        public IEnumerable<GitHubActivity> GetActivitiesAfter(int id)
        {
            return repository.GetActivitiesAfter(id);
        }
    }
}
