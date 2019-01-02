using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque_CCA
{
    public partial class Form1 : Form
    {

        //Abre a tela de menu
        public Form1()
        {
            InitializeComponent();
        }

        //Botão estoque
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            newForm2.ShowDialog();
        }

        //Botão fechar
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        //Botão Saída das sampleBox
        private void button2_Click(object sender, EventArgs e)
        {
            Saida newForm3 = new Saida();
            newForm3.ShowDialog();
        }
        
        //Botão Retorno das sampleBox
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 newForm4 = new Form4();
            newForm4.ShowDialog();
        }

        //Botão Relatório
        private void button4_Click(object sender, EventArgs e)
        {
            Form5 newForm5 = new Form5();
            newForm5.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
