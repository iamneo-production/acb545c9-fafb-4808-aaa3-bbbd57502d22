using dotnetapp.Context;
using dotnetapp.Core.Interface;
using dotnetapp.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace dotnetapp.Core
{
    public class TeamCore : ITeamCore
    {
        private readonly TeamContext _teamContext;
        public TeamCore(TeamContext teamContext)
        {
            this._teamContext = teamContext;
        }

        public async Task<ResponseModel> addTeam(TeamModel teamModel)
        {
            try
            {
                if (teamModel != null)
                {

                    ResponseModel responseModel = new ResponseModel();
                    await _teamContext.teamModels.AddAsync(teamModel);
                    await _teamContext.SaveChangesAsync();
                    responseModel.Message = "Success";
                    responseModel.Status = true;
                    return responseModel;
                }
                else
                {
                    ResponseModel responseModel = new ResponseModel();
                    responseModel.ErrorMessage = string.Empty;
                    return responseModel;
                }
            }
            catch
            {
                throw;
            }
        }

        public async Task<TeamModel> deleteTeam(int teamId)
        {
            try
            {
                var tm = await _teamContext.teamModels.FindAsync(teamId);

                if (tm != null)
                {
                    _teamContext.Remove(tm);
                    _teamContext.SaveChanges();
                    ResponseModel responseModel = new ResponseModel();
                    responseModel.Message = "Success";
                    responseModel.Status = true;
                    return tm;

                }
                else
                {
                    ResponseModel responseModel = new ResponseModel();
                    responseModel.ErrorMessage = "give some data";
                    return null;
                }
            }
            catch
            {
                ResponseModel responseModel= new ResponseModel();
                responseModel.ErrorMessage = "Something went wrong";
                responseModel.Status = false;
                return null;
            }
        }

        public async Task<TeamModel> editTeam(TeamModel team, int teamId)
        {
            try
            {

                var tm = await _teamContext.teamModels.FindAsync(teamId);
                if (tm != null)
                {
                    //tm.teamId = team.teamId;
                    tm.teamName = team.teamName;
                    tm.teamDescription = team.teamDescription;
                    tm.TeamLocation = team.TeamLocation;
                    tm.FirstName = team.FirstName;
                    tm.LastName = team.LastName;
                    tm.Age = team.Age;
                    tm.Gender = team.Gender;
                    tm.noOfplayers = team.noOfplayers;
                    _teamContext.teamModels.Update(tm);
                    _teamContext.SaveChanges();
                    ResponseModel responseModel = new ResponseModel();
                    responseModel.Message = "Success";
                    responseModel.Status = true;
                    return tm;

                }
                else
                {
                    ResponseModel responseModel = new ResponseModel();
                    responseModel.ErrorMessage = "Give proper data";
                    responseModel.Status = false;
                    return null;

                }


            }
            catch 
            {
                ResponseModel responseModel=new ResponseModel();
                responseModel.ErrorMessage = "Something went wrong";
                responseModel.Status = false;
                return null;
            }
        }

        public async Task<TeamModel> readbyid(int teamId)
        {
            try
            {
                if (teamId != 0)
                {
                    ResponseModel responseModel = new ResponseModel();
                    var response = await _teamContext.teamModels.FindAsync(teamId);
                    await _teamContext.SaveChangesAsync();
                    return response;
                }
                else
                {
                    ResponseModel responseModel = new ResponseModel();
                    responseModel.ErrorMessage = "Id can't not be null";
                    responseModel.Status = false;
                    return null;
                }
            }
            catch
            {
                ResponseModel responseModel = new ResponseModel();
                responseModel.ErrorMessage = "something went wrong";
                responseModel.Status = false;
                return null;
            }
        }
    }
}
