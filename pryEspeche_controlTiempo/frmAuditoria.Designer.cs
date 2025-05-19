namespace pryEspeche_controlTiempo
{
    partial class frmAuditoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblCoordenadas = new System.Windows.Forms.Label();
            this.timerTiempoTrabajo = new System.Windows.Forms.Timer(this.components);
            this.panelTrabajo = new System.Windows.Forms.Panel();
            this.btnAuditar = new System.Windows.Forms.Button();
            this.lstCoordenadas = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTrabajo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 387);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiempo Trabajo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lugares:";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(164, 387);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(10, 13);
            this.lblTiempo.TabIndex = 3;
            this.lblTiempo.Text = "-";
            // 
            // lblCoordenadas
            // 
            this.lblCoordenadas.AutoSize = true;
            this.lblCoordenadas.Location = new System.Drawing.Point(138, 431);
            this.lblCoordenadas.Name = "lblCoordenadas";
            this.lblCoordenadas.Size = new System.Drawing.Size(10, 13);
            this.lblCoordenadas.TabIndex = 4;
            this.lblCoordenadas.Text = "-";
            // 
            // timerTiempoTrabajo
            // 
            this.timerTiempoTrabajo.Tick += new System.EventHandler(this.timerTiempoTrabajo_Tick);
            // 
            // panelTrabajo
            // 
            this.panelTrabajo.Controls.Add(this.lstCoordenadas);
            this.panelTrabajo.Location = new System.Drawing.Point(61, 48);
            this.panelTrabajo.Name = "panelTrabajo";
            this.panelTrabajo.Size = new System.Drawing.Size(635, 311);
            this.panelTrabajo.TabIndex = 5;
            this.panelTrabajo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTrabajo_Paint);
            this.panelTrabajo.MouseLeave += new System.EventHandler(this.panelTrabajo_MouseLeave);
            this.panelTrabajo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTrabajo_MouseMove);
            // 
            // btnAuditar
            // 
            this.btnAuditar.Location = new System.Drawing.Point(530, 387);
            this.btnAuditar.Name = "btnAuditar";
            this.btnAuditar.Size = new System.Drawing.Size(166, 38);
            this.btnAuditar.TabIndex = 6;
            this.btnAuditar.Text = "Auditar";
            this.btnAuditar.UseVisualStyleBackColor = true;
            this.btnAuditar.Click += new System.EventHandler(this.btnAuditar_Click);
            // 
            // lstCoordenadas
            // 
            this.lstCoordenadas.FormattingEnabled = true;
            this.lstCoordenadas.Location = new System.Drawing.Point(0, 0);
            this.lstCoordenadas.Name = "lstCoordenadas";
            this.lstCoordenadas.Size = new System.Drawing.Size(632, 303);
            this.lstCoordenadas.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.tToolStripMenuItem.Text = "Inicio Sesion";
            this.tToolStripMenuItem.Click += new System.EventHandler(this.tToolStripMenuItem_Click);
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 517);
            this.Controls.Add(this.btnAuditar);
            this.Controls.Add(this.panelTrabajo);
            this.Controls.Add(this.lblCoordenadas);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAuditoria";
            this.Load += new System.EventHandler(this.frmAuditoria_Load);
            this.panelTrabajo.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblCoordenadas;
        private System.Windows.Forms.Timer timerTiempoTrabajo;
        private System.Windows.Forms.Panel panelTrabajo;
        private System.Windows.Forms.Button btnAuditar;
        private System.Windows.Forms.ListBox lstCoordenadas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
    }
}