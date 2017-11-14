using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Respository
{
    public class GitHubActivitiesRepository : IDisposable
    {
        GitHubDbEntities context;

        public GitHubActivitiesRepository()
        {
            context = new GitHubDbEntities();
        }

        public List<GitHubActivity> GetAllActivities()
        {
            return context.GitHubActivities.ToList();
        }

        public List<GitHubActivity> GetActivitiesAfter(int activityId)
        {
            return context.GitHubActivities.Where(gha => gha.ActivityId > activityId).ToList();
        }

        public GitHubActivity AddNewActivity(GitHubActivity activity)
        {
            var activityAdded = context.GitHubActivities.Add(activity);
            context.SaveChanges();

            return activityAdded;
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}