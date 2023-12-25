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
    public partial class UserControlRegistroSaida : UserControl
    {
        private Form1 form1;
        private Estacionamento _estacionamento;
        public UserControlRegistroSaida(Form1 mainForm, Estacionamento estacionamento)
        {
            InitializeComponent();
            form1 = mainForm;
            _estacionamento = estacionamento;
        }

        private void UserControlRegistroSaida_Load(object sender, EventArgs e)
        {
            gBDadosVeiculo.Visible = false;
            txtPlaca.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.Trim();
            string buscarVeiculo = _estacionamento.BuscarVeiculo(placa);

            if(_estacionamento.TarifaBase <= 0 && _estacionamento.ValorPorHora <= 0)
            {
                MessageBox.Show("Os valores base e de tarifa não foram definidos!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (_estacionamento.TarifaBase <= 0 && _estacionamento.ValorPorHora > 0)
            {
                MessageBox.Show("O valor base não foi definido!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (_estacionamento.TarifaBase > 0 && _estacionamento.ValorPorHora <= 0)
            {
                MessageBox.Show("O valor da tarifa não foi definido!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if (buscarVeiculo == null)
                {
                   MessageBox.Show("Veículo não encontrado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string[] dadosDoVeiculo = buscarVeiculo.Split('-');
                    gBDadosVeiculo.Visible = true;
                    lblSaidaPlaca.Text = dadosDoVeiculo[0].Trim();
                    lblDadosEntrada.Text = dadosDoVeiculo[1];
                    dateTimePickerSaida.Value = DateTime.Now;
                    txtHoraSaida.Text = DateTime.Now.ToShortTimeString();

                    DateTime entrada = DateTime.Parse($"{lblDadosEntrada.Text}");
                    DateTime saida = DateTime.Parse($"{dateTimePickerSaida.Value.ToShortDateString()} {txtHoraSaida.Text}");

                    lblSaidaValor.Text = _estacionamento.ValorAPagar(entrada, saida).ToString("C2");
                }
            }
            btnVoltar2.Visible = true;
        }

        private void btnRegistrarSaida_Click(object sender, EventArgs e)
        {
            string placa = lblSaidaPlaca.Text.Trim();
            string buscarVeiculo = _estacionamento.BuscarVeiculo(placa);

            if(buscarVeiculo != null)
            {
                bool remover = _estacionamento.RemoverVeiculo(buscarVeiculo);
                if (remover)
                {
                    MessageBox.Show($"Veículo {placa} removido com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gBDadosVeiculo.Visible = false;
                    txtPlaca.Text = "";
                    txtPlaca.Focus();
                } 
                else
                {
                    MessageBox.Show($"Erro ao tentar remover o veículo {placa}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Veículo {placa} não registrado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            UserControlMenu ucMenu = new UserControlMenu(form1, _estacionamento);
            form1.AddUserControl(ucMenu);
        }
    }
}
