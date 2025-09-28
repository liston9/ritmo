namespace API;

using com.strava.v3.api.Activities;
using com.strava.v3.api.Athletes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IStravaService
{
    Task<Athlete> GetCurrentAthleteAsync(); // Fetch your Strava profile
    
    Task<IEnumerable<ActivitySummary>> GetRecentActivitiesAsync(DateTime after); // Fetch recent activities
}