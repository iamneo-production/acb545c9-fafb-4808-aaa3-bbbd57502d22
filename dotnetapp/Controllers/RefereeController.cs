using dotnetapp.Context;
using dotnetapp.Core.Interface;
using dotnetapp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;
using System;

namespace dotnetapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefereeController : ControllerBase
    {
        private readonly IReferee _ireferee;
        

        public RefereeController(IReferee ireferee)
        {
            this._ireferee = ireferee;
        }

        [HttpGet]
        [Route("getReferee")]

        public ActionResult<ResponseModel> readbyid(int refreeid)
        {
            try
            {

                var response = _ireferee.readbyid(refreeid);
                ResponseModel responseModel = new ResponseModel();
                responseModel.Message = response;
                responseModel.Status = true;
                return responseModel;
            }
            catch(Exception ex) 
            {
                ResponseModel responseModel = new ResponseModel();
                responseModel.Status = false;
                responseModel.Message = ex.Message;
                return responseModel;
            }
        }


        [HttpDelete]
        [Route("deleteReferee/{refereeId}")]



        public ActionResult<ResponseModel> deleteReferee(int refereeId)
        {
            try
            {
                var response = _ireferee.deleteReferee(refereeId);
                ResponseModel responseModel = new ResponseModel();
                responseModel.Status = true;
                return responseModel;
            }
            catch(Exception ex)
            {
                ResponseModel responseModel = new ResponseModel();
                responseModel.Status = false;
                responseModel.Message = ex.Message;
                return responseModel;

            }
        }

        [HttpPost]
        [Route("addReferee")]



        public ActionResult<ResponseModel> addReferee(RefereeModels refereeModel)
        {
            try
            {
                var response = _ireferee.addReferee(refereeModel);
                ResponseModel responseModel = new ResponseModel();
                responseModel.Status = true;
                return responseModel;
            }
            catch(Exception ex) 
            {
                ResponseModel responseModel = new ResponseModel();
                responseModel.Status = false;
                responseModel.Message = ex.Message;
                return responseModel;

            }
        }

        [HttpPut]
        [Route("editReferee")]



        public ActionResult<ResponseModel> editReferee(int refereeID, RefereeModels referee)

        {
            try
            {
                var response = _ireferee.editReferee(refereeID, referee);
                ResponseModel responseModel = new ResponseModel();
                responseModel.Status = true;
                return responseModel;
            }
            catch(Exception ex) 
            {
                ResponseModel responseModel = new ResponseModel();
                responseModel.Status = false;
                responseModel.Message = ex.Message;
                return responseModel;
            }
        }
    }
}





    
