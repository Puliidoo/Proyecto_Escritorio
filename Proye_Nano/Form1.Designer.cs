namespace Proye_Nano
{
    partial class Form1
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
            Boton_Inicio_Sesion = new Button();
            Logo = new PictureBox();
            Correo_Electronico = new TextBox();
            Contraseña = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            Titulo_Inicio = new Label();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Boton_Inicio_Sesion
            // 
            Boton_Inicio_Sesion.BackColor = Color.DeepSkyBlue;
            Boton_Inicio_Sesion.FlatStyle = FlatStyle.Flat;
            Boton_Inicio_Sesion.ForeColor = SystemColors.ButtonHighlight;
            Boton_Inicio_Sesion.Location = new Point(337, 322);
            Boton_Inicio_Sesion.Name = "Boton_Inicio_Sesion";
            Boton_Inicio_Sesion.Size = new Size(156, 41);
            Boton_Inicio_Sesion.TabIndex = 2;
            Boton_Inicio_Sesion.Text = "Iniciar Sesion";
            Boton_Inicio_Sesion.UseVisualStyleBackColor = false;
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.Nano_Logo_removebg_preview;
            Logo.Location = new Point(347, 12);
            Logo.Name = "Logo";
            Logo.Size = new Size(136, 121);
            Logo.TabIndex = 3;
            Logo.TabStop = false;
            Logo.Click += pictureBox1_Click;
            // 
            // Correo_Electronico
            // 
            Correo_Electronico.Location = new Point(300, 232);
            Correo_Electronico.Name = "Correo_Electronico";
            Correo_Electronico.Size = new Size(238, 23);
            Correo_Electronico.TabIndex = 5;
            // 
            // Contraseña
            // 
            Contraseña.Location = new Point(300, 272);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(238, 23);
            Contraseña.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = Properties.Resources.Captura_de_pantalla_2025_10_20_190627;
            pictureBox2.Location = new Point(514, 232);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Captura_de_pantalla_2025_10_20_190643;
            pictureBox3.Location = new Point(513, 272);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // Titulo_Inicio
            // 
            Titulo_Inicio.AutoSize = true;
            Titulo_Inicio.Font = new Font("Segoe UI", 30F);
            Titulo_Inicio.Location = new Point(300, 148);
            Titulo_Inicio.Name = "Titulo_Inicio";
            Titulo_Inicio.Size = new Size(252, 54);
            Titulo_Inicio.TabIndex = 11;
            Titulo_Inicio.Text = "Inicia Sesion ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Titulo_Inicio);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(Contraseña);
            Controls.Add(Correo_Electronico);
            Controls.Add(Logo);
            Controls.Add(Boton_Inicio_Sesion);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Boton_Inicio_Sesion;
        private PictureBox Logo;
        private TextBox Correo_Electronico;
        private TextBox Contraseña;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label Titulo_Inicio;
    }
}
