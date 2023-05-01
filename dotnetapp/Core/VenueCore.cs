using System.Collections.Generic;
using System;
using System.Linq;
using dotnetapp.Context;
using dotnetapp.Core.Interface;
using dotnetapp.Models;
using System.Threading.Tasks;

namespace dotnetapp.Core
{
    public class Venue : IVenue
    {
        private readonly VenueContext venueContext;
        public Venue(VenueContext VenueContext)
        {
            this.venueContext = VenueContext;

        }

        public async Task<ResponseModel> CreateVenue(VenueModel venue)
        {
            try
            {
                venueContext.Add(venue);
                venueContext.SaveChanges();
                ResponseModel responseModel = new ResponseModel();
                responseModel.Message = "Success";
                responseModel.Status = true;
                return responseModel;

            }
            catch (Exception)
            {
                ResponseModel responseModel = new ResponseModel();
                responseModel.ErrorMessage = "Something went wrong";
                responseModel.Status = false;
                return responseModel;
            }
            
        }


        public async Task<VenueModel> DeleteVenue(int Venueid)
        {
            try
            {
                var venue = await venueContext.Venuetable.FindAsync(Venueid);
                if (venue != null)
                {
                    venueContext.Remove(venue);
                    venueContext.SaveChanges();
                    ResponseModel responseModel = new ResponseModel();
                    responseModel.Message = "Success";
                    responseModel.Status = true;
                    return venue;

                }
                else
                {
                    ResponseModel responseModel = new ResponseModel();
                    responseModel.ErrorMessage = "Null Value Can't accept";
                    responseModel.Status = false;
                    return null;
                }
            }
            catch (Exception)
            {
                ResponseModel responseModel = new ResponseModel();
                responseModel.ErrorMessage = "Something went wrong";
                responseModel.Status = false;
                return null;
            }
        }

        

        public async Task<VenueModel> ReadVenue(int VenueId)
        {
            try
            {
                if (VenueId != 0)
                {
                    var a = await venueContext.Venuetable.FindAsync(VenueId);
                    await venueContext.SaveChangesAsync();
                    ResponseModel responseModel = new ResponseModel();
                    responseModel.Message = "Success";
                    responseModel.Status = true;
                    return a;
                }
                else
                {
                    ResponseModel responseModel = new ResponseModel();
                    responseModel.ErrorMessage = "Null Value Can't accept";
                    responseModel.Status = false;
                    return null;
                }

            }
            catch (Exception)
            {
                ResponseModel responseModel = new ResponseModel();
                responseModel.ErrorMessage = "Something went wrong";
                responseModel.Status = false;
                return null;

            }
        }

        public async Task<VenueModel> UpdateVenue(VenueModel venuemodel, int venueid)
        {
            try
            {
                var venue = await venueContext.Venuetable.FindAsync(venueid);

                if (venue != null)
                {
                    venue.venueName = venuemodel.venueName;
                    venue.venueImageURL = venuemodel.venueImageURL;
                    venue.venueDescription = venuemodel.venueDescription;
                    venue.VenueLocation = venuemodel.VenueLocation;
                    venue.Totalprice = venuemodel.Totalprice;
                    venue.Time = venuemodel.Time;
                    venue.Date = venuemodel.Date;
                     venueContext.Venuetable.Update(venue);
                   await venueContext.SaveChangesAsync();
                    ResponseModel responseModel = new ResponseModel();
                    responseModel.Message = "Success";
                    responseModel.Status = true;
                    return venue;
                }
                else
                {
                    ResponseModel responseModel = new ResponseModel();
                    responseModel.ErrorMessage = "Something went wrong";
                    responseModel.Status = false;
                    return null;
                }

            }
            catch (System.Exception)
            {
                ResponseModel responseModel = new ResponseModel();
                responseModel.ErrorMessage = "Something went wrong";
                responseModel.Status = false;
                return null;
            }
        }

    
        }
    }









