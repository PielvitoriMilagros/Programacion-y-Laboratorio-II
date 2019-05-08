namespace GUI
{
    partial class FrmPC
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMemoria = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.nUDMemoria = new System.Windows.Forms.NumericUpDown();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.grbPlacaDeVideo = new System.Windows.Forms.GroupBox();
            this.rtxtSystemInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMemoria)).BeginInit();
            this.grbPlacaDeVideo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(30, 33);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(30, 62);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMemoria
            // 
            this.lblMemoria.AutoSize = true;
            this.lblMemoria.Location = new System.Drawing.Point(32, 99);
            this.lblMemoria.Name = "lblMemoria";
            this.lblMemoria.Size = new System.Drawing.Size(72, 13);
            this.lblMemoria.TabIndex = 2;
            this.lblMemoria.Text = "Memoria (MB)";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(169, 124);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 29);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(250, 124);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 29);
            this.btnSacar.TabIndex = 4;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(185, 202);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(156, 43);
            this.btnInfo.TabIndex = 5;
            this.btnInfo.Text = "System Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // nUDMemoria
            // 
            this.nUDMemoria.Location = new System.Drawing.Point(104, 97);
            this.nUDMemoria.Name = "nUDMemoria";
            this.nUDMemoria.Size = new System.Drawing.Size(120, 20);
            this.nUDMemoria.TabIndex = 6;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(104, 26);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(120, 20);
            this.txtMarca.TabIndex = 7;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(104, 62);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(120, 20);
            this.txtModelo.TabIndex = 8;
            // 
            // grbPlacaDeVideo
            // 
            this.grbPlacaDeVideo.Controls.Add(this.txtModelo);
            this.grbPlacaDeVideo.Controls.Add(this.txtMarca);
            this.grbPlacaDeVideo.Controls.Add(this.nUDMemoria);
            this.grbPlacaDeVideo.Controls.Add(this.btnSacar);
            this.grbPlacaDeVideo.Controls.Add(this.btnAgregar);
            this.grbPlacaDeVideo.Controls.Add(this.lblMemoria);
            this.grbPlacaDeVideo.Controls.Add(this.lblModelo);
            this.grbPlacaDeVideo.Controls.Add(this.lblMarca);
            this.grbPlacaDeVideo.Location = new System.Drawing.Point(16, 20);
            this.grbPlacaDeVideo.Name = "grbPlacaDeVideo";
            this.grbPlacaDeVideo.Size = new System.Drawing.Size(333, 160);
            this.grbPlacaDeVideo.TabIndex = 9;
            this.grbPlacaDeVideo.TabStop = false;
            this.grbPlacaDeVideo.Text = "Placa de Video";
            // 
            // rtxtSystemInfo
            // 
            this.rtxtSystemInfo.Location = new System.Drawing.Point(2, 251);
            this.rtxtSystemInfo.Name = "rtxtSystemInfo";
            this.rtxtSystemInfo.Size = new System.Drawing.Size(347, 150);
            this.rtxtSystemInfo.TabIndex = 10;
            this.rtxtSystemInfo.Text = "";
            this.rtxtSystemInfo.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 402);
            this.Controls.Add(this.rtxtSystemInfo);
            this.Controls.Add(this.grbPlacaDeVideo);
            this.Controls.Add(this.btnInfo);
            this.Name = "Form1";
            this.Text = "Pielvitori.Milagros.2C";
            ((System.ComponentModel.ISupportInitialize)(this.nUDMemoria)).EndInit();
            this.grbPlacaDeVideo.ResumeLayout(false);
            this.grbPlacaDeVideo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMemoria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.NumericUpDown nUDMemoria;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.GroupBox grbPlacaDeVideo;
        private System.Windows.Forms.RichTextBox rtxtSystemInfo;
    }
}

