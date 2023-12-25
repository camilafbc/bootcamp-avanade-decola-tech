using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoEstacionamento.UserControls;

namespace ProjetoEstacionamento
{
    public partial class UserControlListagem : UserControl
    {
        private Form1 form1;
        private Estacionamento _estacionamento;
        public UserControlListagem(Form1 mainForm, Estacionamento estacionamento)
        {
            InitializeComponent();
            form1 = mainForm;
            _estacionamento = estacionamento;
        }

        
        private void UserControlListagem_Load(object sender, EventArgs e)
        {
            List<string> veiculos = _estacionamento.ListaDeVeiculos;

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("PLACA", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("DATA", 130, HorizontalAlignment.Right);
            listView1.Columns.Add("HORA DE ENTRADA", 200, HorizontalAlignment.Right);


            foreach(string linha in veiculos)
            {
                string[] dados = linha.Split('-', ' ');

                ListViewItem item = new ListViewItem(dados[0].ToString());
                item.SubItems.Add(dados[3].ToString());
                item.SubItems.Add(dados[4].ToString());
                listView1.Items.Add(item);
            }

            txtPlaca.Focus();
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            List<string> veiculos = _estacionamento.BuscarVeiculos(txtPlaca.Text);

            if(veiculos.Count > 0)
            {
                listView1.Items.Clear();

                foreach (string linha in veiculos)
                {
                    string[] dados = linha.Split('-', ' ');

                    ListViewItem item = new ListViewItem(dados[0].ToString());
                    item.SubItems.Add(dados[3].ToString());
                    item.SubItems.Add(dados[4].ToString());
                    listView1.Items.Add(item);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            UserControlMenu ucMenu = new UserControlMenu(form1, _estacionamento);
            form1.AddUserControl(ucMenu);
        }
    }
}
