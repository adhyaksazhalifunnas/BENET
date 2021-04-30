using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BENET.Models
{
    public class ExerciseRecommendation
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Sport name")]
        public string SportName { get; set; }

        [DisplayName("Sport type [Indoor/Outdoor]")]
        public string SportType { get; set; }

        [DataType(DataType.MultilineText)]
        [DisplayName("Sport Drill")]
        public string SportDrill { get; set; }
        public ExerciseRecommendation()
        {

        }
    }
}
