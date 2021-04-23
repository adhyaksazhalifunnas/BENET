using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BENETproto
{
    class Recommendation
    {
        public string Sport { get; set; }
        public string Weather { get; }
        public DateTime Time { get; }
        public string Drill { get; set; }
        public string Place { get; set; }

        public string ShowRecommendation()
        {
            //input sport, weather, and time -> out Drill and place
            //TODO
        }
    }
}
