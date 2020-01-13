using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ControlePessoal
{
    public partial class Form2 : MaterialSkin.Controls.MaterialForm
    {
        string caminho = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory)
           .Parent.Parent.FullName + "\\dados.txt";
        string caminhoPrivado = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory)
                   .Parent.Parent.FullName + "\\privado";
        block b = new block();

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

            if (!GravaDados())
            {
                MessageBox.Show("Não foi possivel verificar seus dados, favor verificar sua conexão", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

            if (VerificaAcesso())
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.ShowDialog();
                this.Close();

                try
                {
                    Process[] proc = Process.GetProcessesByName("Controle Pessoal");
                    proc[0].Kill();
                }
                catch (Exception)
                {
                }
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
                MessageBox.Show("Guarde bem essa senha, não será possivel lembra-la caso voce esqueça.");
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

        /// <summary>
        /// Grava IP maquina e horario de acesso, criptografando com o IP da maquina
        /// </summary>
        /// <returns></returns>
        private bool GravaDados()
        {
            try
            {
                string nome = Dns.GetHostName();
                IPAddress[] ip = Dns.GetHostAddresses(nome);

                b.DesBloquearPasta(caminhoPrivado);
                FileInfo file = new FileInfo(caminhoPrivado + "\\ip.txt");

                if (!file.Exists)
                    file.Create().Close();

                Criptografia cripto = new Criptografia(CryptProvider.RC2);
                cripto.Key = ip[1].ToString();

                string[] linhas = File.ReadAllLines(caminhoPrivado + "\\ip.txt");

                StreamWriter gravarTXT = new StreamWriter(caminhoPrivado + "\\ip.txt");
                bool gravou = false;
                if (linhas.Length == 0)
                {
                    gravarTXT.WriteLine(cripto.Encrypt(nome + ";" + ip[1].ToString() + ";" + DateTime.Now));

                    gravou = true;
                }
                foreach (var line in linhas)
                {
                    string lineDescripto = cripto.Decrypt(line);

                    if (lineDescripto.Contains(ip[1].ToString()))
                    {
                        gravarTXT.WriteLine(cripto.Encrypt(nome + ";" + ip[1].ToString() + ";" + DateTime.Now));
                        gravou = true;
                    }
                    else
                        gravarTXT.WriteLine(line);
                }

                if (!gravou)
                {
                    gravarTXT.WriteLine(cripto.Encrypt(nome + ";" + ip[1].ToString() + ";" + DateTime.Now));
                }

                gravarTXT.Close();

                b.BloquearPasta(caminhoPrivado);
                return true;
            }
            catch (Exception)
            {
                b.BloquearPasta(caminhoPrivado);
                return false;
            }
        }
    }
}
