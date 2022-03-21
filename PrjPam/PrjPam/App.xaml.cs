using PrjPam.Data;
using PrjPam.Services;
using PrjPam.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrjPam
{
    public partial class App : Application
    {

        static Banco banco;

        public static Banco Banco
        {
            get
            {
                if (banco == null)
                {
                    banco = new Banco(
                        Path.Combine(
                            Environment.GetFolderPath(
                                Environment
                                .SpecialFolder
                                .LocalApplicationData)
                            , "Computador.db3"
                        )
                    );
                }
                return banco;
            }
        }


        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
