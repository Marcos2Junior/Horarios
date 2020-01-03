using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Windows.Forms;

namespace horario
{
    public partial class Lembrete : Form
    {
        int timer_1 = 0;
        int timer_2 = 0;

        //a ideia é apenas o administrador ter opção de alterar nivel emergencia.
        //caso emergencia = true, a cada 15 seg dar um bip e a tela não irá fechar sozinha.
        //Pode ser também que mude a label para emergência ou algo assim
        //essa função ignora caso o usuario tenha marcado para não exibir novamente
        bool emergencia = false;
        //instal AudioSwitcher.AudioApi.CoreAudio
        CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
        bool configMute;
        double configVolu;

        public Lembrete()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void Lembrete_Load(object sender, EventArgs e)
        {

        }
    }
}
