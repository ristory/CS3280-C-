using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Assignment6AirlineReservation
{
    class Information
    {
        clsDataAccess clsData = new clsDataAccess();
        DataSet ds = new DataSet();
        SQL sql = new SQL();
        int iRet = 0;

        BindingList<FlightName> FlightName1 = new BindingList<FlightName>();
        BindingList<PassengerName> PassengerName1 = new BindingList<PassengerName>();
        BindingList<Label> Seat1 = new BindingList<Label>();
        

        public BindingList<FlightName> FlightNameTable()
        {
            ds = clsData.ExecuteSQLStatement(sql.FlightName(), ref iRet);

            for (int i = 0; i < iRet; i++)
            {
                FlightName1.Add(new FlightName
                {
                    Flight_ID1 = ds.Tables[0].Rows[i][0].ToString(),
                    Flight_Number1 = ds.Tables[0].Rows[i][1].ToString(),
                    Aircraft_Typer1 = ds.Tables[0].Rows[i][2].ToString()
                });
            }
            return FlightName1;
        }

        public BindingList<PassengerName> PassengerNameTable(string a)
        {
            PassengerName1.Clear();
            ds = clsData.ExecuteSQLStatement(sql.PassengerName(a), ref iRet);

            for (int i = 0; i < iRet; i++)
            {
                PassengerName1.Add(new PassengerName
                {
                    FirstName1 = ds.Tables[0].Rows[i][1].ToString(),
                    LastName1 = ds.Tables[0].Rows[i][2].ToString(),
                    Seat_Number1 = ds.Tables[0].Rows[i][3].ToString(),
                    Flight_ID1 = ds.Tables[0].Rows[i][4].ToString(),
                    Passenger_ID1 = ds.Tables[0].Rows[i][0].ToString()
                });

            }
            return PassengerName1;
        }

        public void ChangeSeatTable(string a, string b, string c)
        {
            clsData.ExecuteScalarSQL(sql.ChangeSeat(a, b, c));
            
        }

        public void DeletePassengerTable(string a, string b)
        {
            clsData.ExecuteScalarSQL(sql.DeletePassenger(a,b));
            clsData.ExecuteScalarSQL(sql.DeletePassenger1(b));

        }
       
        public string AddPassengerTable(string a, string b)
        {            
            string PassengerID = clsData.ExecuteScalarSQL(sql.AddPassenger(a,b));
            return PassengerID;
        }


        public void AddPassengerTable1(string a, string b)
        {
            clsData.ExecuteScalarSQL(sql.AddPassenger1(a, b));

        }

        public void AddPassengerTable2(string c, string d, string e)
        {
            
            clsData.ExecuteScalarSQL(sql.AddPassenger2(c, d, e));

        }

        public BindingList<Label> SeatTable(string a)
        {
            Seat1.Clear();
            ds = clsData.ExecuteSQLStatement(sql.Seat(a), ref iRet);
            for (int i = 0; i < iRet; i++)
            {
                Seat1.Add(new Label
                {
                    Content = ds.Tables[0].Rows[i][0].ToString()
                });
            }
            return Seat1;
        }
    }

    public class FlightName
    {
        public string Aircraft_Type;
        public string Flight_ID;
        public string Flight_Number;

        public string Flight_ID1
        {
            get { return Flight_ID; }
            set { Flight_ID = value; }
        }

        public string Flight_Number1
        {
            get { return Flight_Number; }
            set { Flight_Number = value; }
        }

        public string Aircraft_Typer1
        {
            get { return Aircraft_Type; }
            set { Aircraft_Type = value; }
        }

        public override string ToString()
        {
            return Flight_Number + "-" + Aircraft_Type;
        }
    }

    public class PassengerName
    {
        public string First_Name;
        public string Last_Name;
        public string Seat_Number;
        public string Flight_ID;
        public string Passenger_ID;
        public string FirstName1
        {
            get { return First_Name; }
            set { First_Name = value; }
        }

        public string LastName1
        {
            get { return Last_Name; }
            set { Last_Name = value; }
        }

        public string Seat_Number1
        {
            get { return Seat_Number; }
            set { Seat_Number = value; }
        }

        public string Flight_ID1
        {
            get { return Flight_ID; }
            set { Flight_ID = value; }
        }

        public string Passenger_ID1
        {
            get { return Passenger_ID; }
            set { Passenger_ID = value; }
        }



        public override string ToString()
        {
            return First_Name + " " + Last_Name; 
        }
    }


    public class Seat
    {
        public string Seat_Number;
        public string Seat_Number1
        {
            get { return Seat_Number; }
            set { Seat_Number = value; }
        }

        public override string ToString()
        {
            return "Seat" + Seat_Number;
        }
    }
}
