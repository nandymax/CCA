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
    public partial class Saida : Form
    {
        //Conexão com o banco de dados 
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Fernanda\Documents\CCA\projeto_cca-master\Estoque_CCA\Estoque_CCA\Database1.mdf;Integrated Security=True");

        public Saida()
        {
            InitializeComponent();
        }

       
        private void Saida_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.samplebox'. Você pode movê-la ou removê-la conforme necessário.
           // this.sampleboxTableAdapter.Fill(this.database1DataSet.samplebox);
            disp_data();
        }

        // Método dis_data , tem a função de mostrar os dados da tabela no grid 
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from samplebox";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        /*Botão com função de inserir dados
        * Inserir na tabela estoque os valores contidos nos campos textbox1 e texbox2
        *  "insert into samplebox  values( '" + salaComboBox.Text + "', '" + caixaTextBox.Text + "', '" + prontTextBox.Text + "', '" + dt_saidaDateTimePicker.Text + "')"
        */
        private void button1_Click(object sender, EventArgs e)
        {
            

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into samplebox (sala, caixa, pront,dt_saida, extra, qnt, status) values( '" + salaComboBox.Text + "', '" + caixaTextBox.Text + "', '" + prontTextBox.Text + "', '"+dt_saidaDateTimePicker.Value+ "', '" +extraComboBox.Text +"', '" + qntNumericUpDown.Text + "', '"+ statusComboBox.Text + "'  )";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Dados inseridos com sucesso!");
        }

        //Botão fechar
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
