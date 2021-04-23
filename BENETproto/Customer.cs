using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BENETproto
{
    class Customer
    {
        private string customerName1;
        private string customerEmail1;
        private string preferences1;

        [key]
        public string customerName { get => customerName1; set => customerName1 = value; }
        public string customerEmail { get => customerEmail1; set => customerEmail1 = value; }
        public string preferences { get => preferences1; set => preferences1 = value; }

        public void SignUp(string email, string pass)
        {
            //Add information data to Database
            //TODO
        }

        public void Login(string email, string pass)
        {
            //Get email and pass from database
            //Compare to the input
            //TODO
        }

        public void UpdateProfile(string email, string desc)
        {
            //TODO
        }

        public string GetSport(string option)
        {
            //Get sports data from indor/outdor input
            //TODO
        }

        public string GetPlace(string sport)
        {
            //Get place data from sport input
            //TODO
        }

        public string GetCurrentPosition()
        {
            //Get latitude and altitude of the user
            //TODO
        }

        public string GetDrill(string sport)
        {
            //Get drill from sport
            //TODO
        }

        public string SearchPlace(string name)
        {
            //Get the altitude and latitude from given the place
            //TODO
        }
    }
}
