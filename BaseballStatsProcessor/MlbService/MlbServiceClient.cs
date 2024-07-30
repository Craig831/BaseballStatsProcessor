using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseballStatsProcessor.Interfaces;
using BaseballStatsProcessor.MlbService.Models;
using RestSharp;

namespace BaseballStatsProcessor.MlbService
{
    public class MlbServiceClient : IMlbServiceClient, IDisposable
    {
        readonly RestClient _restClient;

        public MlbServiceClient()
        {
            //"Basev1ApiUrl": "http://statsapi.mlb.com:80/api/v1/",
            //"Basev11ApiUrl": "http://statsapi.mlb.com:80/api/v1.1/",
            var options = new RestClientOptions("http://statsapi.mlb.com:80/api/v1/");

            _restClient = new RestClient(options);
        }

        public async Task<BoxScoreRoot> GetBoxScore(int gamePackId)
        {
            var response = await _restClient.GetJsonAsync<BoxScoreRoot>("game/{gamePackId}/boxscore", new { gamePackId });
            return response!;
        }

        public async Task<PeopleRoot> GetPlayersByIds(int[] ids)
        {
            var response = await _restClient.GetJsonAsync<PeopleRoot>("people?personIds={ids}", new { ids });
            return response!;
        }

        public async Task<ScheduleRoot> GetScheduleGames(DateTime scheduleDate)
        {
            var response = await _restClient.GetJsonAsync<ScheduleRoot>("schedule?sportId=1&date={scheduleDate:MM/dd/yyyy}", new { scheduleDate });
            return response!;
        }

        public async Task<RosterRoot> GetTeamRoster(int teamId)
        {
            var response = await _restClient.GetJsonAsync<RosterRoot>("teams/{teamId}/roster/depthChart", new { teamId });
            return response!;
        }

        public void Dispose()
        {
            _restClient.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
