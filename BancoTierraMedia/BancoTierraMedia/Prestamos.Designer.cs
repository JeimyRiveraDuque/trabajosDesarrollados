
namespace BancoTierraMedia
{
    partial class Prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.saludo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bntConfirmarSolicitud = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.raza = new System.Windows.Forms.ComboBox();
            this.Datospersonales = new System.Windows.Forms.Panel();
            this.lugares = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Detallesprestamo = new System.Windows.Forms.Panel();
            this.montoprestamo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cuotas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Datospersonales.SuspendLayout();
            this.Detallesprestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // saludo
            // 
            this.saludo.AutoSize = true;
            this.saludo.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saludo.ForeColor = System.Drawing.Color.Maroon;
            this.saludo.Location = new System.Drawing.Point(46, 33);
            this.saludo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.saludo.Name = "saludo";
            this.saludo.Size = new System.Drawing.Size(226, 46);
            this.saludo.TabIndex = 0;
            this.saludo.Text = "Bienvenido,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(50, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datos personales:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(474, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalles del prestamo:";
            // 
            // bntConfirmarSolicitud
            // 
            this.bntConfirmarSolicitud.BackColor = System.Drawing.Color.Maroon;
            this.bntConfirmarSolicitud.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntConfirmarSolicitud.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.errorProvider1.SetIconAlignment(this.bntConfirmarSolicitud, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.bntConfirmarSolicitud.Location = new System.Drawing.Point(54, 362);
            this.bntConfirmarSolicitud.Name = "bntConfirmarSolicitud";
            this.bntConfirmarSolicitud.Size = new System.Drawing.Size(236, 70);
            this.bntConfirmarSolicitud.TabIndex = 5;
            this.bntConfirmarSolicitud.Text = "ConfirmarSolicitud";
            this.bntConfirmarSolicitud.UseVisualStyleBackColor = false;
            this.bntConfirmarSolicitud.Click += new System.EventHandler(this.bntConfirmarSolicitud_Click);
            // 
            // volver
            // 
            this.volver.BackColor = System.Drawing.Color.Maroon;
            this.volver.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.volver.Location = new System.Drawing.Point(749, 476);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(110, 41);
            this.volver.TabIndex = 6;
            this.volver.Text = "VOLVER";
            this.volver.UseVisualStyleBackColor = false;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(15, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Raza:";
            // 
            // raza
            // 
            this.raza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.raza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raza.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raza.FormattingEnabled = true;
            this.raza.Location = new System.Drawing.Point(83, 28);
            this.raza.Name = "raza";
            this.raza.Size = new System.Drawing.Size(262, 29);
            this.raza.TabIndex = 3;
            // 
            // Datospersonales
            // 
            this.Datospersonales.BackColor = System.Drawing.Color.DarkOrange;
            this.Datospersonales.Controls.Add(this.lugares);
            this.Datospersonales.Controls.Add(this.label6);
            this.Datospersonales.Controls.Add(this.raza);
            this.Datospersonales.Controls.Add(this.label5);
            this.Datospersonales.Location = new System.Drawing.Point(54, 164);
            this.Datospersonales.Name = "Datospersonales";
            this.Datospersonales.Size = new System.Drawing.Size(360, 159);
            this.Datospersonales.TabIndex = 7;
            // 
            // lugares
            // 
            this.lugares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lugares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lugares.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lugares.FormattingEnabled = true;
            this.lugares.Location = new System.Drawing.Point(185, 85);
            this.lugares.Name = "lugares";
            this.lugares.Size = new System.Drawing.Size(160, 29);
            this.lugares.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(15, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Lugar de origen:";
            // 
            // Detallesprestamo
            // 
            this.Detallesprestamo.BackColor = System.Drawing.Color.DarkOrange;
            this.Detallesprestamo.Controls.Add(this.montoprestamo);
            this.Detallesprestamo.Controls.Add(this.label7);
            this.Detallesprestamo.Controls.Add(this.cuotas);
            this.Detallesprestamo.Controls.Add(this.label4);
            this.Detallesprestamo.Location = new System.Drawing.Point(478, 164);
            this.Detallesprestamo.Name = "Detallesprestamo";
            this.Detallesprestamo.Size = new System.Drawing.Size(381, 159);
            this.Detallesprestamo.TabIndex = 8;
            // 
            // montoprestamo
            // 
            this.montoprestamo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoprestamo.Location = new System.Drawing.Point(222, 23);
            this.montoprestamo.Name = "montoprestamo";
            this.montoprestamo.Size = new System.Drawing.Size(145, 28);
            this.montoprestamo.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(13, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "cuotas:";
            // 
            // cuotas
            // 
            this.cuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuotas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuotas.FormattingEnabled = true;
            this.cuotas.Location = new System.Drawing.Point(98, 92);
            this.cuotas.Name = "cuotas";
            this.cuotas.Size = new System.Drawing.Size(274, 29);
            this.cuotas.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(13, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Monto de prestamo:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(919, 527);
            this.Controls.Add(this.Detallesprestamo);
            this.Controls.Add(this.Datospersonales);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.bntConfirmarSolicitud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saludo);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.Datospersonales.ResumeLayout(false);
            this.Datospersonales.PerformLayout();
            this.Detallesprestamo.ResumeLayout(false);
            this.Detallesprestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saludo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntConfirmarSolicitud;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox raza;
        private System.Windows.Forms.Panel Datospersonales;
        private System.Windows.Forms.ComboBox lugares;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel Detallesprestamo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cuotas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox montoprestamo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}