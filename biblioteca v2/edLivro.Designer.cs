namespace biblioteca_v2
{
    partial class edLivro
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
            tbDataPublicada = new TextBox();
            label6 = new Label();
            btnDeletarLivro = new Button();
            btnAtualizarLivro = new Button();
            button1 = new Button();
            tbEdGeneroLivro = new TextBox();
            label5 = new Label();
            tbEdAutorLivro = new TextBox();
            label4 = new Label();
            tbEdQntLivro = new TextBox();
            label3 = new Label();
            tbEdQntAlugados = new TextBox();
            label2 = new Label();
            tbEdTituloLivro = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Salmon;
            groupBox1.Controls.Add(tbDataPublicada);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnDeletarLivro);
            groupBox1.Controls.Add(btnAtualizarLivro);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(tbEdGeneroLivro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbEdAutorLivro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbEdQntLivro);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbEdQntAlugados);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbEdTituloLivro);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 424);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edição Clientes";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tbDataPublicada
            // 
            tbDataPublicada.BorderStyle = BorderStyle.FixedSingle;
            tbDataPublicada.Cursor = Cursors.IBeam;
            tbDataPublicada.Location = new Point(177, 145);
            tbDataPublicada.Name = "tbDataPublicada";
            tbDataPublicada.ScrollBars = ScrollBars.Horizontal;
            tbDataPublicada.Size = new Size(194, 27);
            tbDataPublicada.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(27, 147);
            label6.Name = "label6";
            label6.Size = new Size(144, 22);
            label6.TabIndex = 13;
            label6.Text = "Data de publicação:";
            // 
            // btnDeletarLivro
            // 
            btnDeletarLivro.Location = new Point(526, 276);
            btnDeletarLivro.Name = "btnDeletarLivro";
            btnDeletarLivro.Size = new Size(94, 29);
            btnDeletarLivro.TabIndex = 12;
            btnDeletarLivro.Text = "Deletar";
            btnDeletarLivro.UseVisualStyleBackColor = true;
            btnDeletarLivro.Click += btnDeletarLivro_Click;
            // 
            // btnAtualizarLivro
            // 
            btnAtualizarLivro.Location = new Point(319, 276);
            btnAtualizarLivro.Name = "btnAtualizarLivro";
            btnAtualizarLivro.Size = new Size(94, 29);
            btnAtualizarLivro.TabIndex = 11;
            btnAtualizarLivro.Text = "Atualizar";
            btnAtualizarLivro.UseVisualStyleBackColor = true;
            btnAtualizarLivro.Click += btnAtualizarLivro_Click;
            // 
            // button1
            // 
            button1.Location = new Point(108, 276);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbEdGeneroLivro
            // 
            tbEdGeneroLivro.BorderStyle = BorderStyle.FixedSingle;
            tbEdGeneroLivro.Cursor = Cursors.IBeam;
            tbEdGeneroLivro.Location = new Point(472, 61);
            tbEdGeneroLivro.Name = "tbEdGeneroLivro";
            tbEdGeneroLivro.ScrollBars = ScrollBars.Horizontal;
            tbEdGeneroLivro.Size = new Size(194, 27);
            tbEdGeneroLivro.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(401, 61);
            label5.Name = "label5";
            label5.Size = new Size(62, 22);
            label5.TabIndex = 8;
            label5.Text = "Gênero:";
            // 
            // tbEdAutorLivro
            // 
            tbEdAutorLivro.BorderStyle = BorderStyle.FixedSingle;
            tbEdAutorLivro.Cursor = Cursors.IBeam;
            tbEdAutorLivro.Location = new Point(88, 103);
            tbEdAutorLivro.Name = "tbEdAutorLivro";
            tbEdAutorLivro.ScrollBars = ScrollBars.Horizontal;
            tbEdAutorLivro.Size = new Size(194, 27);
            tbEdAutorLivro.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(27, 105);
            label4.Name = "label4";
            label4.Size = new Size(51, 22);
            label4.TabIndex = 6;
            label4.Text = "Autor:";
            // 
            // tbEdQntLivro
            // 
            tbEdQntLivro.BorderStyle = BorderStyle.FixedSingle;
            tbEdQntLivro.Cursor = Cursors.IBeam;
            tbEdQntLivro.Location = new Point(473, 101);
            tbEdQntLivro.Name = "tbEdQntLivro";
            tbEdQntLivro.ScrollBars = ScrollBars.Horizontal;
            tbEdQntLivro.Size = new Size(194, 27);
            tbEdQntLivro.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(371, 103);
            label3.Name = "label3";
            label3.Size = new Size(92, 22);
            label3.TabIndex = 4;
            label3.Text = "Quantidade:";
            // 
            // tbEdQntAlugados
            // 
            tbEdQntAlugados.BorderStyle = BorderStyle.FixedSingle;
            tbEdQntAlugados.Cursor = Cursors.IBeam;
            tbEdQntAlugados.Location = new Point(473, 141);
            tbEdQntAlugados.Name = "tbEdQntAlugados";
            tbEdQntAlugados.ScrollBars = ScrollBars.Horizontal;
            tbEdQntAlugados.Size = new Size(194, 27);
            tbEdQntAlugados.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(386, 143);
            label2.Name = "label2";
            label2.Size = new Size(77, 22);
            label2.TabIndex = 2;
            label2.Text = "Alugados:";
            // 
            // tbEdTituloLivro
            // 
            tbEdTituloLivro.BorderStyle = BorderStyle.FixedSingle;
            tbEdTituloLivro.Cursor = Cursors.IBeam;
            tbEdTituloLivro.Location = new Point(88, 62);
            tbEdTituloLivro.Name = "tbEdTituloLivro";
            tbEdTituloLivro.ScrollBars = ScrollBars.Horizontal;
            tbEdTituloLivro.Size = new Size(194, 27);
            tbEdTituloLivro.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(27, 65);
            label1.Name = "label1";
            label1.Size = new Size(52, 22);
            label1.TabIndex = 0;
            label1.Text = "Titulo:";
            // 
            // edLivro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "edLivro";
            Text = "edLivro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDeletarLivro;
        private Button btnAtualizarLivro;
        private Button button1;
        private TextBox tbEdGeneroLivro;
        private Label label5;
        private TextBox tbEdAutorLivro;
        private Label label4;
        private TextBox tbEdQntLivro;
        private Label label3;
        private TextBox tbEdQntAlugados;
        private Label label2;
        private TextBox tbEdTituloLivro;
        private Label label1;
        private TextBox tbDataPublicada;
        private Label label6;
    }
}