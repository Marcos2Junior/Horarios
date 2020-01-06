﻿using MaterialSkin;
using System;
using System.IO;
using System.Windows.Forms;

namespace horario
{
    public partial class SenhaAdministrativa : MaterialSkin.Controls.MaterialForm
    {
        string caminho = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory)
            .Parent.Parent.FullName + "\\privado";
        public string senha;

        public bool verificacao;

        public SenhaAdministrativa()
        {
            InitializeComponent();
        }

        private void SenhaAdministrativa_Load(object sender, EventArgs e)
        {
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

            txt_senha.Focus();
        }

        private void btn_pronto_Click(object sender, EventArgs e)
        {
            block bl = new block();
            bl.DesBloquearPasta(caminho);

            string[] lines = File.ReadAllLines(caminho + "\\pass.txt");
            Criptografia cripto = new Criptografia(CryptProvider.RC2);
            cripto.Key = txt_senha.Text;

            try
            {
                if (cripto.Encrypt(txt_senha.Text) == lines[0])
                {
                    senha = txt_senha.Text;
                    verificacao = true;
                    bl.BloquearPasta(caminho);
                    this.Close();
                }
                else
                {
                    bl.BloquearPasta(caminho);
                    verificacao = false;
                    label2.Visible = true;
                }
            }
            catch (Exception)
            {
                bl.BloquearPasta(caminho);
                verificacao = false;
                label2.Visible = true;
            }
            
        }

        private void SenhaAdministrativa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_pronto.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
        }
    }
}
