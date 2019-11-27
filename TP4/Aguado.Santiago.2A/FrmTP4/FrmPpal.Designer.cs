namespace FrmTP4
{
    partial class FrmPpal
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

        #region InitializeComponent

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstEstadoIngresado = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEstadoIngresado = new System.Windows.Forms.Label();
            this.lblEstadoEntregado = new System.Windows.Forms.Label();
            this.lblEstadoEnViaje = new System.Windows.Forms.Label();
            this.lstEstadoEntregado = new System.Windows.Forms.ListBox();
            this.lstEstadoEnViaje = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTrackingID = new System.Windows.Forms.Label();
            this.mtxtTrackingId = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.cmsListas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.cmsListas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEstadoIngresado
            // 
            this.lstEstadoIngresado.FormattingEnabled = true;
            this.lstEstadoIngresado.Location = new System.Drawing.Point(10, 50);
            this.lstEstadoIngresado.Name = "lstEstadoIngresado";
            this.lstEstadoIngresado.Size = new System.Drawing.Size(227, 251);
            this.lstEstadoIngresado.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEstadoIngresado);
            this.groupBox1.Controls.Add(this.lblEstadoEntregado);
            this.groupBox1.Controls.Add(this.lblEstadoEnViaje);
            this.groupBox1.Controls.Add(this.lstEstadoEntregado);
            this.groupBox1.Controls.Add(this.lstEstadoEnViaje);
            this.groupBox1.Controls.Add(this.lstEstadoIngresado);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 318);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estados Paquetes";
            // 
            // lblEstadoIngresado
            // 
            this.lblEstadoIngresado.AutoSize = true;
            this.lblEstadoIngresado.Location = new System.Drawing.Point(7, 34);
            this.lblEstadoIngresado.Name = "lblEstadoIngresado";
            this.lblEstadoIngresado.Size = new System.Drawing.Size(54, 13);
            this.lblEstadoIngresado.TabIndex = 5;
            this.lblEstadoIngresado.Text = "Ingresado";
            // 
            // lblEstadoEntregado
            // 
            this.lblEstadoEntregado.AutoSize = true;
            this.lblEstadoEntregado.Location = new System.Drawing.Point(554, 34);
            this.lblEstadoEntregado.Name = "lblEstadoEntregado";
            this.lblEstadoEntregado.Size = new System.Drawing.Size(56, 13);
            this.lblEstadoEntregado.TabIndex = 4;
            this.lblEstadoEntregado.Text = "Entregado";
            // 
            // lblEstadoEnViaje
            // 
            this.lblEstadoEnViaje.AutoSize = true;
            this.lblEstadoEnViaje.Location = new System.Drawing.Point(288, 34);
            this.lblEstadoEnViaje.Name = "lblEstadoEnViaje";
            this.lblEstadoEnViaje.Size = new System.Drawing.Size(46, 13);
            this.lblEstadoEnViaje.TabIndex = 3;
            this.lblEstadoEnViaje.Text = "En Viaje";
            // 
            // lstEstadoEntregado
            // 
            this.lstEstadoEntregado.ContextMenuStrip = this.cmsListas;
            this.lstEstadoEntregado.FormattingEnabled = true;
            this.lstEstadoEntregado.Location = new System.Drawing.Point(548, 50);
            this.lstEstadoEntregado.Name = "lstEstadoEntregado";
            this.lstEstadoEntregado.Size = new System.Drawing.Size(230, 251);
            this.lstEstadoEntregado.TabIndex = 2;
            // 
            // lstEstadoEnViaje
            // 
            this.lstEstadoEnViaje.FormattingEnabled = true;
            this.lstEstadoEnViaje.Location = new System.Drawing.Point(279, 50);
            this.lstEstadoEnViaje.Name = "lstEstadoEnViaje";
            this.lstEstadoEnViaje.Size = new System.Drawing.Size(229, 251);
            this.lstEstadoEnViaje.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMostrarTodos);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.lblTrackingID);
            this.groupBox2.Controls.Add(this.mtxtTrackingId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Location = new System.Drawing.Point(475, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 112);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paquete";
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(182, 71);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(118, 39);
            this.btnMostrarTodos.TabIndex = 3;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(182, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 38);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTrackingID
            // 
            this.lblTrackingID.AutoSize = true;
            this.lblTrackingID.Location = new System.Drawing.Point(19, 27);
            this.lblTrackingID.Name = "lblTrackingID";
            this.lblTrackingID.Size = new System.Drawing.Size(60, 13);
            this.lblTrackingID.TabIndex = 3;
            this.lblTrackingID.Text = "TrackingID";
            // 
            // mtxtTrackingId
            // 
            this.mtxtTrackingId.Location = new System.Drawing.Point(6, 47);
            this.mtxtTrackingId.Mask = "000-000-0000";
            this.mtxtTrackingId.Name = "mtxtTrackingId";
            this.mtxtTrackingId.Size = new System.Drawing.Size(170, 20);
            this.mtxtTrackingId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(6, 88);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(170, 20);
            this.txtDireccion.TabIndex = 1;
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.BackColor = System.Drawing.SystemColors.Control;
            this.rtbMostrar.Location = new System.Drawing.Point(12, 336);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.ReadOnly = true;
            this.rtbMostrar.Size = new System.Drawing.Size(457, 123);
            this.rtbMostrar.TabIndex = 8;
            this.rtbMostrar.Text = "";
            // 
            // cmsListas
            // 
            this.cmsListas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem});
            this.cmsListas.Name = "cmsListas";
            this.cmsListas.Size = new System.Drawing.Size(125, 26);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar...";
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPpal";
            this.Text = "Correo UTN por Santiago.Aguado.2A";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.cmsListas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEstadoIngresado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEstadoIngresado;
        private System.Windows.Forms.Label lblEstadoEntregado;
        private System.Windows.Forms.Label lblEstadoEnViaje;
        private System.Windows.Forms.ListBox lstEstadoEntregado;
        private System.Windows.Forms.ListBox lstEstadoEnViaje;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTrackingID;
        private System.Windows.Forms.MaskedTextBox mtxtTrackingId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.ContextMenuStrip cmsListas;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
    }
}

