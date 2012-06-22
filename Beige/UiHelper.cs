using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.CommandBars;

namespace Beige
{
    sealed class UiHelper
    {
        private static CommandBarControl _appHarborMenu;

        public static CommandBarControl GetAppHarborMenu(DTE2 applicationObject, AddIn addIn)
        {
            if (_appHarborMenu == null)
            {
                var menuBarCommandBar = ((CommandBars)applicationObject.CommandBars)["MenuBar"];
                const string toolsMenuName = "Tools";
                var toolsControl = menuBarCommandBar.Controls[toolsMenuName];

                CommandBarControl appHarborMenu;

                _appHarborMenu = menuBarCommandBar.Controls.Add(Type: MsoControlType.msoControlPopup, Id: 1234567890,
                                                               Before: toolsControl.Index + 1);
                _appHarborMenu.Caption = "AppHarbor";

                var commands = (Commands2) applicationObject.Commands;

                var popUp = (CommandBarPopup) _appHarborMenu;
                //var command = commands.AddNamedCommand2(addIn, "AppHarborNewApplication", "New AppHarbor Application", "Create a new AppHarbor Application", true, 59, null, (int)vsCommandStatus.vsCommandStatusSupported + (int)vsCommandStatus.vsCommandStatusEnabled, (int)vsCommandStyle.vsCommandStylePictAndText, vsCommandControlType.vsCommandControlTypeButton);

                var newAppButton = (CommandBarButton) popUp.Controls.Add(Type: MsoControlType.msoControlButton);
                newAppButton.Caption = "Create New AppHarbor Application";
                
                //if ((command != null))
                //{
                //    command.AddControl(popUp.CommandBar);
                //}

            }
            return _appHarborMenu;
        }
    }
}
