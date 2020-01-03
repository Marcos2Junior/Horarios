using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace horario
{
    public partial class SenhaAdministrativa : MaterialSkin.Controls.MaterialForm
    {
        string caminho = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory)
            .Parent.Parent.FullName + "\\privado";


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

            if (txt_senha.Text == lines[0])
            {
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

        private void SenhaAdministrativa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_pronto.PerformClick();
            }
        }
    }
}
