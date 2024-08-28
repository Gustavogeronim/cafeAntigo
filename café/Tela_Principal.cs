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
    public partial class Tela_Principal : Form
    {
        public Tela_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Tela_Venda form3 = new Tela_Venda();
            this.Visible = false;
            form3.ShowDialog();
            this.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tela_Estoque estoque = new Tela_Estoque();
            this.Visible = false;
            estoque.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Tela_Cadastro cadastro = new Tela_Cadastro();
            this.Visible = false;
            cadastro.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tela_Delivery delivery = new Tela_Delivery();
            this.Visible = false;
            delivery.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tela_Ajuste ajuste = new Tela_Ajuste();
            this.Visible = false;
            ajuste.ShowDialog();
            this.Visible = true;
        }
    }
}
