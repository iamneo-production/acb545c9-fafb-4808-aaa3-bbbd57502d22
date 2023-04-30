using dotnetapp.Models;
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Core.Interface
{
    public interface IEvent
    {
       
        string CreateEvent(EventModel eventModel);
        EventModel ReadByEvents(int eventId);
        string UpdateEvent(EventModel eventModel,int eventId);
        string DeleteEvent(int eventId);

    }
}
