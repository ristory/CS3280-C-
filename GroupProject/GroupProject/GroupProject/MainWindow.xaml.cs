using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Data; //
using System.ComponentModel; //

namespace GroupProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml This will enable you to reach the other windows
    /// Liz Ruttenbur
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        #region Attributes
        /// <summary>
        /// new invoice object
        /// </summary>
        CreateInvoice invoice;


        /// <summary>
        /// new object for edit invoice
        /// </summary>
        EditInvoice editedInvoice;

        /// <summary>
        /// search window object
        /// </summary>

        SearchInvoice searchedInvoice;

        /// <summary>
        /// new inventory window object
        /// </summary>
        wndInventory inventoryWin;

        /// <summary>
        /// invoice object
        /// </summary>
        InvoiceInfo information;

        /// <summary>
        /// new database object.
        /// </summary>
        clsDataAccess dataAccess;

        /// <summary>
        /// Currently Selected Invoice Object
        /// </summary>
        Invoice info;

        /// <summary>
        /// SQL object
        /// </summary>
        SQL clsSQL;

        //public Invoice info;

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindow()
        {
            try
            {
                InitializeComponent();

                //tell the window to close everything when the close button is clicked
                Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;

                dataGrid.Items.Clear();
                information = new InvoiceInfo(); //instantiates the new invoice object
                clsSQL = new SQL();
                dataAccess = new clsDataAccess();
                dataGrid.ItemsSource = information.InvoiceTableshow(); //calls the dataGrid.
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        #endregion

        #region UI Methods

        /// <summary>
        /// upon clicking with the mouse, this will bring up the new invoice window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createNewInvoiceBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                invoice = new CreateInvoice(); //instantiates a new invoice object
                this.Hide();//closes the current window
                invoice.Show(); //calls the Create New Invoice Window.
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        /// <summary>
        /// This will bring up the search Window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchInvoiceBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                ///calls the search Window
                searchedInvoice = new SearchInvoice();
                searchedInvoice.SetMain = this;
                this.Hide();
                searchedInvoice.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        /// <summary>
        /// This will bring up the inventory list window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inventoryBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                //instantiates the new window and calls the inventory Window.
                inventoryWin = new wndInventory();
                this.Hide();
                inventoryWin.SetMain = this;
                inventoryWin.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        /// <summary>
        /// This method will delete the selected invoice from the list.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteInvoiceBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete " + dataGrid.SelectedItem + " ?", "Confirm Deletion:", MessageBoxButton.YesNoCancel);
                if (MessageBoxResult.Yes == result)
                {


                    string sql = clsSQL.DeleteLineItems(((Invoice)dataGrid.SelectedItem).InvoiceNum);
                    dataAccess.ExecuteNonQuery(sql);

                    sql = clsSQL.DeleteInvoice(((Invoice)dataGrid.SelectedItem).InvoiceNum);
                    dataAccess.ExecuteNonQuery(sql);

                    information.InvoiceTableshow().Clear();
                    dataGrid.ItemsSource = information.InvoiceTableshow(); //calls the dataGrid.
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        /// <summary>
        /// This will enable you to edit an invoice from the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editnvoice(object sender, RoutedEventArgs e)
        {
            try
            {
                //once a invoice is created this will open up a window that will enable you
                //to edit and/or delete the invoice.
                editedInvoice = new EditInvoice();

                clsSQL.genLink(((Invoice)dataGrid.SelectedItem).InvoiceNum);

                editedInvoice.setInvoice((Invoice)dataGrid.SelectedItem);
                editedInvoice.OrigList = ((Invoice)dataGrid.SelectedItem).InvoiceItems;

                this.Hide();
                editedInvoice.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        #endregion

    }
}
