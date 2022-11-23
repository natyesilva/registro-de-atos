namespace RegistroAtos
{
    partial class obito
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
            this.nome_falecido = new System.Windows.Forms.TextBox();
            this.data_obito = new System.Windows.Forms.MaskedTextBox();
            this.data_registro = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cpf_mae = new System.Windows.Forms.MaskedTextBox();
            this.nascimento_mae = new System.Windows.Forms.MaskedTextBox();
            this.nome_mae = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cpf_pai = new System.Windows.Forms.MaskedTextBox();
            this.nome_pai = new System.Windows.Forms.TextBox();
            this.nascimento_pai = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.data_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nome_falecido
            // 
            this.nome_falecido.Location = new System.Drawing.Point(269, 95);
            this.nome_falecido.Name = "nome_falecido";
            this.nome_falecido.Size = new System.Drawing.Size(191, 23);
            this.nome_falecido.TabIndex = 26;
            // 
            // data_obito
            // 
            this.data_obito.Location = new System.Drawing.Point(543, 42);
            this.data_obito.Mask = "00/00/0000";
            this.data_obito.Name = "data_obito";
            this.data_obito.Size = new System.Drawing.Size(91, 23);
            this.data_obito.TabIndex = 25;
            // 
            // data_registro
            // 
            this.data_registro.Location = new System.Drawing.Point(269, 47);
            this.data_registro.Mask = "00/00/0000";
            this.data_registro.Name = "data_registro";
            this.data_registro.Size = new System.Drawing.Size(91, 23);
            this.data_registro.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cpf_mae);
            this.groupBox2.Controls.Add(this.nascimento_mae);
            this.groupBox2.Controls.Add(this.nome_mae);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(106, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 100);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Mãe";
            // 
            // cpf_mae
            // 
            this.cpf_mae.Location = new System.Drawing.Point(339, 18);
            this.cpf_mae.Mask = "___.___.___-__";
            this.cpf_mae.Name = "cpf_mae";
            this.cpf_mae.Size = new System.Drawing.Size(100, 23);
            this.cpf_mae.TabIndex = 19;
            // 
            // nascimento_mae
            // 
            this.nascimento_mae.Location = new System.Drawing.Point(190, 54);
            this.nascimento_mae.Mask = "00/00/0000";
            this.nascimento_mae.Name = "nascimento_mae";
            this.nascimento_mae.Size = new System.Drawing.Size(91, 23);
            this.nascimento_mae.TabIndex = 18;
            // 
            // nome_mae
            // 
            this.nome_mae.Location = new System.Drawing.Point(72, 22);
            this.nome_mae.Name = "nome_mae";
            this.nome_mae.Size = new System.Drawing.Size(209, 23);
            this.nome_mae.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(13, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nome:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(302, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "CPF ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(13, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Data de Nascimento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cpf_pai);
            this.groupBox1.Controls.Add(this.nome_pai);
            this.groupBox1.Controls.Add(this.nascimento_pai);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(106, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pai";
            // 
            // cpf_pai
            // 
            this.cpf_pai.Location = new System.Drawing.Point(339, 13);
            this.cpf_pai.Mask = "___.___.___-__";
            this.cpf_pai.Name = "cpf_pai";
            this.cpf_pai.Size = new System.Drawing.Size(100, 23);
            this.cpf_pai.TabIndex = 20;
            // 
            // nome_pai
            // 
            this.nome_pai.Location = new System.Drawing.Point(72, 19);
            this.nome_pai.Name = "nome_pai";
            this.nome_pai.Size = new System.Drawing.Size(209, 23);
            this.nome_pai.TabIndex = 17;
            // 
            // nascimento_pai
            // 
            this.nascimento_pai.Location = new System.Drawing.Point(190, 54);
            this.nascimento_pai.Mask = "00/00/0000";
            this.nascimento_pai.Name = "nascimento_pai";
            this.nascimento_pai.Size = new System.Drawing.Size(91, 23);
            this.nascimento_pai.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(302, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "CPF ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(106, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nome do Falecido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(408, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Data de Obíto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data do Registro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(466, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Data de Obíto";
            // 
            // data_nascimento
            // 
            this.data_nascimento.Location = new System.Drawing.Point(591, 90);
            this.data_nascimento.Mask = "00/00/0000";
            this.data_nascimento.Name = "data_nascimento";
            this.data_nascimento.Size = new System.Drawing.Size(91, 23);
            this.data_nascimento.TabIndex = 28;
            // 
            // obito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data_nascimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nome_falecido);
            this.Controls.Add(this.data_obito);
            this.Controls.Add(this.data_registro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "obito";
            this.Text = "obito";
            this.Load += new System.EventHandler(this.obito_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nome_falecido;
        private MaskedTextBox data_obito;
        private MaskedTextBox data_registro;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private MaskedTextBox cpf_mae;
        private MaskedTextBox nascimento_mae;
        private TextBox nome_mae;
        private Label label10;
        private Label label11;
        private Label label12;
        private GroupBox groupBox1;
        private MaskedTextBox cpf_pai;
        private TextBox nome_pai;
        private MaskedTextBox nascimento_pai;
        private Label label4;
        private Label label9;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private MaskedTextBox data_nascimento;
    }
}