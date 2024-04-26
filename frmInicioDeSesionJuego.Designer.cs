namespace pryAriasMatiasExequiel
{
    partial class frmInicioDeSesionJuego
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            cmdIngresar = new Button();
            cmdVolver = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(52, 15);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(234, 33);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Ingrese un nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 78);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(316, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // cmdIngresar
            // 
            cmdIngresar.Location = new Point(183, 122);
            cmdIngresar.Name = "cmdIngresar";
            cmdIngresar.Size = new Size(101, 23);
            cmdIngresar.TabIndex = 2;
            cmdIngresar.Text = "INGRESAR";
            cmdIngresar.UseVisualStyleBackColor = true;
            cmdIngresar.Click += cmdIngresar_Click;
            // 
            // cmdVolver
            // 
            cmdVolver.Location = new Point(76, 122);
            cmdVolver.Name = "cmdVolver";
            cmdVolver.Size = new Size(101, 23);
            cmdVolver.TabIndex = 3;
            cmdVolver.Text = "VOLVER";
            cmdVolver.UseVisualStyleBackColor = true;
            cmdVolver.Click += cmdVolver_Click;
            // 
            // frmInicioDeSesionJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 161);
            Controls.Add(cmdVolver);
            Controls.Add(cmdIngresar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            MaximizeBox = false;
            Name = "frmInicioDeSesionJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            Load += frmInicioDeSesionJuego_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Button cmdIngresar;
        private Button cmdVolver;
    }
}