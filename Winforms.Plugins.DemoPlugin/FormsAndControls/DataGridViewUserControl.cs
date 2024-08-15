using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Winforms.Plugins.Shared;

namespace Winforms.Plugins.DemoPlugin
{
    public partial class DataGridViewUserControl : UserControlWithCallBack
    {
        public DataGridViewUserControl()
        {
            InitializeComponent();
            base.CallBack += DataGridViewUserControl_CallBack;
        }

        void DataGridViewUserControl_CallBack(object sender, EventArgs<string> e)
        {
            if (e.Value == "Load Data")
            {
                DataTable testData = MockData.GenerateDataTable<Person>(50);
                dataGridViewTest.DataSource = testData;

                lblDescription.Visible = true;
                dataGridViewTest.Visible = true;
            }
        }
    }
}
