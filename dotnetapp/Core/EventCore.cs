using dotnetapp.Context;
using dotnetapp.Core.Interface;
using dotnetapp.Models;
using System;

namespace dotnetapp.Core
{
    public class EventCore : IEvent
    { 
        private readonly EventContext _context;

        public EventCore(EventContext context)
        {
            _context = context;
        }

        public string CreateEvent(EventModel eventModel)
        {
             try
             {   
                if (eventModel != null)
                {
                    var acc = _context.EventTable.Add(eventModel);
                    _context.SaveChanges();
                    return "create is Done";
                }
                     return "Create is failed";
             }
             catch (Exception)
             {

                throw;
             }
        }

        public EventModel ReadByEvents(int eventId)
        {
            try
            {
                var acc = _context.EventTable.Find(eventId);
                _context.SaveChanges();
                return acc;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string UpdateEvent(EventModel eventModel,int eventId)
        {
            try
            {

                var acc = _context.EventTable.Find(eventId);
                if (acc != null)
                {
                    acc.EventName = eventModel.EventName;
                    acc.ApplicantName = eventModel.ApplicantName;
                    acc.ApplicantAddress = eventModel.ApplicantAddress;
                    acc.ApplicantMobile = eventModel.ApplicantMobile;
                    acc.ApplicantEmail = eventModel.ApplicantEmail;
                    acc.EventAddress = eventModel.EventAddress;
                    acc.EventFromDate = eventModel.EventFromDate;
                    acc.EventToDate = eventModel.EventToDate;
                    _context.EventTable.Update(acc);
                    _context.SaveChanges();
                    return "Update is Create";
                }
                else
                {
                    return "Show some Exception error";
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public string DeleteEvent(int eventId)
        {
            try
            {
                var acc = _context.EventTable.Find(eventId);

                if (acc != null)
                {
                    _context.EventTable.Remove(acc);
                    _context.SaveChanges();
                    return "Delete the EventID";
                }
                return "Error Exception";

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
