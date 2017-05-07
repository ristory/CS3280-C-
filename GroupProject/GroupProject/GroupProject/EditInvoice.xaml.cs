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
using System.Windows.Shapes;
using System.ComponentModel; //

namespace GroupProject
{
    /// <summary>
    /// Interaction logic for EditInvoice.xaml
    /// </summary>
    public partial class EditInvoice : Window
    {
        #region Attributes
        /// <summary>
        /// new menu object.
        /// </summary>
        MainWindow menu;
        /// <summary>
        /// new invoice object.
        /// </summary>
        SearchInvoice invoice;

        /// <summary>
        /// new db object
        /// </summary>
        clsDataAccess ds;

        /// <summary>
        /// new SQL object
        /// </summary>
        SQL clsSQL;
 
        /// <summary>
        /// The variable to save the currently selected invoice
        /// </summary>
        Invoice information;

        #endregion
        /// <summary>
        /// Constructor
        /// </summary>
        public EditInvoice()
        {
            try
            {
                InitializeComponent();
                //menu = new MainWindow();
                invoice = new SearchInvoice();
                ds = new clsDataAccess();
                clsSQL = new SQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region UI methods
        /// <summary>
        /// this button will add the selected item to the invoice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                itemsListBox.IsEnabled = true; //enables the items list box which will allow items to be saved.
                information.InvoiceItems.Add((stStoreItem)cmbItemBox.SelectedItem);

                if (information.InvoiceItems.Count == 1)
                {
                    information.TotalCharge = ((stStoreItem)cmbItemBox.SelectedItem).ItemCost.ToString();
                }
                else
                {
                    double dblTemp;
                    Double.TryParse(information.TotalCharge, out dblTemp);
                    dblTemp += ((stStoreItem)cmbItemBox.SelectedItem).ItemCost;
                    information.TotalCharge = dblTemp.ToString();
                }

                totalChargedLbl.Content = information.TotalCharge; //updates the total charged label
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        /// <summary>
        /// This button will delete the selected item from the invoice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //shows a message to make sure you want to delete the item.
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete " + itemsListBox.SelectedItem + " ?", "Confirm Deletion:", MessageBoxButton.YesNoCancel);
                if (MessageBoxResult.Yes == result)
                {
                    double dblTemp;
                    Double.TryParse(information.TotalCharge, out dblTemp);
                    dblTemp -= ((stStoreItem)itemsListBox.SelectedItem).ItemCost;
                    information.TotalCharge = dblTemp.ToString();

                    int index = information.InvoiceItems.IndexOf((stStoreItem)itemsListBox.SelectedItem);
                    information.InvoiceItems.RemoveAt(index); //deletes the item from the list

                    totalChargedLbl.Content = information.TotalCharge;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        /// <summary>
        /// this button will save the invoice to the database.
        /// and then return you to the main menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //this will save the update invoice to the database.

                //takes you back to the main menu
                menu = new MainWindow();

                InvoiceInfo info = new InvoiceInfo();
                info.InvoiceTableshow().Clear();
                menu.dataGrid.ItemsSource = info.InvoiceTableshow(); //calls the dataGrid.

                clsSQL.UpdateLink(information.InvoiceItems, information.InvoiceNum);

                clsSQL.genLink(information.InvoiceNum);
                this.Hide();
                menu.Show();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        /// <summary>
        /// This button will return you to the edit and delete invoice window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //takes you back to the edit and delete invoice window.
                menu = new MainWindow();

                information.InvoiceItems = OrigList;

                this.Hide();
                menu.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        /// <summary>
        /// Method to change the invoice with the search window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeInvoiceBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //takes you back to the edit and delete invoice window.
                //invoice = new UpDelInvoice();
                invoice = new SearchInvoice();
                this.Hide();
                invoice.Show();
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
        }

        /// <summary>
        /// Method to set the invoice to view in the screen
        /// </summary>
        /// <param name="info"></param>
        public void setInvoice(Invoice info)
        {
            try
            {
                information = info;

                cmbItemBox.ItemsSource = clsSQL.ItemsList; //loads the items into the combo box
                invoiceNumLbl.Content = "Invoice # " + information.InvoiceNum; //shows the invoice number 
                invoiceDateLbl.Content = information.InvoiceDate; //shows the date for the invoice
                totalChargedLbl.Content = information.TotalCharge; //shows total charge for the invoice
                itemsListBox.ItemsSource = information.InvoiceItems;  //loads the items from the invoice into the items datagrid
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Getter and Setter to easily replace the original
        /// list if the user selects cancel
        /// </summary>
        public BindingList<stStoreItem> OrigList
        {
            get;
            set;
        }
    }
        #endregion
}
