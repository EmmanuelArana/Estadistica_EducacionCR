namespace Estadistica_EducacionCR
{
    partial class Frm_EducacionCR
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EducacionCR));
            this.lblProcesandoHilo = new System.Windows.Forms.Label();
            this.txtHilo = new System.Windows.Forms.TextBox();
            this.dgvEdad = new System.Windows.Forms.DataGridView();
            this.dgvSexo = new System.Windows.Forms.DataGridView();
            this.dgvEscolaridad = new System.Windows.Forms.DataGridView();
            this.lblTituloEdad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscolaridad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProcesandoHilo
            // 
            this.lblProcesandoHilo.AutoSize = true;
            this.lblProcesandoHilo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcesandoHilo.Location = new System.Drawing.Point(30, 137);
            this.lblProcesandoHilo.Name = "lblProcesandoHilo";
            this.lblProcesandoHilo.Size = new System.Drawing.Size(113, 19);
            this.lblProcesandoHilo.TabIndex = 0;
            this.lblProcesandoHilo.Text = "Procesando Hilo:";
            // 
            // txtHilo
            // 
            this.txtHilo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHilo.Location = new System.Drawing.Point(149, 134);
            this.txtHilo.Name = "txtHilo";
            this.txtHilo.ReadOnly = true;
            this.txtHilo.Size = new System.Drawing.Size(129, 26);
            this.txtHilo.TabIndex = 1;
            this.txtHilo.TabStop = false;
            this.txtHilo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvEdad
            // 
            this.dgvEdad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdad.Location = new System.Drawing.Point(12, 194);
            this.dgvEdad.Name = "dgvEdad";
            this.dgvEdad.Size = new System.Drawing.Size(361, 398);
            this.dgvEdad.TabIndex = 2;
            // 
            // dgvSexo
            // 
            this.dgvSexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSexo.Location = new System.Drawing.Point(389, 194);
            this.dgvSexo.Name = "dgvSexo";
            this.dgvSexo.Size = new System.Drawing.Size(361, 398);
            this.dgvSexo.TabIndex = 3;
            // 
            // dgvEscolaridad
            // 
            this.dgvEscolaridad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEscolaridad.Location = new System.Drawing.Point(770, 194);
            this.dgvEscolaridad.Name = "dgvEscolaridad";
            this.dgvEscolaridad.Size = new System.Drawing.Size(361, 398);
            this.dgvEscolaridad.TabIndex = 4;
            // 
            // lblTituloEdad
            // 
            this.lblTituloEdad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEdad.Location = new System.Drawing.Point(90, 171);
            this.lblTituloEdad.Name = "lblTituloEdad";
            this.lblTituloEdad.Size = new System.Drawing.Size(210, 20);
            this.lblTituloEdad.TabIndex = 5;
            this.lblTituloEdad.Text = "Lista de Edades Según Sexo";
            this.lblTituloEdad.Click += new System.EventHandler(this.lblTituloEdad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Listado Según Sexo y Grupo Etario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(858, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Listado Según Escolaridad";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(902, 598);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(118, 23);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar Archivo";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1026, 598);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1138, 128);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(94, 267);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1010, 120);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.White;
            this.lblEstado.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(94, 267);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(1010, 38);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Procesando ";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEstado.Visible = false;
            // 
            // Frm_EducacionCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 624);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloEdad);
            this.Controls.Add(this.dgvEscolaridad);
            this.Controls.Add(this.dgvSexo);
            this.Controls.Add(this.dgvEdad);
            this.Controls.Add(this.txtHilo);
            this.Controls.Add(this.lblProcesandoHilo);
            this.KeyPreview = true;
            this.Name = "Frm_EducacionCR";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_EducacionCR_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscolaridad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcesandoHilo;
        private System.Windows.Forms.TextBox txtHilo;
        private System.Windows.Forms.DataGridView dgvEdad;
        private System.Windows.Forms.DataGridView dgvSexo;
        private System.Windows.Forms.DataGridView dgvEscolaridad;
        private System.Windows.Forms.Label lblTituloEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblEstado;
    }
}

