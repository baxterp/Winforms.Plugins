using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winforms.Plugins.Shared;

namespace Winforms.Plugins.DemoPlugin.Plugins
{
    public class DataGridViewPlugin : IPlugin
    {
        private ControlTemplate controlTemplate;
        private String name = String.Empty;

        public DataGridViewPlugin(String name)
        {
            this.name = name;
            controlTemplate = new ControlTemplate(this.Name(), 
                                                    new List<string>() { "Load Data" }, 
                                                    new DataGridViewUserControl());
        
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
