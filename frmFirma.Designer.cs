namespace pryAriasMatiasExequiel
{
    partial class frmFirma
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
            pbDibujo = new PictureBox();
            cmdGrabar = new Button();
            cmdBorrar = new Button();
            cmdVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pbDibujo).BeginInit();
            SuspendLayout();
            // 
            // pbDibujo
            // 
            pbDibujo.BackColor = Color.Silver;
            pbDibujo.Location = new Point(12, 12);
            pbDibujo.Name = "pbDibujo";
            pbDibujo.Size = new Size(531, 192);
            pbDibujo.TabIndex = 0;
            pbDibujo.TabStop = false;
            pbDibujo.Paint += pbDibujo_Paint;
            pbDibujo.MouseMove += pbDibujo_MouseMove;
            // 
            // cmdGrabar
            // 
            cmdGrabar.Location = new Point(12, 210);
            cmdGrabar.Name = "cmdGrabar";
            cmdGrabar.Size = new Size(75, 23);
            cmdGrabar.TabIndex = 1;
            cmdGrabar.Text = "Grabar";
            cmdGrabar.UseVisualStyleBackColor = true;
            cmdGrabar.Click += cmdGrabar_Click;
            // 
            // cmdBorrar
            // 
            cmdBorrar.Location = new Point(93, 210);
            cmdBorrar.Name = "cmdBorrar";
            cmdBorrar.Size = new Size(75, 23);
            cmdBorrar.TabIndex = 2;
            cmdBorrar.Text = "Borrar";
            cmdBorrar.UseVisualStyleBackColor = true;
            cmdBorrar.Click += cmdBorrar_Click;
            // 
            // cmdVolver
            // 
            cmdVolver.Location = new Point(468, 210);
            cmdVolver.Name = "cmdVolver";
            cmdVolver.Size = new Size(75, 23);
            cmdVolver.TabIndex = 3;
            cmdVolver.Text = "Volver";
            cmdVolver.UseVisualStyleBackColor = true;
            cmdVolver.Click += cmdVolver_Click;
            // 
            // frmFirma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 243);
            Controls.Add(cmdVolver);
            Controls.Add(cmdBorrar);
            Controls.Add(cmdGrabar);
            Controls.Add(pbDibujo);
            Name = "frmFirma";
            Text = "frmFirma";
            Load += frmFirma_Load;
            ((System.ComponentModel.ISupportInitialize)pbDibujo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbDibujo;
        private Button cmdGrabar;
        private Button cmdBorrar;
        private Button cmdVolver;
    }
}