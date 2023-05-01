using dotnetapp.Context;
using dotnetapp.Core.Interface;
using dotnetapp.Models;
using System.Collections.Generic;

namespace dotnetapp.Core

{

    public class RefereeCore : IReferee
    {

        private readonly RefereeContext _refereeContext;
        

        public RefereeCore(RefereeContext refereeContext)
        {

            this._refereeContext = refereeContext;

        }

        public string addReferee(RefereeModels referee)
        {
            try
            {
                _refereeContext.refereemodel.Add(referee);
                _refereeContext.SaveChanges();
                return "added successfully";



            }
            catch
            {
                throw;
            }
        }

        public string deleteReferee(int idrefereeID)
        {
            try
            {
                var res = _refereeContext.refereemodel.Find(idrefereeID);



                if (res != null)
                {
                    _refereeContext.Remove(res);
                    _refereeContext.SaveChanges();
                    return "Referee deleted successfully";



                }
                return $"No referee found with id{idrefereeID}";
            }
            catch
            {
                throw;
            }
        }

        public string editReferee(int refereeID, RefereeModels referee)
        {
            try
            {



                var res = _refereeContext.refereemodel.Find(refereeID);
                if (res != null)
                {
                    res.refereeName = referee.refereeName;
                    res.noOfMatches = referee.noOfMatches;
                    _refereeContext.refereemodel.Update(res);
                    _refereeContext.SaveChanges();
                    return "Referee updated successfully";



                }
                return $"No data found{referee.refereeID}";




            }
            catch
            {
                throw;
            }
        }

        public RefereeModels readbyid(int refereeID)
        {
            var res = _refereeContext.refereemodel.Find(refereeID);
            _refereeContext.SaveChanges();
            return res;
        }
    }

}




