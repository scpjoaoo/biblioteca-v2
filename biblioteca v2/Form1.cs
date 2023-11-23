using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System.Data;
namespace biblioteca_v2
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost;Database=biblioteca;Uid=root;Pwd=;";
        public Form1()
        {
            InitializeComponent();

            PreencherComboBoxTabelas();
        }

        private void PreencherComboBoxTabelas()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Obt�m a lista de tabelas no banco de dados
                    DataTable schema = connection.GetSchema("Tables");
                    foreach (DataRow row in schema.Rows)
                    {
                        string tableName = row["TABLE_NAME"].ToString();
                        cbTabela.Items.Add(tableName);
                        cbEdicao.Items.Add(tableName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter as tabelas: " + ex.Message);
            }
        }
        private void btnEnviarLivro_Click(object sender, EventArgs e)
        {
            // Extrai os valores dos controles do formul�rio
            string titulo = tbTituloLivro.Text;
            string autor = tbAutorLivro.Text;
            int quantidade = Convert.ToInt32(tbQntLivro.Text);
            int alugados = Convert.ToInt32(tbExAlugadosLivro.Text);
            DateTime anoPublicado = dtpPublicacao.Value;
            string genero = cbGeneroLivro.Text;

            // Executa a inser��o no banco de dados
            InserirLivro(titulo, autor, quantidade, alugados, anoPublicado, genero);
        }

        private void InserirLivro(string titulo, string autor, int quantidade, int alugados, DateTime anoPublicado, string genero)
        {
            try
            {
                string connectionString = "Server=localhost;Database=biblioteca;Uid=root;Pwd=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Constr�i a instru��o SQL para a inser��o
                    string query = "INSERT INTO livros (Titulo, Autor, Quantidade, Alugados, AnoPublicado, Genero) VALUES (@Titulo, @Autor, @Quantidade, @Alugados, @AnoPublicado, @Genero)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Adiciona par�metros � consulta
                        command.Parameters.AddWithValue("@Titulo", titulo);
                        command.Parameters.AddWithValue("@Autor", autor);
                        command.Parameters.AddWithValue("@Quantidade", quantidade);
                        command.Parameters.AddWithValue("@Alugados", alugados);
                        command.Parameters.AddWithValue("@AnoPublicado", anoPublicado);
                        command.Parameters.AddWithValue("@Genero", genero);

                        // Executa a consulta
                        command.ExecuteNonQuery();

                        MessageBox.Show("Livro inserido com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir livro: " + ex.Message);
            }
        }

        private void btnEnviarEscritor_Click(object sender, EventArgs e)
        {
            // Extrai os valores dos controles do formul�rio
            string nomeEscritor = tbNomeEscritor.Text;
            string obraPrincipal = tbObraPrincipal.Text;
            int quantidadeObras = Convert.ToInt32(tbQntObras.Text);
            string generoPrincipal = cbGeneroEscritor.Text;

            // Executa a inser��o no banco de dados
            InserirEscritor(nomeEscritor, obraPrincipal, quantidadeObras, generoPrincipal);
        }

        private void InserirEscritor(string nomeEscritor, string obraPrincipal, int quantidadeObras, string generoPrincipal)
        {
            try
            {
                string connectionString = "Server=localhost;Database=biblioteca;Uid=root;Pwd=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Constr�i a instru��o SQL para a inser��o
                    string query = "INSERT INTO Escritores (Nome, ObraPrincipal, QuantidadeObras, GeneroPrincipal) VALUES (@Nome, @ObraPrincipal, @QuantidadeObras, @GeneroPrincipal)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Adiciona par�metros � consulta
                        command.Parameters.AddWithValue("@Nome", nomeEscritor);
                        command.Parameters.AddWithValue("@ObraPrincipal", obraPrincipal);
                        command.Parameters.AddWithValue("@QuantidadeObras", quantidadeObras);
                        command.Parameters.AddWithValue("@GeneroPrincipal", generoPrincipal);

                        // Executa a consulta
                        command.ExecuteNonQuery();

                        MessageBox.Show("Escritor inserido com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir escritor: " + ex.Message);
            }
        }

        private void btnEnviarFuncionario_Click(object sender, EventArgs e)
        {
            // Extrai os valores dos controles do formul�rio
            string nomeFuncionario = tbNomeFuncionario.Text;
            int idadeFuncionario = Convert.ToInt32(tbIdadeFuncionario.Text);
            string numeroFuncionario = tbFoneFuncionario.Text;
            string setorFuncionario = cbSetorFuncionario.Text;
            DateTime inicioFuncionario = dtpFuncionario.Value;

            // Executa a inser��o no banco de dados
            InserirFuncionario(nomeFuncionario, idadeFuncionario, numeroFuncionario, setorFuncionario, inicioFuncionario);
        }

        private void InserirFuncionario(string nomeFuncionario, int idadeFuncionario, string numeroFuncionario, string setorFuncionario, DateTime inicioFuncionario)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Constr�i a instru��o SQL para a inser��o
                    string query = "INSERT INTO bibliotecarios (Nome, Idade, Numero, Setor, Inicio) VALUES (@Nome, @Idade, @Numero, @Setor, @Inicio)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Adiciona par�metros � consulta
                        command.Parameters.AddWithValue("@Nome", nomeFuncionario);
                        command.Parameters.AddWithValue("@Idade", idadeFuncionario);
                        command.Parameters.AddWithValue("@Numero", numeroFuncionario);
                        command.Parameters.AddWithValue("@Setor", setorFuncionario);
                        command.Parameters.AddWithValue("@Inicio", inicioFuncionario);

                        // Executa a consulta
                        command.ExecuteNonQuery();

                        MessageBox.Show("Funcion�rio inserido com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir funcion�rio: " + ex.Message);
            }
        }

        private void btnEnviarCliente_Click(object sender, EventArgs e)
        {
            // Extrai os valores dos controles do formul�rio
            string nomeCliente = tbNomeCliente.Text;
            string emailCliente = tbEmailCliente.Text;
            string numeroCliente = tbFoneCliente.Text;
            string cpfCliente = tbCPFcliente.Text;
            int livrosAlugadosCliente = Convert.ToInt32(tbExAlugadosCliente.Text);

            // Executa a inser��o no banco de dados
            InserirCliente(nomeCliente, emailCliente, numeroCliente, cpfCliente, livrosAlugadosCliente);
        }

        private void InserirCliente(string nomeCliente, string emailCliente, string numeroCliente, string cpfCliente, int livrosAlugadosCliente)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Constr�i a instru��o SQL para a inser��o
                    string query = "INSERT INTO clientes (Nome, Email, Numero, CPF, LivrosAlugados) VALUES (@Nome, @Email, @Numero, @CPF, @LivrosAlugados)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Adiciona par�metros � consulta
                        command.Parameters.AddWithValue("@Nome", nomeCliente);
                        command.Parameters.AddWithValue("@Email", emailCliente);
                        command.Parameters.AddWithValue("@Numero", numeroCliente);
                        command.Parameters.AddWithValue("@CPF", cpfCliente);
                        command.Parameters.AddWithValue("@LivrosAlugados", livrosAlugadosCliente);

                        // Executa a consulta
                        command.ExecuteNonQuery();

                        MessageBox.Show("Cliente inserido com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir cliente: " + ex.Message);
            }
        }

        private void btnEnviarAluguel_Click(object sender, EventArgs e)
        {
            // Extrai os valores dos controles do formul�rio
            string clienteAluguel = tbAluguelCliente.Text;
            string livroAluguel = tbLivroAluguel.Text;
            DateTime dataAluguel = dtpAluguel.Value;
            DateTime dataDevolucao = dtpDevolucao.Value;

            // Verifica se o cliente existe antes de inserir o aluguel
            if (VerificarClienteExistente(clienteAluguel))
            {
                // Executa a inser��o do aluguel e atualiza��o do cliente no banco de dados
                InserirAluguel(clienteAluguel, livroAluguel, dataAluguel, dataDevolucao);
            }
            else
            {
                MessageBox.Show("Cliente n�o encontrado. Por favor, verifique o nome do cliente.");
            }
        }

        private void InserirAluguel(string clienteAluguel, string livroAluguel, DateTime dataAluguel, DateTime dataDevolucao)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Inserir o aluguel na tabela alugueis
                    string queryInserirAluguel = "INSERT INTO alugueis (Cliente, Livro, DataAluguel, DataEntrega) VALUES (@Cliente, @Livro, @DataAluguel, @DataEntrega)";

                    using (MySqlCommand commandInserirAluguel = new MySqlCommand(queryInserirAluguel, connection))
                    {
                        commandInserirAluguel.Parameters.AddWithValue("@Cliente", clienteAluguel);
                        commandInserirAluguel.Parameters.AddWithValue("@Livro", livroAluguel);
                        commandInserirAluguel.Parameters.AddWithValue("@DataAluguel", dataAluguel);
                        commandInserirAluguel.Parameters.AddWithValue("@DataEntrega", dataDevolucao);

                        commandInserirAluguel.ExecuteNonQuery();
                    }

                    // Atualizar a coluna ULivroAlugado na tabela clientes
                    string queryAtualizarCliente = "UPDATE clientes SET ULivroAlugado = @Livro WHERE Nome = @Cliente";

                    using (MySqlCommand commandAtualizarCliente = new MySqlCommand(queryAtualizarCliente, connection))
                    {
                        commandAtualizarCliente.Parameters.AddWithValue("@Livro", livroAluguel);
                        commandAtualizarCliente.Parameters.AddWithValue("@Cliente", clienteAluguel);

                        commandAtualizarCliente.ExecuteNonQuery();
                    }

                    MessageBox.Show("Aluguel registrado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar aluguel: " + ex.Message);
            }
        }

        private bool VerificarClienteExistente(string nomeCliente)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Verifica se o cliente existe na tabela clientes
                string query = "SELECT COUNT(*) FROM clientes WHERE Nome = @Nome";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nomeCliente);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            // Obt�m o nome da tabela selecionada
            string tabelaSelecionada = cbTabela.SelectedItem as string;

            if (!string.IsNullOrEmpty(tabelaSelecionada))
            {
                // Carrega os dados da tabela selecionada no DataGrid
                CarregarDadosNoDataGrid(tabelaSelecionada);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma tabela.");
            }
        }

        private void CarregarDadosNoDataGrid(string tabela)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Constr�i a consulta SQL para selecionar todos os dados da tabela
                    string query = $"SELECT * FROM {tabela}";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Define a fonte de dados para o DataGrid
                        DataGrid.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }

        private void btnCarregarEdicao_Click(object sender, EventArgs e)
        {
            // Obt�m o nome da tabela selecionada
            string tabelaSelecionada = cbEdicao.SelectedItem as string;

            if (!string.IsNullOrEmpty(tabelaSelecionada))
            {
                // Carrega os dados da tabela selecionada no DataGrid
                CarregarDadosNoDataGrid2(tabelaSelecionada);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma tabela.");
            }
        }

        private void CarregarDadosNoDataGrid2(string tabela)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Constr�i a consulta SQL para selecionar todos os dados da tabela
                    string query = $"SELECT * FROM {tabela}";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Define a fonte de dados para o DataGrid
                        DataGrid2.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verifica se o usu�rio selecionou uma tabela
            if (cbEdicao.SelectedItem != null)
            {
                // Obt�m o nome da tabela selecionada
                string tabelaSelecionada = cbEdicao.SelectedItem.ToString();

                // Verifica se o usu�rio inseriu um ID v�lido
                if (int.TryParse(tbIDEdicao.Text, out int ID))
                {
                    // Abre o formul�rio din�mico para edi��o
                    AbrirFormularioEdicao(tabelaSelecionada, ID);
                }
                else
                {
                    MessageBox.Show("Insira um ID v�lido para edi��o.");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma tabela para edi��o.");
            }
        }

        private void AbrirFormularioEdicao(string tabela, int ID)
        {
            if (tabela == "clientes")
            {
                using (edCliente formEdicao = new edCliente(ID))
                {
                    formEdicao.ShowDialog();
                }
            }

            if (tabela == "escritores")
            {
                using (edEscritores formEdicao = new edEscritores(ID))
                {
                    formEdicao.ShowDialog();
                }
            }

            if (tabela == "livros")
            {
                using (edLivro formEdicao = new edLivro(ID))
                {
                    formEdicao.ShowDialog();
                }
            }

            if (tabela == "bibliotecarios")
            {
                using (edFuncionario formEdicao = new edFuncionario(ID))
                {
                    formEdicao.ShowDialog();
                }
            }

            if (tabela == "alugueis")
            {
                using (edAluguel formEdicao = new edAluguel(ID))
                {
                    formEdicao.ShowDialog();
                }
            }
            //Abre o formul�rio din�mico para edi��o

        }

        private void btnCancelarLivro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarEscritor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarAluguel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
