
namespace JuegoMemoria
{
    partial class Normal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Normal));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelJuego = new System.Windows.Forms.Panel();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tiempo1 = new System.Windows.Forms.Label();
            this.nivel = new System.Windows.Forms.Label();
            this.saludo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 61;
            this.label1.Text = "SALIR";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(491, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 66);
            this.button1.TabIndex = 60;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelJuego
            // 
            this.PanelJuego.BackColor = System.Drawing.Color.Transparent;
            this.PanelJuego.Location = new System.Drawing.Point(19, 130);
            this.PanelJuego.Name = "PanelJuego";
            this.PanelJuego.Size = new System.Drawing.Size(552, 469);
            this.PanelJuego.TabIndex = 59;
            this.PanelJuego.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelJuego_Paint);
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.BackColor = System.Drawing.Color.Transparent;
            this.lblRecord.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(406, 48);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(0, 26);
            this.lblRecord.TabIndex = 58;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(447, 98);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(124, 26);
            this.lblTiempo.TabIndex = 57;
            this.lblTiempo.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 56;
            this.label2.Text = "Normal";
            // 
            // tiempo1
            // 
            this.tiempo1.AutoSize = true;
            this.tiempo1.BackColor = System.Drawing.Color.Transparent;
            this.tiempo1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo1.ForeColor = System.Drawing.Color.Black;
            this.tiempo1.Location = new System.Drawing.Point(292, 94);
            this.tiempo1.Name = "tiempo1";
            this.tiempo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tiempo1.Size = new System.Drawing.Size(134, 33);
            this.tiempo1.TabIndex = 55;
            this.tiempo1.Text = "Tiempo:";
            // 
            // nivel
            // 
            this.nivel.AutoSize = true;
            this.nivel.BackColor = System.Drawing.Color.Transparent;
            this.nivel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivel.ForeColor = System.Drawing.Color.Black;
            this.nivel.Location = new System.Drawing.Point(13, 94);
            this.nivel.Name = "nivel";
            this.nivel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nivel.Size = new System.Drawing.Size(101, 33);
            this.nivel.TabIndex = 54;
            this.nivel.Text = "Nivel:";
            // 
            // saludo
            // 
            this.saludo.AutoSize = true;
            this.saludo.BackColor = System.Drawing.Color.Transparent;
            this.saludo.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saludo.ForeColor = System.Drawing.Color.Black;
            this.saludo.Location = new System.Drawing.Point(13, 31);
            this.saludo.Name = "saludo";
            this.saludo.Size = new System.Drawing.Size(268, 31);
            this.saludo.TabIndex = 53;
            this.saludo.Text = "Hora de jugar,    ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Normal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(596, 641);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PanelJuego);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tiempo1);
            this.Controls.Add(this.nivel);
            this.Controls.Add(this.saludo);
            this.Name = "Normal";
            this.Text = "Juego de Memoria";
            this.Load += new System.EventHandler(this.Normal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PanelJuego;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tiempo1;
        private System.Windows.Forms.Label nivel;
        private System.Windows.Forms.Label saludo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}