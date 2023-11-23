using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca_v2
{
    public partial class edAluguel : Form
    {
        private int ID;
        public edAluguel(int ID)
        {
            InitializeComponent();
            PreencherCamposAluguel(ID);
            this.ID = ID;


        }
        private string connectionString = "Server=localhost;Database=biblioteca;Uid=root;Pwd=;";
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PreencherCamposAluguel(int ID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Cliente, Livro, DataAluguel, DataEntrega, Status FROM alugueis WHERE ID = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", ID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Preencher os TextBoxes com os valores recuperados do banco de dados
                            tbEdClienteAluguel.Text = reader["Cliente"].ToString();
                            tbEdLivroAluguel.Text = reader["Livro"].ToString();
                            tbEdStatus.Text = reader["Status"].ToString();
                            tbEdDataAluguel.Text = reader["DataAluguel"].ToString();
                            tbEdDataEntrega.Text = reader["DataEntrega"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Registro não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }
        }

        private void btnEdDeletarAluguel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja deletar este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeletarCliente(ID);
            }
        }

        private void DeletarCliente(int ID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM alugueis WHERE ID = @id";
                using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@id", ID);

                    int rowsAffected = deleteCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registro deletado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
            }
        }

        private void btnAtualizarAluguel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja atualizar este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AtualizarCliente(ID);
            }
        }

        private void AtualizarCliente(int ID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE alugueis SET Cliente = @nome, Livro = @livro, DataAluguel = @dataaluguel, DataEntrega = @dataentrega, Status = @status WHERE ID = @id";
                using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@id", ID);
                    updateCommand.Parameters.AddWithValue("@nome", tbEdClienteAluguel.Text);
                    updateCommand.Parameters.AddWithValue("@livro", tbEdLivroAluguel.Text);
                    updateCommand.Parameters.AddWithValue("@status", tbEdStatus.Text);
                    updateCommand.Parameters.AddWithValue("@dataaluguel", Convert.ToDateTime(tbEdDataAluguel.Text));
                    updateCommand.Parameters.AddWithValue("@dataentrega", Convert.ToDateTime(tbEdDataEntrega.Text));

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registro atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
