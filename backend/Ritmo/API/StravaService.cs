using com.strava.v3.api.Activities;
using com.strava.v3.api.Athletes;
using com.strava.v3.api.Authentication;
using com.strava.v3.api.Clients;

namespace API;


public class StravaService : IStravaService
{
    private readonly StravaClient _stravaClient;

    public StravaService()
    {
        // TODO: Replace with a real token or load from DB/config
        var token = "<cc942a9eddc00289593f2857d32991925543491a>";
        var auth = new StaticAuthentication(token);
        _stravaClient = new StravaClient(auth);
    }

    public Task<Athlete> GetCurrentAthleteAsync()
    {
        return _stravaClient.Athletes.GetAthleteAsync();
    }

    public Task<IEnumerable<ActivitySummary>> GetRecentActivitiesAsync(DateTime after)
    {
        return null;
    }
}