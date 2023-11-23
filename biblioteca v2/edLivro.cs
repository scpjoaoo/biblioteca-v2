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
    public partial class edLivro : Form
    {
        private int ID;
        public edLivro(int ID)
        {
            InitializeComponent();
            PreencherCamposLivro(ID);
            this.ID = ID;
        }
        private string connectionString = "Server=localhost;Database=biblioteca;Uid=root;Pwd=;";
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PreencherCamposLivro(int ID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Titulo, Autor, AnoPublicado, Genero, Quantidade, Alugados FROM Livros WHERE ID = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", ID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Preencher os TextBoxes com os valores recuperados do banco de dados
                            tbEdTituloLivro.Text = reader["Titulo"].ToString();
                            tbEdAutorLivro.Text = reader["Autor"].ToString();
                            tbDataPublicada.Text = reader["AnoPublicado"].ToString();
                            tbEdGeneroLivro.Text = reader["Genero"].ToString();
                            tbEdQntLivro.Text = reader["Quantidade"].ToString();
                            tbEdQntAlugados.Text = reader["Alugados"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Livro não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //LimparCampos();
                        }
                    }
                }
            }
        }

        private void btnDeletarLivro_Click(object sender, EventArgs e)
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

                string deleteQuery = "DELETE FROM livros WHERE ID = @id";
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

        private void btnAtualizarLivro_Click(object sender, EventArgs e)
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

                string updateQuery = "UPDATE livros SET Titulo = @titulo, Autor = @nome, AnoPublicado = @anopublicado, Genero = @genero, Quantidade = @quantidade, Alugados = @alugados WHERE ID = @id";
                using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@id", ID);
                    updateCommand.Parameters.AddWithValue("@titulo", tbEdTituloLivro.Text);
                    updateCommand.Parameters.AddWithValue("@nome", tbEdAutorLivro.Text);
                    updateCommand.Parameters.AddWithValue("@anopublicado", Convert.ToDateTime(tbDataPublicada.Text));
                    updateCommand.Parameters.AddWithValue("@genero", tbEdGeneroLivro.Text);
                    updateCommand.Parameters.AddWithValue("@quantidade", tbEdQntLivro.Text);
                    updateCommand.Parameters.AddWithValue("@alugados", tbEdQntAlugados.Text);

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
