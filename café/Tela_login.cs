using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace café
{
    public partial class Tela_login : Form
    {
        public Tela_login()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(75, Color.Gray);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbUser.Text == "admin" && txbPass.Text == "12345")
            {
                txbUser.Text = String.Empty; // Limpa o campo de usuário
                txbPass.Text = String.Empty; // Limpa o campo de senha 
                txbUser.Focus(); // Coloca o foco no campo do usuário
                Tela_Principal principal = new Tela_Principal();
                this.Visible = false; // Esconder  a tela de login
                principal.ShowDialog(); // Abre a tela principal
                this.Visible = true; // Volta a mostrar a tela de login
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos",
                    "ERRO NO LOGIN",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
