using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms.Plugins.Shared
{
    public class ControlTemplate
    {
        public UserControlWithCallBack UserControlContainer;
        public ToolStripMenuItem MenuStripItemContainer;

        public ControlTemplate(String name, List<String> dropDownMenuItemNames, UserControlWithCallBack pluginUserControl)
        {
            UserControlContainer = new UserControlWithCallBack();

            UserControlContainer = pluginUserControl;

            ToolStripMenuItem topLevelMenuStripItem = new ToolStripMenuItem(name);

            foreach (String dropDownMenuItemName in dropDownMenuItemNames)
            {
                ToolStripMenuItem dropDownMenuStripItem = new ToolStripMenuItem(dropDownMenuItemName);
                dropDownMenuStripItem.Click += new EventHandler(MenuItemClickHandler);

                topLevelMenuStripItem.DropDownItems.Add(dropDownMenuStripItem);
            }

            MenuStripItemContainer = topLevelMenuStripItem;
        }

        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem receivedMenuItem = (ToolStripMenuItem)sender;
            UserControlContainer.ReceiveData(receivedMenuItem.Text);
        }
    }
}
