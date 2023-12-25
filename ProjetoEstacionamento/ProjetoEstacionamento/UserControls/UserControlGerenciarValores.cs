using ProjetoEstacionamento.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstacionamento
{
    public partial class UserControlGerenciarValores : UserControl
    {
        private Form1 form1;
        private Estacionamento _estacionamento;
        public UserControlGerenciarValores(Form1 mainForm, Estacionamento estacionamento)
        {
            InitializeComponent();
            form1 = mainForm;
            _estacionamento = estacionamento;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            string valorBase = txtValorBase.Text.Trim();
            string valorHora = txtValorHora.Text.Trim();

            try
            {

                if(valorBase != "" && valorHora != "")
                {
                    bool converterValorBaseParaDecimal = decimal.TryParse(valorBase, out decimal valor_Base);
                    bool converterValorHoraParaDecimal = decimal.TryParse(valorHora, out decimal valor_Hora);

                    if (!converterValorBaseParaDecimal)
                    {
                        MessageBox.Show("O valor base inserido não é válido!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                    else if (!converterValorHoraParaDecimal)
                    {
                        MessageBox.Show("O valor base inserido não é válido!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (converterValorBaseParaDecimal && converterValorHoraParaDecimal)
                    {
                        _estacionamento.TarifaBase = valor_Base;
                        _estacionamento.ValorPorHora = valor_Hora;
                        MessageBox.Show("Valores atribuídos com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnVoltar.PerformClick();
                    }
                }
                else if (valorBase == "")
                {
                    MessageBox.Show("O valor base deve ser preenchido!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (valorHora == "")
                {
                    MessageBox.Show("O valor da hora deve ser preenchido!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void UserControlGerenciarValores_Load(object sender, EventArgs e)
        {
            txtValorBase.Focus();

            if (_estacionamento.TarifaBase > 0)
            {
                txtValorBase.Text = _estacionamento.TarifaBase.ToString("N2");
            }

            if (_estacionamento.ValorPorHora > 0)
            {
                txtValorHora.Text = _estacionamento.ValorPorHora.ToString("N2");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            UserControlMenu ucMenu = new UserControlMenu(form1, _estacionamento);
            form1.AddUserControl(ucMenu);
        }
    }
}
