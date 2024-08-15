using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms.Plugins.Shared
{
    public partial class UserControlWithCallBack : UserControl
    {
        public event EventHandler<EventArgs<String>> CallBack;

        public UserControlWithCallBack()
        {
            InitializeComponent();
        }

        public void ReceiveData(String callBackData)
        {
            CallBack.SafeInvoke(this, new EventArgs<string>(callBackData));
        }
    }
}
