using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winforms.Plugins.Shared;
using System.Windows.Forms;

namespace Winforms.Plugins.Host
{
    class TestPlugin : IPlugin
    {
        private ControlTemplate controlTemplate;
        private String name = String.Empty;

        public TestPlugin(String name)
        {
            this.name = name;
            controlTemplate = new ControlTemplate(this.Name(), 
                                                    new List<string>() { "New", "Open" }, 
                                                    new InheritedUserControl());
        
        }

        public String Name()
        {
            return this.name;
        }

        public ControlTemplate PluginControls()
        {
            return controlTemplate;
        }
    }
}
