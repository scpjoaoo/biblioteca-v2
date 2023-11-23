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
    public partial class edFuncionario : Form
    {
        private int ID;
        public edFuncionario(int ID)
        {
            InitializeComponent();
            PreencherCamposFuncionario(ID);
            this.ID = ID;
        }
        private string connectionString = "Server=localhost;Database=biblioteca;Uid=root;Pwd=;";
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PreencherCamposFuncionario(int ID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Nome, Idade, Numero, Setor, Inicio FROM bibliotecarios WHERE ID = @id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", ID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Preencher os TextBoxes com os valores recuperados do banco de dados
                            tbEdNomeFuncionario.Text = reader["Nome"].ToString();
                            tbEdIdadeFuncionario.Text = reader["Idade"].ToString();
                            tbEdFoneFuncionario.Text = reader["Numero"].ToString();
                            tbEdSetorFuncionario.Text = reader["Setor"].ToString();
                            tbEdDataFuncionario.Text = reader["Inicio"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Funcionário não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //LimparCampos();
                        }
                    }
                }
            }
        }

        private void btnEdDeletarFuncionario_Click(object sender, EventArgs e)
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

                string deleteQuery = "DELETE FROM bibliotecarios WHERE ID = @id";
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

        private void btnAtulizarFuncionario_Click(object sender, EventArgs e)
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

                string updateQuery = "UPDATE bibliotecarios SET Nome = @nome, Idade = @idade, Numero = @numero, Setor = @setor, Inicio = @inicio WHERE ID = @id";
                using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@id", ID);
                    updateCommand.Parameters.AddWithValue("@nome", tbEdNomeFuncionario.Text);
                    updateCommand.Parameters.AddWithValue("@idade", tbEdIdadeFuncionario.Text);
                    updateCommand.Parameters.AddWithValue("@numero", tbEdFoneFuncionario.Text);
                    updateCommand.Parameters.AddWithValue("@setor", tbEdSetorFuncionario.Text);
                    updateCommand.Parameters.AddWithValue("@inicio", Convert.ToDateTime(tbEdDataFuncionario.Text));


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

        private void btnDeletarFuncionario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja deletar este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeletarCliente(ID);
            }
        }
    }
}
