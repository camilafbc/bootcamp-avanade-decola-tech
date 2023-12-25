using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstacionamento.UserControls
{
    public partial class UserControlMenu : UserControl
    {
        private Form1 form1;
        private Estacionamento _estacionamento;

        public UserControlMenu(Form1 mainForm, Estacionamento estacionamento)
        {
            InitializeComponent();
            form1 = mainForm;
            _estacionamento = estacionamento;
        }

        private void btnGerenciarValores_MouseEnter(object sender, EventArgs e)
        {
            btnGerenciarValores.BackColor = ColorTranslator.FromHtml("#27ae60");
        }

        private void btnGerenciarValores_MouseLeave(object sender, EventArgs e)
        {
            btnGerenciarValores.BackColor = ColorTranslator.FromHtml("#2ecc71"); 
        }

        private void btnGerenciarValores_Click(object sender, EventArgs e)
        {
            UserControlGerenciarValores ucGerenciamento = new UserControlGerenciarValores(form1, _estacionamento);
            form1.AddUserControl(ucGerenciamento);
        }

        private void btnRegistroDeEntrada_MouseEnter(object sender, EventArgs e)
        {
            btnRegistroDeEntrada.BackColor = ColorTranslator.FromHtml("#d35400");
        }

        private void btnRegistroDeEntrada_MouseLeave(object sender, EventArgs e)
        {
            btnRegistroDeEntrada.BackColor = ColorTranslator.FromHtml("#f39c12");
        }

        private void btnRegistroDeEntrada_Click(object sender, EventArgs e)
        {
            UserControlRegistroEntrada ucRegistroEntrada = new UserControlRegistroEntrada(form1, _estacionamento);
            form1.AddUserControl(ucRegistroEntrada);
        }

        private void btnRegistroDeSaida_MouseEnter(object sender, EventArgs e)
        {
            btnRegistroDeSaida.BackColor = ColorTranslator.FromHtml("#c0392b");
        }

        private void btnRegistroDeSaida_MouseLeave(object sender, EventArgs e)
        {
            btnRegistroDeSaida.BackColor = ColorTranslator.FromHtml("#e74c3c");
        }

        private void btnRegistroDeSaida_Click(object sender, EventArgs e)
        {
            UserControlRegistroSaida ucRegistroSaida = new UserControlRegistroSaida(form1, _estacionamento);
            form1.AddUserControl(ucRegistroSaida);
        }
        private void btnListagemVeiculos_MouseEnter(object sender, EventArgs e)
        {
            btnListagemVeiculos.BackColor = ColorTranslator.FromHtml("#8e44ad");
        }

        private void btnListagemVeiculos_MouseLeave(object sender, EventArgs e)
        {
            btnListagemVeiculos.BackColor = ColorTranslator.FromHtml("#9b59b6");
        }

        private void btnListagemVeiculos_Click(object sender, EventArgs e)
        {
            UserControlListagem ucListagem = new UserControlListagem(form1, _estacionamento);
            form1.AddUserControl(ucListagem);
        }
    }
}
