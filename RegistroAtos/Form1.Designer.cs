namespace RegistroAtos
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
            this.btn_nascimento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_casamento = new System.Windows.Forms.Button();
            this.btn_obito = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_nascimento
            // 
            this.btn_nascimento.Location = new System.Drawing.Point(29, 87);
            this.btn_nascimento.Name = "btn_nascimento";
            this.btn_nascimento.Size = new System.Drawing.Size(106, 36);
            this.btn_nascimento.TabIndex = 0;
            this.btn_nascimento.Text = "Nascimento";
            this.btn_nascimento.UseVisualStyleBackColor = true;
            this.btn_nascimento.Click += new System.EventHandler(this.btn_nascimento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clique no Tipo de Registro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_casamento
            // 
            this.btn_casamento.Location = new System.Drawing.Point(155, 87);
            this.btn_casamento.Name = "btn_casamento";
            this.btn_casamento.Size = new System.Drawing.Size(106, 36);
            this.btn_casamento.TabIndex = 2;
            this.btn_casamento.Text = "Casamento";
            this.btn_casamento.UseVisualStyleBackColor = true;
            this.btn_casamento.Click += new System.EventHandler(this.btn_casamento_Click);
            // 
            // btn_obito
            // 
            this.btn_obito.Location = new System.Drawing.Point(279, 87);
            this.btn_obito.Name = "btn_obito";
            this.btn_obito.Size = new System.Drawing.Size(106, 36);
            this.btn_obito.TabIndex = 3;
            this.btn_obito.Text = "Obíto";
            this.btn_obito.UseVisualStyleBackColor = true;
            this.btn_obito.Click += new System.EventHandler(this.btn_obito_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(325, 171);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(60, 27);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 210);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_obito);
            this.Controls.Add(this.btn_casamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_nascimento);
            this.Name = "Form1";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_nascimento;
        private Label label1;
        private Button btn_casamento;
        private Button btn_obito;
        private Button btn_sair;
    }
}