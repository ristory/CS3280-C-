using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineFlightReservation
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Data access class.
        /// </summary>
        DataAccess db;
        private string flightid;
        string sSQL;    //Holds an SQL statement
        string sSQL1;    //Holds an SQL statement
        string sSQL2;    //Holds an SQL statement
        int iRet = 0;   //Number of return values
        int iRet1 = 0;   //Number of return values
        DataSet ds = new DataSet(); //Holds the return values
        DataSet ds1 = new DataSet(); //Holds the return values
        DataSet ds2 = new DataSet(); //Holds the return values
        Passenger Passenger; //Used to load the return values into the combo box
        FlightInfo Flight; //Used to load the return values into the combo box
        public Form1()
        {
            InitializeComponent();
            db = new DataAccess();
           panel1.Visible = false;
           panel2.Visible = false;
           comboBox2.Enabled = false;
           button1.Enabled = false;
           button2.Enabled = false;
           button3.Enabled = false;


            try
            {
                //Create the SQL statement to extract the flightinfo
                sSQL = "SELECT DISTINCT Flight.Flight_ID, Flight_Number, Aircraft_Type " +
                   "FROM Flight, Flight_Passenger_Link " +
                   "WHERE Flight.Flight_ID = Flight_Passenger_Link.Flight_ID";

                //Extract the flightinfo and put them into the DataSet
                ds = db.ExecuteSQLStatement(sSQL, ref iRet);

                //Loop through the data and create flight classes
                for (int i = 0; i < iRet; i++)
                {
                    Flight = new FlightInfo();
                    Flight.sFlight_ID = ds.Tables[0].Rows[i][0].ToString();
                    Flight.sFlight_Number = ds.Tables[0].Rows[i]["Flight_Number"].ToString();
                    Flight.sAircraft_Type = ds.Tables[0].Rows[i]["Aircraft_Type"].ToString();
                    comboBox1.Items.Add(Flight);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Handle exception");
            }


        }

        private void Seat_Click(object sender, EventArgs e)
        {
            try
            {
                Label MyLabel = (Label)sender;  //Get the label that the user clicked
                string sSeatNumber; //The seat number
                Passenger Passenger; //The Passenger

                //Check to see if the seat backcolor is read
                if (MyLabel.BackColor == Color.Red)
                {
                    //Turn the seat green
                    MyLabel.BackColor = Color.Green;

                    //Get the seat number
                    sSeatNumber = MyLabel.Text;

                    //Loop through the items in the combo box
                    for (int i = 0; i < comboBox2.Items.Count; i++)
                    {
                        //Extract the passenger from the combo box
                        Passenger = (Passenger)comboBox2.Items[i];

                        //If the seat number matches then select the passenger in the combo box
                        if (sSeatNumber == Passenger.sSeat)
                        {
                            comboBox2.SelectedIndex = i;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Handle exception");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox2.ResetText();
                comboBox2.Items.Clear();
                comboBox2.Enabled = true;
                button2.Enabled = true;
                //Create a Flight object
                FlightInfo Flight;

                //Extract the selected Flight object from the combo box
                Flight = (FlightInfo)comboBox1.SelectedItem;
                flightid = Flight.sFlight_ID;

                if (flightid == "1")
                {
                    panel1.Dock = DockStyle.Left;
                    panel2.Visible = true;
                    panel1.Visible = false;
                    sSQL1 = "SELECT Passenger.Passenger_ID, First_Name, Last_Name, Flight_ID, Seat_Number " +
                  "FROM Passenger, Flight_Passenger_Link " +
                  "WHERE Passenger.Passenger_ID = Flight_Passenger_Link.Passenger_ID AND " +
                  "Flight_id = 1";

                }
                else if (flightid == "2")
                {
                    panel2.Dock = DockStyle.Left;
                    panel1.Visible = true;
                    panel2.Visible = false;
                    sSQL1 = "SELECT Passenger.Passenger_ID, First_Name, Last_Name, Flight_ID, Seat_Number " +
                  "FROM Passenger, Flight_Passenger_Link " +
                  "WHERE Passenger.Passenger_ID = Flight_Passenger_Link.Passenger_ID AND " +
                  "Flight_id = 2";
                }
                //Extract the passengers and put them into the DataSet
                ds1 = db.ExecuteSQLStatement(sSQL1, ref iRet1);


                //Loop through the data and create passenger classes
                for (int i = 0; i < iRet1; i++)
                {
                    Passenger = new Passenger();
                    Passenger.sID = ds1.Tables[0].Rows[i][0].ToString();
                    Passenger.sFirstName = ds1.Tables[0].Rows[i]["First_Name"].ToString();
                    Passenger.sLastName = ds1.Tables[0].Rows[i]["Last_Name"].ToString();
                    Passenger.sFlight = ds1.Tables[0].Rows[i][3].ToString();
                    Passenger.sSeat = ds1.Tables[0].Rows[i][4].ToString();

                    comboBox2.Items.Add(Passenger);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Handle exception");
            }


        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button3.Enabled = true;
                //Create a Passenger object
                Passenger Passenger;

                //Extract the selected Passenger object from the combo box
                Passenger = (Passenger)comboBox2.SelectedItem;

                //Set the seat label
                label11.Text = Passenger.sSeat;

                foreach (Label MyLabel1 in panel2.Controls)
                {
                    if (MyLabel1.BackColor == Color.Green)
                    {
                        MyLabel1.BackColor = Color.Red;
                    }
                    //Check to see if the passenger's seat matches the label
                    if (MyLabel1.Text == Passenger.sSeat)
                    {
                        MyLabel1.BackColor = Color.Green;
                    }
                }
                foreach (Label MyLabel2 in panel1.Controls)
                {
                    if (MyLabel2.BackColor == Color.Green)
                    {
                        MyLabel2.BackColor = Color.Red;
                    }
                    //Check to see if the passenger's seat matches the label
                    if (MyLabel2.Text == Passenger.sSeat)
                    {
                        MyLabel2.BackColor = Color.Green;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Handle exception");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            try
            {
                Label MyLabel = (Label)sender;  //Get the label that the user clicked
                string sSeatNumber; //The seat number
                Passenger Passenger; //The Passenger

                //Check to see if the seat backcolor is read
                if (MyLabel.BackColor == Color.Red)
                {
                    //Turn the seat green
                    MyLabel.BackColor = Color.Green;

                    //Get the seat number
                    sSeatNumber = MyLabel.Text;

                    //Loop through the items in the combo box
                    for (int i = 0; i < comboBox2.Items.Count; i++)
                    {
                        //Extract the passenger from the combo box
                        Passenger = (Passenger)comboBox2.Items[i];

                        //If the seat number matches then select the passenger in the combo box
                        if (sSeatNumber == Passenger.sSeat)
                        {
                            comboBox2.SelectedIndex = i;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Handle exception");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                PassengerInfo Passenger = new PassengerInfo();
                Passenger.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Handle exception");
            }
        }
    }
 

}
    
