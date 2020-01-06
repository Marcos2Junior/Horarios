namespace horario
{
    partial class senhas
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
            this.btn_gravar = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_confSenha = new System.Windows.Forms.TextBox();
            this.rtb_descricao = new System.Windows.Forms.RichTextBox();
            this.txt_chave = new System.Windows.Forms.TextBox();
            this.cb_chaves = new System.Windows.Forms.ComboBox();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(213, 447);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(128, 48);
            this.btn_gravar.TabIndex = 4;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(60, 213);
            this.txt_senha.MaxLength = 50;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(281, 20);
            this.txt_senha.TabIndex = 1;
            // 
            // txt_confSenha
            // 
            this.txt_confSenha.Location = new System.Drawing.Point(60, 262);
            this.txt_confSenha.MaxLength = 50;
            this.txt_confSenha.Name = "txt_confSenha";
            this.txt_confSenha.PasswordChar = '*';
            this.txt_confSenha.Size = new System.Drawing.Size(281, 20);
            this.txt_confSenha.TabIndex = 2;
            // 
            // rtb_descricao
            // 
            this.rtb_descricao.Location = new System.Drawing.Point(60, 311);
            this.rtb_descricao.MaxLength = 200;
            this.rtb_descricao.Name = "rtb_descricao";
            this.rtb_descricao.Size = new System.Drawing.Size(281, 96);
            this.rtb_descricao.TabIndex = 3;
            this.rtb_descricao.Text = "";
            // 
            // txt_chave
            // 
            this.txt_chave.Location = new System.Drawing.Point(60, 164);
            this.txt_chave.MaxLength = 50;
            this.txt_chave.Name = "txt_chave";
            this.txt_chave.Size = new System.Drawing.Size(158, 20);
            this.txt_chave.TabIndex = 0;
            // 
            // cb_chaves
            // 
            this.cb_chaves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_chaves.FormattingEnabled = true;
            this.cb_chaves.Location = new System.Drawing.Point(214, 70);
            this.cb_chaves.Name = "cb_chaves";
            this.cb_chaves.Size = new System.Drawing.Size(175, 21);
            this.cb_chaves.TabIndex = 6;
            this.cb_chaves.SelectedIndexChanged += new System.EventHandler(this.cb_chaves_SelectedIndexChanged);
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Location = new System.Drawing.Point(272, 185);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(69, 22);
            this.btn_visualizar.TabIndex = 5;
            this.btn_visualizar.Text = "Visualizar";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(259, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pressione ESC para voltar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(57, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Palavra Chave para identificação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Location = new System.Drawing.Point(57, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(57, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Confirme a senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Location = new System.Drawing.Point(57, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descrição";
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(320, 97);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(69, 22);
            this.btn_excluir.TabIndex = 12;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(12, 70);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(100, 37);
            this.btn_limpar.TabIndex = 13;
            this.btn_limpar.Text = "Limpar campos";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // senhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(401, 527);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_visualizar);
            this.Controls.Add(this.cb_chaves);
            this.Controls.Add(this.txt_chave);
            this.Controls.Add(this.rtb_descricao);
            this.Controls.Add(this.txt_confSenha);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.btn_gravar);
            this.KeyPreview = true;
            this.Name = "senhas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.senhas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.senhas_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_confSenha;
        private System.Windows.Forms.RichTextBox rtb_descricao;
        private System.Windows.Forms.TextBox txt_chave;
        private System.Windows.Forms.ComboBox cb_chaves;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_limpar;
    }
}