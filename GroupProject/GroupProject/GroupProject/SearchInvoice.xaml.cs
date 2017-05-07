using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace GroupProject
{
    /// <summary>
    /// Interaction logic for SearchInvoice.xaml
    /// </summary>
    public partial class SearchInvoice : Window
    {

        InvoiceInfo information = new InvoiceInfo();
        public string InvoiceNum;
        public string InvoiceDate;
        public string TotalCharge;
        MainWindow main;// = new MainWindow();
        ObservableCollection<Invoice> CurrentInvoiceSelected = new ObservableCollection<Invoice>();
       
        /// <summary>
        /// Constructor
        /// </summary>
        public SearchInvoice()
        {
            try
            {
                InitializeComponent();
                // I will import the combobox with the same method

                //Get the data to be put into the DataGrid
                dataGrid.ItemsSource = information.InvoiceTableshow();
                Invoicecombo.ItemsSource = information.InvoiceNumcombo();
                Datecombo.ItemsSource = information.InvoiceDatecombo();
                ChargeCombo.ItemsSource = information.TotalChargecombo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to clear the comboboxes of 
        /// selected text and reset the window 
        /// to it's default state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Clear the list, set the ComboboxIndex and load the dataGrid
                information.InvoiceTableshow().Clear();
                Invoicecombo.SelectedIndex = -1;
                Datecombo.SelectedIndex = -1;
                ChargeCombo.SelectedIndex = -1;
                dataGrid.ItemsSource = information.InvoiceTableshow();
            }
            catch(Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to set the selected invoice and view it in 
        /// a different window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dataGrid.SelectedIndex != -1)
                {
                    Invoice CurrentInvoiceSelected;
                    CurrentInvoiceSelected = (Invoice)dataGrid.SelectedItem;
                    this.InvoiceDate = CurrentInvoiceSelected.InvoiceDate;
                    this.TotalCharge = CurrentInvoiceSelected.TotalCharge.ToString();
                    this.InvoiceNum = information.CurrentInvoiceNumTableshow(this.InvoiceDate, this.TotalCharge);

                    EditInvoice editedInvoice = new EditInvoice();
                    editedInvoice.setInvoice(CurrentInvoiceSelected);
                    editedInvoice.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to Cancel selecting an invoice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                main.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to change the view in the datagrid in order to limit
        /// the selection by invoice number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Invoicecombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (Invoicecombo.SelectedIndex == -1)
                {
                    return;
                }
                else
                {
                    string a = Invoicecombo.SelectedItem.ToString();
                    information.InvoiceTableshow().Clear();
                    dataGrid.ItemsSource = information.InvoiceTableshowInvoiceNum(a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to change the view in the datagrid in order to limit
        /// the selection by date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Datecombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (Datecombo.SelectedIndex == -1)
                {
                    return;
                }
                else
                {

                    string a = Datecombo.SelectedItem.ToString();
                    information.InvoiceTableshow().Clear();
                    dataGrid.ItemsSource = information.InvoiceTableshowInvoiceDate(a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to change the view in the datagrid in order to limit
        /// the selection by ammount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChargeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (ChargeCombo.SelectedIndex == -1)
                {
                    return;
                }
                else
                {
                    string a = ChargeCombo.SelectedItem.ToString();
                    information.InvoiceTableshow().Clear();
                    dataGrid.ItemsSource = information.InvoiceTableshowTotalCharge(a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to set the main window so that it will open back up
        /// </summary>
        public MainWindow SetMain
        {
            set
            {
                main = value;
            }
        }
    }
}
