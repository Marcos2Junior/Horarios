using MaterialSkin;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace horario
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        TimeSpan horaSaida;
        TimeSpan horario;
        TimeSpan almoco;
        TimeSpan horario1;
        TimeSpan horario2;
        TimeSpan horario3;
        TimeSpan horario4;
        TimeSpan adicional;
        bool diaEncerrado;
        string usuario;
        string cidade;
        string[] linhas;
        string caminho = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory)
            .Parent.Parent.FullName + "\\dados.txt";
        int contador = 10;
        WeatherInfo.RootObject result;
        bool inicioForm = false;

        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            RetornaDados();
            timer1.Start();

            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);

            PrevisaoTempo previsaoTempo = new PrevisaoTempo();
            result = previsaoTempo.getWeather(cidade);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GravaDados(false, cidade, usuario);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F1)
            {
                panel2.Visible = true;
                numericUpDown1.Value = DateTime.Now.Month;
                numericUpDown2.Value = DateTime.Now.Year;

            }
            else if (e.KeyCode == Keys.F2)
            {
                this.Hide();
                SenhaAdministrativa frmSenha = new SenhaAdministrativa();
                frmSenha.ShowDialog();
                if (frmSenha.verificacao)
                {
                    senhas frm = new senhas(frmSenha.senha);
                    frm.ShowDialog();
                }

            }
            else
            {
                Calculo();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (inicioForm == true)
                contador = contador - 4;
            else
                contador--;

            if (contador < -700)
                contador = 300;

            exibeText();
            label1.Text = "Horario Saida: " + horaSaida;
            label2.Text = "Voce fez " + almoco + " de almoço";
            label3.Text = "Adicional: " + adicional;
            Calculo();
        }

        private void exibeText()
        {
            if (inicioForm == false)
            {
                lbl_titulo.Location = new Point(0, 36);

                if (contador < -20)
                {
                    inicioForm = true;
                    contador = 0;
                }
            }
            else
            {
                lbl_titulo.Location = new Point(contador, 36);
            }

            string previsao = ", Previsão para hoje é " + result.results.description + ", Temperatura atual: " + result.results.temp.ToString() + "°,  Cidade de " + cidade;

            if (DateTime.Now > DateTime.Parse("11:59:00") && DateTime.Now < DateTime.Parse("18:00:00"))
            {
                lbl_titulo.Text = "Boa tarde " + usuario + previsao;
            }
            else if (DateTime.Now > DateTime.Parse("18:00:00"))
            {
                lbl_titulo.Text = "Boa noite " + usuario + previsao;
            }
            else
                lbl_titulo.Text = "Bom dia " + usuario + previsao;
        }

        private void Calculo()
        {
            try
            {
                horario1 = TimeSpan.Parse(mtb1.Text);
                horario2 = TimeSpan.Parse(mtb2.Text);
                horario3 = TimeSpan.Parse(mtb3.Text);
                horario4 = TimeSpan.Parse(mtb4.Text);
                almoco = TimeSpan.Parse("00:00");
                adicional = TimeSpan.Parse("00:00");

                if (mtb1.Text == "00:00")
                {
                    mtb1.SelectAll();
                    horaSaida = TimeSpan.Parse(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second) + horario;
                }
                else if (mtb2.Text == "00:00")
                {
                    mtb2.SelectAll();
                    horaSaida = horario + horario1;
                }
                else if (mtb2.Text != "00:00" && mtb3.Text == "00:00")
                {
                    mtb3.SelectAll();
                    almoco = TimeSpan.Parse((DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second)) - horario2;
                    horaSaida = (horario + almoco) + horario1;
                }
                else if (mtb3.Text != "00:00" && mtb4.Text == "00:00")
                {
                    mtb4.SelectAll();
                    almoco = horario3 - horario2;
                    horaSaida = (horario + almoco) + horario1;

                    adicional = TimeSpan.Parse(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second).Subtract(horaSaida);
                }

                else if (mtb4.Text != "00:00")
                {
                    almoco = horario3 - horario2;
                    horaSaida = (horario + almoco) + horario1;

                    adicional = horario4 - horaSaida;
                }
                else if (horaSaida < TimeSpan.Parse(DateTime.Now.ToShortTimeString()))
                {
                    adicional = TimeSpan.Parse(DateTime.Now.ToShortTimeString()).Subtract(horaSaida);
                }

                if (diaEncerrado)
                    timer1.Stop();
            }
            catch (Exception)
            {
            }
        }

        private void RetornaDados()
        {
            if (!File.Exists(caminho))
            {
                FileStream x = File.Create(caminho);
                x.Close();
            }

            linhas = File.ReadAllLines(caminho);
            diaEncerrado = false;
            mtb1.Text = "00:00";
            foreach (var line in linhas)
            {
                if (line.Contains("---"))
                {
                    horario = TimeSpan.Parse(line.Substring(3, 8));
                    usuario = line.Substring(11, 10).Trim();
                    cidade = line.Substring(21, 20).Trim();
                }
                else if (line.Substring(0, 10) == (dateTimePicker1.Value.ToShortDateString()))
                {
                    mtb1.Text = line.Substring(10, 8);
                    mtb2.Text = line.Substring(18, 8);
                    mtb3.Text = line.Substring(26, 8);
                    mtb4.Text = line.Substring(34, 8);
                    string simOuNao = line.Substring(42, 3);

                    if (simOuNao == "sim")
                    {
                        diaEncerrado = true;
                        label4.Text = "Dia finalizado";
                    }
                    else
                    {
                        diaEncerrado = false;
                        label4.Text = "";
                    }
                }
            }

            if (mtb1.Text == "00:00")
            {
                almoco = TimeSpan.Parse("00:00");
                mtb1.Text = "00:00";
                mtb2.Text = "00:00";
                mtb3.Text = "00:00";
                mtb4.Text = "00:00";
            }
        }

        private void GravaDados(bool encerraDia, string city, string user)
        {
            timer1.Start();
            linhas = File.ReadAllLines(caminho);
            StreamWriter gravarTXT = new StreamWriter(caminho);
            bool x = false;
            if (linhas.Length == 1)
            {
                gravarTXT.WriteLine("---" + horario + user + city);
                if (encerraDia)
                    gravarTXT.WriteLine(dateTimePicker1.Value.ToShortDateString() + horario1 + horario2 + horario3 + horario4 + "sim" + textBox1.Text.PadRight(50, ' '));
                else
                    gravarTXT.WriteLine(dateTimePicker1.Value.ToShortDateString() + horario1 + horario2 + horario3 + horario4 + "nao");
            }
            else
            {
                string valor = dateTimePicker1.Value.ToShortDateString() + horario1 + horario2 + horario3 + horario4;

                foreach (var line in linhas)
                {
                    if (!line.Contains("---"))
                    {
                        if (line.Substring(0, 10) == (dateTimePicker1.Value.ToShortDateString()))
                        {

                            if (encerraDia)
                            {
                                gravarTXT.WriteLine(valor + "sim" + textBox1.Text.PadRight(50, ' '));
                            }
                            else
                                gravarTXT.WriteLine(valor + "nao");

                            x = true;
                        }
                        else
                        {
                            gravarTXT.WriteLine(line);
                        }
                    }
                    else
                    {
                        gravarTXT.WriteLine("---" + horario + user.PadRight(10, ' ') + city.PadRight(20, ' '));
                    }
                }

                if (!x)
                {
                    if (encerraDia)
                    {
                        gravarTXT.WriteLine(valor + "sim" + textBox1.Text.PadRight(50, ' '));
                    }
                    else
                        gravarTXT.WriteLine(valor + "nao");
                }
            }

            gravarTXT.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Start();
            RetornaDados();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir todos os seus dados?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
            }
            else
            {
                File.Delete(caminho);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void Relatorio(DateTime dtReferente)
        {
            string relatorio = null;
            TimeSpan HorasTrabalhadas = TimeSpan.Zero;
            TimeSpan Adicional = TimeSpan.Zero;

            relatorio = "Registro de horas de " + usuario + ", referente a " + dtReferente.Month + "/" + dtReferente.Year;

            linhas = File.ReadAllLines(caminho);
            diaEncerrado = false;
            foreach (var line in linhas)
            {
                if (line.Contains("---"))
                {
                    horario = TimeSpan.Parse(line.Substring(3, 8));
                    usuario = line.Substring(11, line.Length - 11);
                }
                else if (DateTime.Parse(line.Substring(0, 10)).Month == dtReferente.Month && DateTime.Parse(line.Substring(0, 10)).Year == dtReferente.Year)
                {
                    TimeSpan h1 = TimeSpan.Parse(line.Substring(10, 8));
                    TimeSpan h2 = TimeSpan.Parse(line.Substring(18, 8));
                    TimeSpan h3 = TimeSpan.Parse(line.Substring(26, 8));
                    TimeSpan h4 = TimeSpan.Parse(line.Substring(34, 8));
                    TimeSpan totalDia = h2.Subtract(h1) + h4.Subtract(h3);
                    TimeSpan adicionalDia = totalDia.Subtract(horario);

                    HorasTrabalhadas += totalDia;
                    Adicional += adicionalDia;

                    relatorio += "\n\nData: " + line.Substring(0, 10)
                        + "\nEntrada: " + line.Substring(10, 8) + ", Almoço: " + line.Substring(18, 8) + ", Retorno: " + line.Substring(26, 8) + ", Saída: " + line.Substring(34, 8)
                        + "\nHoras trabalhadas: " + totalDia + ", Adicional: " + adicionalDia;

                    string simOuNao = line.Substring(42, 3);

                    if (simOuNao == "sim")
                        relatorio += " Obs: Dia encerrado antes do previsto -- Comentário: " + line.Substring(45, 50);
                }
            }

            relatorio += "\n\nTotal de horas trabalhado: " + HorasTrabalhadas
                + "\nAdicional: " + Adicional;

            string data = dtReferente.Month + "-" + dtReferente.Year;

            string caminhoRelatorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RelatorioHorarios";

            Directory.CreateDirectory(caminhoRelatorio);

            FileStream x = File.Create(caminhoRelatorio + "\\Horarios" + data + ".pdf");
            x.Close();


            gerapdf gerarpdf = new gerapdf();
            gerarpdf.Gerar(caminhoRelatorio + "\\Horarios" + data + ".pdf", relatorio);

            Process process = new Process();
            process.StartInfo.FileName = caminhoRelatorio;
            process.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            GravaDados(true, cidade, usuario);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Relatorio(DateTime.Parse("01/" + numericUpDown1.Value + "/" + numericUpDown2.Value));

            panel2.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Criando um material theme manager e adicionando o formulário
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Definindo um esquema de Cor para formulário com tom Azul
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.BLACK
            );
        }

        private void btn_gravar_cidade_Click(object sender, EventArgs e)
        {
            GravaDados(false, txt_cidade.Text, txt_nome.Text);
            panel_cidade.Visible = false;

            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void btn_cancel_cidade_Click(object sender, EventArgs e)
        {
            panel_cidade.Visible = false;
        }

        private void btn_alterar_dados_Click(object sender, EventArgs e)
        {
            if (panel_cidade.Visible == true)
                panel_cidade.Visible = false;
            else
            {
                panel_cidade.Visible = true;
                txt_cidade.Text = cidade;
                txt_nome.Text = usuario;
            }
        }
    }
}