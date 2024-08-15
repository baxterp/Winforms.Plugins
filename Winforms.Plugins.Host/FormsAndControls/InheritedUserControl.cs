using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Winforms.Plugins.Shared;

namespace Winforms.Plugins.Host
{
    public partial class InheritedUserControl : UserControlWithCallBack
    {    
        public InheritedUserControl()
        {
            InitializeComponent();
            base.CallBack += InheritedUserControl_CallBack;
        }

        void InheritedUserControl_CallBack(object sender, EventArgs<string> e)
        {
            MessageBox.Show("Message From ToolStrip, Received in Inherited User Control : " + e.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message From Inherited User Control");
        }
    }
}
