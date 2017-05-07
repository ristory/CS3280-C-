using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineFlightReservation
{
    class Passenger
    {
        //Class variables
        public string sID;
        public string sFirstName;
        public string sLastName;
        public string sSeat;
        public string sFlight;

        /// <summary>
        /// Override the ToString method so that this string is displayed in the combo box.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return sFirstName + " " + sLastName;
        }
    }
}
