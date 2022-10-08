namespace acceso_a_hardware_y_SO
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.plGeneral = new System.Windows.Forms.Panel();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdInformacion = new System.Windows.Forms.Button();
            this.cmdBalance = new System.Windows.Forms.Button();
            this.cmdRegistro = new System.Windows.Forms.Button();
            this.cmdProcesos = new System.Windows.Forms.Button();
            this.cmdGeneral = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.rtbInformacion = new System.Windows.Forms.RichTextBox();
            this.plFinalizar = new System.Windows.Forms.Panel();
            this.cmdFinalizar = new System.Windows.Forms.Button();
            this.N = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwInformacion = new System.Windows.Forms.ListView();
            this.plGeneral.SuspendLayout();
            this.plFinalizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // plGeneral
            // 
            this.plGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.plGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plGeneral.Controls.Add(this.cmdSalir);
            this.plGeneral.Controls.Add(this.cmdInformacion);
            this.plGeneral.Controls.Add(this.cmdBalance);
            this.plGeneral.Controls.Add(this.cmdRegistro);
            this.plGeneral.Controls.Add(this.cmdProcesos);
            this.plGeneral.Controls.Add(this.cmdGeneral);
            this.plGeneral.Location = new System.Drawing.Point(12, 25);
            this.plGeneral.Name = "plGeneral";
            this.plGeneral.Size = new System.Drawing.Size(147, 237);
            this.plGeneral.TabIndex = 2;
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmdSalir.FlatAppearance.BorderSize = 0;
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.ForeColor = System.Drawing.Color.White;
            this.cmdSalir.Location = new System.Drawing.Point(3, 191);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(139, 29);
            this.cmdSalir.TabIndex = 5;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdInformacion
            // 
            this.cmdInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmdInformacion.FlatAppearance.BorderSize = 0;
            this.cmdInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInformacion.ForeColor = System.Drawing.Color.White;
            this.cmdInformacion.Location = new System.Drawing.Point(3, 156);
            this.cmdInformacion.Name = "cmdInformacion";
            this.cmdInformacion.Size = new System.Drawing.Size(139, 29);
            this.cmdInformacion.TabIndex = 4;
            this.cmdInformacion.Text = "Informacion";
            this.cmdInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdInformacion.UseVisualStyleBackColor = false;
            this.cmdInformacion.Click += new System.EventHandler(this.cmdInformacion_Click);
            // 
            // cmdBalance
            // 
            this.cmdBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmdBalance.FlatAppearance.BorderSize = 0;
            this.cmdBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBalance.ForeColor = System.Drawing.Color.White;
            this.cmdBalance.Location = new System.Drawing.Point(3, 51);
            this.cmdBalance.Name = "cmdBalance";
            this.cmdBalance.Size = new System.Drawing.Size(139, 29);
            this.cmdBalance.TabIndex = 1;
            this.cmdBalance.Text = "Balance del sistema";
            this.cmdBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdBalance.UseVisualStyleBackColor = false;
            this.cmdBalance.Click += new System.EventHandler(this.cmdBalance_Click);
            // 
            // cmdRegistro
            // 
            this.cmdRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmdRegistro.FlatAppearance.BorderSize = 0;
            this.cmdRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistro.ForeColor = System.Drawing.Color.White;
            this.cmdRegistro.Location = new System.Drawing.Point(3, 86);
            this.cmdRegistro.Name = "cmdRegistro";
            this.cmdRegistro.Size = new System.Drawing.Size(139, 29);
            this.cmdRegistro.TabIndex = 2;
            this.cmdRegistro.Text = "Registro del sistema";
            this.cmdRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRegistro.UseVisualStyleBackColor = false;
            this.cmdRegistro.Click += new System.EventHandler(this.cmdRegistro_Click);
            // 
            // cmdProcesos
            // 
            this.cmdProcesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmdProcesos.FlatAppearance.BorderSize = 0;
            this.cmdProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProcesos.ForeColor = System.Drawing.Color.White;
            this.cmdProcesos.Location = new System.Drawing.Point(3, 121);
            this.cmdProcesos.Name = "cmdProcesos";
            this.cmdProcesos.Size = new System.Drawing.Size(139, 29);
            this.cmdProcesos.TabIndex = 3;
            this.cmdProcesos.Text = "Procesos activos";
            this.cmdProcesos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdProcesos.UseVisualStyleBackColor = false;
            this.cmdProcesos.Click += new System.EventHandler(this.cmdProcesos_Click);
            // 
            // cmdGeneral
            // 
            this.cmdGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmdGeneral.FlatAppearance.BorderSize = 0;
            this.cmdGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGeneral.ForeColor = System.Drawing.Color.White;
            this.cmdGeneral.Location = new System.Drawing.Point(3, 16);
            this.cmdGeneral.Name = "cmdGeneral";
            this.cmdGeneral.Size = new System.Drawing.Size(139, 29);
            this.cmdGeneral.TabIndex = 0;
            this.cmdGeneral.Text = "General";
            this.cmdGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGeneral.UseVisualStyleBackColor = false;
            this.cmdGeneral.Click += new System.EventHandler(this.cmdGeneral_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(9, 435);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(33, 15);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "v1.2";
            // 
            // rtbInformacion
            // 
            this.rtbInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.rtbInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInformacion.ForeColor = System.Drawing.Color.White;
            this.rtbInformacion.Location = new System.Drawing.Point(165, 25);
            this.rtbInformacion.Name = "rtbInformacion";
            this.rtbInformacion.ReadOnly = true;
            this.rtbInformacion.ShortcutsEnabled = false;
            this.rtbInformacion.Size = new System.Drawing.Size(623, 408);
            this.rtbInformacion.TabIndex = 9;
            this.rtbInformacion.TabStop = false;
            this.rtbInformacion.Text = "";
            // 
            // plFinalizar
            // 
            this.plFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.plFinalizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plFinalizar.Controls.Add(this.cmdFinalizar);
            this.plFinalizar.Location = new System.Drawing.Point(12, 268);
            this.plFinalizar.Name = "plFinalizar";
            this.plFinalizar.Size = new System.Drawing.Size(147, 39);
            this.plFinalizar.TabIndex = 11;
            this.plFinalizar.Visible = false;
            // 
            // cmdFinalizar
            // 
            this.cmdFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmdFinalizar.FlatAppearance.BorderSize = 0;
            this.cmdFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFinalizar.ForeColor = System.Drawing.Color.White;
            this.cmdFinalizar.Location = new System.Drawing.Point(3, 3);
            this.cmdFinalizar.Name = "cmdFinalizar";
            this.cmdFinalizar.Size = new System.Drawing.Size(139, 29);
            this.cmdFinalizar.TabIndex = 0;
            this.cmdFinalizar.Text = "Finalizar";
            this.cmdFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdFinalizar.UseVisualStyleBackColor = false;
            this.cmdFinalizar.Click += new System.EventHandler(this.cmdFinalizar_Click);
            // 
            // N
            // 
            this.N.Text = "N";
            this.N.Width = 40;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 250;
            // 
            // MB
            // 
            this.MB.Text = "MB";
            this.MB.Width = 40;
            // 
            // lvwInformacion
            // 
            this.lvwInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lvwInformacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.N,
            this.Nombre,
            this.MB});
            this.lvwInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwInformacion.ForeColor = System.Drawing.Color.White;
            this.lvwInformacion.FullRowSelect = true;
            this.lvwInformacion.HideSelection = false;
            this.lvwInformacion.Location = new System.Drawing.Point(165, 25);
            this.lvwInformacion.Name = "lvwInformacion";
            this.lvwInformacion.Size = new System.Drawing.Size(623, 408);
            this.lvwInformacion.TabIndex = 10;
            this.lvwInformacion.UseCompatibleStateImageBehavior = false;
            this.lvwInformacion.View = System.Windows.Forms.View.Details;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.plFinalizar);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.plGeneral);
            this.Controls.Add(this.lvwInformacion);
            this.Controls.Add(this.rtbInformacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hardware & Software";
            this.plGeneral.ResumeLayout(false);
            this.plFinalizar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel plGeneral;
        private System.Windows.Forms.Button cmdBalance;
        private System.Windows.Forms.Button cmdRegistro;
        private System.Windows.Forms.Button cmdProcesos;
        private System.Windows.Forms.Button cmdGeneral;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdInformacion;
        private System.Windows.Forms.RichTextBox rtbInformacion;
        private System.Windows.Forms.Panel plFinalizar;
        private System.Windows.Forms.Button cmdFinalizar;
        private System.Windows.Forms.ColumnHeader N;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader MB;
        private System.Windows.Forms.ListView lvwInformacion;
    }
}

