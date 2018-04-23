using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication204
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public object DataSource
        {
            get { return dataLayoutControl1.DataSource; }
            set { dataLayoutControl1.DataSource = value; }
        }
    }
}