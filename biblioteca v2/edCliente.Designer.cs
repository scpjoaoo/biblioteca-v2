
namespace biblioteca_v2
{
    partial class edCliente
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tbEdULACliente = new TextBox();
            label5 = new Label();
            tbEdFoneCliente = new TextBox();
            label4 = new Label();
            tbEdCPFCliente = new TextBox();
            label3 = new Label();
            tbEdEmailCliente = new TextBox();
            label2 = new Label();
            tbEdNomeCliente = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Salmon;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(tbEdULACliente);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbEdFoneCliente);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbEdCPFCliente);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbEdEmailCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbEdNomeCliente);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 424);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edição Clientes";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button3
            // 
            button3.Location = new Point(526, 276);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Deletar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(319, 276);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            // tbEdULACliente
            // 
            tbEdULACliente.BorderStyle = BorderStyle.FixedSingle;
            tbEdULACliente.Cursor = Cursors.IBeam;
            tbEdULACliente.Location = new Point(472, 61);
            tbEdULACliente.Name = "tbEdULACliente";
            tbEdULACliente.ScrollBars = ScrollBars.Horizontal;
            tbEdULACliente.Size = new Size(194, 27);
            tbEdULACliente.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(310, 64);
            label5.Name = "label5";
            label5.Size = new Size(156, 22);
            label5.TabIndex = 8;
            label5.Text = "Ultimo Livro Alugado:";
            // 
            // tbEdFoneCliente
            // 
            tbEdFoneCliente.BorderStyle = BorderStyle.FixedSingle;
            tbEdFoneCliente.Cursor = Cursors.IBeam;
            tbEdFoneCliente.Location = new Point(88, 103);
            tbEdFoneCliente.Name = "tbEdFoneCliente";
            tbEdFoneCliente.ScrollBars = ScrollBars.Horizontal;
            tbEdFoneCliente.Size = new Size(194, 27);
            tbEdFoneCliente.TabIndex = 7;
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
            // tbEdCPFCliente
            // 
            tbEdCPFCliente.BorderStyle = BorderStyle.FixedSingle;
            tbEdCPFCliente.Cursor = Cursors.IBeam;
            tbEdCPFCliente.Location = new Point(88, 143);
            tbEdCPFCliente.Name = "tbEdCPFCliente";
            tbEdCPFCliente.ScrollBars = ScrollBars.Horizontal;
            tbEdCPFCliente.Size = new Size(194, 27);
            tbEdCPFCliente.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(43, 145);
            label3.Name = "label3";
            label3.Size = new Size(38, 22);
            label3.TabIndex = 4;
            label3.Text = "CPF:";
            // 
            // tbEdEmailCliente
            // 
            tbEdEmailCliente.BorderStyle = BorderStyle.FixedSingle;
            tbEdEmailCliente.Cursor = Cursors.IBeam;
            tbEdEmailCliente.Location = new Point(88, 183);
            tbEdEmailCliente.Name = "tbEdEmailCliente";
            tbEdEmailCliente.ScrollBars = ScrollBars.Horizontal;
            tbEdEmailCliente.Size = new Size(194, 27);
            tbEdEmailCliente.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(27, 186);
            label2.Name = "label2";
            label2.Size = new Size(51, 22);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // tbEdNomeCliente
            // 
            tbEdNomeCliente.BorderStyle = BorderStyle.FixedSingle;
            tbEdNomeCliente.Cursor = Cursors.IBeam;
            tbEdNomeCliente.Location = new Point(88, 62);
            tbEdNomeCliente.Name = "tbEdNomeCliente";
            tbEdNomeCliente.ScrollBars = ScrollBars.Horizontal;
            tbEdNomeCliente.Size = new Size(194, 27);
            tbEdNomeCliente.TabIndex = 1;
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
            // edCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "edCliente";
            Text = "edCliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbEdNomeCliente;
        private Label label1;
        private TextBox tbEdFoneCliente;
        private Label label4;
        private TextBox tbEdCPFCliente;
        private Label label3;
        private TextBox tbEdEmailCliente;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox tbEdULACliente;
        private Label label5;
    }
}