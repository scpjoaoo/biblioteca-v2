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
    public partial class edEscritores : Form
    {
        private int ID;
        public edEscritores(int ID)
        {
            InitializeComponent();
            PreencherCamposEscritor(ID);
            this.ID = ID;
        }
        private string connectionString = "Server=localhost;Database=biblioteca;Uid=root;Pwd=;";
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PreencherCamposEscritor(int ID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Nome, ObraPrincipal, QuantidadeObras, GeneroPrincipal FROM escritores WHERE ID = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", ID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Preencher os TextBoxes com os valores recuperados do banco de dados
                            tbEdNomeAutor.Text = reader["Nome"].ToString();
                            tbEdObraPrincipal.Text = reader["ObraPrincipal"].ToString();
                            tbEdQntObras.Text = reader["QuantidadeObras"].ToString();
                            cbEdGeneroPrincipal.Text = reader["GeneroPrincipal"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Escritor não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //LimparCampos();
                        }
                    }
                }
            }
        }

        private void btnDeletarAutor_Click(object sender, EventArgs e)
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

                string deleteQuery = "DELETE FROM escritores WHERE ID = @id";
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

        private void btnAtualizarAutor_Click(object sender, EventArgs e)
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

                string updateQuery = "UPDATE escritores SET Nome = @nome, ObraPrincipal = @obraprincipal, QuantidadeObras = @quantidadeobras, GeneroPrincipal = @generoprincipal WHERE ID = @id";
                using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@id", ID);
                    updateCommand.Parameters.AddWithValue("@nome", tbEdNomeAutor.Text);
                    updateCommand.Parameters.AddWithValue("@obraprincipal", tbEdObraPrincipal.Text);
                    updateCommand.Parameters.AddWithValue("@quantidadeobras", tbEdQntObras.Text);
                    updateCommand.Parameters.AddWithValue("@generoprincipal", cbEdGeneroPrincipal.Text);



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

        private void btnCancelarAutor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
