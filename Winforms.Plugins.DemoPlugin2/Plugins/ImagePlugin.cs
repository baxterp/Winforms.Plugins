using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winforms.Plugins.Shared;

namespace Winforms.Plugins.DemoPlugin2
{
    public class ImagePlugin : IPlugin
    {
        private ControlTemplate controlTemplate;
        private String name = String.Empty;

        //public DataGridViewPlugin()
        //{ }

        public ImagePlugin(String name)
        {
            this.name = name;
            controlTemplate = new ControlTemplate(this.Name(), 
                                                    new List<string>() { "Show Image" }, 
                                                    new ImageUserControl());
        
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
