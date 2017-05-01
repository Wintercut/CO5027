using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TblMoviePeople
/// </summary>
namespace Entities
{
    public class TblMoviePeople
    {
        private string type;

        public int MoviePeopleID { set; get; }

        public string LoginUsername { set; get; }

        public string UserEmail { set; get; }

        public string UserPasscode { set; get; }

        public TblMoviePeople(int moviePeopleID, string loginUsername, string userEmail, string userPasscode)
        {
            MoviePeopleID = moviePeopleID;
            LoginUsername = loginUsername;
            UserEmail = userEmail;
            UserPasscode = userPasscode;
        }

        public TblMoviePeople(string loginUsername, string userEmail, string userPasscode)
        {
            LoginUsername = loginUsername;
            UserEmail = userEmail;
            UserPasscode = userPasscode;
        }

        public TblMoviePeople(string loginUsername, string userEmail, string userPasscode, string type) : this(loginUsername, userEmail, userPasscode)
        {
            this.type = type;
        }
    }
}