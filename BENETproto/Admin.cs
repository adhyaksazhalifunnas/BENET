using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BENETproto
{
    public class Admin
    {
        //Property
        //Get email and pass from Database
        private string adminEmail1;
        private string adminPassword1;
        
        [key]
        public string adminEmail { get => adminEmail1; set => adminEmail1 = value; }
        private string adminPassword { get => adminPassword1; set => adminPassword1 = value; }

        public void SignUp(string email, string pass)
        {
            //Add information data to Database
            //TODO
        }

        public void Login(string email, string pass)
        {
            //Get adminEmail and adminPassword from database
            //Compare to the input
            //TODO
        }

        public void AddSport(string name, string desc)
        {
            //Add sports to database
            //TODO
        }

        public void AppPlaces(string name, string desc)
        {
            //Add places to Database
            //TODO
        }

        public void AddDrills(string name, string desc)
        {
            //Add drills to database
            //TODO
        }

        public Boolean VerifyUser()
        {
            //If user verified -> ok
            //else RemoveUser()
            //TODO
        }
        
        private void RemoveUser()
        {
            //TODO
        }
    }
}
