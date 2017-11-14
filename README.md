Back-End
########

I have added a webhook handler which will listen to the GitHub webhook I have created for one of my GitHub repositories.

This webhook handler will listen to any activities and it will update in a local database.


I have created a web API (ActivitiesController) which will expose endpoints in the backend. We can call this API to get all the activities.


Front-End
#########

I have added a DashboardController and corresponding views in Views->Dashboard Folder. 

I am calling the back-end API using the Angular services.

If you go to scripts- > service.js you can see that I have created a function over there which is making an HTTP call to the above-mentioned API and get all git hub activities.

In controller.js you can see the logic where I refresh the grid.
