﻿namespace PM2RECU2 {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            MainPage = new AppShell();
            //MainPage = new NavigationPage(new MainPage());
        }
    }
}