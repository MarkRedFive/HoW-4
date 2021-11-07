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

namespace Inventário
{
    public partial class dgvItem : Form
    {
        public dgvItem()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }
    }
}
