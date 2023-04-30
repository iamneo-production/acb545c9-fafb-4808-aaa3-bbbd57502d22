using dotnetapp.Context;
using dotnetapp.Core.Interface;
using dotnetapp.Core;
using dotnetapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System;

namespace dotnetapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TeamController:ControllerBase
    {
        private readonly ITeamCore _teamint;
        public TeamController(ITeamCore _teamint) 
        {
            this._teamint = _teamint;
        }


        [HttpGet]
        [Route("getTeam")]

        public Task<TeamModel>readbyid(int teamId)
        {
            try
            {
                ResponseModel responseModel = new ResponseModel();
                var response =_teamint.readbyid(teamId);
                responseModel.Message = "Read by id is success";
                responseModel.Status = true;
                return response;
            }
            catch(Exception ex) 
            {
              ResponseModel responseModel = new ResponseModel();
                responseModel.Message = "Something Went Wrong";
                responseModel.Status = false;
                responseModel.ErrorMessage = ex.Message;
                return null;
            }
        }

        [HttpDelete]
        [Route("deleteTeam/{teamId}")]

        public Task<TeamModel> deleteTeam(int teamId)
        {
            try
            {
                ResponseModel responseModel = new ResponseModel();
                var  response = _teamint.deleteTeam(teamId);
                responseModel.Message = "Deleted Successfully";
                responseModel.Status = true;
                return response;
            }
            catch (Exception ex)
            {
                ResponseModel responseModel = new ResponseModel();
                responseModel.Message = "Something Went Wrong";
                responseModel.Status = false;
                responseModel.ErrorMessage = ex.Message;
                return null;
            }
        }

        [HttpPost]
        [Route("addTeam")]

        public  Task<ResponseModel> addTeam(TeamModel teamModel)
        {
            try
            {
                ResponseModel responseModel = new ResponseModel();
                var response =_teamint.addTeam(teamModel);
                responseModel.Message = "Added Successfully";
                responseModel.Status = true;
                return response;
            }
            catch(Exception ex)
            {
                ResponseModel responseModel = new ResponseModel();
                responseModel.Message = "Something Went Wrong";
                responseModel.Status = false;
                responseModel.ErrorMessage = ex.Message;
                return null;
            }
        }

        [HttpPut]
        [Route("editTeam")]

        public Task<TeamModel> editTeam(TeamModel team, int teamId)
        {
            try
            {
                ResponseModel responseModel = new ResponseModel();
                var response = _teamint.editTeam(team, teamId);
                responseModel.Message = "Updated Successfully";
                responseModel.Status = true;
                return response;
            }
            catch(Exception ex)
            {

                ResponseModel responseModel = new ResponseModel();
                responseModel.Message = "Something Went Wrong";
                responseModel.Status = false;
                responseModel.ErrorMessage = ex.Message;
                return null;
            }
        }
    }
}
