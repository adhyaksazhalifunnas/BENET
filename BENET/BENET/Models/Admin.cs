using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BENET.Models
{
    public class Admin : User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public Admin()
        {

        }
    }
}
