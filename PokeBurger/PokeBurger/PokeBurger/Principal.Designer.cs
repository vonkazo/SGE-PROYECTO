﻿namespace PokeBurger
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pContenedor = new System.Windows.Forms.Panel();
            this.bEstadisticas = new System.Windows.Forms.Button();
            this.bFacturas = new System.Windows.Forms.Button();
            this.bDistribuidores = new System.Windows.Forms.Button();
            this.bInventario = new System.Windows.Forms.Button();
            this.bPedidos = new System.Windows.Forms.Button();
            this.bProductos = new System.Windows.Forms.Button();
            this.bEmpleado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pContenedor
            // 
            this.pContenedor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pContenedor.Location = new System.Drawing.Point(195, 0);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Size = new System.Drawing.Size(1854, 988);
            this.pContenedor.TabIndex = 1;
            this.pContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bEstadisticas
            // 
            this.bEstadisticas.BackgroundImage = global::PokeBurger.Properties.Resources.Estadisticas;
            this.bEstadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEstadisticas.FlatAppearance.BorderSize = 0;
            this.bEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEstadisticas.Location = new System.Drawing.Point(41, 736);
            this.bEstadisticas.Name = "bEstadisticas";
            this.bEstadisticas.Size = new System.Drawing.Size(114, 91);
            this.bEstadisticas.TabIndex = 7;
            this.bEstadisticas.UseVisualStyleBackColor = true;
            // 
            // bFacturas
            // 
            this.bFacturas.BackgroundImage = global::PokeBurger.Properties.Resources.Facturas;
            this.bFacturas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bFacturas.FlatAppearance.BorderSize = 0;
            this.bFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFacturas.Location = new System.Drawing.Point(41, 639);
            this.bFacturas.Name = "bFacturas";
            this.bFacturas.Size = new System.Drawing.Size(114, 91);
            this.bFacturas.TabIndex = 6;
            this.bFacturas.UseVisualStyleBackColor = true;
            // 
            // bDistribuidores
            // 
            this.bDistribuidores.BackgroundImage = global::PokeBurger.Properties.Resources.Distribuidores;
            this.bDistribuidores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bDistribuidores.FlatAppearance.BorderSize = 0;
            this.bDistribuidores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDistribuidores.Location = new System.Drawing.Point(41, 542);
            this.bDistribuidores.Name = "bDistribuidores";
            this.bDistribuidores.Size = new System.Drawing.Size(114, 91);
            this.bDistribuidores.TabIndex = 5;
            this.bDistribuidores.UseVisualStyleBackColor = true;
            // 
            // bInventario
            // 
            this.bInventario.BackgroundImage = global::PokeBurger.Properties.Resources.Inventario;
            this.bInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bInventario.FlatAppearance.BorderSize = 0;
            this.bInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInventario.Location = new System.Drawing.Point(41, 445);
            this.bInventario.Name = "bInventario";
            this.bInventario.Size = new System.Drawing.Size(114, 91);
            this.bInventario.TabIndex = 4;
            this.bInventario.UseVisualStyleBackColor = true;
            // 
            // bPedidos
            // 
            this.bPedidos.BackgroundImage = global::PokeBurger.Properties.Resources.Pedidos;
            this.bPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPedidos.FlatAppearance.BorderSize = 0;
            this.bPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPedidos.Location = new System.Drawing.Point(41, 348);
            this.bPedidos.Name = "bPedidos";
            this.bPedidos.Size = new System.Drawing.Size(114, 91);
            this.bPedidos.TabIndex = 3;
            this.bPedidos.UseVisualStyleBackColor = true;
            // 
            // bProductos
            // 
            this.bProductos.BackgroundImage = global::PokeBurger.Properties.Resources.Productos;
            this.bProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bProductos.FlatAppearance.BorderSize = 0;
            this.bProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProductos.Location = new System.Drawing.Point(41, 251);
            this.bProductos.Name = "bProductos";
            this.bProductos.Size = new System.Drawing.Size(114, 91);
            this.bProductos.TabIndex = 2;
            this.bProductos.UseVisualStyleBackColor = true;
            // 
            // bEmpleado
            // 
            this.bEmpleado.BackgroundImage = global::PokeBurger.Properties.Resources.Empleados;
            this.bEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEmpleado.FlatAppearance.BorderSize = 0;
            this.bEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEmpleado.Location = new System.Drawing.Point(41, 154);
            this.bEmpleado.Name = "bEmpleado";
            this.bEmpleado.Size = new System.Drawing.Size(114, 91);
            this.bEmpleado.TabIndex = 0;
            this.bEmpleado.UseVisualStyleBackColor = true;
            this.bEmpleado.Click += new System.EventHandler(this.bEmpleado_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::PokeBurger.Properties.Resources.menuDef;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 996);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 989);
            this.Controls.Add(this.bEstadisticas);
            this.Controls.Add(this.bFacturas);
            this.Controls.Add(this.bDistribuidores);
            this.Controls.Add(this.bInventario);
            this.Controls.Add(this.bPedidos);
            this.Controls.Add(this.bProductos);
            this.Controls.Add(this.bEmpleado);
            this.Controls.Add(this.pContenedor);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "PokeBurger";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pContenedor;
        private System.Windows.Forms.Button bEmpleado;
        private System.Windows.Forms.Button bProductos;
        private System.Windows.Forms.Button bPedidos;
        private System.Windows.Forms.Button bInventario;
        private System.Windows.Forms.Button bDistribuidores;
        private System.Windows.Forms.Button bFacturas;
        private System.Windows.Forms.Button bEstadisticas;
    }
}

