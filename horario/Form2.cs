using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace horario
{
    public partial class Form2 : MaterialSkin.Controls.MaterialForm
    {
        string caminho = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory)
           .Parent.Parent.FullName + "\\dados.txt";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!File.Exists(caminho))
            {
                FileStream x = File.Create(caminho);
                x.Close();
            }

            if (VerificaAcesso())
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.ShowDialog();
                this.Close();

                try
                {
                    Process[] proc = Process.GetProcessesByName("horario");
                    proc[0].Kill();
                }
                catch (Exception)
                { }

            }
        }

        private bool VerificaAcesso()
        {
            if (!File.Exists(caminho))
            {
                FileStream x = File.Create(caminho);
                x.Close();
            }

            string[] linhas = File.ReadAllLines(caminho);

            foreach (var line in linhas)
            {
                if (line.Contains("---"))
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (txt_senha.Text == txt_confsenha.Text)
            {
                MessageBox.Show("Guarde bem essa senha, voce sempre irá precisar dela. Caso voce esqueça, será necessário resetar todo o programa.");
                string caminho = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory)
                .Parent.Parent.FullName + "\\privado";

                if (!File.Exists(caminho + "\\pass.txt"))
                {
                    Directory.CreateDirectory(caminho);
                    FileStream x = File.Create(caminho + "\\pass.txt");
                    x.Close();
                }

                StreamWriter writer = new StreamWriter(caminho + "\\pass.txt");
                Criptografia cripto = new Criptografia(CryptProvider.RC2);
                cripto.Key = txt_senha.Text;

                writer.Write(cripto.Encrypt(txt_senha.Text));
                writer.Close();


                block bl = new block();
                bl.BloquearPasta(caminho);

                this.Hide();
                Form1 frm = new Form1();
                frm.ShowDialog();
            }

            else
            {
                MessageBox.Show("Senhas não conferem");
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    TimeSpan hora = TimeSpan.Parse(maskedTextBox1.Text);
                    StreamWriter gravarTXT = new StreamWriter(caminho);
                    gravarTXT.Write("---" + hora + textBox1.Text.PadRight(10, ' ') + textBox2.Text.PadRight(20, ' '));
                    gravarTXT.Close();
                    panel1.Visible = true;
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
