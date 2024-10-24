namespace MauiAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState activityState)
        {
            var window = base.CreateWindow(activityState);
            window.Width = 400;
            window.Height = 600;
            return window;
        }
    } // Fecha Classe
}
