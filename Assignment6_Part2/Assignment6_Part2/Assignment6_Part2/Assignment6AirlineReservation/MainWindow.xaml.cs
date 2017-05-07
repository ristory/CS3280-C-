using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment6AirlineReservation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        wndAddPassenger wndAddPass;
        Information Info;
        private int count = 1;
        public string selection = "1";
        public string CurrentSeat;
        public string CurrentFlightID;
        public string CurrentPassengerID;
        public string CurrentFirstName;
        public string CurrentLastNamel;
        private bool ClickChange = false;

        public MainWindow()
        {

            try
            {

                Info = new Information();
                wndAddPass = new wndAddPassenger();
                InitializeComponent();
                Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
                cbChooseFlight.ItemsSource = Info.FlightNameTable();
                CanvasA380.Visibility = Visibility.Hidden;
                Canvas767.Visibility = Visibility.Hidden;
                lblPassengersSeatclick.Visibility = Visibility.Hidden;


            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        public void ChooseSeat(wndAddPassenger wndAddPass)
        {
            try
            {
                this.cbChooseFlight.IsEnabled = false;
                this.cbChoosePassenger.IsEnabled = false;
                this.lblPassengersSeatNumber.IsEnabled = false;
                this.cmdAddPassenger.IsEnabled = false;
                this.cmdChangeSeat.IsEnabled = false;
                this.cmdDeletePassenger.IsEnabled = false;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        private void cbChooseFlight_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                cmdChangeSeat.IsEnabled = false;
                cmdDeletePassenger.IsEnabled = false;
                Info = new Information();
                selection = cbChooseFlight.SelectedItem.ToString();
                cbChoosePassenger.IsEnabled = true;
                gPassengerCommands.IsEnabled = true;

                string a;
                if (selection == "412-Boeing 767")
                {
                    a = "2";
                    CurrentFlightID = "2";
                    CanvasA380.Visibility = Visibility.Hidden;
                    Canvas767.Visibility = Visibility.Visible;
                    foreach (Label child in Canvas767.Children)
                    {

                        foreach (Label value in Info.SeatTable(a))
                        {

                            if (child.ToString().Equals(value.ToString()))
                            {
                                child.Background = Brushes.Red;
                            }

                        }
                    }

                }
                else
                {
                    a = "1";
                    CurrentFlightID = "1";
                    Canvas767.Visibility = Visibility.Hidden;
                    CanvasA380.Visibility = Visibility.Visible;
                    foreach (Label child in CanvasA380.Children)
                    {
                        foreach (Label value in Info.SeatTable(a))
                        {

                            if (child.ToString().Equals(value.ToString()))
                            {
                                child.Background = Brushes.Red;
                            }
                        }
                    }
                }

                cbChoosePassenger.ItemsSource = Info.PassengerNameTable(a);

            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void cmdAddPassenger_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wndAddPass = new wndAddPassenger();
                wndAddPass.ShowDialog();
                if (wndAddPass.ClickAdd == true)
                {
                    cbChooseFlight.IsEnabled = false;
                    cbChoosePassenger.IsEnabled = false;
                    lblPassengersSeatNumber.Content = "";
                    cmdAddPassenger.IsEnabled = false;
                    cmdDeletePassenger.IsEnabled = false;
                    cmdChangeSeat.IsEnabled = false;
                }
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                MessageBox.Show(sClass + "." + sMethod + " -> " + sMessage);
            }
            catch (System.Exception ex)
            {
                System.IO.File.AppendAllText(@"C:\Error.txt", Environment.NewLine + "HandleError Exception: " + ex.Message);
            }
        }



        private void cmdChangeSeat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Canvas767_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
        }

        private void cbChoosePassenger_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                cmdChangeSeat.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                PassengerName Passenger1;
                Passenger1 = (PassengerName)cbChoosePassenger.SelectedItem;

                if (cbChoosePassenger.SelectedIndex == -1)
                {
                    lblPassengersSeatNumber.Content = "";
                    return;
                }

                //Set the seat label

                lblPassengersSeatNumber.Content = Passenger1.Seat_Number;
                if (cbChooseFlight.SelectedItem.ToString() == "102-Airbus A380")
                {
                    foreach (Label child in CanvasA380.Children)
                    {
                        if (child.Background == Brushes.Green)
                        {
                            child.Background = Brushes.Red;
                        }

                        if (child.Content.ToString() == (Passenger1.Seat_Number1.ToString()))
                        {
                            child.Background = Brushes.Green;
                        }

                    }
                }
                if (cbChooseFlight.SelectedItem.ToString() == "412-Boeing 767")
                {
                    foreach (Label child in Canvas767.Children)
                    {
                        if (child.Background == Brushes.Green)
                        {
                            child.Background = Brushes.Red;
                        }

                        if (child.Content.ToString() == (Passenger1.Seat_Number1.ToString()))
                        {
                            child.Background = Brushes.Green;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }

        private void Seat_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (wndAddPass.ClickAdd == true)
                {
                    Label MyLabel2 = (Label)sender;
                    if (MyLabel2.Background == Brushes.Blue)
                    {
                        MyLabel2.Background = Brushes.Green;
                        lblPassengersSeatNumber.Content = MyLabel2.Content.ToString();
                        cbChoosePassenger.IsEnabled = true;
                        cbChooseFlight.IsEnabled = true;
                        cmdAddPassenger.IsEnabled = true;
                        cmdDeletePassenger.IsEnabled = true;
                        cmdChangeSeat.IsEnabled = true;
                        FlightName FlightName1;
                        FlightName1 = (FlightName)cbChooseFlight.SelectedItem;
                        Info.AddPassengerTable1(wndAddPass.First_Name, wndAddPass.Last_Name);
                        Info.AddPassengerTable2(FlightName1.Flight_ID, Info.AddPassengerTable(wndAddPass.First_Name, wndAddPass.Last_Name), MyLabel2.Content.ToString());
                        cbChoosePassenger.ItemsSource = null;
                        cbChoosePassenger.Items.Clear();
                        cbChoosePassenger.ItemsSource = Info.PassengerNameTable(FlightName1.Flight_ID);
                        for (int i = 0; i < cbChoosePassenger.Items.Count; i++)
                        {
                            //Extract the passenger from the combo box
                            PassengerName Passenger3;
                            Passenger3 = (PassengerName)cbChoosePassenger.Items[i];

                            //If the seat number matches then select the passenger in the combo box
                            if (MyLabel2.Content.ToString() == Passenger3.Seat_Number1)
                            {
                                cbChoosePassenger.SelectedIndex = i;
                            }
                        }
                    }
                    else
                    { }



                }



                Label MyLabel = (Label)sender;//Get the label that the user clicked        
                wndAddPass = new wndAddPassenger();
                string sSeatNumber; //The seat number
                PassengerName Passenger1; //The Passenger


                if (MyLabel.Background == Brushes.Red)
                {
                    //Turn the seat green
                    MyLabel.Background = Brushes.Green;

                    //Get the seat number
                    sSeatNumber = MyLabel.Content.ToString();

                    //Loop through the items in the combo box
                    for (int i = 0; i < cbChoosePassenger.Items.Count; i++)
                    {
                        //Extract the passenger from the combo box
                        Passenger1 = (PassengerName)cbChoosePassenger.Items[i];

                        //If the seat number matches then select the passenger in the combo box
                        if (sSeatNumber == Passenger1.Seat_Number1)
                        {
                            cbChoosePassenger.SelectedIndex = i;
                        }
                    }
                }



                if (ClickChange == true)
                {
                    if (count == 1)
                    {
                        Label MyLabel1 = (Label)sender;//Get the label that the user clicked        

                        foreach (Label child in Canvas767.Children)
                        {
                            if (child.Background == Brushes.Green)
                            {
                                child.Background = Brushes.Blue;
                            }
                        }

                        foreach (Label child in CanvasA380.Children)
                        {
                            if (child.Background == Brushes.Green)
                            {
                                child.Background = Brushes.Blue;
                            }
                        }

                        count++;
                        if (MyLabel1.Background == Brushes.Blue)
                        {
                            //Turn the seat green

                            CurrentSeat = MyLabel1.Content.ToString();

                            PassengerName Passenger2;
                            Passenger2 = (PassengerName)cbChoosePassenger.SelectedItem;
                            Passenger2.Seat_Number = this.CurrentSeat;

                            Info.ChangeSeatTable(CurrentSeat, CurrentFlightID, CurrentPassengerID);
                            MyLabel1.Background = Brushes.Green;
                            lblPassengersSeatNumber.Content = CurrentSeat;
                            cbChoosePassenger.IsEnabled = true;
                            cbChooseFlight.IsEnabled = true;
                            cmdAddPassenger.IsEnabled = true;
                            cmdDeletePassenger.IsEnabled = true;
                            cmdChangeSeat.IsEnabled = true;

                        }

                        if (MyLabel1.Background == Brushes.Red)
                        {
                            MyLabel1.Background = Brushes.Red;
                        }
                    }


                    if (wndAddPass.ClickAdd == true)
                    {

                    }

                }
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void cmdChangeSeat_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                cbChoosePassenger.IsEnabled = false;
                cbChooseFlight.IsEnabled = false;
                cmdAddPassenger.IsEnabled = false;
                cmdDeletePassenger.IsEnabled = false;
                cmdChangeSeat.IsEnabled = false;
                lblPassengersSeatclick.Visibility = Visibility.Visible;

                PassengerName Passenger1;
                Passenger1 = (PassengerName)cbChoosePassenger.SelectedItem;
                this.CurrentSeat = Passenger1.Seat_Number;
                this.CurrentFlightID = Passenger1.Flight_ID;
                this.CurrentPassengerID = Passenger1.Passenger_ID;
                ClickChange = true;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void cmdDeletePassenger_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cmdChangeSeat.IsEnabled = false;
                cmdAddPassenger.IsEnabled = false;
                PassengerName Passenger1;
                Passenger1 = (PassengerName)cbChoosePassenger.SelectedItem;
                this.CurrentSeat = Passenger1.Seat_Number;
                this.CurrentFlightID = Passenger1.Flight_ID;
                this.CurrentPassengerID = Passenger1.Passenger_ID;
                this.CurrentFirstName = Passenger1.First_Name;
                this.CurrentLastNamel = Passenger1.Last_Name;
                Info.DeletePassengerTable(CurrentFlightID, CurrentPassengerID);

                lblPassengersSeatNumber.Content = "";
                cbChoosePassenger.ItemsSource = null;
                cbChoosePassenger.Items.Clear();
                cbChoosePassenger.ItemsSource = Info.PassengerNameTable(CurrentFlightID);
                cbChoosePassenger.SelectedIndex = -1;




                foreach (Label child in Canvas767.Children)
                {
                    if (child.Background == Brushes.Green)
                    {
                        child.Background = Brushes.Blue;
                    }
                }

                foreach (Label child in CanvasA380.Children)
                {
                    if (child.Background == Brushes.Green)
                    {
                        child.Background = Brushes.Blue;
                    }
                }


            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
    }

    }
    

