﻿namespace esantacruzExamen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new views.login());
        }
    }
}
