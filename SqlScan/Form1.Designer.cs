namespace SqlScan
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbConexion = new System.Windows.Forms.GroupBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btConectar = new System.Windows.Forms.Button();
            this.txContraseña = new System.Windows.Forms.TextBox();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.txServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.txUsuarioActual = new System.Windows.Forms.TextBox();
            this.txPuerto = new System.Windows.Forms.TextBox();
            this.txHostName = new System.Windows.Forms.TextBox();
            this.txVersion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbTabs = new System.Windows.Forms.GroupBox();
            this.btRiesgos = new System.Windows.Forms.Button();
            this.btCredenciales = new System.Windows.Forms.Button();
            this.btFeatures = new System.Windows.Forms.Button();
            this.btBD = new System.Windows.Forms.Button();
            this.btUsuarios = new System.Windows.Forms.Button();
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.pnlBD = new System.Windows.Forms.Panel();
            this.pnlFeatures = new System.Windows.Forms.Panel();
            this.pnlCredenciales = new System.Windows.Forms.Panel();
            this.pnlRiesgos = new System.Windows.Forms.Panel();
            this.dtgRiesgos = new System.Windows.Forms.DataGridView();
            this.dgvCredenciales = new System.Windows.Forms.DataGridView();
            this.dgvFeatures = new System.Windows.Forms.DataGridView();
            this.dgvDB = new System.Windows.Forms.DataGridView();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.gbConexion.SuspendLayout();
            this.gbInformacion.SuspendLayout();
            this.gbTabs.SuspendLayout();
            this.pnlUsuarios.SuspendLayout();
            this.pnlBD.SuspendLayout();
            this.pnlFeatures.SuspendLayout();
            this.pnlCredenciales.SuspendLayout();
            this.pnlRiesgos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRiesgos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredenciales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeatures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enumerador de Sql Server";
            // 
            // gbConexion
            // 
            this.gbConexion.Controls.Add(this.btLimpiar);
            this.gbConexion.Controls.Add(this.btConectar);
            this.gbConexion.Controls.Add(this.txContraseña);
            this.gbConexion.Controls.Add(this.txUsuario);
            this.gbConexion.Controls.Add(this.txServer);
            this.gbConexion.Controls.Add(this.label4);
            this.gbConexion.Controls.Add(this.label3);
            this.gbConexion.Controls.Add(this.label2);
            this.gbConexion.Location = new System.Drawing.Point(33, 76);
            this.gbConexion.Name = "gbConexion";
            this.gbConexion.Size = new System.Drawing.Size(596, 152);
            this.gbConexion.TabIndex = 1;
            this.gbConexion.TabStop = false;
            this.gbConexion.Text = "Conexion";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(418, 89);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 7;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(418, 38);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(75, 23);
            this.btConectar.TabIndex = 6;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // txContraseña
            // 
            this.txContraseña.Location = new System.Drawing.Point(90, 106);
            this.txContraseña.Name = "txContraseña";
            this.txContraseña.PasswordChar = '*';
            this.txContraseña.Size = new System.Drawing.Size(137, 20);
            this.txContraseña.TabIndex = 5;
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(67, 71);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(113, 20);
            this.txUsuario.TabIndex = 4;
            // 
            // txServer
            // 
            this.txServer.Location = new System.Drawing.Point(67, 38);
            this.txServer.Name = "txServer";
            this.txServer.Size = new System.Drawing.Size(160, 20);
            this.txServer.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Server:";
            // 
            // gbInformacion
            // 
            this.gbInformacion.Controls.Add(this.txUsuarioActual);
            this.gbInformacion.Controls.Add(this.txPuerto);
            this.gbInformacion.Controls.Add(this.txHostName);
            this.gbInformacion.Controls.Add(this.txVersion);
            this.gbInformacion.Controls.Add(this.label8);
            this.gbInformacion.Controls.Add(this.label7);
            this.gbInformacion.Controls.Add(this.label6);
            this.gbInformacion.Controls.Add(this.label5);
            this.gbInformacion.Location = new System.Drawing.Point(26, 256);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(696, 176);
            this.gbInformacion.TabIndex = 2;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Informacion";
            this.gbInformacion.Visible = false;
            // 
            // txUsuarioActual
            // 
            this.txUsuarioActual.Location = new System.Drawing.Point(88, 128);
            this.txUsuarioActual.Name = "txUsuarioActual";
            this.txUsuarioActual.ReadOnly = true;
            this.txUsuarioActual.Size = new System.Drawing.Size(146, 20);
            this.txUsuarioActual.TabIndex = 7;
            // 
            // txPuerto
            // 
            this.txPuerto.Location = new System.Drawing.Point(57, 98);
            this.txPuerto.Name = "txPuerto";
            this.txPuerto.ReadOnly = true;
            this.txPuerto.Size = new System.Drawing.Size(80, 20);
            this.txPuerto.TabIndex = 6;
            // 
            // txHostName
            // 
            this.txHostName.Location = new System.Drawing.Point(74, 70);
            this.txHostName.Name = "txHostName";
            this.txHostName.ReadOnly = true;
            this.txHostName.Size = new System.Drawing.Size(261, 20);
            this.txHostName.TabIndex = 5;
            // 
            // txVersion
            // 
            this.txVersion.Location = new System.Drawing.Point(57, 33);
            this.txVersion.Name = "txVersion";
            this.txVersion.ReadOnly = true;
            this.txVersion.Size = new System.Drawing.Size(616, 20);
            this.txVersion.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Usuario Actual:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Puerto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hostname:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Version:";
            // 
            // gbTabs
            // 
            this.gbTabs.Controls.Add(this.btRiesgos);
            this.gbTabs.Controls.Add(this.btCredenciales);
            this.gbTabs.Controls.Add(this.btFeatures);
            this.gbTabs.Controls.Add(this.btBD);
            this.gbTabs.Controls.Add(this.btUsuarios);
            this.gbTabs.Location = new System.Drawing.Point(26, 438);
            this.gbTabs.Name = "gbTabs";
            this.gbTabs.Size = new System.Drawing.Size(531, 66);
            this.gbTabs.TabIndex = 3;
            this.gbTabs.TabStop = false;
            this.gbTabs.Text = "Tabs";
            this.gbTabs.Visible = false;
            // 
            // btRiesgos
            // 
            this.btRiesgos.Location = new System.Drawing.Point(425, 28);
            this.btRiesgos.Name = "btRiesgos";
            this.btRiesgos.Size = new System.Drawing.Size(75, 23);
            this.btRiesgos.TabIndex = 4;
            this.btRiesgos.Text = "Riesgos";
            this.btRiesgos.UseVisualStyleBackColor = true;
            this.btRiesgos.Click += new System.EventHandler(this.btRiesgos_Click);
            // 
            // btCredenciales
            // 
            this.btCredenciales.Location = new System.Drawing.Point(315, 28);
            this.btCredenciales.Name = "btCredenciales";
            this.btCredenciales.Size = new System.Drawing.Size(84, 23);
            this.btCredenciales.TabIndex = 3;
            this.btCredenciales.Text = "Credenciales";
            this.btCredenciales.UseVisualStyleBackColor = true;
            this.btCredenciales.Click += new System.EventHandler(this.btCredenciales_Click);
            // 
            // btFeatures
            // 
            this.btFeatures.Location = new System.Drawing.Point(204, 28);
            this.btFeatures.Name = "btFeatures";
            this.btFeatures.Size = new System.Drawing.Size(75, 23);
            this.btFeatures.TabIndex = 2;
            this.btFeatures.Text = "Features";
            this.btFeatures.UseVisualStyleBackColor = true;
            this.btFeatures.Click += new System.EventHandler(this.btFeatures_Click);
            // 
            // btBD
            // 
            this.btBD.Location = new System.Drawing.Point(121, 28);
            this.btBD.Name = "btBD";
            this.btBD.Size = new System.Drawing.Size(57, 23);
            this.btBD.TabIndex = 1;
            this.btBD.Text = "BD";
            this.btBD.UseVisualStyleBackColor = true;
            this.btBD.Click += new System.EventHandler(this.btBD_Click);
            // 
            // btUsuarios
            // 
            this.btUsuarios.Location = new System.Drawing.Point(21, 28);
            this.btUsuarios.Name = "btUsuarios";
            this.btUsuarios.Size = new System.Drawing.Size(75, 23);
            this.btUsuarios.TabIndex = 0;
            this.btUsuarios.Text = "Usuarios";
            this.btUsuarios.UseVisualStyleBackColor = true;
            this.btUsuarios.Click += new System.EventHandler(this.btUsuarios_Click);
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.Controls.Add(this.pnlBD);
            this.pnlUsuarios.Controls.Add(this.dgvUsuarios);
            this.pnlUsuarios.Location = new System.Drawing.Point(26, 510);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(674, 192);
            this.pnlUsuarios.TabIndex = 4;
            // 
            // pnlBD
            // 
            this.pnlBD.Controls.Add(this.pnlFeatures);
            this.pnlBD.Controls.Add(this.dgvDB);
            this.pnlBD.Location = new System.Drawing.Point(-2, 0);
            this.pnlBD.Name = "pnlBD";
            this.pnlBD.Size = new System.Drawing.Size(676, 192);
            this.pnlBD.TabIndex = 1;
            // 
            // pnlFeatures
            // 
            this.pnlFeatures.Controls.Add(this.pnlCredenciales);
            this.pnlFeatures.Controls.Add(this.dgvFeatures);
            this.pnlFeatures.Location = new System.Drawing.Point(0, 0);
            this.pnlFeatures.Name = "pnlFeatures";
            this.pnlFeatures.Size = new System.Drawing.Size(676, 192);
            this.pnlFeatures.TabIndex = 1;
            // 
            // pnlCredenciales
            // 
            this.pnlCredenciales.Controls.Add(this.pnlRiesgos);
            this.pnlCredenciales.Controls.Add(this.dgvCredenciales);
            this.pnlCredenciales.Location = new System.Drawing.Point(0, 0);
            this.pnlCredenciales.Name = "pnlCredenciales";
            this.pnlCredenciales.Size = new System.Drawing.Size(676, 192);
            this.pnlCredenciales.TabIndex = 1;
            // 
            // pnlRiesgos
            // 
            this.pnlRiesgos.Controls.Add(this.dtgRiesgos);
            this.pnlRiesgos.Location = new System.Drawing.Point(3, 0);
            this.pnlRiesgos.Name = "pnlRiesgos";
            this.pnlRiesgos.Size = new System.Drawing.Size(673, 192);
            this.pnlRiesgos.TabIndex = 1;
            // 
            // dtgRiesgos
            // 
            this.dtgRiesgos.AllowUserToAddRows = false;
            this.dtgRiesgos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRiesgos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRiesgos.Location = new System.Drawing.Point(0, 0);
            this.dtgRiesgos.Name = "dtgRiesgos";
            this.dtgRiesgos.ReadOnly = true;
            this.dtgRiesgos.Size = new System.Drawing.Size(673, 192);
            this.dtgRiesgos.TabIndex = 0;
            // 
            // dgvCredenciales
            // 
            this.dgvCredenciales.AllowUserToAddRows = false;
            this.dgvCredenciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCredenciales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCredenciales.Location = new System.Drawing.Point(0, 0);
            this.dgvCredenciales.Name = "dgvCredenciales";
            this.dgvCredenciales.ReadOnly = true;
            this.dgvCredenciales.Size = new System.Drawing.Size(676, 192);
            this.dgvCredenciales.TabIndex = 0;
            // 
            // dgvFeatures
            // 
            this.dgvFeatures.AllowUserToAddRows = false;
            this.dgvFeatures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFeatures.Location = new System.Drawing.Point(0, 0);
            this.dgvFeatures.Name = "dgvFeatures";
            this.dgvFeatures.ReadOnly = true;
            this.dgvFeatures.Size = new System.Drawing.Size(676, 192);
            this.dgvFeatures.TabIndex = 0;
            // 
            // dgvDB
            // 
            this.dgvDB.AllowUserToAddRows = false;
            this.dgvDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDB.Location = new System.Drawing.Point(0, 0);
            this.dgvDB.Name = "dgvDB";
            this.dgvDB.ReadOnly = true;
            this.dgvDB.Size = new System.Drawing.Size(676, 192);
            this.dgvDB.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(674, 192);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.pnlUsuarios);
            this.Controls.Add(this.gbTabs);
            this.Controls.Add(this.gbInformacion);
            this.Controls.Add(this.gbConexion);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbConexion.ResumeLayout(false);
            this.gbConexion.PerformLayout();
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            this.gbTabs.ResumeLayout(false);
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlBD.ResumeLayout(false);
            this.pnlFeatures.ResumeLayout(false);
            this.pnlCredenciales.ResumeLayout(false);
            this.pnlRiesgos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRiesgos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredenciales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeatures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbConexion;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.TextBox txContraseña;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.TextBox txServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.TextBox txUsuarioActual;
        private System.Windows.Forms.TextBox txPuerto;
        private System.Windows.Forms.TextBox txHostName;
        private System.Windows.Forms.TextBox txVersion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbTabs;
        private System.Windows.Forms.Button btRiesgos;
        private System.Windows.Forms.Button btCredenciales;
        private System.Windows.Forms.Button btFeatures;
        private System.Windows.Forms.Button btBD;
        private System.Windows.Forms.Button btUsuarios;
        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.Panel pnlBD;
        private System.Windows.Forms.Panel pnlFeatures;
        private System.Windows.Forms.DataGridView dgvFeatures;
        private System.Windows.Forms.DataGridView dgvDB;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel pnlCredenciales;
        private System.Windows.Forms.Panel pnlRiesgos;
        private System.Windows.Forms.DataGridView dtgRiesgos;
        private System.Windows.Forms.DataGridView dgvCredenciales;
    }
}

