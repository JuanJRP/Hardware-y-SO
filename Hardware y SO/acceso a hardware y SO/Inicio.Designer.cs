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
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmdLeer = new System.Windows.Forms.Button();
            this.cmdEditar = new System.Windows.Forms.Button();
            this.plRegedit = new System.Windows.Forms.Panel();
            this.cmdCrear = new System.Windows.Forms.Button();
            this.cmdCRUD = new System.Windows.Forms.Button();
            this.txtCrud = new System.Windows.Forms.TextBox();
            this.lblCrud = new System.Windows.Forms.Label();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.plGeneral.SuspendLayout();
            this.plFinalizar.SuspendLayout();
            this.plRegedit.SuspendLayout();
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
            this.lblVersion.Text = "v1.5";
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
            this.cmdFinalizar.ForeColor = System.Drawing.SystemColors.Window;
            this.cmdFinalizar.Location = new System.Drawing.Point(3, 3);
            this.cmdFinalizar.Name = "cmdFinalizar";
            this.cmdFinalizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            // txtRuta
            // 
            this.txtRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRuta.ForeColor = System.Drawing.Color.White;
            this.txtRuta.Location = new System.Drawing.Point(273, 134);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(417, 20);
            this.txtRuta.TabIndex = 12;
            this.txtRuta.Visible = false;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.BackColor = System.Drawing.Color.Transparent;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.ForeColor = System.Drawing.Color.White;
            this.lblRuta.Location = new System.Drawing.Point(307, 93);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(351, 20);
            this.lblRuta.TabIndex = 13;
            this.lblRuta.Text = "Ingrese la Ruta/Dirrecion del archivo a leer";
            this.lblRuta.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(336, 183);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(289, 20);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Ingrese el nombre de la llave a leer";
            this.lblNombre.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(273, 230);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(417, 20);
            this.txtNombre.TabIndex = 15;
            this.txtNombre.Visible = false;
            // 
            // cmdLeer
            // 
            this.cmdLeer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmdLeer.FlatAppearance.BorderSize = 0;
            this.cmdLeer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdLeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLeer.ForeColor = System.Drawing.Color.White;
            this.cmdLeer.Location = new System.Drawing.Point(311, 296);
            this.cmdLeer.Name = "cmdLeer";
            this.cmdLeer.Size = new System.Drawing.Size(347, 29);
            this.cmdLeer.TabIndex = 6;
            this.cmdLeer.Text = "Leer";
            this.cmdLeer.UseVisualStyleBackColor = false;
            this.cmdLeer.Visible = false;
            this.cmdLeer.Click += new System.EventHandler(this.cmdLeer_Click);
            // 
            // cmdEditar
            // 
            this.cmdEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmdEditar.FlatAppearance.BorderSize = 0;
            this.cmdEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEditar.ForeColor = System.Drawing.Color.White;
            this.cmdEditar.Location = new System.Drawing.Point(3, 45);
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.Size = new System.Drawing.Size(139, 29);
            this.cmdEditar.TabIndex = 0;
            this.cmdEditar.Text = "Editar";
            this.cmdEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdEditar.UseVisualStyleBackColor = false;
            this.cmdEditar.Click += new System.EventHandler(this.cmdEditar_Click);
            // 
            // plRegedit
            // 
            this.plRegedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.plRegedit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plRegedit.Controls.Add(this.cmdBorrar);
            this.plRegedit.Controls.Add(this.cmdCrear);
            this.plRegedit.Controls.Add(this.cmdEditar);
            this.plRegedit.Location = new System.Drawing.Point(12, 313);
            this.plRegedit.Name = "plRegedit";
            this.plRegedit.Size = new System.Drawing.Size(147, 119);
            this.plRegedit.TabIndex = 12;
            this.plRegedit.Visible = false;
            // 
            // cmdCrear
            // 
            this.cmdCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmdCrear.FlatAppearance.BorderSize = 0;
            this.cmdCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCrear.ForeColor = System.Drawing.Color.White;
            this.cmdCrear.Location = new System.Drawing.Point(3, 10);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(139, 29);
            this.cmdCrear.TabIndex = 1;
            this.cmdCrear.Text = "Crear";
            this.cmdCrear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCrear.UseVisualStyleBackColor = false;
            this.cmdCrear.Click += new System.EventHandler(this.cmdCrear_Click);
            // 
            // cmdCRUD
            // 
            this.cmdCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmdCRUD.FlatAppearance.BorderSize = 0;
            this.cmdCRUD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCRUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCRUD.ForeColor = System.Drawing.Color.White;
            this.cmdCRUD.Location = new System.Drawing.Point(311, 224);
            this.cmdCRUD.Name = "cmdCRUD";
            this.cmdCRUD.Size = new System.Drawing.Size(347, 29);
            this.cmdCRUD.TabIndex = 16;
            this.cmdCRUD.UseVisualStyleBackColor = false;
            this.cmdCRUD.Visible = false;
            this.cmdCRUD.Click += new System.EventHandler(this.cmdCRUD_Click);
            // 
            // txtCrud
            // 
            this.txtCrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtCrud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCrud.ForeColor = System.Drawing.Color.White;
            this.txtCrud.Location = new System.Drawing.Point(273, 158);
            this.txtCrud.Name = "txtCrud";
            this.txtCrud.Size = new System.Drawing.Size(417, 20);
            this.txtCrud.TabIndex = 18;
            this.txtCrud.Visible = false;
            // 
            // lblCrud
            // 
            this.lblCrud.AutoSize = true;
            this.lblCrud.BackColor = System.Drawing.Color.Transparent;
            this.lblCrud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrud.ForeColor = System.Drawing.Color.White;
            this.lblCrud.Location = new System.Drawing.Point(336, 111);
            this.lblCrud.Name = "lblCrud";
            this.lblCrud.Size = new System.Drawing.Size(0, 20);
            this.lblCrud.TabIndex = 17;
            this.lblCrud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCrud.Visible = false;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmdBorrar.FlatAppearance.BorderSize = 0;
            this.cmdBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBorrar.ForeColor = System.Drawing.Color.White;
            this.cmdBorrar.Location = new System.Drawing.Point(3, 80);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(139, 29);
            this.cmdBorrar.TabIndex = 2;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdBorrar.UseVisualStyleBackColor = false;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.cmdCRUD);
            this.Controls.Add(this.txtCrud);
            this.Controls.Add(this.lblCrud);
            this.Controls.Add(this.plRegedit);
            this.Controls.Add(this.plFinalizar);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.plGeneral);
            this.Controls.Add(this.rtbInformacion);
            this.Controls.Add(this.lvwInformacion);
            this.Controls.Add(this.cmdLeer);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.txtRuta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hardware & Software";
            this.plGeneral.ResumeLayout(false);
            this.plFinalizar.ResumeLayout(false);
            this.plRegedit.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button cmdLeer;
        private System.Windows.Forms.Button cmdEditar;
        private System.Windows.Forms.Panel plRegedit;
        private System.Windows.Forms.Button cmdCrear;
        private System.Windows.Forms.Button cmdCRUD;
        private System.Windows.Forms.TextBox txtCrud;
        private System.Windows.Forms.Label lblCrud;
        private System.Windows.Forms.Button cmdBorrar;
    }
}

