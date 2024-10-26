
namespace MAUIAPPLOGIN
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        //----------DIMENSIONANDO TELA ------------------------------------
        //MODIFICAÇÃO CRIANDO UM NOVO MÉTODO, FAZENDO UMA SOBRECARGA.
        //MÉTODO QUE RECEBE COMO PARAMETRO, ACTIVATIONSTATE...
        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 700;

            return window;
        }
    }//Fecha Classe
}
