using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using Winforms.Plugins.Shared;

namespace Winforms.Plugins.Host
{
    public partial class HostForm : Form
    {
        IUnityContainer container = null;
        private String pluginFilePath = String.Empty;
        private Boolean testMode = false;

        public HostForm()
        {
            InitializeComponent();
        }

        private void HostForm_Load(object sender, EventArgs e)
        {
            pluginFilePath = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName + @"\PluginsToConsume\";
            testMode = Boolean.Parse(ConfigurationManager.AppSettings["TestMode"]);

            hostTabControl.Visible = false;

            if (testMode)
                this.Text = "Test Mode";
            else
                this.Text = "Live Mode - Plugins Extracted From Assemblies";
        }

        private void btnLoadPlugins_Click(object sender, EventArgs e)
        {
            LoadPluginsFromContainer();
        }

        private void LoadPluginsFromContainer()
        {
            if (container != null)
            {
                hostTabControl.TabPages.Clear();
                menuStripHost.Items.Clear();

                var loadedPlugins = container.ResolveAll<IPlugin>();

                if (loadedPlugins.Count() > 0)
                    hostTabControl.Visible = true;

                foreach (var loadedPlugin in loadedPlugins)
                {
                    menuStripHost.Items.Add(loadedPlugin.PluginControls().MenuStripItemContainer);

                    TabPage tabPage = new TabPage(loadedPlugin.Name());
                    tabPage.Controls.Add(loadedPlugin.PluginControls().UserControlContainer);
                    hostTabControl.TabPages.Add(tabPage);
                }
            }
        }

        private void btnEmptyContainer_Click(object sender, EventArgs e)
        {
            container = new UnityContainer();
            hostTabControl.Visible = false;

            hostTabControl.TabPages.Clear();
            menuStripHost.Items.Clear();

        }

        private void btnLoadContainer_Click(object sender, EventArgs e)
        {
            container = new UnityContainer();
            hostTabControl.Visible = false;

            hostTabControl.TabPages.Clear();
            menuStripHost.Items.Clear();

            if (testMode)
            {
                container.RegisterInstance<IPlugin>("Plugin 1", new TestPlugin("Test Plugin 1"));
                container.RegisterInstance<IPlugin>("Plugin 2", new TestPlugin("Test Plugin 2"));
            }
            else
            {
                string[] files = Directory.GetFiles(pluginFilePath, "*.dll");

                Int32 pluginCount = 1;

                foreach (String file in files)
                {
                    Assembly assembly = Assembly.LoadFrom(file);

                    foreach (Type T in assembly.GetTypes())
                    {
                        foreach (Type iface in T.GetInterfaces())
                        {
                            if (iface == typeof(IPlugin))
                            {
                                IPlugin pluginInstance = (IPlugin)Activator.CreateInstance(T, new [] {"Live Plugin " + pluginCount++});
                                container.RegisterInstance<IPlugin>(pluginInstance.Name(), pluginInstance);
                            }
                        }
                    }
                }
            }
            // At this point the unity container has all the plugin data loaded onto it. 
        }
    }
}
