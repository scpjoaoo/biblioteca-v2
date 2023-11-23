
namespace biblioteca_v2
{
    partial class edFuncionario
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
            btnDeletarFuncionario = new Button();
            btnAtulizarFuncionario = new Button();
            button1 = new Button();
            tbEdSetorFuncionario = new TextBox();
            label5 = new Label();
            tbEdFoneFuncionario = new TextBox();
            label4 = new Label();
            tbEdDataFuncionario = new TextBox();
            label3 = new Label();
            tbEdIdadeFuncionario = new TextBox();
            label2 = new Label();
            tbEdNomeFuncionario = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleGreen;
            groupBox1.Controls.Add(btnDeletarFuncionario);
            groupBox1.Controls.Add(btnAtulizarFuncionario);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(tbEdSetorFuncionario);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbEdFoneFuncionario);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbEdDataFuncionario);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbEdIdadeFuncionario);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbEdNomeFuncionario);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 424);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edição Clientes";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnDeletarFuncionario
            // 
            btnDeletarFuncionario.Location = new Point(526, 276);
            btnDeletarFuncionario.Name = "btnDeletarFuncionario";
            btnDeletarFuncionario.Size = new Size(94, 29);
            btnDeletarFuncionario.TabIndex = 12;
            btnDeletarFuncionario.Text = "Deletar";
            btnDeletarFuncionario.UseVisualStyleBackColor = true;
            btnDeletarFuncionario.Click += btnDeletarFuncionario_Click;
            // 
            // btnAtulizarFuncionario
            // 
            btnAtulizarFuncionario.Location = new Point(319, 276);
            btnAtulizarFuncionario.Name = "btnAtulizarFuncionario";
            btnAtulizarFuncionario.Size = new Size(94, 29);
            btnAtulizarFuncionario.TabIndex = 11;
            btnAtulizarFuncionario.Text = "Atualizar";
            btnAtulizarFuncionario.UseVisualStyleBackColor = true;
            btnAtulizarFuncionario.Click += btnAtulizarFuncionario_Click;
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
            // tbEdSetorFuncionario
            // 
            tbEdSetorFuncionario.BorderStyle = BorderStyle.FixedSingle;
            tbEdSetorFuncionario.Cursor = Cursors.IBeam;
            tbEdSetorFuncionario.Location = new Point(472, 61);
            tbEdSetorFuncionario.Name = "tbEdSetorFuncionario";
            tbEdSetorFuncionario.ScrollBars = ScrollBars.Horizontal;
            tbEdSetorFuncionario.Size = new Size(194, 27);
            tbEdSetorFuncionario.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(417, 64);
            label5.Name = "label5";
            label5.Size = new Size(49, 22);
            label5.TabIndex = 8;
            label5.Text = "Setor:";
            // 
            // tbEdFoneFuncionario
            // 
            tbEdFoneFuncionario.BorderStyle = BorderStyle.FixedSingle;
            tbEdFoneFuncionario.Cursor = Cursors.IBeam;
            tbEdFoneFuncionario.Location = new Point(88, 103);
            tbEdFoneFuncionario.Name = "tbEdFoneFuncionario";
            tbEdFoneFuncionario.ScrollBars = ScrollBars.Horizontal;
            tbEdFoneFuncionario.Size = new Size(194, 27);
            tbEdFoneFuncionario.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(14, 106);
            label4.Name = "label4";
            label4.Size = new Size(68, 22);
            label4.TabIndex = 6;
            label4.Text = "Número:";
            // 
            // tbEdDataFuncionario
            // 
            tbEdDataFuncionario.BorderStyle = BorderStyle.FixedSingle;
            tbEdDataFuncionario.Cursor = Cursors.IBeam;
            tbEdDataFuncionario.Location = new Point(471, 103);
            tbEdDataFuncionario.Name = "tbEdDataFuncionario";
            tbEdDataFuncionario.ScrollBars = ScrollBars.Horizontal;
            tbEdDataFuncionario.Size = new Size(194, 27);
            tbEdDataFuncionario.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(359, 106);
            label3.Name = "label3";
            label3.Size = new Size(107, 22);
            label3.TabIndex = 4;
            label3.Text = "Data de inicio:";
            // 
            // tbEdIdadeFuncionario
            // 
            tbEdIdadeFuncionario.BorderStyle = BorderStyle.FixedSingle;
            tbEdIdadeFuncionario.Cursor = Cursors.IBeam;
            tbEdIdadeFuncionario.Location = new Point(88, 141);
            tbEdIdadeFuncionario.Name = "tbEdIdadeFuncionario";
            tbEdIdadeFuncionario.ScrollBars = ScrollBars.Horizontal;
            tbEdIdadeFuncionario.Size = new Size(194, 27);
            tbEdIdadeFuncionario.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(27, 144);
            label2.Name = "label2";
            label2.Size = new Size(52, 22);
            label2.TabIndex = 2;
            label2.Text = "Idade:";
            // 
            // tbEdNomeFuncionario
            // 
            tbEdNomeFuncionario.BorderStyle = BorderStyle.FixedSingle;
            tbEdNomeFuncionario.Cursor = Cursors.IBeam;
            tbEdNomeFuncionario.Location = new Point(88, 62);
            tbEdNomeFuncionario.Name = "tbEdNomeFuncionario";
            tbEdNomeFuncionario.ScrollBars = ScrollBars.Horizontal;
            tbEdNomeFuncionario.Size = new Size(194, 27);
            tbEdNomeFuncionario.TabIndex = 1;
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
            // edFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "edFuncionario";
            Text = "edFuncionario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private GroupBox groupBox1;
        private Button btnDeletarFuncionario;
        private Button btnAtulizarFuncionario;
        private Button button1;
        private TextBox tbEdSetorFuncionario;
        private Label label5;
        private TextBox tbEdFoneFuncionario;
        private Label label4;
        private TextBox tbEdDataFuncionario;
        private Label label3;
        private TextBox tbEdIdadeFuncionario;
        private Label label2;
        private TextBox tbEdNomeFuncionario;
        private Label label1;
    }
}