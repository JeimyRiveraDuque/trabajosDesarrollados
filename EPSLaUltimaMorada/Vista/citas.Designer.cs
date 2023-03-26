
namespace EPSLaUltimaMorada
{
    partial class citas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(citas));
            this.Cbmedico = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtconsultorio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.hora = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txthora = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cbmedico
            // 
            this.Cbmedico.FormattingEnabled = true;
            this.Cbmedico.Location = new System.Drawing.Point(207, 109);
            this.Cbmedico.Name = "Cbmedico";
            this.Cbmedico.Size = new System.Drawing.Size(257, 21);
            this.Cbmedico.TabIndex = 59;
            this.Cbmedico.SelectedIndexChanged += new System.EventHandler(this.Cbmedico_SelectedIndexChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(208, 143);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(256, 20);
            this.txtnombre.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Nombre y Apellido:";
            // 
            // txtconsultorio
            // 
            this.txtconsultorio.Location = new System.Drawing.Point(207, 243);
            this.txtconsultorio.Name = "txtconsultorio";
            this.txtconsultorio.Size = new System.Drawing.Size(257, 20);
            this.txtconsultorio.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Consultorio:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button3.Location = new System.Drawing.Point(208, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 27);
            this.button3.TabIndex = 51;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btncrear
            // 
            this.btncrear.BackColor = System.Drawing.Color.White;
            this.btncrear.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrear.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btncrear.Location = new System.Drawing.Point(11, 317);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(104, 27);
            this.btncrear.TabIndex = 50;
            this.btncrear.Text = "Agendar Cita";
            this.btncrear.UseVisualStyleBackColor = false;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.Location = new System.Drawing.Point(11, 206);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(49, 20);
            this.hora.TabIndex = 49;
            this.hora.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "NombreMedico:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 38);
            this.label1.TabIndex = 47;
            this.label1.Text = "CITA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EPSLaUltimaMorada.Properties.Resources.undraw_blogging_vpvv;
            this.pictureBox1.Location = new System.Drawing.Point(496, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 160);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(207, 278);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(257, 20);
            this.txtfecha.TabIndex = 61;
            this.txtfecha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(7, 276);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(57, 20);
            this.fecha.TabIndex = 60;
            this.fecha.Text = "Fecha:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 188);
            this.dataGridView1.TabIndex = 62;
            // 
            // txthora
            // 
            this.txthora.Location = new System.Drawing.Point(208, 206);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(257, 20);
            this.txthora.TabIndex = 63;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(207, 70);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(257, 20);
            this.txtcedula.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Cedula:";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(208, 174);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(257, 20);
            this.txtestado.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "Beneficiario / Afiliado";
            // 
            // citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(203)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(713, 550);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txthora);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.Cbmedico);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtconsultorio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "citas";
            this.Text = "EPS LA ULTIMA MORADA";
            this.Load += new System.EventHandler(this.citas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbmedico;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtconsultorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txthora;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Label label6;
    }
}