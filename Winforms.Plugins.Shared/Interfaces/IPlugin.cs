using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms.Plugins.Shared
{
    public interface IPlugin
    {
        String Name();
        ControlTemplate PluginControls();
    }
}
