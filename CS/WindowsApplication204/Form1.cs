using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsApplication204
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable CreateTable()
        {
            DataTable table = new DataTable();
            DataRow dataRow;

            table.Columns.Add("SupplierID", typeof(int));
            table.Columns.Add("CompanyName", typeof(string));
            table.Columns.Add("ContactName", typeof(string));
            table.Columns.Add("ContactTitle", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("Region", typeof(string));
            table.Columns.Add("PostalCode", typeof(string));
            table.Columns.Add("Country", typeof(string));
            table.Columns.Add("Phone", typeof(string));
            table.Columns.Add("Fax", typeof(string));
            table.Columns.Add("HomePage", typeof(string));

            dataRow = table.NewRow();
            dataRow["SupplierID"] = 1;
            dataRow["CompanyName"] = "Exotic Liquids";
            dataRow["ContactName"] = "Charlotte Cooper";
            dataRow["ContactTitle"] = "Purchasing Manager";
            dataRow["Address"] = "49 Gilbert St.";
            dataRow["City"] = "London";
            dataRow["Region"] = "";
            dataRow["PostalCode"] = "EC1 4SD";
            dataRow["Country"] = "UK";
            dataRow["Phone"] = "(171) 555-2222";
            dataRow["Fax"] = "";
            dataRow["HomePage"] = "";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["SupplierID"] = 2;
            dataRow["CompanyName"] = "New Orleans Cajun Delights";
            dataRow["ContactName"] = "Shelley Burke";
            dataRow["ContactTitle"] = "Order Administrator";
            dataRow["Address"] = "P.O. Box 78934";
            dataRow["City"] = "New Orleans";
            dataRow["Region"] = "LA";
            dataRow["PostalCode"] = "70117";
            dataRow["Country"] = "USA";
            dataRow["Phone"] = "(100) 555-4822";
            dataRow["Fax"] = "";
            dataRow["HomePage"] = "#CAJUN.HTM#";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["SupplierID"] = 3;
            dataRow["CompanyName"] = "Grandma Kelly's Homestead";
            dataRow["ContactName"] = "Regina Murphy";
            dataRow["ContactTitle"] = "Sales Representative";
            dataRow["Address"] = "707 Oxford Rd.";
            dataRow["City"] = "Ann Arbor";
            dataRow["Region"] = "MI";
            dataRow["PostalCode"] = "48104";
            dataRow["Country"] = "USA";
            dataRow["Phone"] = "(313) 555-5735";
            dataRow["Fax"] = "(313) 555-3349";
            dataRow["HomePage"] = "";
            table.Rows.Add(dataRow);

            return table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable table = CreateTable();
            suppliersBindingSource.DataSource = table;
        }

        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Custom)
            {
                ShowEditForm();
            }
            else if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Append)
            {
                suppliersBindingSource.AddNew();
                ShowEditForm();
                e.Handled = true;
            }
        }

        void ShowEditForm()
        {
            Form2 f = new Form2();
            f.DataSource = gridControl1.DataSource;
            if (f.ShowDialog() == DialogResult.OK)
            {
                suppliersBindingSource.EndEdit();
            }
            else
            {
                suppliersBindingSource.CancelEdit();
            }
            f.Dispose();
        }
    }
}