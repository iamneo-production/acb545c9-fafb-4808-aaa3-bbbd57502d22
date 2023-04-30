using dotnetapp.Core.Interface;
using dotnetapp.Models;
using Microsoft.AspNetCore.Mvc;
using System;


namespace dotnetapp.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class EventController : ControllerBase
    {
        private readonly IEvent _ievent;

        public EventController(IEvent ievent)
        {
            this._ievent = ievent;
        }

        [HttpPost]
        [Route("create")]
        public ActionResult<ResponseModel> CreateEvent(EventModel eventModel)
        {
            try
            {
                
                ResponseModel responseModel = new ResponseModel();
                var Response = _ievent.CreateEvent(eventModel);
                responseModel.Message = Response;
                responseModel.Status = true;
                return responseModel;

            }
            catch (Exception ex)
            {
                ResponseModel responseModel = new ResponseModel();
                responseModel.Status = false;
                responseModel.Message = ex.Message;
                return responseModel;

            }
        }

        [HttpGet]
        [Route("ReadById")]
        public ActionResult<ResponseModel> ReadByEvents(int eventId)
        {
            try
            {
                ResponseModel responseModel=new ResponseModel();
                var Response = _ievent.ReadByEvents(eventId);
                responseModel.Message = Response;
                responseModel.Status = true;
                return responseModel;
            }
            catch (Exception ex)
            {
                ResponseModel responseModel = new ResponseModel();
                responseModel.Status=false;
                responseModel.Message = ex.Message;
                return responseModel;
                
            }
        }

        [HttpPost]
        [Route("Update")]
        public ActionResult<ResponseModel> UpdateEvent(EventModel eventModel, int eventId)
        {
            try
            {
                ResponseModel responseModel = new ResponseModel();
                var Response = _ievent.UpdateEvent(eventModel, eventId);
                responseModel.Message = Response;
                responseModel.Status = true;
                return responseModel;
                
               
                
            }
            catch (Exception ex)
            {

                ResponseModel responseModel = new ResponseModel();
                responseModel.Status = false;
                responseModel.Message = ex.Message;
                return responseModel;
            }
        }

        [HttpDelete]
        [Route("Delete")]
        public ActionResult<ResponseModel> DeleteEvent(int eventId)
        {
            try
            {
                ResponseModel responseModel = new ResponseModel();
                var Response = _ievent.DeleteEvent(eventId);
                responseModel.Message = Response;
                responseModel.Status = true;
                return responseModel;

            }
            catch (Exception ex)
            {
                ResponseModel responseModel = new ResponseModel();
                responseModel.Status = false;
                responseModel.Message = ex.Message;
                return responseModel;
                
            }
        }


    }
}
