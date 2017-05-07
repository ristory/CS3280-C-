using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
//using static GroupProject.SearchInvoice;

namespace GroupProject
{
    /// <summary>
    /// Class to help with some of the lists
    /// related to the invoices
    /// </summary>
    public class InvoiceInfo
    {
        //Class variables
        public string InvoiceID;
        public string InvoiceDate;
        public string InvoiceCharge;

        //use to access the SQL
        SQL method = new SQL();

        /// <summary>
        /// Used to access the database
        /// </summary>
        clsDataAccess db = new clsDataAccess();

        /// <summary>
        /// Holds the info from the database
        /// </summary>
        DataSet ds = new DataSet();

        int iRet = 0;
        string c;

        /// <summary>
        /// Use the BindingList class instead of the List class when you are going to bind data to a DataGridView.  The BindingList
        /// class allows for communication between it and the DataGridView.  This communication allows items to be added or removed
        /// from the BindingList or DataGridView.
        /// </summary>
        BindingList<Invoice> Invoicedata = new BindingList<Invoice>();
        BindingList<InvoiceNum1> InvoiceNumdata = new BindingList<InvoiceNum1>();
        BindingList<InvoiceDate1> InvoiceDateData = new BindingList<InvoiceDate1>();
        BindingList<TotalCharge1> TotalChargeData = new BindingList<TotalCharge1>();
        BindingList<Invoice> CurrentInvoiceNum = new BindingList<Invoice>();
        /// <summary>
        /// Method to update the list of invoices
        /// </summary>
        /// <returns></returns>
        public BindingList<Invoice> InvoiceTableshow()
        {
            try
            {

                string data = method.InvoiceTable();
                ds = db.ExecuteSQLStatement(data, ref iRet);
                for (int i = 0; i < iRet; i++)
                {
                    Invoicedata.Add(new Invoice
                    {
                        InvoiceNum = ds.Tables[0].Rows[i][0].ToString(),
                        InvoiceDate = ds.Tables[0].Rows[i][1].ToString(),
                        TotalCharge = ds.Tables[0].Rows[i][2].ToString(),
                        InvoiceItems = method.genLink(ds.Tables[0].Rows[i][0].ToString())
                    });

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            return Invoicedata;
        }

        /// <summary>
        /// Method to change the invoice list
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string CurrentInvoiceNumTableshow(string a, string b)
        {
            try
            {

                string data = method.InvoiceNum(a, b);
                c = db.ExecuteScalarSQL(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            return c;
        }

        /// <summary>
        /// Method to change the invoice list to show the invoice number
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public BindingList<Invoice> InvoiceTableshowInvoiceNum(string a)
        {
            try
            {
                string data = method.SelectInvoiceNum(a);
                ds = db.ExecuteSQLStatement(data, ref iRet);
                for (int i = 0; i < iRet; i++)
                {
                    Invoicedata.Add(new Invoice
                    {
                        InvoiceNum = ds.Tables[0].Rows[i][0].ToString(),
                        InvoiceDate = ds.Tables[0].Rows[i][1].ToString(),
                        TotalCharge = ds.Tables[0].Rows[i][2].ToString(),
                        InvoiceItems = method.genLink(ds.Tables[0].Rows[i][0].ToString())
                    });

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            return Invoicedata;
        }

        /// <summary>
        /// Method to change the invoice list to show the invoice date
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public BindingList<Invoice> InvoiceTableshowInvoiceDate(string a)
        {
            try
            {
                string data = method.SelectInvoiceDate(a);
                ds = db.ExecuteSQLStatement(data, ref iRet);
                for (int i = 0; i < iRet; i++)
                {
                    Invoicedata.Add(new Invoice
                    {
                        InvoiceNum = ds.Tables[0].Rows[i][0].ToString(),
                        InvoiceDate = ds.Tables[0].Rows[i][1].ToString(),
                        TotalCharge = ds.Tables[0].Rows[i][2].ToString()
                    });

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            return Invoicedata;
        }

        /// <summary>
        /// Method to change the invoice list to show the invoice total charge
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public BindingList<Invoice> InvoiceTableshowTotalCharge(string a)
        {
            try
            {
                string data = method.SelectTotalCharge(a);
                ds = db.ExecuteSQLStatement(data, ref iRet);
                for (int i = 0; i < iRet; i++)
                {
                    Invoicedata.Add(new Invoice
                    {
                        InvoiceNum = ds.Tables[0].Rows[i][0].ToString(),
                        InvoiceDate = ds.Tables[0].Rows[i][1].ToString(),
                        TotalCharge = ds.Tables[0].Rows[i][2].ToString()
                    });

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            return Invoicedata;
        }

        /// <summary>
        /// Method to change the invoice list to show the invoice ID
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public BindingList<InvoiceNum1> InvoiceNumcombo()
        {
            try
            {
                string data = method.InvoiceTable();
                ds = db.ExecuteSQLStatement(data, ref iRet);
                for (int i = 0; i < iRet; i++)
                {
                    InvoiceNumdata.Add(new InvoiceNum1 { InvoiceNum = ds.Tables[0].Rows[i][0].ToString() });

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            return InvoiceNumdata;
        }

        /// <summary>
        /// Method to change the combobox list to show the invoice date
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public BindingList<InvoiceDate1> InvoiceDatecombo()
        {
            try
            {
                string data = method.InvoiceTable();
                ds = db.ExecuteSQLStatement(data, ref iRet);
                for (int i = 0; i < iRet; i++)
                {
                    InvoiceDateData.Add(new InvoiceDate1 { InvoiceDate = ds.Tables[0].Rows[i][1].ToString() });

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            return InvoiceDateData;
        }

        /// <summary>
        /// Method to change the combobox list to show the invoice total charge
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public BindingList<TotalCharge1> TotalChargecombo()
        {
            try
            {
                string data = method.InvoiceTable();
                ds = db.ExecuteSQLStatement(data, ref iRet);
                for (int i = 0; i < iRet; i++)
                {
                    TotalChargeData.Add(new TotalCharge1 { TotalCharge = ds.Tables[0].Rows[i][2].ToString() });

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            return TotalChargeData;
        }


    }

    /// <summary>
    /// Class that holds all the information for Invoices
    /// </summary>
    public class Invoice
    {
        private string Num;
        private string Date;
        private string Charge;
        private BindingList<stStoreItem> invoiceItems = new BindingList<stStoreItem>();

        public string InvoiceNum
        {
            get { return Num; }
            set { Num = value; }
        }

        public string InvoiceDate
        {
            get { return Date; }
            set { Date = value; }
        }

        public string TotalCharge
        {
            get { return Charge; }
            set { Charge = value; }
        }

        public BindingList<stStoreItem> InvoiceItems
        {
            get { return invoiceItems; }
            set { invoiceItems = value;  }
        }

        public void addItems(stStoreItem item)
        {
            invoiceItems.Add(item);
        }

        /// <summary>
        /// The Tostring method has been overridden to show that this is the default method that is called when controls are bound to collections.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Invoice";
        }
    }

    public class InvoiceNum1
    {
        private string Num;
        public string InvoiceNum
        {
            get { return Num; }
            set { Num = value; }
        }
        public override string ToString()
        {
            return Num;
        }
    }

    public class InvoiceDate1
    {
        private string Date;
        public string InvoiceDate
        {
            get { return Date; }
            set { Date = value; }
        }
        public override string ToString()
        {
            return Date;
        }
    }

    public class TotalCharge1
    {
        private string Charge;
        public string TotalCharge
        {
            get { return Charge; }
            set { Charge = value; }
        }
        public override string ToString()
        {
            return Charge;
        }
    }
}
