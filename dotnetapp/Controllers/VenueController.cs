using Microsoft.AspNetCore.Mvc;
using System;
using dotnetapp.Core;
using dotnetapp.Context;
using dotnetapp.Core;
using dotnetapp.Core.Interface;
using dotnetapp.Models;
using System.Threading.Tasks;

namespace dotnetapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VenueController : ControllerBase
    {
        private readonly IVenue ivenue;
        public VenueController(IVenue ivenue)
        {
            this.ivenue = ivenue;
        }

        [HttpGet]
        [Route("ReadVenue")]
        public Task<VenueModel> ReadVenue(int VenueId)
        {
            try
            {
                ResponseModel responseModel = new ResponseModel();
                var response = ivenue.ReadVenue(VenueId);
                responseModel.Message = response;
                responseModel.Status = true;
                return response;
            }
            catch (Exception ex)
            {
                ResponseModel responseModel = new ResponseModel();
                responseModel.Status = false;
                responseModel.ErrorMessage= ex.Message;
                return null;

            }
        }



        [HttpPost]
        [Route("CreateVenue")]
        public ActionResult<ResponseModel>  CreateVenue(VenueModel venue)
        {
            try
            {
                ResponseModel responseModel = new ResponseModel();
                var response = ivenue.CreateVenue(venue);
                responseModel.Message = response;
                responseModel.Status = true;
                return responseModel;
            }
            catch (Exception ex)
            {
                ResponseModel responseModel = new ResponseModel();
                responseModel.Status = false;
                responseModel.ErrorMessage = ex.Message;
                return responseModel;
            }
        }



        [HttpPut]
        [Route("UpdateVenue")]
        public Task<VenueModel> updateVenue(VenueModel venuemodel,int VenueId)
        {
            try
            {
                ResponseModel responseModel = new ResponseModel();
                var response = ivenue.UpdateVenue(venuemodel,VenueId);
                responseModel.Message = response;
                responseModel.Status = true;
                return response;
            }
            catch (Exception ex)
            {
                ResponseModel responseModel = new ResponseModel();
                responseModel.Status=false;
                responseModel.Message = ex.Message;
                return null;
            }
        }




        [HttpDelete]
        [Route("DeleteVenue")]
        public Task<VenueModel> DeleteVenue(int VenueId)
        {
            try
            {
                ResponseModel responseModel = new ResponseModel();
                var response = ivenue.DeleteVenue(VenueId);
                responseModel.Message = response;
                responseModel.Status = true;
                return response;
            }
            catch (Exception ex)
            {
                ResponseModel responseModel = new ResponseModel();
                responseModel.Status=false;
                responseModel.Message=ex.Message;
                return null;
                
            }
        }
    }
}



