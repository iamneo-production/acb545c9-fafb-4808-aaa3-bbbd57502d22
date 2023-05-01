using System.Threading.Tasks;
using dotnetapp.Models;

namespace dotnetapp.Core.Interface
{
    public interface IVenue
    {
         Task<ResponseModel> CreateVenue(VenueModel venueModel);
       Task <VenueModel> ReadVenue(int VenueId);
        Task<VenueModel> UpdateVenue(VenueModel venuemodel,int VenueId);
        Task<VenueModel> DeleteVenue(int VenueId);

        
    }
}
