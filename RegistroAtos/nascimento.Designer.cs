namespace RegistroAtos
{
    partial class nascimento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cpf_pai = new System.Windows.Forms.MaskedTextBox();
            this.nome_pai = new System.Windows.Forms.TextBox();
            this.nascimento_pai = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cpf_mae = new System.Windows.Forms.MaskedTextBox();
            this.nascimento_mae = new System.Windows.Forms.MaskedTextBox();
            this.nome_mae = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.data_registro = new System.Windows.Forms.MaskedTextBox();
            this.data_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.nome_registro = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data do Registro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(356, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(54, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Registro";
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
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cpf_pai);
            this.groupBox1.Controls.Add(this.nome_pai);
            this.groupBox1.Controls.Add(this.nascimento_pai);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(54, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 100);
            this.groupBox1.TabIndex = 9;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cpf_mae);
            this.groupBox2.Controls.Add(this.nascimento_mae);
            this.groupBox2.Controls.Add(this.nome_mae);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(54, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 100);
            this.groupBox2.TabIndex = 10;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // data_registro
            // 
            this.data_registro.Location = new System.Drawing.Point(217, 52);
            this.data_registro.Mask = "00/00/0000";
            this.data_registro.Name = "data_registro";
            this.data_registro.Size = new System.Drawing.Size(91, 23);
            this.data_registro.TabIndex = 14;
            // 
            // data_nascimento
            // 
            this.data_nascimento.Location = new System.Drawing.Point(539, 52);
            this.data_nascimento.Mask = "00/00/0000";
            this.data_nascimento.Name = "data_nascimento";
            this.data_nascimento.Size = new System.Drawing.Size(91, 23);
            this.data_nascimento.TabIndex = 15;
            // 
            // nome_registro
            // 
            this.nome_registro.Location = new System.Drawing.Point(217, 100);
            this.nome_registro.Name = "nome_registro";
            this.nome_registro.Size = new System.Drawing.Size(209, 23);
            this.nome_registro.TabIndex = 16;
            // 
            // nascimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 436);
            this.Controls.Add(this.nome_registro);
            this.Controls.Add(this.data_nascimento);
            this.Controls.Add(this.data_registro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "nascimento";
            this.Text = "Registro de Nascimento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label9;
        private GroupBox groupBox1;
        private MaskedTextBox cpf_pai;
        private TextBox nome_pai;
        private MaskedTextBox nascimento_pai;
        private GroupBox groupBox2;
        private MaskedTextBox cpf_mae;
        private MaskedTextBox nascimento_mae;
        private TextBox nome_mae;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button button1;
        private Button button2;
        private MaskedTextBox data_registro;
        private MaskedTextBox data_nascimento;
        private TextBox nome_registro;
    }
}