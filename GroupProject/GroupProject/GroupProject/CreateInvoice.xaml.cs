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
using System.ComponentModel;

namespace GroupProject
{
    /// <summary>
    /// Interaction logic for CreateInvoice.xaml
    /// Liz Ruttenbur
    /// </summary>
    public partial class CreateInvoice : Window
    {
        #region Attributes

        /// <summary>
        /// New Menu Object.
        /// </summary>
        MainWindow menu = new MainWindow();

        /// <summary>
        /// new invoice object
        /// </summary>
        Invoice information;
        /// <summary>
        /// this should hold the value for the total cost of the number of items.
        /// need Rachel's information to finish the calculation
        /// totalCharged = item cost + item cost + item cost;
        /// probably need a for loop.
        /// </summary>


        clsDataAccess ds;

        SQL clsSQL;

        wndInventory inventoryList;

        string invoiceID;

        #endregion

        #region Constructor
        public CreateInvoice()
        {
            try
            {
                InitializeComponent();
                clsSQL = new SQL();
                inventoryList = new wndInventory();
                ds = new clsDataAccess();
                information = new Invoice();

                int newInvoiceNum = clsSQL.getNewInvoiceID();
                lblInvoiceNum.Content = "Invoice #" + newInvoiceNum;

                cmbItemBox.ItemsSource = clsSQL.ItemsList;
                itemsListBox.ItemsSource = information.InvoiceItems;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        #endregion

        #region UI Methods
        /// <summary>
        /// closes this window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                menu = new MainWindow(); //instantiates the new menu object
                this.Hide(); //hides the create invoice window
                menu.Show(); //shows the menu window.


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        /// <summary>
        /// Saves the invoice to 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dateBox.Text == "") //makes sure this isn't empty
                {
                    MessageBox.Show("You must add a date");
                }
                else if (itemsListBox.Items.Count <= 0) //makes sure this isn't empty
                {
                    MessageBox.Show("You must add items to the invoice");
                }
                else
                {
                    information.InvoiceDate = dateBox.Text;

                    //add to database
                    string sql = clsSQL.CreateInvoice(dateBox.Text, information.TotalCharge.ToString());
                    ds.ExecuteNonQuery(sql);

                    InvoiceInfo info = new InvoiceInfo();
                    info.InvoiceTableshow().Clear();
                    menu.dataGrid.ItemsSource = info.InvoiceTableshow(); //calls the dataGrid.

                    menu.Show();
                    this.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        /// <summary>
        /// This will delete the item from the list.
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
                    int index = information.InvoiceItems.IndexOf((stStoreItem)itemsListBox.SelectedItem);
                    information.InvoiceItems.RemoveAt(index);
                    double dblTemp;
                    Double.TryParse(information.TotalCharge, out dblTemp);
                    dblTemp -= ((stStoreItem)itemsListBox.SelectedItem).ItemCost;
                    information.TotalCharge = dblTemp.ToString();
                    totalCharge.Content = information.TotalCharge;

                    clsSQL.InvoiceDeleteLink(invoiceID);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        /// <summary>
        /// This will enable you to add the selected item in the combo box to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                itemsListBox.IsEnabled = true; //enables the items list box which will allow items to be saved.
                information.InvoiceItems.Add((stStoreItem)cmbItemBox.SelectedItem);

                invoiceID = clsSQL.getNewInvoiceID().ToString();
                string itemIndex = (itemsListBox.Items.Count + 1).ToString();
                string itemID = ((stStoreItem)cmbItemBox.SelectedItem).ItemID;
                clsSQL.CreateLink(invoiceID, itemIndex, itemID);

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

                totalCharge.Content = information.TotalCharge;
            }
            catch(Exception exc)
            {
                //if there is nothing selected in the combo box it will return a message asking 
                //the user to select an item first.
                MessageBox.Show(exc.Message);
            }
        }
    }
}
#endregion