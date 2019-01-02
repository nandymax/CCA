using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque_CCA
{
    public partial class Form2 : Form
    {
        //Conexão com o banco de dados 
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Fernanda\Documents\CCA\projeto_cca-master\Estoque_CCA\Estoque_CCA\Database1.mdf;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }

        //Fechar janela
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Chama o método dis_data() para mostrar os dados da tabela
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.estoqueTableAdapter.Fill(this.database1DataSet.estoque);
            disp_data();
        }


        // Método dis_data , tem a função de mostrar os dados da tabela no grid 
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from estoque";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        /*Botão com função de inserir dados
         * Inserir na tabela estoque os valores contidos nos campos textbox1 e texbox2
         *  "insert into estoque values( '" + textBox1.Text + "', '" + textBox2.Text + "')"
         */
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into estoque values( '" + textBox1.Text + "', '" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Dados inseridos com sucesso!");

        }
      

        /*Função Update de dados
         * Alterar tabela estoque, somar a quantidade da reposição com a quantidade que tem em estoque, onde o medicamento é igual ao medicamento selecionado na combobox
         * "update estoque set qnt = qnt  + '" +numericUpDown1.Text + "' where medicamento  = '" + medicamentoComboBox.Text + "'";
         */
        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update estoque set qnt = qnt  + '" +numericUpDown1.Text + "' where medicamento  = '" + medicamentoComboBox.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Alteração realizada com sucesso!");


        }

      
    }
}
