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
    public partial class Form4 : Form
    {
        //Conexão com o banco de dados 
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Fernanda\Documents\CCA\projeto_cca-master\Estoque_CCA\Estoque_CCA\Database1.mdf;Integrated Security=True");

        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Chama o método dis_data() para mostrar os dados da tabela
        /*
         * 
        */
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.estoqueTableAdapter.Fill(this.database1DataSet.estoque);
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.samplebox'. Você pode movê-la ou removê-la conforme necessário.
            this.sampleboxTableAdapter.Fill(this.database1DataSet.samplebox);
            disp_data();
           

        }
        // Método dis_data , tem a função de mostrar os dados da tabela no grid 
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select extra, qnt from samplebox";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
       


        /*
         * Inserir a data de retorno de acordo com a caixa que voltou
         * atualizar status da caixa para na farmácia
         */
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into samplebox(dt_retorno) values( '" + dt_retornoDateTimePicker.Value + "') where caixa = '"+ caixaTextBox.Text+"'";
            cmd.CommandText = "update samplebox set status =  '"+ statusTextBox.Text+ "' where caixa = '" + caixaTextBox.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            
        }

     

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update estoque set qnt = qnt  - '" + numericUpDown1.Text + "' where medicamento  = '" + medicamentoComboBox.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
          //  disp_data2();
            MessageBox.Show("Alteração realizada com sucesso!");
        }
    }
}
