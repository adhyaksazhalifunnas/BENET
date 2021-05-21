using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BENET.Models
{
    public class Admin : User
    {
        [Key]
        public new int Id { get; set; }
        public string Username { get; set; }
        public Admin()
        {

        }
    }
}
