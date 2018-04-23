using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication204
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.nwindDataSet.Suppliers);

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