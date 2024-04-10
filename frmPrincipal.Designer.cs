namespace pryAriasMatiasExequiel
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmdFirma = new Button();
            cmdJuego = new Button();
            cmdSalir = new Button();
            SuspendLayout();
            // 
            // cmdFirma
            // 
            cmdFirma.Location = new Point(12, 12);
            cmdFirma.Name = "cmdFirma";
            cmdFirma.Size = new Size(175, 64);
            cmdFirma.TabIndex = 0;
            cmdFirma.Text = "Firma";
            cmdFirma.UseVisualStyleBackColor = true;
            cmdFirma.Click += cmdFirma_Click;
            // 
            // cmdJuego
            // 
            cmdJuego.Location = new Point(12, 82);
            cmdJuego.Name = "cmdJuego";
            cmdJuego.Size = new Size(175, 64);
            cmdJuego.TabIndex = 1;
            cmdJuego.Text = "Juego";
            cmdJuego.UseVisualStyleBackColor = true;
            cmdJuego.Click += cmdJuego_Click;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(62, 161);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(75, 23);
            cmdSalir.TabIndex = 2;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(202, 199);
            Controls.Add(cmdSalir);
            Controls.Add(cmdJuego);
            Controls.Add(cmdFirma);
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button cmdFirma;
        private Button cmdJuego;
        private Button cmdSalir;
    }
}