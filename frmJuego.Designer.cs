namespace pryAriasMatiasExequiel
{
    partial class frmJuego
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJuego));
            temporizadorBala = new System.Windows.Forms.Timer(components);
            temporizadorEnemigo = new System.Windows.Forms.Timer(components);
            lblScore = new Label();
            lblPuntos = new Label();
            SuspendLayout();
            // 
            // temporizadorBala
            // 
            temporizadorBala.Tick += temporizadorBala_Tick;
            // 
            // temporizadorEnemigo
            // 
            temporizadorEnemigo.Tick += temporizadorEnemigo_Tick;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.ForeColor = Color.Yellow;
            lblScore.Location = new Point(12, 9);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(62, 17);
            lblScore.TabIndex = 0;
            lblScore.Text = "SCORE:";
            // 
            // lblPuntos
            // 
            lblPuntos.AutoSize = true;
            lblPuntos.BackColor = Color.Transparent;
            lblPuntos.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPuntos.ForeColor = Color.Yellow;
            lblPuntos.Location = new Point(69, 9);
            lblPuntos.Name = "lblPuntos";
            lblPuntos.Size = new Size(50, 17);
            lblPuntos.TabIndex = 1;
            lblPuntos.Text = "_______";
            // 
            // frmJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(565, 694);
            Controls.Add(lblPuntos);
            Controls.Add(lblScore);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Galaga GAME";
            Load += frmJuego_Load;
            KeyDown += frmJuego_KeyDown;
            KeyPress += frmJuego_KeyPress;
            KeyUp += frmJuego_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer temporizadorBala;
        private System.Windows.Forms.Timer temporizadorEnemigo;
        private Label lblScore;
        private Label lblPuntos;
    }
}