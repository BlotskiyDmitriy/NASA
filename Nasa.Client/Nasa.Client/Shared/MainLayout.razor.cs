﻿using MudBlazor;
using Nasa.Client.Themes;

namespace Nasa.Client.Shared
{
    public partial class MainLayout
    {
        private MudBlazorAdminDashboard _theme = new();
        public  bool _isOpenFooter = true;
        private bool _isDarkMode;
        public bool _drawerOpen = false;
        string greeting = "";
        void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }
    }
}
