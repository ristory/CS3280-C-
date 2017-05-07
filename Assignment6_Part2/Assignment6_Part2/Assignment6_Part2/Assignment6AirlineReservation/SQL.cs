using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6AirlineReservation
{
   
    public class SQL
    {
        String sSQL;

        public string FlightName()
        {
            sSQL = "SELECT Flight_ID, Flight_Number, Aircraft_Type FROM FLIGHT";
            return sSQL;
        }

        public string Seat(string a)
        {
            sSQL = "SELECT Seat_Number FROM Flight_Passenger_Link " + "WHERE Flight_Passenger_Link.Flight_ID = " + a;
            return sSQL;
        }

        public string PassengerName(string a)
        {

            sSQL = "SELECT PASSENGER.Passenger_ID, First_Name, Last_Name, Seat_Number, FLIGHT.Flight_ID " +
                  "FROM FLIGHT_PASSENGER_LINK, FLIGHT, PASSENGER " +
              "WHERE FLIGHT.FLIGHT_ID = FLIGHT_PASSENGER_LINK.FLIGHT_ID AND " +
              "FLIGHT_PASSENGER_LINK.PASSENGER_ID = PASSENGER.PASSENGER_ID AND " +
              "FLIGHT.FLIGHT_ID = " + a; 
            return sSQL;
        }



        public string ChangeSeat(string a, string b, string c)
        {

            sSQL = "UPDATE FLIGHT_PASSENGER_LINK " +
           "SET Seat_Number = " + a +
           " WHERE Flight_ID = " + b +" AND Passenger_ID = " + c;
     
            return sSQL;
        }

        public string UpdateSeat()
        {
            sSQL = " SELECT Flight_ID, Passenger_ID, Seat_Number " +
                  "FROM FLIGHT_PASSENGER_LINK";

            return sSQL;
        }



        public string DeletePassenger(string a, string b)
        {
           sSQL = "Delete FROM FLIGHT_PASSENGER_LINK " +
           "WHERE FLIGHT_ID = " + a + " AND " +
           "PASSENGER_ID = " + b;

            return sSQL;
        }

        public string DeletePassenger1(string b)
        {       
             sSQL = "Delete FROM PASSENGER " +
            "WHERE PASSENGER_ID = " + b;
            return sSQL;
        }

        public string AddPassenger(string a, string b)
        {
            sSQL = "SELECT Passenger_ID from Passenger WHERE First_Name = " + "'" + a + "'" + " AND Last_Name = " + "'" + b + "'";

            return sSQL;
        }

        public string AddPassenger1(string a, string b)
        {
  
            sSQL = "INSERT INTO PASSENGER(First_Name, Last_Name) VALUES(" + "'" + a + "'" + "," + "'" + b + "'" + ")";

            return sSQL;
        }

        public string AddPassenger2(string c, string d, string e)
        {
            sSQL = "INSERT INTO Flight_Passenger_Link(Flight_ID, Passenger_ID, Seat_Number) " +
             "VALUES( "  + c + "," + d + "," + e + ")";
            return sSQL;
        }

    }
    
}
