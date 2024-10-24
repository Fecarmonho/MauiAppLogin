namespace MauiAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitializeMainPageAsync();
        }

        private async void InitializeMainPageAsync()
        {
            string? usuario_logado = await SecureStorage.Default.GetAsync("usuario_logado");

            if (usuario_logado == null)
            {
                MainPage = new Login();
            }
            else
            {
                MainPage = new Protegida();
            }
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
