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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(75, Color.Gray);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tela_Principal tela_Principal = new Tela_Principal();
           this.Visible = false;
            tela_Principal.ShowDialog();
            this.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
