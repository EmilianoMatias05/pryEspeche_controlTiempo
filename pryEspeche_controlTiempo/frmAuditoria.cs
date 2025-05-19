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

namespace pryEspeche_controlTiempo
{
    public partial class frmAuditoria : Form
    {
        StreamWriter streamWriter;
        public frmAuditoria()
        {
            InitializeComponent();
        }
        int vTiempoTrabajo = 0;

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            streamWriter = new StreamWriter("zonaCalor.txt");
        }

        private void panelTrabajo_MouseMove(object sender, MouseEventArgs e)
        {
            timerTiempoTrabajo.Enabled = true;
            lblCoordenadas.Text = e.Location.ToString();
            streamWriter.WriteLine(lblCoordenadas.Text);
        }

        private void panelTrabajo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerTiempoTrabajo_Tick(object sender, EventArgs e)
        {
            vTiempoTrabajo++; 
            lblTiempo.Text =  vTiempoTrabajo.ToString();
        }

        private void panelTrabajo_MouseLeave(object sender, EventArgs e)
        {
            timerTiempoTrabajo.Enabled = false;
        }

        private void btnAuditar_Click(object sender, EventArgs e)
        {
            lstCoordenadas.Visible = true;
            OpenFileDialog ofdArchivoCoordenadas = new OpenFileDialog();
            if (ofdArchivoCoordenadas.ShowDialog() == DialogResult.OK)
            {
                StreamReader srAuditar = new StreamReader(ofdArchivoCoordenadas.FileName);
                while (!srAuditar.EndOfStream)
                {
                    lstCoordenadas.Items.Add(srAuditar.ReadLine());
                }
            } 

            
            
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicioSesion frmInicioSesion = new frmInicioSesion();
            frmInicioSesion.Show();
            this.Hide();
        }
    }
}
