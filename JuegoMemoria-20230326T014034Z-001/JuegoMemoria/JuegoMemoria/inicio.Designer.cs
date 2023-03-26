
namespace JuegoMemoria
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.lbel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.Facil = new System.Windows.Forms.Button();
            this.Normal = new System.Windows.Forms.Button();
            this.Dificil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Broadway", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENCUENTRA LA PAREJA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbel1
            // 
            this.lbel1.AutoSize = true;
            this.lbel1.BackColor = System.Drawing.Color.Transparent;
            this.lbel1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbel1.Location = new System.Drawing.Point(135, 150);
            this.lbel1.Name = "lbel1";
            this.lbel1.Size = new System.Drawing.Size(127, 30);
            this.lbel1.TabIndex = 1;
            this.lbel1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(549, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "¡¡Escoge el nivel  y que empiece el juego!!";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(268, 152);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(404, 24);
            this.nombre.TabIndex = 5;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // Facil
            // 
            this.Facil.BackColor = System.Drawing.Color.Transparent;
            this.Facil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Facil.BackgroundImage")));
            this.Facil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Facil.FlatAppearance.BorderSize = 0;
            this.Facil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Facil.Location = new System.Drawing.Point(224, 271);
            this.Facil.Name = "Facil";
            this.Facil.Size = new System.Drawing.Size(86, 86);
            this.Facil.TabIndex = 9;
            this.Facil.UseVisualStyleBackColor = false;
            this.Facil.Click += new System.EventHandler(this.Facil_Click);
            // 
            // Normal
            // 
            this.Normal.BackColor = System.Drawing.Color.Transparent;
            this.Normal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Normal.BackgroundImage")));
            this.Normal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Normal.FlatAppearance.BorderSize = 0;
            this.Normal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Normal.Location = new System.Drawing.Point(362, 271);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(86, 86);
            this.Normal.TabIndex = 12;
            this.Normal.UseVisualStyleBackColor = false;
            this.Normal.Click += new System.EventHandler(this.Normal_Click);
            // 
            // Dificil
            // 
            this.Dificil.BackColor = System.Drawing.Color.Transparent;
            this.Dificil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Dificil.BackgroundImage")));
            this.Dificil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Dificil.FlatAppearance.BorderSize = 0;
            this.Dificil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dificil.Location = new System.Drawing.Point(505, 271);
            this.Dificil.Name = "Dificil";
            this.Dificil.Size = new System.Drawing.Size(86, 86);
            this.Dificil.TabIndex = 13;
            this.Dificil.UseVisualStyleBackColor = false;
            this.Dificil.Click += new System.EventHandler(this.Dificil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Facil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Normal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dificil";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dificil);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.Facil);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego de Memoria";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button Facil;
        private System.Windows.Forms.Button Normal;
        private System.Windows.Forms.Button Dificil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}