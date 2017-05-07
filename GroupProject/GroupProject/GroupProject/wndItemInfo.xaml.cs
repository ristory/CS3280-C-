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

namespace GroupProject
{
    /*
    * Author: Rachel Berghout
    */

    /// <summary>
    /// Interaction logic for wndItemInfo.xaml
    /// </summary>
    public partial class wndItemInfo : Window
    {
        /// <summary>
        /// Default Constructor 
        /// Initializes the screen
        /// </summary>
        public wndItemInfo()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Method to close the window and 
        /// add an item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool blInputGood = true;
                //check if text boxes are filled
                /*if (txtType.Text == "")
                {
                    //color box red
                    blInputGood = false;
                }*/
                if (txtCost.Text == "")
                {
                    blInputGood = false;
                }
                if (txtDescription.Text == "")
                {
                    blInputGood = false;
                }

                //save text to variables
                if (blInputGood == true)
                {
                    //ItemType = txtType.Text;
                    ItemDescription = txtDescription.Text;
                    double dblTemp;
                    double.TryParse(txtCost.Text, out dblTemp);
                    ItemCost = dblTemp;

                    DialogResult = true;
                    Hide();
                }
                DialogResult = false;
                //Close();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Method to cancel adding an Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Hide();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Method to make sure only money values are allowed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCost_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                //add a boolean variable that makes sure only one '.' is entered.
                //needs to check if the inputed text is numbers, '.', and 'enter'
                //no letters!
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Method to Fill the textboxes of 
        /// an item's information
        /// </summary>
        /// <param name="i_code">The name of the selected item</param>
        /// <param name="i_cost">The cost of the selected item</param>
        /// <param name="i_description">The description of the selected item</param>
        public void FillTextBoxes(/*string i_code,*/ string i_description, double i_cost)
        {
            try
            {
                //fill textboxes
                //txtType.Text = i_code;
                txtCost.Text = i_cost.ToString();
                txtDescription.Text = i_description;

                //changes btnAddItem content/text to 'Save Item'
                btnAddItem.Content = "Save Item";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Method to return the name of 
        /// the added item
        /// </summary>
        public string ItemType
        {
            set;
            get;
        }

        /// <summary>
        /// Method to return the cost of the
        /// added item
        /// </summary>
        public double ItemCost
        {
            set;
            get;
        }

        /// <summary>
        /// Method to return the description of 
        /// the added item
        /// </summary>
        public string ItemDescription
        {
            set;
            get;
        }

        public bool Result
        {
            set;
            get;
        }
    }
}
