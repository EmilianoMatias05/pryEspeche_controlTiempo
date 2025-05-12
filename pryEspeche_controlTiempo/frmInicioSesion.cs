using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEspeche_controlTiempo
{
    public partial class frmInicioSesion : Form
    {
        public bool timerActivo = false;
        private TimeSpan tiempoTranscurrido;
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 segundo
            timer1.Start();
            tiempoTranscurrido = TimeSpan.Zero;
            btnTiempo.BackColor = Color.Green;
        }

        private void btnTiempo_Click(object sender, EventArgs e)
        {
            if (!timerActivo)
            {
                
                timer1.Start();
                timerActivo = true;
                btnTiempo.Text = "Detener Timer";
                btnTiempo.BackColor = Color.Red;
            }
            else
            {
                timer1.Stop();
                timerActivo = false;
                btnTiempo.Text = "Iniciar Timer";
                btnTiempo.BackColor = Color.Green;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempoTranscurrido = tiempoTranscurrido.Add(TimeSpan.FromSeconds(1));
            tssTiempo.Text = "Tiempo en Sesión: " + tiempoTranscurrido.ToString(@"hh\:mm\:ss");
        }
    }
}
