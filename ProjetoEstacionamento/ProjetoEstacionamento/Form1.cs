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
    public partial class Form1 : Form
    {
        private Estacionamento estacionamento = new Estacionamento();

        public void ExibirMenu()
        {

            UserControls.UserControlMenu ucMenu = new UserControls.UserControlMenu(this, estacionamento);
            AddUserControl(ucMenu);
        }
        public Form1()
        {
            InitializeComponent();
            ExibirMenu();
        }

        public void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            ExibirMenu();
        }

        private void lblTextLogo_Click(object sender, EventArgs e)
        {
            ExibirMenu();
        }

        private void pBImageLogo_Click(object sender, EventArgs e)
        {
            ExibirMenu();
        }
    }
}
