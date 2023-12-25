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
    public partial class UserControlRegistroEntrada : UserControl
    {
        private Form1 form1;
        private Estacionamento _estacionamento;
        public UserControlRegistroEntrada(Form1 mainForm, Estacionamento estacionamento)
        {
            InitializeComponent();
            form1 = mainForm;
            _estacionamento = estacionamento;
        }


        private void UserControlRegistroEntrada_Load(object sender, EventArgs e)
        {
            dateTimePickerEntrada.Value = DateTime.Now;
            txtHoraEntrada.Text = DateTime.Now.ToShortTimeString();
            txtPlaca.Focus();
        }

        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.Trim();
            DateTime entrada = DateTime.Parse($"{dateTimePickerEntrada.Value.ToShortDateString()} {txtHoraEntrada.Text}");
            bool registrarEntrada = _estacionamento.RegistrarVeiculo(txtPlaca.Text, entrada);

            if (registrarEntrada)
            {
                MessageBox.Show("Veículo registrado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnToMenu.PerformClick();
                
            } else
            {
                MessageBox.Show("Veículo já registrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnToMenu_Click(object sender, EventArgs e)
        {
            UserControlMenu ucMenu = new UserControlMenu(form1, _estacionamento);
            form1.AddUserControl(ucMenu);
        }
    }
}
