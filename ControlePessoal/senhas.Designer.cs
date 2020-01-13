namespace ControlePessoal
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
            this.btn_gerarSenha = new System.Windows.Forms.Button();
            this.panel_gerarSenha = new System.Windows.Forms.Panel();
            this.btn_cancelarGerarSenha = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.btn_gerar = new System.Windows.Forms.Button();
            this.numeric_quantidade = new System.Windows.Forms.NumericUpDown();
            this.cb_caracteres = new System.Windows.Forms.CheckBox();
            this.cb_maiusculas = new System.Windows.Forms.CheckBox();
            this.cb_minusculas = new System.Windows.Forms.CheckBox();
            this.cb_numeros = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_gerarSenha.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_quantidade)).BeginInit();
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
            this.txt_senha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(60, 209);
            this.txt_senha.MaxLength = 40;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(281, 27);
            this.txt_senha.TabIndex = 1;
            // 
            // txt_confSenha
            // 
            this.txt_confSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confSenha.Location = new System.Drawing.Point(60, 271);
            this.txt_confSenha.MaxLength = 40;
            this.txt_confSenha.Name = "txt_confSenha";
            this.txt_confSenha.PasswordChar = '*';
            this.txt_confSenha.Size = new System.Drawing.Size(281, 27);
            this.txt_confSenha.TabIndex = 2;
            // 
            // rtb_descricao
            // 
            this.rtb_descricao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_descricao.Location = new System.Drawing.Point(60, 331);
            this.rtb_descricao.MaxLength = 220;
            this.rtb_descricao.Name = "rtb_descricao";
            this.rtb_descricao.Size = new System.Drawing.Size(281, 96);
            this.rtb_descricao.TabIndex = 3;
            this.rtb_descricao.Text = "";
            this.rtb_descricao.TextChanged += new System.EventHandler(this.rtb_descricao_TextChanged);
            // 
            // txt_chave
            // 
            this.txt_chave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chave.Location = new System.Drawing.Point(60, 146);
            this.txt_chave.MaxLength = 50;
            this.txt_chave.Name = "txt_chave";
            this.txt_chave.Size = new System.Drawing.Size(158, 27);
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
            this.btn_visualizar.Location = new System.Drawing.Point(181, 181);
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
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(56, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Palavra Chave para identificação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Location = new System.Drawing.Point(56, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(56, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Confirme a senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Location = new System.Drawing.Point(56, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
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
            // btn_gerarSenha
            // 
            this.btn_gerarSenha.Location = new System.Drawing.Point(256, 181);
            this.btn_gerarSenha.Name = "btn_gerarSenha";
            this.btn_gerarSenha.Size = new System.Drawing.Size(85, 22);
            this.btn_gerarSenha.TabIndex = 14;
            this.btn_gerarSenha.Text = "Gerar senha";
            this.btn_gerarSenha.UseVisualStyleBackColor = true;
            this.btn_gerarSenha.Click += new System.EventHandler(this.btn_gerarSenha_Click);
            // 
            // panel_gerarSenha
            // 
            this.panel_gerarSenha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_gerarSenha.Controls.Add(this.btn_cancelarGerarSenha);
            this.panel_gerarSenha.Controls.Add(this.groupBox1);
            this.panel_gerarSenha.Location = new System.Drawing.Point(2, 70);
            this.panel_gerarSenha.Name = "panel_gerarSenha";
            this.panel_gerarSenha.Size = new System.Drawing.Size(387, 445);
            this.panel_gerarSenha.TabIndex = 15;
            this.panel_gerarSenha.Visible = false;
            // 
            // btn_cancelarGerarSenha
            // 
            this.btn_cancelarGerarSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarGerarSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cancelarGerarSenha.Location = new System.Drawing.Point(284, 404);
            this.btn_cancelarGerarSenha.Name = "btn_cancelarGerarSenha";
            this.btn_cancelarGerarSenha.Size = new System.Drawing.Size(96, 26);
            this.btn_cancelarGerarSenha.TabIndex = 7;
            this.btn_cancelarGerarSenha.Text = "Cancelar";
            this.btn_cancelarGerarSenha.UseVisualStyleBackColor = true;
            this.btn_cancelarGerarSenha.Click += new System.EventHandler(this.btn_cancelarGerarSenha_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_quantidade);
            this.groupBox1.Controls.Add(this.btn_gerar);
            this.groupBox1.Controls.Add(this.numeric_quantidade);
            this.groupBox1.Controls.Add(this.cb_caracteres);
            this.groupBox1.Controls.Add(this.cb_maiusculas);
            this.groupBox1.Controls.Add(this.cb_minusculas);
            this.groupBox1.Controls.Add(this.cb_numeros);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Location = new System.Drawing.Point(37, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 300);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerar nova senha";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidade.Location = new System.Drawing.Point(46, 39);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(222, 21);
            this.lbl_quantidade.TabIndex = 5;
            this.lbl_quantidade.Text = "Quantidade de caracteres";
            // 
            // btn_gerar
            // 
            this.btn_gerar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_gerar.Location = new System.Drawing.Point(83, 236);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(128, 48);
            this.btn_gerar.TabIndex = 6;
            this.btn_gerar.Text = "Gerar";
            this.btn_gerar.UseVisualStyleBackColor = true;
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // numeric_quantidade
            // 
            this.numeric_quantidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_quantidade.Location = new System.Drawing.Point(52, 66);
            this.numeric_quantidade.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numeric_quantidade.Name = "numeric_quantidade";
            this.numeric_quantidade.Size = new System.Drawing.Size(57, 27);
            this.numeric_quantidade.TabIndex = 0;
            // 
            // cb_caracteres
            // 
            this.cb_caracteres.AutoSize = true;
            this.cb_caracteres.Checked = true;
            this.cb_caracteres.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_caracteres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_caracteres.Location = new System.Drawing.Point(49, 174);
            this.cb_caracteres.Name = "cb_caracteres";
            this.cb_caracteres.Size = new System.Drawing.Size(238, 25);
            this.cb_caracteres.TabIndex = 3;
            this.cb_caracteres.Text = "Incluir caracteres especiais";
            this.cb_caracteres.UseVisualStyleBackColor = true;
            // 
            // cb_maiusculas
            // 
            this.cb_maiusculas.AutoSize = true;
            this.cb_maiusculas.Checked = true;
            this.cb_maiusculas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_maiusculas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_maiusculas.Location = new System.Drawing.Point(49, 110);
            this.cb_maiusculas.Name = "cb_maiusculas";
            this.cb_maiusculas.Size = new System.Drawing.Size(210, 25);
            this.cb_maiusculas.TabIndex = 1;
            this.cb_maiusculas.Text = "Incluir letras maiusculas";
            this.cb_maiusculas.UseVisualStyleBackColor = true;
            // 
            // cb_minusculas
            // 
            this.cb_minusculas.AutoSize = true;
            this.cb_minusculas.Checked = true;
            this.cb_minusculas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_minusculas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_minusculas.Location = new System.Drawing.Point(49, 143);
            this.cb_minusculas.Name = "cb_minusculas";
            this.cb_minusculas.Size = new System.Drawing.Size(209, 25);
            this.cb_minusculas.TabIndex = 2;
            this.cb_minusculas.Text = "Incluir letras minusculas";
            this.cb_minusculas.UseVisualStyleBackColor = true;
            // 
            // cb_numeros
            // 
            this.cb_numeros.AutoSize = true;
            this.cb_numeros.Checked = true;
            this.cb_numeros.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_numeros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_numeros.Location = new System.Drawing.Point(49, 205);
            this.cb_numeros.Name = "cb_numeros";
            this.cb_numeros.Size = new System.Drawing.Size(145, 25);
            this.cb_numeros.TabIndex = 4;
            this.cb_numeros.Text = "Incluir numeros";
            this.cb_numeros.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(63, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Max 220 caracteres";
            // 
            // senhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(401, 527);
            this.Controls.Add(this.panel_gerarSenha);
            this.Controls.Add(this.btn_gerarSenha);
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
            this.Controls.Add(this.label6);
            this.KeyPreview = true;
            this.Name = "senhas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.senhas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.senhas_KeyDown);
            this.panel_gerarSenha.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_quantidade)).EndInit();
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
        private System.Windows.Forms.Button btn_gerarSenha;
        private System.Windows.Forms.Panel panel_gerarSenha;
        private System.Windows.Forms.Button btn_gerar;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.NumericUpDown numeric_quantidade;
        private System.Windows.Forms.CheckBox cb_numeros;
        private System.Windows.Forms.CheckBox cb_caracteres;
        private System.Windows.Forms.CheckBox cb_minusculas;
        private System.Windows.Forms.CheckBox cb_maiusculas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancelarGerarSenha;
        private System.Windows.Forms.Label label6;
    }
}