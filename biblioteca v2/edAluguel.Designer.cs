namespace biblioteca_v2
{
    partial class edAluguel
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
            btnEdDeletarAluguel = new Button();
            btnAtualizarAluguel = new Button();
            button1 = new Button();
            tbEdDataAluguel = new TextBox();
            label5 = new Label();
            tbEdLivroAluguel = new TextBox();
            label4 = new Label();
            tbEdStatus = new TextBox();
            label3 = new Label();
            tbEdDataEntrega = new TextBox();
            label2 = new Label();
            tbEdClienteAluguel = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.RosyBrown;
            groupBox1.Controls.Add(btnEdDeletarAluguel);
            groupBox1.Controls.Add(btnAtualizarAluguel);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(tbEdDataAluguel);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbEdLivroAluguel);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbEdStatus);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbEdDataEntrega);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbEdClienteAluguel);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 424);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edição Clientes";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnEdDeletarAluguel
            // 
            btnEdDeletarAluguel.Location = new Point(526, 276);
            btnEdDeletarAluguel.Name = "btnEdDeletarAluguel";
            btnEdDeletarAluguel.Size = new Size(94, 29);
            btnEdDeletarAluguel.TabIndex = 12;
            btnEdDeletarAluguel.Text = "Deletar";
            btnEdDeletarAluguel.UseVisualStyleBackColor = true;
            btnEdDeletarAluguel.Click += btnEdDeletarAluguel_Click;
            // 
            // btnAtualizarAluguel
            // 
            btnAtualizarAluguel.Location = new Point(319, 276);
            btnAtualizarAluguel.Name = "btnAtualizarAluguel";
            btnAtualizarAluguel.Size = new Size(94, 29);
            btnAtualizarAluguel.TabIndex = 11;
            btnAtualizarAluguel.Text = "Atualizar";
            btnAtualizarAluguel.UseVisualStyleBackColor = true;
            btnAtualizarAluguel.Click += btnAtualizarAluguel_Click;
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
            // tbEdDataAluguel
            // 
            tbEdDataAluguel.BorderStyle = BorderStyle.FixedSingle;
            tbEdDataAluguel.Cursor = Cursors.IBeam;
            tbEdDataAluguel.Location = new Point(547, 59);
            tbEdDataAluguel.Name = "tbEdDataAluguel";
            tbEdDataAluguel.ScrollBars = ScrollBars.Horizontal;
            tbEdDataAluguel.Size = new Size(194, 27);
            tbEdDataAluguel.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(421, 62);
            label5.Name = "label5";
            label5.Size = new Size(120, 22);
            label5.TabIndex = 8;
            label5.Text = "Data de aluguel:";
            // 
            // tbEdLivroAluguel
            // 
            tbEdLivroAluguel.BorderStyle = BorderStyle.FixedSingle;
            tbEdLivroAluguel.Cursor = Cursors.IBeam;
            tbEdLivroAluguel.Location = new Point(197, 101);
            tbEdLivroAluguel.Name = "tbEdLivroAluguel";
            tbEdLivroAluguel.ScrollBars = ScrollBars.Horizontal;
            tbEdLivroAluguel.Size = new Size(194, 27);
            tbEdLivroAluguel.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(144, 103);
            label4.Name = "label4";
            label4.Size = new Size(46, 22);
            label4.TabIndex = 6;
            label4.Text = "Livro:";
            // 
            // tbEdStatus
            // 
            tbEdStatus.BorderStyle = BorderStyle.FixedSingle;
            tbEdStatus.Cursor = Cursors.IBeam;
            tbEdStatus.Location = new Point(197, 141);
            tbEdStatus.Name = "tbEdStatus";
            tbEdStatus.ScrollBars = ScrollBars.Horizontal;
            tbEdStatus.Size = new Size(194, 27);
            tbEdStatus.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(136, 146);
            label3.Name = "label3";
            label3.Size = new Size(54, 22);
            label3.TabIndex = 4;
            label3.Text = "Status:";
            // 
            // tbEdDataEntrega
            // 
            tbEdDataEntrega.BorderStyle = BorderStyle.FixedSingle;
            tbEdDataEntrega.Cursor = Cursors.IBeam;
            tbEdDataEntrega.Location = new Point(549, 99);
            tbEdDataEntrega.Name = "tbEdDataEntrega";
            tbEdDataEntrega.ScrollBars = ScrollBars.Horizontal;
            tbEdDataEntrega.Size = new Size(194, 27);
            tbEdDataEntrega.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(421, 101);
            label2.Name = "label2";
            label2.Size = new Size(122, 22);
            label2.TabIndex = 2;
            label2.Text = "Data de entrega:";
            // 
            // tbEdClienteAluguel
            // 
            tbEdClienteAluguel.BorderStyle = BorderStyle.FixedSingle;
            tbEdClienteAluguel.Cursor = Cursors.IBeam;
            tbEdClienteAluguel.Location = new Point(197, 60);
            tbEdClienteAluguel.Name = "tbEdClienteAluguel";
            tbEdClienteAluguel.ScrollBars = ScrollBars.Horizontal;
            tbEdClienteAluguel.Size = new Size(194, 27);
            tbEdClienteAluguel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(27, 65);
            label1.Name = "label1";
            label1.Size = new Size(164, 22);
            label1.TabIndex = 0;
            label1.Text = "Cliente que emprestou:";
            // 
            // edAluguel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "edAluguel";
            Text = "edAluguel";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnEdDeletarAluguel;
        private Button btnAtualizarAluguel;
        private Button button1;
        private Label label5;
        private TextBox tbEdLivroAluguel;
        private Label label4;
        private TextBox tbEdStatus;
        private Label label3;
        private Label label2;
        private TextBox tbEdClienteAluguel;
        private Label label1;
        private TextBox tbEdDataAluguel;
        private TextBox tbEdDataEntrega;
    }
}