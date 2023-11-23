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
    public partial class edCliente : Form
    {
        private int ID;
        public edCliente(int ID)
        {
            InitializeComponent();
            PreencherCamposCliente(ID);
            this.ID = ID;
        }
        private string connectionString = "Server=localhost;Database=biblioteca;Uid=root;Pwd=;";
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PreencherCamposCliente(int ID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Nome, Numero, CPF, Email, ULivroAlugado FROM clientes WHERE ID = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", ID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Preencher os TextBoxes com os valores recuperados do banco de dados
                            tbEdNomeCliente.Text = reader["Nome"].ToString();
                            tbEdFoneCliente.Text = reader["Numero"].ToString();
                            tbEdCPFCliente.Text = reader["CPF"].ToString();
                            tbEdEmailCliente.Text = reader["Email"].ToString();
                            tbEdULACliente.Text = reader["ULivroAlugado"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //LimparCampos();
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

                string deleteQuery = "DELETE FROM clientes WHERE ID = @id";
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


        private void button2_Click(object sender, EventArgs e)
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

                string updateQuery = "UPDATE clientes SET Nome = @nome, Numero = @numero, CPF = @cpf, Email = @email, ULivroAlugado = @uLivroAlugado WHERE ID = @id";
                using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@id", ID);
                    updateCommand.Parameters.AddWithValue("@nome", tbEdNomeCliente.Text);
                    updateCommand.Parameters.AddWithValue("@numero", tbEdFoneCliente.Text);
                    updateCommand.Parameters.AddWithValue("@cpf", tbEdCPFCliente.Text);
                    updateCommand.Parameters.AddWithValue("@email", tbEdEmailCliente.Text);
                    updateCommand.Parameters.AddWithValue("@uLivroAlugado", tbEdULACliente.Text);

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
