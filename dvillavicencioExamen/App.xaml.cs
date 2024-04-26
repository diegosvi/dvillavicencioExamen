namespace dvillavicencioExamen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = MainPage = new NavigationPage(new Vistas.Login());
        }
    }
}
