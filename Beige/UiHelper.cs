﻿using EnvDTE;
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

                _appHarborMenu = menuBarCommandBar.Controls.Add(MsoControlType.msoControlPopup, Id: 1234567890,
                                                               Before: toolsControl.Index + 1);
                _appHarborMenu.Caption = "AppHarbor";
                

                var popUp = (CommandBarPopup) _appHarborMenu;

                var newAppButton = (CommandBarButton) popUp.Controls.Add(MsoControlType.msoControlButton);
                newAppButton.Caption = "Create New AppHarbor Application";

                var manageApplications = (CommandBarButton) popUp.Controls.Add(MsoControlType.msoControlButton);
                manageApplications.Caption = "Manage Applications";
            }
            return _appHarborMenu;
        }
    }
}
