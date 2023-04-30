using dotnetapp.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace dotnetapp.Core.Interface
{
    public interface ITeamCore
    {
        Task<TeamModel>readbyid(int teamId);
        Task<ResponseModel> addTeam(TeamModel teamModel);
        Task<TeamModel> editTeam(TeamModel team, int teamId);
        Task<TeamModel> deleteTeam(int teamId);
    }
}
