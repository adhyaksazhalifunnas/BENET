using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BENET.Models
{
    public class Customer : User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Preferences { get; set; }

        public Customer()
        {

        }
    }
}
