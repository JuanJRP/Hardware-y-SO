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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plGeneral = new System.Windows.Forms.Panel();
            this.cmdBalance = new System.Windows.Forms.Button();
            this.cmdRegistro = new System.Windows.Forms.Button();
            this.cmdProcesos = new System.Windows.Forms.Button();
            this.cmdGeneral = new System.Windows.Forms.Button();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plInformacion = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblHDD = new System.Windows.Forms.Label();
            this.lblHDDinfo = new System.Windows.Forms.Label();
            this.lblCDinfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDVDinfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUDinfo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.plGeneral.SuspendLayout();
            this.plInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // plGeneral
            // 
            this.plGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.plGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plGeneral.Controls.Add(this.cmdBalance);
            this.plGeneral.Controls.Add(this.cmdRegistro);
            this.plGeneral.Controls.Add(this.cmdProcesos);
            this.plGeneral.Controls.Add(this.cmdGeneral);
            this.plGeneral.Location = new System.Drawing.Point(12, 39);
            this.plGeneral.Name = "plGeneral";
            this.plGeneral.Size = new System.Drawing.Size(147, 184);
            this.plGeneral.TabIndex = 2;
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
            this.cmdBalance.Size = new System.Drawing.Size(143, 29);
            this.cmdBalance.TabIndex = 1;
            this.cmdBalance.Text = "Balance del sistema";
            this.cmdBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdBalance.UseVisualStyleBackColor = false;
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
            this.cmdProcesos.Size = new System.Drawing.Size(128, 29);
            this.cmdProcesos.TabIndex = 3;
            this.cmdProcesos.Text = "Procesos activos";
            this.cmdProcesos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdProcesos.UseVisualStyleBackColor = false;
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
            this.cmdGeneral.Size = new System.Drawing.Size(128, 29);
            this.cmdGeneral.TabIndex = 0;
            this.cmdGeneral.Text = "General";
            this.cmdGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGeneral.UseVisualStyleBackColor = false;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // plInformacion
            // 
            this.plInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.plInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plInformacion.Controls.Add(this.lblUDinfo);
            this.plInformacion.Controls.Add(this.label11);
            this.plInformacion.Controls.Add(this.label8);
            this.plInformacion.Controls.Add(this.label9);
            this.plInformacion.Controls.Add(this.label6);
            this.plInformacion.Controls.Add(this.label7);
            this.plInformacion.Controls.Add(this.lblDVDinfo);
            this.plInformacion.Controls.Add(this.label5);
            this.plInformacion.Controls.Add(this.lblCDinfo);
            this.plInformacion.Controls.Add(this.label3);
            this.plInformacion.Controls.Add(this.lblHDDinfo);
            this.plInformacion.Controls.Add(this.lblHDD);
            this.plInformacion.Location = new System.Drawing.Point(165, 39);
            this.plInformacion.Name = "plInformacion";
            this.plInformacion.Size = new System.Drawing.Size(623, 406);
            this.plInformacion.TabIndex = 7;
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
            this.lblVersion.Text = "v1.0";
            // 
            // lblHDD
            // 
            this.lblHDD.AutoSize = true;
            this.lblHDD.BackColor = System.Drawing.Color.Transparent;
            this.lblHDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHDD.Location = new System.Drawing.Point(21, 22);
            this.lblHDD.Name = "lblHDD";
            this.lblHDD.Size = new System.Drawing.Size(97, 18);
            this.lblHDD.TabIndex = 9;
            this.lblHDD.Text = "Serial HDD:";
            // 
            // lblHDDinfo
            // 
            this.lblHDDinfo.AutoSize = true;
            this.lblHDDinfo.BackColor = System.Drawing.Color.Transparent;
            this.lblHDDinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDDinfo.ForeColor = System.Drawing.Color.White;
            this.lblHDDinfo.Location = new System.Drawing.Point(64, 37);
            this.lblHDDinfo.Name = "lblHDDinfo";
            this.lblHDDinfo.Size = new System.Drawing.Size(112, 18);
            this.lblHDDinfo.TabIndex = 10;
            this.lblHDDinfo.Text = "Informacion...";
            // 
            // lblCDinfo
            // 
            this.lblCDinfo.AutoSize = true;
            this.lblCDinfo.BackColor = System.Drawing.Color.Transparent;
            this.lblCDinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDinfo.ForeColor = System.Drawing.Color.White;
            this.lblCDinfo.Location = new System.Drawing.Point(67, 105);
            this.lblCDinfo.Name = "lblCDinfo";
            this.lblCDinfo.Size = new System.Drawing.Size(112, 18);
            this.lblCDinfo.TabIndex = 12;
            this.lblCDinfo.Text = "Informacion...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(24, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Serial CD:";
            // 
            // lblDVDinfo
            // 
            this.lblDVDinfo.AutoSize = true;
            this.lblDVDinfo.BackColor = System.Drawing.Color.Transparent;
            this.lblDVDinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDVDinfo.ForeColor = System.Drawing.Color.White;
            this.lblDVDinfo.Location = new System.Drawing.Point(67, 140);
            this.lblDVDinfo.Name = "lblDVDinfo";
            this.lblDVDinfo.Size = new System.Drawing.Size(112, 18);
            this.lblDVDinfo.TabIndex = 14;
            this.lblDVDinfo.Text = "Informacion...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(24, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Serial DVD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(67, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Informacion...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(24, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Unidades de disco:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(67, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Informacion...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(24, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "MAC Address:";
            // 
            // lblUDinfo
            // 
            this.lblUDinfo.AutoSize = true;
            this.lblUDinfo.BackColor = System.Drawing.Color.Transparent;
            this.lblUDinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUDinfo.ForeColor = System.Drawing.Color.White;
            this.lblUDinfo.Location = new System.Drawing.Point(67, 70);
            this.lblUDinfo.Name = "lblUDinfo";
            this.lblUDinfo.Size = new System.Drawing.Size(112, 18);
            this.lblUDinfo.TabIndex = 20;
            this.lblUDinfo.Text = "Informacion...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(24, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "Unidades de disco:";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.plInformacion);
            this.Controls.Add(this.plGeneral);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hardware & Software";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.plGeneral.ResumeLayout(false);
            this.plInformacion.ResumeLayout(false);
            this.plInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Panel plGeneral;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button cmdBalance;
        private System.Windows.Forms.Button cmdRegistro;
        private System.Windows.Forms.Button cmdProcesos;
        private System.Windows.Forms.Button cmdGeneral;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel plInformacion;
        private System.Windows.Forms.Label lblUDinfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDVDinfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCDinfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHDDinfo;
        private System.Windows.Forms.Label lblHDD;
        private System.Windows.Forms.Label lblVersion;
    }
}

