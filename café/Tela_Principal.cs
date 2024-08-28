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
    }
}
