namespace biblioteca_v2
{
    partial class edEscritores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cbEdGeneroPrincipal = new ComboBox();
            btnDeletarAutor = new Button();
            btnAtualizarAutor = new Button();
            btnCancelarAutor = new Button();
            tbEdObraPrincipal = new TextBox();
            label4 = new Label();
            tbEdQntObras = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tbEdNomeAutor = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Salmon;
            groupBox1.Controls.Add(cbEdGeneroPrincipal);
            groupBox1.Controls.Add(btnDeletarAutor);
            groupBox1.Controls.Add(btnAtualizarAutor);
            groupBox1.Controls.Add(btnCancelarAutor);
            groupBox1.Controls.Add(tbEdObraPrincipal);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbEdQntObras);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbEdNomeAutor);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 424);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edição Escritores";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cbEdGeneroPrincipal
            // 
            cbEdGeneroPrincipal.FormattingEnabled = true;
            cbEdGeneroPrincipal.Items.AddRange(new object[] { "Romance", "Terror", "Suspense", "Drama", "Aventura" });
            cbEdGeneroPrincipal.Location = new Point(474, 106);
            cbEdGeneroPrincipal.Name = "cbEdGeneroPrincipal";
            cbEdGeneroPrincipal.Size = new Size(151, 28);
            cbEdGeneroPrincipal.TabIndex = 13;
            // 
            // btnDeletarAutor
            // 
            btnDeletarAutor.Location = new Point(526, 276);
            btnDeletarAutor.Name = "btnDeletarAutor";
            btnDeletarAutor.Size = new Size(94, 29);
            btnDeletarAutor.TabIndex = 12;
            btnDeletarAutor.Text = "Deletar";
            btnDeletarAutor.UseVisualStyleBackColor = true;
            btnDeletarAutor.Click += btnDeletarAutor_Click;
            // 
            // btnAtualizarAutor
            // 
            btnAtualizarAutor.Location = new Point(319, 276);
            btnAtualizarAutor.Name = "btnAtualizarAutor";
            btnAtualizarAutor.Size = new Size(94, 29);
            btnAtualizarAutor.TabIndex = 11;
            btnAtualizarAutor.Text = "Atualizar";
            btnAtualizarAutor.UseVisualStyleBackColor = true;
            btnAtualizarAutor.Click += btnAtualizarAutor_Click;
            // 
            // btnCancelarAutor
            // 
            btnCancelarAutor.Location = new Point(108, 276);
            btnCancelarAutor.Name = "btnCancelarAutor";
            btnCancelarAutor.Size = new Size(94, 29);
            btnCancelarAutor.TabIndex = 10;
            btnCancelarAutor.Text = "Cancelar";
            btnCancelarAutor.UseVisualStyleBackColor = true;
            btnCancelarAutor.Click += btnCancelarAutor_Click;
            // 
            // tbEdObraPrincipal
            // 
            tbEdObraPrincipal.BorderStyle = BorderStyle.FixedSingle;
            tbEdObraPrincipal.Cursor = Cursors.IBeam;
            tbEdObraPrincipal.Location = new Point(128, 104);
            tbEdObraPrincipal.Name = "tbEdObraPrincipal";
            tbEdObraPrincipal.ScrollBars = ScrollBars.Horizontal;
            tbEdObraPrincipal.Size = new Size(194, 27);
            tbEdObraPrincipal.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(14, 106);
            label4.Name = "label4";
            label4.Size = new Size(108, 22);
            label4.TabIndex = 6;
            label4.Text = "Obra Principal:";
            // 
            // tbEdQntObras
            // 
            tbEdQntObras.BorderStyle = BorderStyle.FixedSingle;
            tbEdQntObras.Cursor = Cursors.IBeam;
            tbEdQntObras.Location = new Point(474, 63);
            tbEdQntObras.Name = "tbEdQntObras";
            tbEdQntObras.ScrollBars = ScrollBars.Horizontal;
            tbEdQntObras.Size = new Size(194, 27);
            tbEdQntObras.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(312, 64);
            label3.Name = "label3";
            label3.Size = new Size(156, 22);
            label3.TabIndex = 4;
            label3.Text = "Quantidade de Obras:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(345, 106);
            label2.Name = "label2";
            label2.Size = new Size(123, 22);
            label2.TabIndex = 2;
            label2.Text = "Gênero Principal:";
            // 
            // tbEdNomeAutor
            // 
            tbEdNomeAutor.BorderStyle = BorderStyle.FixedSingle;
            tbEdNomeAutor.Cursor = Cursors.IBeam;
            tbEdNomeAutor.Location = new Point(88, 62);
            tbEdNomeAutor.Name = "tbEdNomeAutor";
            tbEdNomeAutor.ScrollBars = ScrollBars.Horizontal;
            tbEdNomeAutor.Size = new Size(194, 27);
            tbEdNomeAutor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(27, 65);
            label1.Name = "label1";
            label1.Size = new Size(55, 22);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // edEscritores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "edEscritores";
            Text = "Edição de Escritores";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDeletarAutor;
        private Button btnAtualizarAutor;
        private Button btnCancelarAutor;
        private TextBox tbEdObraPrincipal;
        private Label label4;
        private TextBox tbEdQntObras;
        private Label label3;
        private Label label2;
        private TextBox tbEdNomeAutor;
        private Label label1;
        private ComboBox cbEdGeneroPrincipal;
    }
}