using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseballStatsProcessor.MlbService.Models;

namespace BaseballStatsProcessor.Interfaces
{
    public interface IMlbServiceClient
    {
        Task<RosterRoot> GetTeamRoster(int teamId);

        Task<PeopleRoot> GetPlayersByIds(int[] ids);

        Task<ScheduleRoot> GetScheduleGames(DateTime scheduleDate);

        Task<BoxScoreRoot> GetBoxScore(int gamePackId);
    }
}
