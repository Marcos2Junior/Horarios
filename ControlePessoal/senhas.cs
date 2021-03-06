﻿using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ControlePessoal
{
    public partial class senhas : MaterialSkin.Controls.MaterialForm
    {
        string caminho = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory)
          .Parent.Parent.FullName + "\\privado";
        block bl = new block();

        string pass;

        public senhas(string password)
        {
            InitializeComponent();
            pass = password;
        }

        private void senhas_Load(object sender, EventArgs e)
        {
            CarregaComboBox();

            // Criando um material theme manager e adicionando o formulário
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            // Definindo um esquema de Cor para formulário com tom Azul
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

            label6.ForeColor = SystemColors.AppWorkspace;
            label6.BackColor = SystemColors.Window;
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            SenhaAdministrativa frm = new SenhaAdministrativa();
            frm.ShowDialog();
            if (frm.verificacao)
            {
                if (!string.IsNullOrEmpty(txt_chave.Text) && (txt_confSenha.Text == txt_senha.Text) && !string.IsNullOrEmpty(txt_senha.Text))
                {
                    GravarSenha();
                    MessageBox.Show("Gravado com sucesso");
                    txt_chave.Text = "";
                    txt_confSenha.Text = "";
                    txt_senha.Text = "";
                    rtb_descricao.Text = "";
                    CarregaComboBox();
                }
                else
                    MessageBox.Show("Senhas não conferem ou são inválidas");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Tem certeza de que deseja excluir essa senha? ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                SenhaAdministrativa frmSenha = new SenhaAdministrativa();
                frmSenha.ShowDialog();
                if (frmSenha.verificacao)
                {
                    string senha = null;
                    string descricao = null;

                    senha = txt_senha.Text;
                    descricao = rtb_descricao.Text;

                    bl.DesBloquearPasta(caminho);
                    if (!File.Exists(caminho + "\\arquivos.txt"))
                    {
                        FileStream a = File.Create(caminho + "\\arquivos.txt");
                        a.Close();
                    }

                    string[] linhas = File.ReadAllLines(caminho + "\\arquivos.txt");
                    StreamWriter gravarTXT = new StreamWriter(caminho + "\\arquivos.txt");

                    foreach (var line in linhas)
                    {
                        if (line.Substring(0, 50) == txt_chave.Text.PadRight(50, ' '))
                        {
                            MessageBox.Show(txt_chave.Text + ", Excluido com sucesso");
                        }
                        else
                            gravarTXT.WriteLine(line);
                    }

                    gravarTXT.Close();

                    bl.DesBloquearPasta(caminho);

                    txt_chave.Text = "";
                    txt_confSenha.Text = "";
                    txt_senha.Text = "";
                    rtb_descricao.Text = "";
                    CarregaComboBox();
                }
            }
        }

        private void GravarSenha()
        {
            string senha = null;
            string descricao = null;
            Criptografia cripto = new Criptografia(CryptProvider.RC2);
            cripto.Key = pass;
            senha = cripto.Encrypt(txt_senha.Text);

            descricao = rtb_descricao.Text;

            bl.DesBloquearPasta(caminho);
            if (!File.Exists(caminho + "\\arquivos.txt"))
            {
                FileStream a = File.Create(caminho + "\\arquivos.txt");
                a.Close();
            }

            string[] linhas = File.ReadAllLines(caminho + "\\arquivos.txt");
            StreamWriter gravarTXT = new StreamWriter(caminho + "\\arquivos.txt");
            bool gravou = false;
            if (linhas.Length == 0)
            {
                gravarTXT.WriteLine(txt_chave.Text.PadRight(50, ' ') + senha.PadRight(70, ' ') + descricao.PadRight(220, ' '));
            }
            foreach (var line in linhas)
            {
                if (line.Substring(0, 50) == txt_chave.Text.PadRight(50, ' '))
                {
                    gravarTXT.WriteLine(txt_chave.Text.PadRight(50, ' ') + senha.PadRight(70, ' ') + descricao.PadRight(220, ' '));
                    gravou = true;
                }
                else
                    gravarTXT.WriteLine(line);
            }

            if (!gravou)
            {
                gravarTXT.WriteLine(txt_chave.Text.PadRight(50, ' ') + senha.PadRight(70, ' ') + descricao.PadRight(220, ' '));
            }

            gravarTXT.Close();

            bl.DesBloquearPasta(caminho);
        }

        private void VisualizaSenha(string chave)
        {
            bl.DesBloquearPasta(caminho);
            if (!File.Exists(caminho + "\\arquivos.txt"))
            {
                FileStream a = File.Create(caminho + "\\arquivos.txt");
                a.Close();
            }

            string[] linhas = File.ReadAllLines(caminho + "\\arquivos.txt");
            bl.BloquearPasta(caminho);
            foreach (var line in linhas)
            {
                if (line.Substring(0, 50) == chave.PadRight(50, ' '))
                {
                    Criptografia cripto = new Criptografia(CryptProvider.RC2);
                    cripto.Key = pass;

                    txt_chave.Text = line.Substring(0, 50).Trim();
                    txt_senha.Text = cripto.Decrypt(line.Substring(50, 70).Trim());
                    rtb_descricao.Text = line.Substring(120, 220).Trim();
                }
            }
        }

        //ao selecionar, antes de exibir a senha exibir um painel solicitando senha mestre para visualizar qualquer outra senha..
        private void cb_chaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisualizaSenha(cb_chaves.Text);
        }

        private void CarregaComboBox()
        {
            bl.DesBloquearPasta(caminho);
            if (!File.Exists(caminho + "\\arquivos.txt"))
            {
                FileStream a = File.Create(caminho + "\\arquivos.txt");
                a.Close();
            }
            string[] linhas = File.ReadAllLines(caminho + "\\arquivos.txt");

            bl.BloquearPasta(caminho);

            List<string> list = new List<string>();
            foreach (var line in linhas)
            {
                list.Add(line.Substring(0, 50).Trim());
            }

            cb_chaves.DataSource = list;

        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            if (txt_senha.PasswordChar == '*')
            {
                txt_senha.PasswordChar = '\0';
            }
            else
            {
                txt_senha.PasswordChar = '*';
            }
        }

        private void senhas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_chave.Text = "";
            txt_confSenha.Text = "";
            txt_senha.Text = "";
            rtb_descricao.Text = "";
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            NewPass pass = new NewPass();
            txt_senha.Text = pass.Gerar(int.Parse(numeric_quantidade.Value.ToString()), cb_caracteres.Checked, cb_maiusculas.Checked, cb_numeros.Checked, cb_minusculas.Checked);
            txt_confSenha.Text = txt_senha.Text;
            panel_gerarSenha.Visible = false;
        }

        private void btn_gerarSenha_Click(object sender, EventArgs e)
        {
            panel_gerarSenha.Visible = true;
        }

        private void btn_cancelarGerarSenha_Click(object sender, EventArgs e)
        {
            panel_gerarSenha.Visible = false;
        }

        private void rtb_descricao_TextChanged(object sender, EventArgs e)
        {
            if (rtb_descricao.TextLength == 0)
            {
                label6.Text = "Max 220 caracteres";
                label6.ForeColor = SystemColors.AppWorkspace;
            }
            else if (rtb_descricao.TextLength > 220)
            {
                label6.Text = rtb_descricao.TextLength + " Caracteres, Max 220.";
                label6.ForeColor = Color.Red;
            }
            else
            {
                label6.Text = rtb_descricao.TextLength + " Caracteres, Max 220.";
                label6.ForeColor = SystemColors.AppWorkspace;
            }
        }
    }
}
