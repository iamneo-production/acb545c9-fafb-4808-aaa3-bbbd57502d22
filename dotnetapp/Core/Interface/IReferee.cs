using dotnetapp.Models;

namespace dotnetapp.Core.Interface
{
    public interface IReferee
    {
       

        RefereeModels readbyid(int refereeID);

       public string addReferee(RefereeModels refereemodel);
       public string editReferee(int refereeID, RefereeModels referee);

        public string deleteReferee(int idrefereeID);
    }
}
