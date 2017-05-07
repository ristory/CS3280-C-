using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineFlightReservation
{
    class FlightInfo
    {
        //Class variables
        public string sFlight_ID;
        public string sFlight_Number;
        public string sAircraft_Type;

        /// <summary>
        /// Override the ToString method so that this string is displayed in the combo box.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            return sFlight_Number + " " + sAircraft_Type;
        }
        
    }

}
