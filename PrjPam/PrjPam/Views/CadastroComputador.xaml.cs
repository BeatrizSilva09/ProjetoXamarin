using PrjPam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrjPam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroComputador : ContentPage
    {
        public CadastroComputador()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string processador;
            int usb;
            bool atualizado;
            DateTime dataAtualizacao;

            processador = txtProcessador.Text;
            usb = Convert.ToInt32(txtUSB.Text);
            atualizado = swtAtualizado.IsToggled;
            dataAtualizacao = dtpDataAtualizacao.Date;

            Computador computador = new Computador()
            {
                Processador = processador,
                USB = usb,
                Atualizado = atualizado,
                DataAtualizacao = dataAtualizacao,
                ID = 0
            };

            PrjPam.App.Banco.SalvarComputador(computador);

            DisplayAlert("Cadastro", "Computador cadastrado com sucesso", "OK");
        }
    }
}
