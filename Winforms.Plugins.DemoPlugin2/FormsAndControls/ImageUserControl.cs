using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Winforms.Plugins.Shared;

namespace Winforms.Plugins.DemoPlugin2
{
    public partial class ImageUserControl : UserControlWithCallBack
    {
        public ImageUserControl()
        {
            InitializeComponent();
            base.CallBack += ImageUserControl_CallBack;
            pictureBoxImage.Visible = false;
        }

        void ImageUserControl_CallBack(object sender, EventArgs<string> e)
        {
            if (e.Value == "Show Image")
            {
                pictureBoxImage.Visible = true;
            }
        }
    }
}
