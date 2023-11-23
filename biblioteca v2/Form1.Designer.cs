namespace biblioteca_v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox5 = new GroupBox();
            btnEnviarLivro = new Button();
            btnCancelarLivro = new Button();
            groupBox6 = new GroupBox();
            label15 = new Label();
            cbGeneroLivro = new ComboBox();
            dtpPublicacao = new DateTimePicker();
            tbQntLivro = new TextBox();
            tbExAlugadosLivro = new TextBox();
            tbAutorLivro = new TextBox();
            tbTituloLivro = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            btnEnviarEscritor = new Button();
            btnCancelarEscritor = new Button();
            groupBox4 = new GroupBox();
            label8 = new Label();
            cbGeneroEscritor = new ComboBox();
            tbQntObras = new TextBox();
            tbObraPrincipal = new TextBox();
            tbNomeEscritor = new TextBox();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            tabPage3 = new TabPage();
            groupBox7 = new GroupBox();
            btnEnviarFuncionario = new Button();
            btnCancelarFuncionario = new Button();
            groupBox8 = new GroupBox();
            dtpFuncionario = new DateTimePicker();
            tbFoneFuncionario = new TextBox();
            label25 = new Label();
            label9 = new Label();
            cbSetorFuncionario = new ComboBox();
            tbIdadeFuncionario = new TextBox();
            tbNomeFuncionario = new TextBox();
            label11 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            tabPage4 = new TabPage();
            groupBox1 = new GroupBox();
            btnEnviarCliente = new Button();
            btnCancelarCliente = new Button();
            groupBox2 = new GroupBox();
            tbExAlugadosCliente = new TextBox();
            tbEmailCliente = new TextBox();
            tbCPFcliente = new TextBox();
            label7 = new Label();
            tbFoneCliente = new TextBox();
            tbNomeCliente = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage5 = new TabPage();
            groupBox9 = new GroupBox();
            btnEnviarAluguel = new Button();
            btnCancelarAluguel = new Button();
            groupBox10 = new GroupBox();
            dtpDevolucao = new DateTimePicker();
            dtpAluguel = new DateTimePicker();
            tbLivroAluguel = new TextBox();
            tbAluguelCliente = new TextBox();
            label26 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            tabPage6 = new TabPage();
            groupBox11 = new GroupBox();
            cbTabela = new ComboBox();
            DataGrid = new DataGridView();
            btnCarregar = new Button();
            label27 = new Label();
            tabPage7 = new TabPage();
            groupBox12 = new GroupBox();
            btnEditar = new Button();
            tbIDEdicao = new TextBox();
            label28 = new Label();
            cbEdicao = new ComboBox();
            DataGrid2 = new DataGridView();
            btnCarregarEdicao = new Button();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            tabPage4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage5.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox10.SuspendLayout();
            tabPage6.SuspendLayout();
            groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            tabPage7.SuspendLayout();
            groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(968, 583);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = Properties.Resources.livro;
            tabPage1.Controls.Add(groupBox5);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(960, 550);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "CRUD Livros";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.LightGray;
            groupBox5.Controls.Add(btnEnviarLivro);
            groupBox5.Controls.Add(btnCancelarLivro);
            groupBox5.Controls.Add(groupBox6);
            groupBox5.Location = new Point(35, 39);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(856, 423);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "CRUD Livros";
            // 
            // btnEnviarLivro
            // 
            btnEnviarLivro.Cursor = Cursors.Hand;
            btnEnviarLivro.Location = new Point(517, 321);
            btnEnviarLivro.Name = "btnEnviarLivro";
            btnEnviarLivro.Size = new Size(111, 40);
            btnEnviarLivro.TabIndex = 15;
            btnEnviarLivro.Text = "Enviar";
            btnEnviarLivro.UseVisualStyleBackColor = true;
            btnEnviarLivro.Click += btnEnviarLivro_Click;
            // 
            // btnCancelarLivro
            // 
            btnCancelarLivro.Cursor = Cursors.Hand;
            btnCancelarLivro.Location = new Point(180, 321);
            btnCancelarLivro.Name = "btnCancelarLivro";
            btnCancelarLivro.Size = new Size(111, 40);
            btnCancelarLivro.TabIndex = 14;
            btnCancelarLivro.Text = "Cancelar";
            btnCancelarLivro.UseVisualStyleBackColor = true;
            btnCancelarLivro.Click += btnCancelarLivro_Click;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.WhiteSmoke;
            groupBox6.Controls.Add(label15);
            groupBox6.Controls.Add(cbGeneroLivro);
            groupBox6.Controls.Add(dtpPublicacao);
            groupBox6.Controls.Add(tbQntLivro);
            groupBox6.Controls.Add(tbExAlugadosLivro);
            groupBox6.Controls.Add(tbAutorLivro);
            groupBox6.Controls.Add(tbTituloLivro);
            groupBox6.Controls.Add(label16);
            groupBox6.Controls.Add(label17);
            groupBox6.Controls.Add(label18);
            groupBox6.Controls.Add(label19);
            groupBox6.Controls.Add(label20);
            groupBox6.Controls.Add(label21);
            groupBox6.FlatStyle = FlatStyle.System;
            groupBox6.ForeColor = SystemColors.ActiveCaptionText;
            groupBox6.Location = new Point(42, 48);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(745, 236);
            groupBox6.TabIndex = 13;
            groupBox6.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Silver;
            label15.BorderStyle = BorderStyle.Fixed3D;
            label15.Location = new Point(291, 17);
            label15.Name = "label15";
            label15.Size = new Size(131, 22);
            label15.TabIndex = 25;
            label15.Text = "Cadastre seu Livro";
            // 
            // cbGeneroLivro
            // 
            cbGeneroLivro.Cursor = Cursors.Hand;
            cbGeneroLivro.FormattingEnabled = true;
            cbGeneroLivro.Items.AddRange(new object[] { "Romance", "Terror", "Suspense", "Aventura", "Drama" });
            cbGeneroLivro.Location = new Point(212, 177);
            cbGeneroLivro.Name = "cbGeneroLivro";
            cbGeneroLivro.Size = new Size(151, 28);
            cbGeneroLivro.TabIndex = 24;
            // 
            // dtpPublicacao
            // 
            dtpPublicacao.ImeMode = ImeMode.On;
            dtpPublicacao.Location = new Point(578, 61);
            dtpPublicacao.Name = "dtpPublicacao";
            dtpPublicacao.Size = new Size(152, 27);
            dtpPublicacao.TabIndex = 23;
            // 
            // tbQntLivro
            // 
            tbQntLivro.BorderStyle = BorderStyle.FixedSingle;
            tbQntLivro.Cursor = Cursors.IBeam;
            tbQntLivro.Location = new Point(529, 115);
            tbQntLivro.Name = "tbQntLivro";
            tbQntLivro.Size = new Size(125, 27);
            tbQntLivro.TabIndex = 22;
            // 
            // tbExAlugadosLivro
            // 
            tbExAlugadosLivro.BorderStyle = BorderStyle.FixedSingle;
            tbExAlugadosLivro.Cursor = Cursors.IBeam;
            tbExAlugadosLivro.Location = new Point(590, 178);
            tbExAlugadosLivro.Name = "tbExAlugadosLivro";
            tbExAlugadosLivro.Size = new Size(125, 27);
            tbExAlugadosLivro.TabIndex = 21;
            // 
            // tbAutorLivro
            // 
            tbAutorLivro.BorderStyle = BorderStyle.FixedSingle;
            tbAutorLivro.Cursor = Cursors.IBeam;
            tbAutorLivro.Location = new Point(199, 113);
            tbAutorLivro.Name = "tbAutorLivro";
            tbAutorLivro.Size = new Size(198, 27);
            tbAutorLivro.TabIndex = 20;
            // 
            // tbTituloLivro
            // 
            tbTituloLivro.BorderStyle = BorderStyle.FixedSingle;
            tbTituloLivro.Cursor = Cursors.IBeam;
            tbTituloLivro.Location = new Point(199, 61);
            tbTituloLivro.Name = "tbTituloLivro";
            tbTituloLivro.Size = new Size(198, 27);
            tbTituloLivro.TabIndex = 19;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Silver;
            label16.BorderStyle = BorderStyle.Fixed3D;
            label16.Location = new Point(431, 181);
            label16.Name = "label16";
            label16.Size = new Size(155, 22);
            label16.TabIndex = 18;
            label16.Text = "Exemplares alugados:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Silver;
            label17.BorderStyle = BorderStyle.Fixed3D;
            label17.Location = new Point(431, 118);
            label17.Name = "label17";
            label17.Size = new Size(92, 22);
            label17.TabIndex = 17;
            label17.Text = "Quantidade:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Silver;
            label18.BorderStyle = BorderStyle.Fixed3D;
            label18.Location = new Point(431, 64);
            label18.Name = "label18";
            label18.Size = new Size(144, 22);
            label18.TabIndex = 16;
            label18.Text = "Data de publicação:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Silver;
            label19.BorderStyle = BorderStyle.Fixed3D;
            label19.Location = new Point(38, 181);
            label19.Name = "label19";
            label19.Size = new Size(168, 22);
            label19.TabIndex = 15;
            label19.Text = "Insira o gênero do livro:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Silver;
            label20.BorderStyle = BorderStyle.Fixed3D;
            label20.Location = new Point(38, 120);
            label20.Name = "label20";
            label20.Size = new Size(156, 22);
            label20.TabIndex = 14;
            label20.Text = "Insira o autor do livro:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Silver;
            label21.BorderStyle = BorderStyle.Fixed3D;
            label21.Location = new Point(38, 64);
            label21.Name = "label21";
            label21.Size = new Size(156, 22);
            label21.TabIndex = 13;
            label21.Text = "Insira o título do livro:";
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources.livro;
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(960, 550);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "CRUD Escritores";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightGray;
            groupBox3.Controls.Add(btnEnviarEscritor);
            groupBox3.Controls.Add(btnCancelarEscritor);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(35, 39);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(856, 423);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "CRUD Escritores";
            // 
            // btnEnviarEscritor
            // 
            btnEnviarEscritor.Location = new Point(517, 321);
            btnEnviarEscritor.Name = "btnEnviarEscritor";
            btnEnviarEscritor.Size = new Size(111, 40);
            btnEnviarEscritor.TabIndex = 15;
            btnEnviarEscritor.Text = "Enviar";
            btnEnviarEscritor.UseVisualStyleBackColor = true;
            btnEnviarEscritor.Click += btnEnviarEscritor_Click;
            // 
            // btnCancelarEscritor
            // 
            btnCancelarEscritor.Location = new Point(180, 321);
            btnCancelarEscritor.Name = "btnCancelarEscritor";
            btnCancelarEscritor.Size = new Size(111, 40);
            btnCancelarEscritor.TabIndex = 14;
            btnCancelarEscritor.Text = "Cancelar";
            btnCancelarEscritor.UseVisualStyleBackColor = true;
            btnCancelarEscritor.Click += btnCancelarEscritor_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.WhiteSmoke;
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(cbGeneroEscritor);
            groupBox4.Controls.Add(tbQntObras);
            groupBox4.Controls.Add(tbObraPrincipal);
            groupBox4.Controls.Add(tbNomeEscritor);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label14);
            groupBox4.FlatStyle = FlatStyle.System;
            groupBox4.ForeColor = SystemColors.ActiveCaptionText;
            groupBox4.Location = new Point(42, 48);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(745, 236);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Silver;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Location = new Point(291, 17);
            label8.Name = "label8";
            label8.Size = new Size(135, 22);
            label8.TabIndex = 25;
            label8.Text = "Cadastre o Escritor";
            // 
            // cbGeneroEscritor
            // 
            cbGeneroEscritor.FormattingEnabled = true;
            cbGeneroEscritor.Items.AddRange(new object[] { "Romance", "Terror", "Suspense", "Aventura", "Drama" });
            cbGeneroEscritor.Location = new Point(199, 178);
            cbGeneroEscritor.Name = "cbGeneroEscritor";
            cbGeneroEscritor.Size = new Size(151, 28);
            cbGeneroEscritor.TabIndex = 24;
            // 
            // tbQntObras
            // 
            tbQntObras.BorderStyle = BorderStyle.FixedSingle;
            tbQntObras.Location = new Point(588, 64);
            tbQntObras.Name = "tbQntObras";
            tbQntObras.Size = new Size(125, 27);
            tbQntObras.TabIndex = 22;
            // 
            // tbObraPrincipal
            // 
            tbObraPrincipal.BorderStyle = BorderStyle.FixedSingle;
            tbObraPrincipal.Location = new Point(199, 113);
            tbObraPrincipal.Name = "tbObraPrincipal";
            tbObraPrincipal.Size = new Size(198, 27);
            tbObraPrincipal.TabIndex = 20;
            // 
            // tbNomeEscritor
            // 
            tbNomeEscritor.BorderStyle = BorderStyle.FixedSingle;
            tbNomeEscritor.Location = new Point(199, 61);
            tbNomeEscritor.Name = "tbNomeEscritor";
            tbNomeEscritor.Size = new Size(198, 27);
            tbNomeEscritor.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Silver;
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Location = new Point(428, 64);
            label10.Name = "label10";
            label10.Size = new Size(154, 22);
            label10.TabIndex = 17;
            label10.Text = "Quantidade de obras:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Silver;
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Location = new Point(70, 181);
            label12.Name = "label12";
            label12.Size = new Size(123, 22);
            label12.TabIndex = 15;
            label12.Text = "Gênero Principal:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Silver;
            label13.BorderStyle = BorderStyle.Fixed3D;
            label13.Location = new Point(85, 115);
            label13.Name = "label13";
            label13.Size = new Size(108, 22);
            label13.TabIndex = 14;
            label13.Text = "Obra Principal:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Silver;
            label14.BorderStyle = BorderStyle.Fixed3D;
            label14.Location = new Point(63, 63);
            label14.Name = "label14";
            label14.Size = new Size(130, 22);
            label14.TabIndex = 13;
            label14.Text = "Nome do escritor:";
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = Properties.Resources.livro;
            tabPage3.Controls.Add(groupBox7);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(960, 550);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "CRUD Funcionários";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            groupBox7.BackColor = Color.LightGray;
            groupBox7.Controls.Add(btnEnviarFuncionario);
            groupBox7.Controls.Add(btnCancelarFuncionario);
            groupBox7.Controls.Add(groupBox8);
            groupBox7.Location = new Point(35, 39);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(856, 423);
            groupBox7.TabIndex = 3;
            groupBox7.TabStop = false;
            groupBox7.Text = "CRUD Bibliotecários";
            // 
            // btnEnviarFuncionario
            // 
            btnEnviarFuncionario.Location = new Point(517, 321);
            btnEnviarFuncionario.Name = "btnEnviarFuncionario";
            btnEnviarFuncionario.Size = new Size(111, 40);
            btnEnviarFuncionario.TabIndex = 15;
            btnEnviarFuncionario.Text = "Enviar";
            btnEnviarFuncionario.UseVisualStyleBackColor = true;
            btnEnviarFuncionario.Click += btnEnviarFuncionario_Click;
            // 
            // btnCancelarFuncionario
            // 
            btnCancelarFuncionario.Location = new Point(180, 321);
            btnCancelarFuncionario.Name = "btnCancelarFuncionario";
            btnCancelarFuncionario.Size = new Size(111, 40);
            btnCancelarFuncionario.TabIndex = 14;
            btnCancelarFuncionario.Text = "Cancelar";
            btnCancelarFuncionario.UseVisualStyleBackColor = true;
            btnCancelarFuncionario.Click += btnCancelarFuncionario_Click;
            // 
            // groupBox8
            // 
            groupBox8.BackColor = Color.WhiteSmoke;
            groupBox8.Controls.Add(dtpFuncionario);
            groupBox8.Controls.Add(tbFoneFuncionario);
            groupBox8.Controls.Add(label25);
            groupBox8.Controls.Add(label9);
            groupBox8.Controls.Add(cbSetorFuncionario);
            groupBox8.Controls.Add(tbIdadeFuncionario);
            groupBox8.Controls.Add(tbNomeFuncionario);
            groupBox8.Controls.Add(label11);
            groupBox8.Controls.Add(label22);
            groupBox8.Controls.Add(label23);
            groupBox8.Controls.Add(label24);
            groupBox8.FlatStyle = FlatStyle.System;
            groupBox8.ForeColor = SystemColors.ActiveCaptionText;
            groupBox8.Location = new Point(42, 48);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(745, 236);
            groupBox8.TabIndex = 13;
            groupBox8.TabStop = false;
            // 
            // dtpFuncionario
            // 
            dtpFuncionario.Location = new Point(585, 61);
            dtpFuncionario.Name = "dtpFuncionario";
            dtpFuncionario.Size = new Size(154, 27);
            dtpFuncionario.TabIndex = 28;
            // 
            // tbFoneFuncionario
            // 
            tbFoneFuncionario.BorderStyle = BorderStyle.FixedSingle;
            tbFoneFuncionario.Location = new Point(588, 118);
            tbFoneFuncionario.Name = "tbFoneFuncionario";
            tbFoneFuncionario.Size = new Size(125, 27);
            tbFoneFuncionario.TabIndex = 27;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Silver;
            label25.BorderStyle = BorderStyle.Fixed3D;
            label25.Location = new Point(511, 123);
            label25.Name = "label25";
            label25.Size = new Size(71, 22);
            label25.TabIndex = 26;
            label25.Text = "Telefone:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Silver;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Location = new Point(291, 17);
            label9.Name = "label9";
            label9.Size = new Size(163, 22);
            label9.TabIndex = 25;
            label9.Text = "Cadastre o Funcionário";
            // 
            // cbSetorFuncionario
            // 
            cbSetorFuncionario.FormattingEnabled = true;
            cbSetorFuncionario.Items.AddRange(new object[] { "Romance", "Terror", "Suspense", "Aventura", "Drama" });
            cbSetorFuncionario.Location = new Point(199, 178);
            cbSetorFuncionario.Name = "cbSetorFuncionario";
            cbSetorFuncionario.Size = new Size(151, 28);
            cbSetorFuncionario.TabIndex = 24;
            // 
            // tbIdadeFuncionario
            // 
            tbIdadeFuncionario.BorderStyle = BorderStyle.FixedSingle;
            tbIdadeFuncionario.Location = new Point(199, 113);
            tbIdadeFuncionario.Name = "tbIdadeFuncionario";
            tbIdadeFuncionario.Size = new Size(198, 27);
            tbIdadeFuncionario.TabIndex = 20;
            // 
            // tbNomeFuncionario
            // 
            tbNomeFuncionario.BorderStyle = BorderStyle.FixedSingle;
            tbNomeFuncionario.Location = new Point(199, 61);
            tbNomeFuncionario.Name = "tbNomeFuncionario";
            tbNomeFuncionario.Size = new Size(198, 27);
            tbNomeFuncionario.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Silver;
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Location = new Point(463, 66);
            label11.Name = "label11";
            label11.Size = new Size(119, 22);
            label11.TabIndex = 17;
            label11.Text = "Data de adesão:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Silver;
            label22.BorderStyle = BorderStyle.Fixed3D;
            label22.Location = new Point(141, 184);
            label22.Name = "label22";
            label22.Size = new Size(49, 22);
            label22.TabIndex = 15;
            label22.Text = "Setor:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Silver;
            label23.BorderStyle = BorderStyle.Fixed3D;
            label23.Location = new Point(138, 118);
            label23.Name = "label23";
            label23.Size = new Size(52, 22);
            label23.TabIndex = 14;
            label23.Text = "Idade:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Silver;
            label24.BorderStyle = BorderStyle.Fixed3D;
            label24.Location = new Point(35, 61);
            label24.Name = "label24";
            label24.Size = new Size(158, 22);
            label24.TabIndex = 13;
            label24.Text = "Nome do Funcionário:";
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = Properties.Resources.livro;
            tabPage4.Controls.Add(groupBox1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(960, 550);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "CRUD Clientes";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(btnEnviarCliente);
            groupBox1.Controls.Add(btnCancelarCliente);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(35, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(856, 423);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "CRUD Clientes";
            // 
            // btnEnviarCliente
            // 
            btnEnviarCliente.Location = new Point(541, 316);
            btnEnviarCliente.Name = "btnEnviarCliente";
            btnEnviarCliente.Size = new Size(111, 40);
            btnEnviarCliente.TabIndex = 17;
            btnEnviarCliente.Text = "Enviar";
            btnEnviarCliente.UseVisualStyleBackColor = true;
            btnEnviarCliente.Click += btnEnviarCliente_Click;
            // 
            // btnCancelarCliente
            // 
            btnCancelarCliente.Location = new Point(204, 316);
            btnCancelarCliente.Name = "btnCancelarCliente";
            btnCancelarCliente.Size = new Size(111, 40);
            btnCancelarCliente.TabIndex = 16;
            btnCancelarCliente.Text = "Cancelar";
            btnCancelarCliente.UseVisualStyleBackColor = true;
            btnCancelarCliente.Click += btnCancelarCliente_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(tbExAlugadosCliente);
            groupBox2.Controls.Add(tbEmailCliente);
            groupBox2.Controls.Add(tbCPFcliente);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(tbFoneCliente);
            groupBox2.Controls.Add(tbNomeCliente);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.FlatStyle = FlatStyle.System;
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(42, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(745, 236);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // tbExAlugadosCliente
            // 
            tbExAlugadosCliente.BorderStyle = BorderStyle.FixedSingle;
            tbExAlugadosCliente.Location = new Point(592, 115);
            tbExAlugadosCliente.Name = "tbExAlugadosCliente";
            tbExAlugadosCliente.Size = new Size(125, 27);
            tbExAlugadosCliente.TabIndex = 28;
            // 
            // tbEmailCliente
            // 
            tbEmailCliente.BorderStyle = BorderStyle.FixedSingle;
            tbEmailCliente.Location = new Point(201, 181);
            tbEmailCliente.Name = "tbEmailCliente";
            tbEmailCliente.Size = new Size(196, 27);
            tbEmailCliente.TabIndex = 27;
            // 
            // tbCPFcliente
            // 
            tbCPFcliente.BorderStyle = BorderStyle.FixedSingle;
            tbCPFcliente.Location = new Point(475, 61);
            tbCPFcliente.Name = "tbCPFcliente";
            tbCPFcliente.Size = new Size(125, 27);
            tbCPFcliente.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Silver;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(291, 17);
            label7.Name = "label7";
            label7.Size = new Size(132, 22);
            label7.TabIndex = 25;
            label7.Text = "Cadastre o Cliente";
            // 
            // tbFoneCliente
            // 
            tbFoneCliente.BorderStyle = BorderStyle.FixedSingle;
            tbFoneCliente.Location = new Point(199, 113);
            tbFoneCliente.Name = "tbFoneCliente";
            tbFoneCliente.Size = new Size(198, 27);
            tbFoneCliente.TabIndex = 20;
            // 
            // tbNomeCliente
            // 
            tbNomeCliente.BorderStyle = BorderStyle.FixedSingle;
            tbNomeCliente.Location = new Point(199, 61);
            tbNomeCliente.Name = "tbNomeCliente";
            tbNomeCliente.Size = new Size(198, 27);
            tbNomeCliente.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Silver;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(431, 120);
            label6.Name = "label6";
            label6.Size = new Size(155, 22);
            label6.TabIndex = 18;
            label6.Text = "Exemplares alugados:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(431, 64);
            label4.Name = "label4";
            label4.Size = new Size(38, 22);
            label4.TabIndex = 16;
            label4.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(138, 183);
            label3.Name = "label3";
            label3.Size = new Size(57, 22);
            label3.TabIndex = 15;
            label3.Text = "E-mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(122, 120);
            label2.Name = "label2";
            label2.Size = new Size(71, 22);
            label2.TabIndex = 14;
            label2.Text = "Telefone:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(138, 66);
            label1.Name = "label1";
            label1.Size = new Size(55, 22);
            label1.TabIndex = 13;
            label1.Text = "Nome:";
            // 
            // tabPage5
            // 
            tabPage5.BackgroundImage = Properties.Resources.livro;
            tabPage5.Controls.Add(groupBox9);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(960, 550);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "CRUD Aluguel";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            groupBox9.BackColor = Color.LightGray;
            groupBox9.Controls.Add(btnEnviarAluguel);
            groupBox9.Controls.Add(btnCancelarAluguel);
            groupBox9.Controls.Add(groupBox10);
            groupBox9.Location = new Point(35, 39);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(856, 423);
            groupBox9.TabIndex = 2;
            groupBox9.TabStop = false;
            groupBox9.Text = "CRUD Aluguéis";
            // 
            // btnEnviarAluguel
            // 
            btnEnviarAluguel.Location = new Point(536, 322);
            btnEnviarAluguel.Name = "btnEnviarAluguel";
            btnEnviarAluguel.Size = new Size(111, 40);
            btnEnviarAluguel.TabIndex = 17;
            btnEnviarAluguel.Text = "Enviar";
            btnEnviarAluguel.UseVisualStyleBackColor = true;
            btnEnviarAluguel.Click += btnEnviarAluguel_Click;
            // 
            // btnCancelarAluguel
            // 
            btnCancelarAluguel.Location = new Point(199, 322);
            btnCancelarAluguel.Name = "btnCancelarAluguel";
            btnCancelarAluguel.Size = new Size(111, 40);
            btnCancelarAluguel.TabIndex = 16;
            btnCancelarAluguel.Text = "Cancelar";
            btnCancelarAluguel.UseVisualStyleBackColor = true;
            btnCancelarAluguel.Click += btnCancelarAluguel_Click;
            // 
            // groupBox10
            // 
            groupBox10.BackColor = Color.WhiteSmoke;
            groupBox10.Controls.Add(dtpDevolucao);
            groupBox10.Controls.Add(dtpAluguel);
            groupBox10.Controls.Add(tbLivroAluguel);
            groupBox10.Controls.Add(tbAluguelCliente);
            groupBox10.Controls.Add(label26);
            groupBox10.Controls.Add(label29);
            groupBox10.Controls.Add(label30);
            groupBox10.Controls.Add(label31);
            groupBox10.Controls.Add(label32);
            groupBox10.FlatStyle = FlatStyle.System;
            groupBox10.ForeColor = SystemColors.ActiveCaptionText;
            groupBox10.Location = new Point(42, 48);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(745, 236);
            groupBox10.TabIndex = 13;
            groupBox10.TabStop = false;
            // 
            // dtpDevolucao
            // 
            dtpDevolucao.Location = new Point(577, 62);
            dtpDevolucao.Name = "dtpDevolucao";
            dtpDevolucao.Size = new Size(144, 27);
            dtpDevolucao.TabIndex = 29;
            // 
            // dtpAluguel
            // 
            dtpAluguel.Location = new Point(201, 183);
            dtpAluguel.Name = "dtpAluguel";
            dtpAluguel.Size = new Size(201, 27);
            dtpAluguel.TabIndex = 28;
            // 
            // tbLivroAluguel
            // 
            tbLivroAluguel.BorderStyle = BorderStyle.FixedSingle;
            tbLivroAluguel.Location = new Point(204, 113);
            tbLivroAluguel.Name = "tbLivroAluguel";
            tbLivroAluguel.Size = new Size(198, 27);
            tbLivroAluguel.TabIndex = 27;
            // 
            // tbAluguelCliente
            // 
            tbAluguelCliente.BorderStyle = BorderStyle.FixedSingle;
            tbAluguelCliente.Location = new Point(204, 62);
            tbAluguelCliente.Name = "tbAluguelCliente";
            tbAluguelCliente.Size = new Size(198, 27);
            tbAluguelCliente.TabIndex = 26;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Silver;
            label26.BorderStyle = BorderStyle.Fixed3D;
            label26.Location = new Point(291, 17);
            label26.Name = "label26";
            label26.Size = new Size(137, 22);
            label26.TabIndex = 25;
            label26.Text = "Cadastre o Aluguel";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = Color.Silver;
            label29.BorderStyle = BorderStyle.Fixed3D;
            label29.Location = new Point(431, 64);
            label29.Name = "label29";
            label29.Size = new Size(140, 22);
            label29.TabIndex = 16;
            label29.Text = "Data de devolução:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = Color.Silver;
            label30.BorderStyle = BorderStyle.Fixed3D;
            label30.Location = new Point(72, 184);
            label30.Name = "label30";
            label30.Size = new Size(123, 22);
            label30.TabIndex = 15;
            label30.Text = "Data do Aluguel:";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.BackColor = Color.Silver;
            label31.BorderStyle = BorderStyle.Fixed3D;
            label31.Location = new Point(147, 118);
            label31.Name = "label31";
            label31.Size = new Size(46, 22);
            label31.TabIndex = 14;
            label31.Text = "Livro:";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.BackColor = Color.Silver;
            label32.BorderStyle = BorderStyle.Fixed3D;
            label32.Location = new Point(138, 66);
            label32.Name = "label32";
            label32.Size = new Size(60, 22);
            label32.TabIndex = 13;
            label32.Text = "Cliente:";
            // 
            // tabPage6
            // 
            tabPage6.BackgroundImage = Properties.Resources.livro;
            tabPage6.Controls.Add(groupBox11);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(960, 550);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Painel Visualizar";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            groupBox11.BackColor = Color.LightGray;
            groupBox11.Controls.Add(cbTabela);
            groupBox11.Controls.Add(DataGrid);
            groupBox11.Controls.Add(btnCarregar);
            groupBox11.Controls.Add(label27);
            groupBox11.Location = new Point(24, 29);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(901, 496);
            groupBox11.TabIndex = 1;
            groupBox11.TabStop = false;
            // 
            // cbTabela
            // 
            cbTabela.FormattingEnabled = true;
            cbTabela.Location = new Point(247, 20);
            cbTabela.Name = "cbTabela";
            cbTabela.Size = new Size(151, 28);
            cbTabela.TabIndex = 30;
            // 
            // DataGrid
            // 
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Location = new Point(17, 71);
            DataGrid.Name = "DataGrid";
            DataGrid.RowHeadersWidth = 51;
            DataGrid.Size = new Size(878, 404);
            DataGrid.TabIndex = 29;
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(435, 22);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(94, 29);
            btnCarregar.TabIndex = 28;
            btnCarregar.Text = "Carregar";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.Silver;
            label27.BorderStyle = BorderStyle.Fixed3D;
            label27.Location = new Point(6, 23);
            label27.Name = "label27";
            label27.Size = new Size(235, 22);
            label27.TabIndex = 26;
            label27.Text = "Selecione a tabela para visualizar:";
            // 
            // tabPage7
            // 
            tabPage7.BackgroundImage = Properties.Resources.livro;
            tabPage7.Controls.Add(groupBox12);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(960, 550);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Editor";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            groupBox12.BackColor = Color.LightGray;
            groupBox12.Controls.Add(btnEditar);
            groupBox12.Controls.Add(tbIDEdicao);
            groupBox12.Controls.Add(label28);
            groupBox12.Controls.Add(cbEdicao);
            groupBox12.Controls.Add(DataGrid2);
            groupBox12.Controls.Add(btnCarregarEdicao);
            groupBox12.Controls.Add(label5);
            groupBox12.Location = new Point(30, 27);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(901, 496);
            groupBox12.TabIndex = 2;
            groupBox12.TabStop = false;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(462, 60);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 33;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // tbIDEdicao
            // 
            tbIDEdicao.BorderStyle = BorderStyle.FixedSingle;
            tbIDEdicao.Location = new Point(324, 62);
            tbIDEdicao.Name = "tbIDEdicao";
            tbIDEdicao.Size = new Size(132, 27);
            tbIDEdicao.TabIndex = 32;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.BackColor = Color.Silver;
            label28.BorderStyle = BorderStyle.Fixed3D;
            label28.Location = new Point(6, 67);
            label28.Name = "label28";
            label28.Size = new Size(312, 22);
            label28.TabIndex = 31;
            label28.Text = "Digite o ID escolhido para editar ou remover:";
            // 
            // cbEdicao
            // 
            cbEdicao.FormattingEnabled = true;
            cbEdicao.Location = new Point(247, 20);
            cbEdicao.Name = "cbEdicao";
            cbEdicao.Size = new Size(151, 28);
            cbEdicao.TabIndex = 30;
            // 
            // DataGrid2
            // 
            DataGrid2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid2.Location = new Point(17, 122);
            DataGrid2.Name = "DataGrid2";
            DataGrid2.RowHeadersWidth = 51;
            DataGrid2.Size = new Size(878, 353);
            DataGrid2.TabIndex = 29;
            // 
            // btnCarregarEdicao
            // 
            btnCarregarEdicao.Location = new Point(421, 19);
            btnCarregarEdicao.Name = "btnCarregarEdicao";
            btnCarregarEdicao.Size = new Size(94, 29);
            btnCarregarEdicao.TabIndex = 28;
            btnCarregarEdicao.Text = "Carregar";
            btnCarregarEdicao.UseVisualStyleBackColor = true;
            btnCarregarEdicao.Click += btnCarregarEdicao_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(6, 23);
            label5.Name = "label5";
            label5.Size = new Size(235, 22);
            label5.TabIndex = 26;
            label5.Text = "Selecione a tabela para visualizar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 578);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "CRUD Biblioteca";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabPage3.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            tabPage4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage5.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            tabPage6.ResumeLayout(false);
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            tabPage7.ResumeLayout(false);
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox5;
        private Button btnEnviarLivro;
        private Button btnCancelarLivro;
        private GroupBox groupBox6;
        private Label label15;
        private ComboBox cbGeneroLivro;
        private DateTimePicker dtpPublicacao;
        private TextBox tbQntLivro;
        private TextBox tbExAlugadosLivro;
        private TextBox tbAutorLivro;
        private TextBox tbTituloLivro;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private GroupBox groupBox3;
        private Button btnEnviarEscritor;
        private Button btnCancelarEscritor;
        private GroupBox groupBox4;
        private Label label8;
        private ComboBox cbGeneroEscritor;
        private TextBox tbQntObras;
        private TextBox tbObraPrincipal;
        private TextBox tbNomeEscritor;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label14;
        private TabPage tabPage3;
        private GroupBox groupBox7;
        private Button btnEnviarFuncionario;
        private Button btnCancelarFuncionario;
        private GroupBox groupBox8;
        private TextBox tbFoneFuncionario;
        private Label label25;
        private Label label9;
        private ComboBox cbSetorFuncionario;
        private TextBox tbIdadeFuncionario;
        private TextBox tbNomeFuncionario;
        private Label label11;
        private Label label22;
        private Label label23;
        private Label label24;
        private TabPage tabPage4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox tbEmailCliente;
        private TextBox tbCPFcliente;
        private Label label7;
        private TextBox tbFoneCliente;
        private TextBox tbNomeCliente;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage5;
        private GroupBox groupBox9;
        private GroupBox groupBox10;
        private Label label26;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private TabPage tabPage6;
        private Button btnEnviarCliente;
        private Button btnCancelarCliente;
        private TextBox tbExAlugadosCliente;
        private Button btnEnviarAluguel;
        private Button btnCancelarAluguel;
        private DateTimePicker dtpDevolucao;
        private DateTimePicker dtpAluguel;
        private TextBox tbLivroAluguel;
        private TextBox tbAluguelCliente;
        private GroupBox groupBox11;
        private Button btnCarregar;
        private Label label27;
        private ComboBox cbTabela;
        private DataGridView DataGrid;
        private DateTimePicker dtpFuncionario;
        private TabPage tabPage7;
        private GroupBox groupBox12;
        private TextBox tbIDEdicao;
        private Label label28;
        private ComboBox cbEdicao;
        private DataGridView DataGrid2;
        private Button btnCarregarEdicao;
        private Label label5;
        private Button btnEditar;
    }
}
