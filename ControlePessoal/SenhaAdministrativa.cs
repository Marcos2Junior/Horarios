using MaterialSkin;
using System;
using System.IO;
using System.Windows.Forms;

namespace ControlePessoal
{
    public partial class SenhaAdministrativa : MaterialSkin.Controls.MaterialForm
    {
        string caminho = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + "\\privado";
        public string senha;
        int contSenha = 0;
        string senhaNova = null;
        bool alterouSenha = false;

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

        private void AlteraSenha()
        {
            if (contSenha == 2)
            {
                txt_senha.Text = "";
                label1.Text = "Informe Senha Nova";
                contSenha = 3;
            }
            else if (contSenha == 3)
            {
                senhaNova = txt_senha.Text;
                txt_senha.Text = "";
                label1.Text = "Confirme Senha Nova";
                contSenha = 4;
            }
            else if (contSenha == 4)
            {
                if (senhaNova == txt_senha.Text)
                {
                    block bl = new block();

                    string caminhoPass = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + "\\privado";

                    bl.DesBloquearPasta(caminhoPass);

                    StreamWriter writer = new StreamWriter(caminhoPass + "\\pass.txt");
                    Criptografia cripto = new Criptografia(CryptProvider.RC2);
                    cripto.Key = txt_senha.Text;

                    writer.Write(cripto.Encrypt(txt_senha.Text));
                    writer.Close();

                    MessageBox.Show("Sua senha foi alterada com sucesso", "Senha alterada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    contSenha = 0;
                    label1.Text = "Insira sua senha";
                    senhaNova = null;
                    label4.Visible = true;
                    alterouSenha = true;
                }
                else
                {
                    senhaNova = null;
                    MessageBox.Show("Sua senha nova não confere com a senha de confirmação,"
                    + " Por favor repita o processo, só que dessa vez presta mais atenção no que voce está fazendo.", "Senhas não correspondem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    contSenha = 2;
                    AlteraSenha();
                }
            }
        }

        private void btn_pronto_Click(object sender, EventArgs e)
        {
            alterouSenha = false;
            block bl = new block();
            bl.DesBloquearPasta(caminho);

            string[] lines = File.ReadAllLines(caminho + "\\pass.txt");
            Criptografia cripto = new Criptografia(CryptProvider.RC2);
            cripto.Key = txt_senha.Text;

            AlteraSenha();

            try
            {
                if (contSenha <= 1)
                {
                    if (cripto.Encrypt(txt_senha.Text) == lines[0])
                    {
                        if (contSenha == 1)
                        {
                            contSenha = 2;
                            AlteraSenha();
                        }
                        else if (contSenha == 0)
                        {
                            senha = txt_senha.Text;
                            verificacao = true;
                            bl.BloquearPasta(caminho);
                            this.Close();
                        }
                    }
                    else
                    {
                        bl.BloquearPasta(caminho);
                        verificacao = false;

                        if(!alterouSenha) //Caso tenha alterado senha, não exibe label de erro
                            label2.Visible = true;

                        contSenha = 0;
                        label1.Text = "Insira sua senha";
                        label4.Visible = true;
                        txt_senha.Text = "";
                    }
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
            if (e.KeyCode == Keys.F1 && contSenha == 0)
            {
                MessageBox.Show("Alterando sua senha administrativa, esteja ciente de que todas suas senhas armazenadas não será mais possivel visualiza-las. Pois, a criptografia utilizada pelo sistema"
                    + " grava todas as informações com base na sua senha administrativa, sendo APENAS possivel descriptografar utilizando essa mesma senha.\n"
                    + "\nCaso voce decida alterar sua senha, e ainda exista senhas armazenadas, elas continuarão armazenadas, mas voce só irá conseguir visualiza-las caso altere sua senha novamente para a "
                    + "mesma senha em que ela foi criptografada inicialmente."
                    + "\n\nSugerimos que voce armazene manualmente em um outro local todas suas senhas para depois regrava-las no sistema.", "AVISO IMPORTANTE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label1.Text = "Para alterar a senha, Informe sua senha atual";
                contSenha = 1;
                label4.Visible = false;
            }
        }
    }
}
