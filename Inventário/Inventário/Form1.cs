using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventário  //funções futuras:    limpar o chão  ;  contador de flechas  ;  add frasco após beber poção
{
    public partial class inventario : Form
    {
        public inventario()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco() //CONECTA COM O SGBD
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "inventario";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;

        }

        private void atualizarGrid() //ATUALIZA O DGV
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());

            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM item";
                MySqlDataReader reader = comandoMySql.ExecuteReader();


                dgvItem.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgvItem.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0); //ID
                    row.Cells[0].Value = reader.GetString(1); //NOME
                    row.Cells[0].Value = reader.GetString(2); //TIPO
                    row.Cells[0].Value = reader.GetInt32(3); //QUANTIDADE
                    row.Cells[0].Value = reader.GetInt32(4); //PESO
                    row.Cells[0].Value = reader.GetInt32(5); //VALOR
                    row.Cells[0].Value = reader.GetString(6); //DESCRIÇÃO
                    row.Cells[0].Value = reader.GetString(7); //LOCAL
                    dgvItem.Rows.Add(row); //ADD NOVA LINHA
                }

                realizaConexaoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Banco de dados indisponível. Parece que você não me programou direito.");
                Console.WriteLine(ex.Message);
            }

        }
        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e) // EVENTO CLICK ROW
        {
            if (dgvItem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvItem.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                tbNome.Text = dgvItem.Rows[e.RowIndex].Cells["colNome"].FormattedValue.ToString();
                tbTipo.Text = dgvItem.Rows[e.RowIndex].Cells["colTipo"].FormattedValue.ToString();
                tbQuantidade.Text = dgvItem.Rows[e.RowIndex].Cells["colQuantidade"].FormattedValue.ToString();
                tbPeso.Text = dgvItem.Rows[e.RowIndex].Cells["colPeso"].FormattedValue.ToString();
                tbValor.Text = dgvItem.Rows[e.RowIndex].Cells["colValor"].FormattedValue.ToString();
                tbDescricao.Text = dgvItem.Rows[e.RowIndex].Cells["colDescricao"].FormattedValue.ToString();
                tbLocal.Text = dgvItem.Rows[e.RowIndex].Cells["colLocal"].FormattedValue.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e) //REFRESH
        {
            atualizarGrid();
        }

        private void btAdd_Click(object sender, EventArgs e) //ADD (BOTAO)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "INSERT INTO item (nomeItem,tipoItem,valorItem,quantItem,descItem,pesoItem,localItem)" +
                   "VALUES('" + tbNome.Text + "','" + tbTipo.Text + "','" + Convert.ToInt16(tbValor.Text) + "','" + Convert.ToInt16(tbQuantidade.Text) + "','" + tbDescricao.Text + "','" + Convert.ToInt16(tbPeso.Text) + "','" + Convert.ToInt16(tbLocal.Text) + "')";

                comandoMySql.ExecuteNonQuery();

                realizaConexaoBD.Close();
                MessageBox.Show(tbNome.Text + "adicionado ao inventário!");
                atualizarGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar com o banco de dados!");
                Console.WriteLine(ex.Message);
            }
        }
        private void limparCampos()
        {
            tbNome.Text = "";
            tbTipo.Text = "";
            tbQuantidade.Text = "";
            tbPeso.Text = "";
            tbValor.Text = "";
            tbDescricao.Text = "";
            tbLocal.Text = "";
            tbID.Text = "";
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btAlterar_Click(object sender, EventArgs e) //ALTERAR (BOTAO)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "UPDATE item SET nomeItem = '" + tbNome.Text + "', " +
                    "tipoItem = '" + tbTipo.Text + "', " +
                    "valorItem = '" + Convert.ToInt16(tbValor.Text) + "', " +
                    "quantItem = '" + Convert.ToInt16(tbQuantidade.Text) + "'," +
                    "descItem = '" + tbDescricao.Text + "','" +
                    "pesoItem = '" + Convert.ToInt16(tbPeso.Text) + "','" +
                    "localItem = '" + Convert.ToInt16(tbLocal.Text) +
                    " WHERE idAnime = " + tbID.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Atualizado!");
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível estabelecer uma conexão estável com o banco de dados!\nTente novamente mais tarde.");
                Console.WriteLine(ex.Message);
            }
        }
        private void btDrop_Click(object sender, EventArgs e) //JOGAR NO CHAO (BOTAO)   INATIVAR
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "UPDATE item SET localItem = 0 WHERE idItem = " + tbID.Text + "";

                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show(tbNome.Text + " foi jogado no chão!");
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível estabelecer uma conexão estável com o banco de dados!\nTente novamente mais tarde.");
                Console.WriteLine(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) //PEGAR DO CHAO (BOTAO)   ATIVAR
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "UPDATE item SET localItem = 1 WHERE idItem = " + tbID.Text + "";

                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Você juntou " + tbNome.Text + " do chão.");
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível estabelecer uma conexão estável com o banco de dados!\nTente novamente mais tarde.");
                Console.WriteLine(ex.Message);
            }
        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e) //VER CHÃO
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());

            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM item WHERE localItem = 0";
                MySqlDataReader reader = comandoMySql.ExecuteReader();


                dgvItem.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgvItem.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0); //ID
                    row.Cells[0].Value = reader.GetString(1); //NOME
                    row.Cells[0].Value = reader.GetString(2); //TIPO
                    row.Cells[0].Value = reader.GetInt32(3); //QUANTIDADE
                    row.Cells[0].Value = reader.GetInt32(4); //PESO
                    row.Cells[0].Value = reader.GetInt32(5); //VALOR
                    row.Cells[0].Value = reader.GetString(6); //DESCRIÇÃO
                    row.Cells[0].Value = reader.GetString(7); //LOCAL
                    dgvItem.Rows.Add(row); //ADD NOVA LINHA
                }

                realizaConexaoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Banco de dados indisponível. Parece que você não me programou direito.");
                Console.WriteLine(ex.Message);
            }

        }

        private void verMochilaToolStripMenuItem_Click(object sender, EventArgs e) //VER MOCHILA
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());

            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM item WHERE localItem = 1";
                MySqlDataReader reader = comandoMySql.ExecuteReader();


                dgvItem.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgvItem.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0); //ID
                    row.Cells[0].Value = reader.GetString(1); //NOME
                    row.Cells[0].Value = reader.GetString(2); //TIPO
                    row.Cells[0].Value = reader.GetInt32(3); //QUANTIDADE
                    row.Cells[0].Value = reader.GetInt32(4); //PESO
                    row.Cells[0].Value = reader.GetInt32(5); //VALOR
                    row.Cells[0].Value = reader.GetString(6); //DESCRIÇÃO
                    row.Cells[0].Value = reader.GetString(7); //LOCAL
                    dgvItem.Rows.Add(row); //ADD NOVA LINHA
                }

                realizaConexaoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Banco de dados indisponível. Parece que você não me programou direito.");
                Console.WriteLine(ex.Message);
            }

        }

        private void verAlgibeiraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());

            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM item WHERE localItem = 2";
                MySqlDataReader reader = comandoMySql.ExecuteReader();


                dgvItem.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgvItem.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0); //ID
                    row.Cells[0].Value = reader.GetString(1); //NOME
                    row.Cells[0].Value = reader.GetString(2); //TIPO
                    row.Cells[0].Value = reader.GetInt32(3); //QUANTIDADE
                    row.Cells[0].Value = reader.GetInt32(4); //PESO
                    row.Cells[0].Value = reader.GetInt32(5); //VALOR
                    row.Cells[0].Value = reader.GetString(6); //DESCRIÇÃO
                    row.Cells[0].Value = reader.GetString(7); //LOCAL
                    dgvItem.Rows.Add(row); //ADD NOVA LINHA
                }

                realizaConexaoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Banco de dados indisponível. Parece que você não me programou direito.");
                Console.WriteLine(ex.Message);
            }

        }

        private void verColdreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());

            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM item WHERE localItem = 3";
                MySqlDataReader reader = comandoMySql.ExecuteReader();


                dgvItem.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgvItem.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0); //ID
                    row.Cells[0].Value = reader.GetString(1); //NOME
                    row.Cells[0].Value = reader.GetString(2); //TIPO
                    row.Cells[0].Value = reader.GetInt32(3); //QUANTIDADE
                    row.Cells[0].Value = reader.GetInt32(4); //PESO
                    row.Cells[0].Value = reader.GetInt32(5); //VALOR
                    row.Cells[0].Value = reader.GetString(6); //DESCRIÇÃO
                    row.Cells[0].Value = reader.GetString(7); //LOCAL
                    dgvItem.Rows.Add(row); //ADD NOVA LINHA
                }

                realizaConexaoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Banco de dados indisponível. Parece que você não me programou direito.");
                Console.WriteLine(ex.Message);
            }

        }

        private void verTodosToolStripMenuItem1_Click(object sender, EventArgs e) //VER TODOS
        {
            atualizarGrid();
        }

        private void ver4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());

            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM item WHERE localItem = 4";
                MySqlDataReader reader = comandoMySql.ExecuteReader();


                dgvItem.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgvItem.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0); //ID
                    row.Cells[0].Value = reader.GetString(1); //NOME
                    row.Cells[0].Value = reader.GetString(2); //TIPO
                    row.Cells[0].Value = reader.GetInt32(3); //QUANTIDADE
                    row.Cells[0].Value = reader.GetInt32(4); //PESO
                    row.Cells[0].Value = reader.GetInt32(5); //VALOR
                    row.Cells[0].Value = reader.GetString(6); //DESCRIÇÃO
                    row.Cells[0].Value = reader.GetString(7); //LOCAL
                    dgvItem.Rows.Add(row); //ADD NOVA LINHA
                }

                realizaConexaoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Banco de dados indisponível. Parece que você não me programou direito.");
                Console.WriteLine(ex.Message);
            }

        }

        private void ver5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());

            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM item WHERE localItem = 5";
                MySqlDataReader reader = comandoMySql.ExecuteReader();


                dgvItem.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgvItem.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0); //ID
                    row.Cells[0].Value = reader.GetString(1); //NOME
                    row.Cells[0].Value = reader.GetString(2); //TIPO
                    row.Cells[0].Value = reader.GetInt32(3); //QUANTIDADE
                    row.Cells[0].Value = reader.GetInt32(4); //PESO
                    row.Cells[0].Value = reader.GetInt32(5); //VALOR
                    row.Cells[0].Value = reader.GetString(6); //DESCRIÇÃO
                    row.Cells[0].Value = reader.GetString(7); //LOCAL
                    dgvItem.Rows.Add(row); //ADD NOVA LINHA
                }

                realizaConexaoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Banco de dados indisponível. Parece que você não me programou direito.");
                Console.WriteLine(ex.Message);
            }

        }

        private void btDelete_Click(object sender, EventArgs e) // QUEBRAR ITEM (BOTAO)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "DELETE FROM item WHERE idItem = " + tbID.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show(tbNome.Text + " destruído!");
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível estabelecer uma conexão estável com o banco de dados!\nTente novamente mais tarde.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}