using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //
using System.ComponentModel; //
using System.Reflection; //

namespace GroupProject
{
    public class SQL
    {
        string sql; //string variable that saves the current SQL statement

        /// <summary>
        /// Method to Generate the SQL statement to select the
        /// all the data of an invoice from the database
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string InvoiceTable()
        {
            sql = "SELECT * FROM Invoices";
            return sql;
        }

        /// <summary>
        /// Method to Generate the SQL statement to select the
        /// Invoice Number of an invoice
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string SelectInvoiceData()
        {
            sql = "Select InvoiceNum From Invoices";
            return sql;
        }

        /// <summary>
        /// Method to Generate the SQL statement to select the
        /// ID of an invoice
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string SelectInvoiceNum(string a)
        {
            string sSQL = "SELECT * FROM Invoices WHERE InvoiceNum = " + a;

            return sSQL;
        }

        /// <summary>
        /// Method to Generate the SQL statement to select the
        /// date of an invoice
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string SelectInvoiceDate(string a)
        {
            string sSQL = "SELECT * FROM Invoices WHERE InvoiceDate = #" + a + "#";

            return sSQL;
        }

        /// <summary>
        /// Method to Generate the SQL statement to select the
        /// total charge of an invoice
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string SelectTotalCharge(string a)
        {
            string sSQL = "SELECT * FROM Invoices WHERE TotalCharge = " + a;

            return sSQL;
        }

        /// <summary>
        /// Method to Generate the SQL statement to select an invoice
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string SelectDateData()
        {
            sql = "Select InvoiceDate From Invoices";
            return sql;
        }

        /// <summary>
        /// Method to Generate the SQL statement to create an invoice
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string CreateInvoice(string a, string b)
        {
            sql = "INSERT INTO Invoices (InvoiceDate, TotalCharge) Values(#" + a + "#, " + b +")";
            return sql;
        }

        /// <summary>
        /// Method to Generate the SQL statement to update an invoice
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string UpdateInvoice(string a, string b, string c)
        {
            sql = "UPDATE Invoices SET InvoiceDate = " + a + " TotalCharge = " + b + " WHERE INVOICEID = " + c;
            return sql;
        }

        /// <summary>
        /// Method to Generate the SQL statement to delete an invoice
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string DeleteInvoice(string a)
        {
            sql = "DELETE FROM Invoices WHERE InvoiceNum = " + a;
            return sql;
        }

        /// <summary>
        /// Method to Generate the SQL statement to delete any
        /// Items in the invoice
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string DeleteLineItems(string a)
        {
            sql = "DELETE FROM LineItems WHERE InvoiceNum = " + a;
            return sql;
        }

        /// <summary>
        /// Method to Generate the SQL statement to add an invoice
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string InvoiceNum(string a, string b)
        {
            sql = "SELECT InvoiceNum from Invoices where InvoiceDate = #" + a + "# AND TotalCharge = " + b;

            return sql;
        }

        #region Methods for Inventory
        /*
         * This region is written by Rachel Berghout
         */

        /// <summary>
        /// List of Items to be returned
        /// </summary>
        BindingList<stStoreItem> lstItems = new BindingList<stStoreItem>();

        /// <summary>
        /// Method to add a new Item to an invoice
        /// </summary>
        /// <param name="thisInvoice"></param>
        /// <param name="newItem"></param>
        /// <returns></returns>
        public BindingList<stStoreItem> AddInvoiceItems(Invoice thisInvoice, stStoreItem newItem)
        {
            try
            {
                //insert into list
                thisInvoice.addItems(newItem);

                //find max list item
                sql = "SELECT COUNT(ItemCode) FROM LineItems WHERE InvoiceNum = " + thisInvoice.InvoiceNum;

                // int index = ;
                //int index = thisInvoice.InvoiceItemList.Count() - 1;


                //add to database
                //sql = "INSERT INTO LineItems (InvoiceNum, LineItemNumber, ItemCode) " +
                //    "VALUES (" + thisInvoice.InvoiceNum + "," + index + ",'" + newItem.ItemCode +"')"; 

                //return list
                return thisInvoice.InvoiceItems;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name +
                    " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to pull a list of items from the
        /// database
        /// </summary>
        /// <returns></returns>
        public DataSet genItems()
        {
            try
            {
                string sql; //sql statement to get desired info
                clsDataAccess db = new clsDataAccess(); //variable to access the database
                int retVal = 0;
                double dblTemp;

                sql = "SELECT * FROM ItemDesc";

                Items = db.ExecuteSQLStatement(sql, ref retVal);

                //clear list
                lstItems.Clear();

                //make into list
                for (int i = 0; i < retVal; i++)
                {
                    stStoreItem newItem = new stStoreItem();

                    newItem.ItemID = Items.Tables[0].Rows[i][0].ToString();
                    newItem.ItemDescription = Items.Tables[0].Rows[i][1].ToString();
                    double.TryParse(Items.Tables[0].Rows[i][2].ToString(), out dblTemp);
                    newItem.ItemCost = dblTemp;
                    lstItems.Add(newItem);
                }

                return Items;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name +
                    " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to add a new item to the database
        /// </summary>
        /// <param name="s_desc"></param>
        /// <param name="d_cost"></param>
        public void addItem(string s_desc, double d_cost)
        {
            try
            {
                string sql;
                clsDataAccess db = new clsDataAccess(); //variable to access the database
                string maxCode = "";
                int intTemp;
                string u = "";
                //bool newType = false;

                //generate code
                //sql = "SELECT MAX(ItemCode) FROM ItemDesc WHERE ItemCode LIKE '" + s_type + "%'";
                sql = "SELECT MAX(ItemCode) FROM ItemDesc";
                maxCode = db.ExecuteScalarSQL(sql);

                //take out the type, only get the number
                for (int i = 2; i < maxCode.Length; i++)
                {
                    u += maxCode[i];
                }

                //convert to a number
                Int32.TryParse(u, out intTemp);
                u = "";

                //increase the number
                //u += "IC";
                u += (intTemp + 1);
                maxCode = u;

                //insert info
                sql = "INSERT INTO ItemDesc (ItemCode,  ItemDesc, Cost) VALUES ('" + maxCode + "', '" + s_desc
                    + "', " + d_cost + ")";
                db.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to update an item in the database
        /// </summary>
        /// <param name="s_code"></param>
        /// <param name="s_desc"></param>
        /// <param name="d_cost"></param>
        /// <param name="i_index"></param>
        public void updateItem(string s_code, string s_desc, double d_cost, int i_index)
        {
            try
            {
                //update database
                Items.Tables[0].Rows[i_index][1] = s_desc;
                Items.Tables[0].Rows[i_index][2] = d_cost;

                //update list
                stStoreItem updatedItem = new stStoreItem();
                updatedItem.ItemID = s_code;
                updatedItem.ItemCost = d_cost;
                updatedItem.ItemDescription = s_desc;

                lstItems.RemoveAt(i_index);
                lstItems.Insert(i_index, updatedItem);
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name +
                    " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Metod to delete an Item from the Inventory
        /// </summary>
        /// <param name="thisItem"></param>
        public void deleteItem(stStoreItem thisItem)
        {
            try
            {
                //get the sql statement
                string sql = "DELETE FROM ItemDesc WHERE ItemCode = '" + thisItem.ItemID + "'";
                clsDataAccess db = new clsDataAccess();

                //delete the item
                db.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name +
                    " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to return if the invoice exists
        /// </summary>
        /// <param name="curItemCode"></param>
        /// <returns></returns>
        public bool inInvoice(string curItemCode)
        {
            try
            {
                //check if the Item is in an invoice
                string sql = "SELECT * FROM LineItems WHERE ItemCode = " + curItemCode + "";
                int retVal = 0;
                DataSet dsLineItems;
                clsDataAccess db = new clsDataAccess();

                dsLineItems = db.ExecuteSQLStatement(sql, ref retVal);

                if (retVal > 0)
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name +
                    " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to return a list of item ID's
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetItemCode(int index)
        {
            return lstItems[index].ItemID;
        }

        /// <summary>
        /// Method to return a list of Item Descriptions
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetItemDesc(int index)
        {
            return lstItems[index].ItemDescription;
        }

        /// <summary>
        /// Method to return the list of Costs for the items
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public double GetItemCost(int index)
        {
            return lstItems[index].ItemCost;
        }

        /// <summary>
        /// Method to return the list of Items
        /// from the database
        /// </summary>
        public BindingList<stStoreItem> ItemsList
        {
            get
            {
                genItems();
                return lstItems;
            }
        }

        /// <summary>
        /// Method to get and set the Items dataset
        /// </summary>
        public DataSet Items
        {
            get;
            set;
        }

        #endregion Methods for Inventory

        #region Methods for Main Window and Create/Edit Inventory Windows

        /// <summary>
        /// Method to generate the list of items in an invoice
        /// </summary>
        /// <param name="invoiceNum"></param>
        /// <returns></returns>
        public BindingList<stStoreItem> genLink(string invoiceNum)
        {
            try
            {
                //select the invoices
                //string sql = "SELECT in.InvoiceDate, in.TotalCharge, id.ItemDesc, id.Cost" +
                //    "FROM Invoices in INNER JOIN LineItems li, INNTER JOIN ";
                string sql = "SELECT li.LineItemNum, li.ItemCode, id.ItemDesc, id.Cost " +
                    "FROM LineItems li "+
                    "INNER JOIN ItemDesc id ON li.ItemCode = id.ItemCode " +
                     "WHERE InvoiceNum = " + invoiceNum;
                int iRetVal = 0;

                //select the Items
                clsDataAccess db = new clsDataAccess();
                DataSet ds = db.ExecuteSQLStatement(sql, ref iRetVal);

                BindingList<stStoreItem> lstInvoiceItems = new BindingList<stStoreItem>();
                //assign items to invoices based on LineitemLink
                for (int i = 0; i < iRetVal; i++)
                {
                    stStoreItem NewInvoiceItem = new stStoreItem();
                    NewInvoiceItem.ItemID = ds.Tables[0].Rows[i][1].ToString();
                    NewInvoiceItem.ItemDescription = ds.Tables[0].Rows[i][2].ToString();
                    double dblTemp;
                    double.TryParse(ds.Tables[0].Rows[i][3].ToString(), out dblTemp);
                    NewInvoiceItem.ItemCost = dblTemp;

                    lstInvoiceItems.Add(NewInvoiceItem);
                }

                //return list
                return lstInvoiceItems;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to get the Invoice ID that will be the next 
        /// to automattically generate.
        /// </summary>
        /// <returns></returns>
        public int getNewInvoiceID()
        {
            try
            {
                string sql = "Select MAX(InvoiceNum) FROM Invoices";

                clsDataAccess db = new clsDataAccess();
                string retVal = db.ExecuteScalarSQL(sql);
                int intTemp;
                Int32.TryParse(retVal, out intTemp);

                return intTemp + 1;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method to delete all the links for an invoice
        /// </summary>
        /// <param name="invoiceID"></param>
        public void InvoiceDeleteLink(string invoiceID)
        {
            try
            {
                string sql = "DELETE FROM LineItems WHERE InvoiceNum = " + invoiceID;
                clsDataAccess db = new clsDataAccess();
                db.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Method to create a new link. This links an item and
        /// an invoice together
        /// </summary>
        /// <param name="invoiceID"></param>
        /// <param name="indx"></param>
        /// <param name="itemID"></param>
        public void CreateLink(string invoiceID, string indx, string itemID)
        {
            try
            {
                sql = "INSERT INTO LineItems (InvoiceNum, LineItemNum, ItemCode) VALUES (" + invoiceID + "," + indx + "," + itemID + ")";

                clsDataAccess db = new clsDataAccess();
                db.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Method to update the LineItems table that links the items
        /// and the invoices together
        /// </summary>
        /// <param name="list"></param>
        /// <param name="invoiceID"></param>
        public void UpdateLink(BindingList<stStoreItem> list, string invoiceID)
        {
            try
            {
                InvoiceDeleteLink(invoiceID);

                int i = 0;
                foreach (stStoreItem item in list)
                {
                    CreateLink(invoiceID, i.ToString(), item.ItemID);
                    i++;
                }
            }
            catch (Exception ex)
            {

            }
        }
        #endregion Method for Main Window
    }
}
