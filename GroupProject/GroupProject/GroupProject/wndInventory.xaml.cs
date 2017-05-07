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
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
using System.ComponentModel;

namespace GroupProject
{
    /*
    * Author: Rachel Berghout
    */

    /// <summary>
    /// Struct to store a StoreItem's information
    /// </summary>
    public struct stStoreItem
    {
        private string ID;
        private double cost;
        private string description;

        /// <summary>
        /// Method to set and return the Store Item ID
        /// </summary>
        public string ItemID
        {
            set
            {
                ID = value;
            }
            get
            {
                return ID;
            }
        }

        /// <summary>
        /// Method to set and return the Store Item Cost
        /// </summary>
        public double ItemCost
        {
            set
            {
                cost = value;
            }
            get
            {
                return cost;
            }
        }

        /// <summary>
        /// Method to set and return the Store Item Description
        /// </summary>
        public string ItemDescription
        {
            set
            {
                description = value;
            }
            get
            {
                return description;
            }
        }

        public override string ToString()
        {
            return description + " $" + cost;
        }
    }


    /// <summary>
    /// Interaction logic for wndInventory.xaml
    /// </summary>
    public partial class wndInventory : Window
    {
        SQL dr; //connecting to class to get inventory
        private BindingList<stStoreItem> lstItemInventory; //list to keep track of Items in the Inventory
        int itemIndex; //the selected item index
        stStoreItem selItem; //the selected Item object
        MainWindow main; //keeps track of the main window
        DataSet ds; //a class-wide data set collection

        /// <summary>
        /// Default constructor to initialize the window
        /// </summary>
        public wndInventory()
        {
            try
            {
                InitializeComponent();
                loadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Method to load the DataGrid
        /// </summary>
        private void loadDataGrid()
        {
            try
            {
                dr = new SQL();
                ds = dr.genItems();

                dr.ItemsList.Clear();
                dgItemList.ItemsSource = dr.ItemsList;
                lstItemInventory = dr.ItemsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        /// <summary>
        /// Method to add a new item to the inventory.
        /// Will call a new window to get information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// ??? Using Dialog Result is causing an error, however, it goes through and adds the item...???
        private void btnNewItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //instantiate a new AddItem window as clsAddNewItem
                wndItemInfo clsAddNewItem = new wndItemInfo();

                //enables the type
                //clsAddNewItem.txtType.IsReadOnly = false;

                //show clsAddNewItem window
                clsAddNewItem.ShowDialog();

                if (clsAddNewItem.DialogResult == true)
                {
                    //add new Item to database
                    dr.addItem(/*clsAddNewItem.ItemType,*/ clsAddNewItem.ItemDescription, clsAddNewItem.ItemCost);

                    //update view and list
                    loadDataGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Method to change an Item in the Inventory.
        /// Will update the datagrid that showes the inventory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //instantiate a new AddItem window as clsAddNewItem
                wndItemInfo wndEditItem = new wndItemInfo();

                //get the item's information
                string code = dr.GetItemCode(itemIndex);
                string description = dr.GetItemDesc(itemIndex);
                double cost = dr.GetItemCost(itemIndex);

                //fill in the information in the dialog
                wndEditItem.FillTextBoxes(/*code,*/ description, cost);

                //make sure the code is not able to change
               // wndEditItem.txtType.IsReadOnly = true;

                //show clsAddNewItem window
                wndEditItem.ShowDialog();

                if (wndEditItem.DialogResult == true)
                {
                    //updates selected Item in database & list
                    dr.updateItem(dr.GetItemCode(itemIndex), wndEditItem.ItemDescription, wndEditItem.ItemCost, itemIndex);

                    lstItemInventory = dr.ItemsList;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Method to delete the selected Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //checks if the Item is in an invoce
                if (dr.inInvoice(selItem.ItemID) == false)
                {
                    //sends an error message if it is in an invoce
                    MessageBox.Show("Sorry, the item cannot be deleted at this time.");
                    return;
                }

                //deletes the Item if it's not in an invoice
                dr.deleteItem(selItem);

                //updates table
                loadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Method to close and save the Inventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //saves everything to the database to make sure it's updated?
                //close screen
                Close();
                main.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Method to change the index of the selected Item 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgItemList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                //get the selected Item from the datagrid
                itemIndex = dgItemList.SelectedIndex;

                if (itemIndex != -1)
                {
                    btnEditItem.IsEnabled = true;
                    btnDeleteItem.IsEnabled = true;

                    //get item info
                    selItem = (stStoreItem)dgItemList.SelectedItem;
                }
                //if no selected Item (ex item was deleted?) return selected item to null
                else
                {
                    btnEditItem.IsEnabled = false;
                    btnDeleteItem.IsEnabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Method to get the Item Inventory
        /// </summary>
        public BindingList<stStoreItem> Inventory
        {
            get
            {
                return lstItemInventory;
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
